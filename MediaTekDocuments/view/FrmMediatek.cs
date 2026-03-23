using System;
using System.Windows.Forms;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using MediaTekDocuments.controller;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using SuiviModel = MediaTekDocuments.model.Suivi;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace MediaTekDocuments.view

{
    /// <summary>
    /// Classe d'affichage
    /// </summary>
    public partial class FrmMediatek : Form
    {
        #region Commun
        private readonly FrmMediatekController controller;
        private readonly BindingSource bdgGenres = new BindingSource();
        private readonly BindingSource bdgPublics = new BindingSource();
        private readonly BindingSource bdgRayons = new BindingSource();
        private readonly BindingSource bsCmdLivre = new BindingSource();
        private readonly BindingSource bsCmdDvd = new BindingSource();
        private readonly BindingSource bsCmdRevue = new BindingSource();


        //---cache suivis + sélection courante (livre / dvd / revue / commande)
        private List<SuiviModel> lesSuivis = new List<SuiviModel>();
        private Livre livreCmdCourant;
        private Revue revueCmdCourante;
        private Dvd dvdCmdCourant;
        private CommandeDocument cmdLivreCourante;
        private CommandeRevue cmdRevueCourante;
        private CommandeDocument cmdDvdCourante;

        // --- états ---
        private List<Etat> lesEtats = new List<Etat>();

        // --- Livres exemplaires ---
        private readonly BindingSource bdgLivresExemplaires = new BindingSource();
        private Exemplaire livreExemplaireCourant;
        private DataGridView dgvLivresExemplaires;
        private ComboBox cbxLivresEtats;
        private Button btnLivresChgtEtat;
        private Button btnLivresSupprExemplaire;

        // --- DVD exemplaires ---
        private readonly BindingSource bdgDvdExemplaires = new BindingSource();
        private Exemplaire dvdExemplaireCourant;
        private DataGridView dgvDvdExemplaires;
        private ComboBox cbxDvdEtats;
        private Button btnDvdChgtEtat;
        private Button btnDvdSupprExemplaire;

        // --- Parutions exemplaires ---
        private ComboBox cbxParutionsEtat;
        private Button btnParutionsChgtEtat;
        private Button btnParutionsSupprExemplaire;

        private FrmMediatekController GetController()
        {
            return controller;
        }

        #region Commandes Livres
        private void TabCmdLivres_Enter(object sender, EventArgs e)
        {
            // 1) charger les suivis (une seule fois)
            if (lesSuivis == null || lesSuivis.Count == 0)
            {
                lesSuivis = controller.GetAllSuivis();
            }

            cbxCmdLivreSuivi.DataSource = null;
            cbxCmdLivreSuivi.DataSource = lesSuivis;
            cbxCmdLivreSuivi.DisplayMember = "libelle";
            cbxCmdLivreSuivi.ValueMember = "id";

            if (cbxCmdLivre.DataSource == null)
            {
                if (lesLivres == null || lesLivres.Count == 0)
                    lesLivres = controller.GetAllLivres();

                cbxCmdLivre.DataSource = lesLivres;
                cbxCmdLivre.DisplayMember = "Titre";
                cbxCmdLivre.ValueMember = "Id";
                cbxCmdLivre.SelectedIndex = (lesLivres.Count > 0) ? 0 : -1;
            }

            dgvCmdLivre.AutoGenerateColumns = true;
            dgvCmdLivre.DataSource = bsCmdLivre;

            foreach (DataGridViewColumn col in dgvCmdLivre.Columns)
                col.SortMode = DataGridViewColumnSortMode.Automatic;

            ChargerCommandesLivreSelectionne();
        }

        private void CbxCmdLivre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerCommandesLivreSelectionne();
        }

        private void ChargerCommandesLivreSelectionne()
        {
            livreCmdCourant = cbxCmdLivre.SelectedItem as Livre;

            if (livreCmdCourant == null)
            {
                bsCmdLivre.DataSource = null;
                btnCmdLivreMajSuivi.Enabled = false;
                btnCmdLivreSuppr.Enabled = false;
                return;
            }

            var commandes = controller.GetCommandesDocument(livreCmdCourant.Id);

            // Trier par date de commande décroissante avant l'affichage
            if (commandes != null && commandes.Count > 0)
                commandes = commandes.OrderByDescending(c => c.datecommande).ToList();

            bsCmdLivre.DataSource = null;
            bsCmdLivre.DataSource = commandes;
            dgvCmdLivre.Refresh();

            btnCmdLivreMajSuivi.Enabled = commandes != null && commandes.Count > 0;
            btnCmdLivreSuppr.Enabled = commandes != null && commandes.Count > 0;
        }
        private void DgvCmdLivre_SelectionChanged(object sender, EventArgs e)
        {
            cmdLivreCourante = dgvCmdLivre.CurrentRow?.DataBoundItem as CommandeDocument;

            if (cmdLivreCourante == null)
            {
                btnCmdLivreMajSuivi.Enabled = false;
                btnCmdLivreSuppr.Enabled = false;
                return;
            }

            cbxCmdLivreSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == cmdLivreCourante.idsuivi);

            string lib = (cmdLivreCourante.suivi ?? "").ToLowerInvariant();
            btnCmdLivreSuppr.Enabled = (lib != "livrée" && lib != "réglée");
        }

        private void BtnCmdLivreAjouter_Click(object sender, EventArgs e)
        {
            if (livreCmdCourant == null)
            {
                MessageBox.Show("Sélectionnez un livre.");
                return;
            }

            if (!double.TryParse(txbCmdLivreMontant.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.");
                return;
            }

            int nb = (int)nudCmdLivreNbEx.Value;
            if (nb <= 0)
            {
                MessageBox.Show("Nombre d'exemplaires invalide.");
                return;
            }

            if (lesSuivis == null || lesSuivis.Count == 0)
                lesSuivis = controller.GetAllSuivis();

            if (lesSuivis == null || lesSuivis.Count == 0)
            {
                MessageBox.Show("Impossible de récupérer les suivis. Vérifiez la connexion au serveur.");
                return;
            }

            SuiviModel suiviEnCours = lesSuivis.FirstOrDefault(s =>
                s.libelle != null && s.libelle.ToLowerInvariant().Contains("cours"));
            if (suiviEnCours == null)
            {
                string liste = string.Join(", ", lesSuivis.Select(s => "'" + s.libelle + "'"));
                MessageBox.Show("Suivi 'en cours' introuvable. Suivis disponibles : " + liste);
                return;
            }

            CommandeDocument cmd = new CommandeDocument
            {
                iddocument = livreCmdCourant.Id,
                datecommande = dtpCmdLivreDate.Value.Date,
                montant = montant,
                nbexemplaire = nb,
                idsuivi = suiviEnCours.id
            };

            bool ok = controller.CreerCommandeDocument(cmd);
            MessageBox.Show(ok ? "Commande enregistrée." : "Échec de l'enregistrement.");

            if (ok) ChargerCommandesLivreSelectionne();
        }

        private void BtnCmdLivreMajSuivi_Click(object sender, EventArgs e)
        {
            if (cmdLivreCourante == null)
            {
                MessageBox.Show("Sélectionnez une commande.");
                return;
            }

            if (lesSuivis == null || lesSuivis.Count == 0)
                lesSuivis = controller.GetAllSuivis();

            SuiviModel suiviNouveau = cbxCmdLivreSuivi.SelectedItem as SuiviModel;
            if (suiviNouveau == null) return;
            int nouveauIdSuivi = suiviNouveau.id;
            int ancienIdSuivi = cmdLivreCourante.idsuivi;

            if (ancienIdSuivi == nouveauIdSuivi) return;

            // id=4 (réglée) uniquement depuis id=3 (livrée)
            if (nouveauIdSuivi == 4 && ancienIdSuivi != 3)
            {
                MessageBox.Show("Une commande ne peut être réglée que si elle est livrée.");
                cbxCmdLivreSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            // id=3 ou 4 (livrée/réglée) ne peut pas revenir à id=1 ou 2
            if ((ancienIdSuivi == 3 || ancienIdSuivi == 4) && (nouveauIdSuivi == 1 || nouveauIdSuivi == 2))
            {
                MessageBox.Show("Une commande livrée ou réglée ne peut pas revenir à une étape précédente.");
                cbxCmdLivreSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            // id=4 (réglée) est finale
            if (ancienIdSuivi == 4)
            {
                MessageBox.Show("Une commande réglée ne peut plus être modifiée.");
                cbxCmdLivreSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            bool ok = controller.ModifierSuiviCommandeDocument(cmdLivreCourante.id, nouveauIdSuivi);
            MessageBox.Show(ok ? "Suivi mis à jour." : "Échec de la mise à jour.");

            if (ok) ChargerCommandesLivreSelectionne();
        }

        private void BtnCmdLivreSuppr_Click(object sender, EventArgs e)
        {
            if (cmdLivreCourante == null)
            {
                MessageBox.Show("Sélectionnez une commande.");
                return;
            }

            string lib = (cmdLivreCourante.suivi ?? "").ToLowerInvariant();
            if (lib == "livrée" || lib == "réglée")
            {
                MessageBox.Show("Suppression interdite : commande livrée / réglée.");
                return;
            }

            DialogResult rep = MessageBox.Show("Confirmer la suppression de cette commande ?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rep != DialogResult.Yes) return;

            bool ok = controller.SupprimerCommandeDocument(cmdLivreCourante.id);
            MessageBox.Show(ok ? "Commande supprimée." : "Échec de la suppression.");

            if (ok) ChargerCommandesLivreSelectionne();
        }

        private void BtnCmdLivreRefresh_Click(object sender, EventArgs e)
        {
            ChargerCommandesLivreSelectionne();
        }

        #endregion

        /// <summary>
        /// Constructeur : création du contrôleur lié à ce formulaire
        /// </summary>
        internal FrmMediatek(model.Utilisateur utilisateur)
        {
            InitializeComponent();
            this.controller = new FrmMediatekController();
            lesSuivis = controller.GetAllSuivis();
            lesEtats = controller.GetAllEtats() ?? new List<Etat>();
            InitialiserControlesExemplaires();
            AppliquerDroitsAcces(utilisateur);
            // L'alerte de fin d'abonnement n'est affichée que pour les utilisateurs
            // qui gèrent les commandes (Administrateur, Responsable)
            if (utilisateur.GereCommandes())
                AlerterRevuesFinAbonnement();
        }

        /// <summary>
        /// Applique les restrictions d'accès selon le service de l'utilisateur connecté.
        /// - Diffusion : masque les onglets de commandes.
        /// - Administrateur / Responsable : accès complet.
        /// (Le cas Culture est traité dans Program.cs avant l'ouverture de cette fenêtre.)
        /// </summary>
        private void AppliquerDroitsAcces(model.Utilisateur utilisateur)
        {
            string service = utilisateur.LibelleService?.ToLower() ?? "";

            switch (service)
            {
                case "diffusion":
                    // Accès consultation uniquement : retirer les onglets commandes
                    // (TabPage.Visible = false ne fonctionne pas en WinForms .NET Framework)
                    tabOngletsApplication.TabPages.Remove(tabCommandesLivres);
                    tabOngletsApplication.TabPages.Remove(tabCommandesDvd);
                    tabOngletsApplication.TabPages.Remove(tabCommandesRevues);
                    break;
                // case "administrateur" et "responsable" : accès complet → rien à masquer
            }
        }

        /// <summary>
        /// Affiche une alerte si des revues ont un abonnement se terminant dans moins de 30 jours.
        /// </summary>
        private void AlerterRevuesFinAbonnement()
        {
            List<dynamic> revuesFinAbo = controller.GetRevuesFinAbonnement();
            if (revuesFinAbo == null || revuesFinAbo.Count == 0) return;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("Attention : les abonnements suivants se terminent dans moins de 30 jours :");
            sb.AppendLine();
            foreach (dynamic r in revuesFinAbo)
            {
                string titre = r["titre"]?.ToString() ?? "(inconnu)";
                string datefin = r["datefin"]?.ToString() ?? "?";
                sb.AppendLine($"  - {titre}  (fin : {datefin})");
            }
            MessageBox.Show(sb.ToString(), "Abonnements bientôt expirés",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Rempli un des 3 combo (genre, public, rayon)
        /// </summary>
        /// <param name="lesCategories">liste des objets de type Genre ou Public ou Rayon</param>
        /// <param name="bdg">bindingsource contenant les informations</param>
        /// <param name="cbx">combobox à remplir</param>
        public void RemplirComboCategorie(List<model.Categorie> lesCategories, BindingSource bdg, ComboBox cbx)
        {
            bdg.DataSource = lesCategories;
            cbx.DataSource = bdg;
            if (cbx.Items.Count > 0)
            {
                cbx.SelectedIndex = -1;
            }
        }
        #endregion

        #region Onglet Livres
        private readonly BindingSource bdgLivresListe = new BindingSource();
        private List<model.Livre> lesLivres = new List<model.Livre>();

        /// <summary>
        /// Ouverture de l'onglet Livres : 
        /// appel des méthodes pour remplir le datagrid des livres et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabLivres_Enter(object sender, EventArgs e)
        {
            lesLivres = controller.GetAllLivres();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxLivresGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxLivresPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxLivresRayons);
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="livres">liste de livres</param>
        private void RemplirLivresListe(List<model.Livre> livres)
        {
            bdgLivresListe.DataSource = livres;
            dgvLivresListe.DataSource = bdgLivresListe;
            dgvLivresListe.Columns["isbn"].Visible = false;
            dgvLivresListe.Columns["idRayon"].Visible = false;
            dgvLivresListe.Columns["idGenre"].Visible = false;
            dgvLivresListe.Columns["idPublic"].Visible = false;
            dgvLivresListe.Columns["image"].Visible = false;
            dgvLivresListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLivresListe.Columns["id"].DisplayIndex = 0;
            dgvLivresListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage du livre dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbLivresNumRecherche.Text.Equals(""))
            {
                txbLivresTitreRecherche.Text = "";
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                Livre livre = lesLivres.Find(x => x.Id.Equals(txbLivresNumRecherche.Text));
                if (livre != null)
                {
                    List<model.Livre> livres = new List<model.Livre>() { livre };
                    RemplirLivresListe(livres);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirLivresListeComplete();
                }
            }
            else
            {
                RemplirLivresListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des livres dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxbLivresTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbLivresTitreRecherche.Text.Equals(""))
            {
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
                txbLivresNumRecherche.Text = "";
                List<model.Livre> lesLivresParTitre;
                lesLivresParTitre = lesLivres.FindAll(x => x.Titre.ToLower().Contains(txbLivresTitreRecherche.Text.ToLower()));
                RemplirLivresListe(lesLivresParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxLivresGenres.SelectedIndex < 0 && cbxLivresPublics.SelectedIndex < 0 && cbxLivresRayons.SelectedIndex < 0
                    && txbLivresNumRecherche.Text.Equals(""))
                {
                    RemplirLivresListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations du livre sélectionné
        /// </summary>
        /// <param name="livre">le livre</param>
        private void AfficheLivresInfos(Livre livre)
        {
            txbLivresAuteur.Text = livre.Auteur;
            txbLivresCollection.Text = livre.Collection;
            txbLivresImage.Text = livre.Image;
            txbLivresIsbn.Text = livre.Isbn;
            txbLivresNumero.Text = livre.Id;
            txbLivresGenre.Text = livre.Genre;
            txbLivresPublic.Text = livre.Public;
            txbLivresRayon.Text = livre.Rayon;
            txbLivresTitre.Text = livre.Titre;
            string image = livre.Image;
            try
            {
                pcbLivresImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbLivresImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations du livre
        /// </summary>
        private void VideLivresInfos()
        {
            txbLivresAuteur.Text = "";
            txbLivresCollection.Text = "";
            txbLivresImage.Text = "";
            txbLivresIsbn.Text = "";
            txbLivresNumero.Text = "";
            txbLivresGenre.Text = "";
            txbLivresPublic.Text = "";
            txbLivresRayon.Text = "";
            txbLivresTitre.Text = "";
            pcbLivresImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresGenres.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Genre genre = (Genre)cbxLivresGenres.SelectedItem;
                List<model.Livre> livres = lesLivres.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirLivresListe(livres);
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresPublics.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Public lePublic = (Public)cbxLivresPublics.SelectedItem;
                List<model.Livre> livres = lesLivres.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirLivresListe(livres);
                cbxLivresRayons.SelectedIndex = -1;
                cbxLivresGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxLivresRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLivresRayons.SelectedIndex >= 0)
            {
                txbLivresTitreRecherche.Text = "";
                txbLivresNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxLivresRayons.SelectedItem;
                List<model.Livre> livres = lesLivres.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirLivresListe(livres);
                cbxLivresGenres.SelectedIndex = -1;
                cbxLivresPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Sur la sélection d'une ligne ou cellule dans le grid
        /// affichage des informations du livre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLivresListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLivresListe.CurrentCell != null)
            {
                try
                {
                    Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
                    AfficheLivresInfos(livre);
                    ChargerExemplairesLivre(livre.Id);
                }
                catch
                {
                    VideLivresZones();
                    ChargerExemplairesLivre(null);
                }
            }
            else
            {
                VideLivresInfos();
                ChargerExemplairesLivre(null);
            }
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des livres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirLivresListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des livres
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirLivresListeComplete()
        {
            RemplirLivresListe(lesLivres);
            VideLivresZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideLivresZones()
        {
            cbxLivresGenres.SelectedIndex = -1;
            cbxLivresRayons.SelectedIndex = -1;
            cbxLivresPublics.SelectedIndex = -1;
            txbLivresNumRecherche.Text = "";
            txbLivresTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLivresListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideLivresZones();
            string titreColonne = dgvLivresListe.Columns[e.ColumnIndex].HeaderText;
            List<model.Livre> sortedList = new List<model.Livre>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesLivres.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesLivres.OrderBy(o => o.Titre).ToList();
                    break;
                case "Collection":
                    sortedList = lesLivres.OrderBy(o => o.Collection).ToList();
                    break;
                case "Auteur":
                    sortedList = lesLivres.OrderBy(o => o.Auteur).ToList();
                    break;
                case "Genre":
                    sortedList = lesLivres.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesLivres.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesLivres.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirLivresListe(sortedList);
        }
        #endregion

        #region Onglet Commandes DVD

        private void CbxCmdDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerCommandesDvdSelectionne();
        }

        private void ChargerCommandesDvdSelectionne()
        {
            dvdCmdCourant = cbxCmdDvd.SelectedItem as Dvd;

            if (dvdCmdCourant == null)
            {
                bsCmdDvd.DataSource = null;
                btnCmdDvdMajSuivi.Enabled = false;
                btnCmdDvdSuppr.Enabled = false;
                return;
            }

            var commandes = controller.GetCommandesDocument(dvdCmdCourant.Id);

            if (commandes != null && commandes.Count > 0)
                commandes = commandes.OrderByDescending(c => c.datecommande).ToList();

            bsCmdDvd.DataSource = null;
            bsCmdDvd.DataSource = commandes;
            dgvCmdDvd.Refresh();

            btnCmdDvdMajSuivi.Enabled = commandes != null && commandes.Count > 0;
            btnCmdDvdSuppr.Enabled = commandes != null && commandes.Count > 0;
        }

        private void DgvCmdDvd_SelectionChanged(object sender, EventArgs e)
        {
            cmdDvdCourante = dgvCmdDvd.CurrentRow?.DataBoundItem as CommandeDocument;

            if (cmdDvdCourante == null)
            {
                btnCmdDvdMajSuivi.Enabled = false;
                btnCmdDvdSuppr.Enabled = false;
                return;
            }

            cbxCmdDvdSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == cmdDvdCourante.idsuivi);

            string lib = (cmdDvdCourante.suivi ?? "").ToLowerInvariant();
            btnCmdDvdSuppr.Enabled = (lib != "livrée" && lib != "réglée");
        }

        private void BtnCmdDvdAjouter_Click(object sender, EventArgs e)
        {
            if (dvdCmdCourant == null)
            {
                MessageBox.Show("Sélectionnez un DVD.");
                return;
            }

            if (!double.TryParse(txbCmdDvdMontant.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.");
                return;
            }

            int nb = (int)nudCmdDvdNbEx.Value;
            if (nb <= 0)
            {
                MessageBox.Show("Nombre d'exemplaires invalide.");
                return;
            }

            if (lesSuivis == null || lesSuivis.Count == 0)
                lesSuivis = controller.GetAllSuivis();

            if (lesSuivis == null || lesSuivis.Count == 0)
            {
                MessageBox.Show("Impossible de récupérer les suivis. Vérifiez la connexion au serveur.");
                return;
            }

            SuiviModel suiviEnCours = lesSuivis.FirstOrDefault(s =>
                s.libelle != null && s.libelle.ToLowerInvariant().Contains("cours"));
            if (suiviEnCours == null)
            {
                string liste = string.Join(", ", lesSuivis.Select(s => "'" + s.libelle + "'"));
                MessageBox.Show("Suivi 'en cours' introuvable. Suivis disponibles : " + liste);
                return;
            }

            CommandeDocument cmd = new CommandeDocument
            {
                iddocument = dvdCmdCourant.Id,
                datecommande = dtpCmdDvdDate.Value.Date,
                montant = montant,
                nbexemplaire = nb,
                idsuivi = suiviEnCours.id
            };

            bool ok = controller.CreerCommandeDocument(cmd);
            MessageBox.Show(ok ? "Commande enregistrée." : "Échec de l'enregistrement.");

            if (ok) ChargerCommandesDvdSelectionne();
        }

        private void BtnCmdDvdMajSuivi_Click(object sender, EventArgs e)
        {
            if (cmdDvdCourante == null)
            {
                MessageBox.Show("Sélectionnez une commande.");
                return;
            }

            if (lesSuivis == null || lesSuivis.Count == 0)
                lesSuivis = controller.GetAllSuivis();

            SuiviModel suiviNouveau = cbxCmdDvdSuivi.SelectedItem as SuiviModel;
            if (suiviNouveau == null) return;
            int nouveauIdSuivi = suiviNouveau.id;
            int ancienIdSuivi = cmdDvdCourante.idsuivi;

            if (ancienIdSuivi == nouveauIdSuivi) return;

            // id=4 (réglée) uniquement depuis id=3 (livrée)
            if (nouveauIdSuivi == 4 && ancienIdSuivi != 3)
            {
                MessageBox.Show("Une commande ne peut être réglée que si elle est livrée.");
                cbxCmdDvdSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            // id=3 ou 4 ne peut pas revenir à id=1 ou 2
            if ((ancienIdSuivi == 3 || ancienIdSuivi == 4) && (nouveauIdSuivi == 1 || nouveauIdSuivi == 2))
            {
                MessageBox.Show("Une commande livrée ou réglée ne peut pas revenir à une étape précédente.");
                cbxCmdDvdSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            // id=4 (réglée) est finale
            if (ancienIdSuivi == 4)
            {
                MessageBox.Show("Une commande réglée ne peut plus être modifiée.");
                cbxCmdDvdSuivi.SelectedItem = lesSuivis.FirstOrDefault(s => s.id == ancienIdSuivi);
                return;
            }

            bool ok = controller.ModifierSuiviCommandeDocument(cmdDvdCourante.id, nouveauIdSuivi);
            MessageBox.Show(ok ? "Suivi mis à jour." : "Échec de la mise à jour.");

            if (ok) ChargerCommandesDvdSelectionne();
        }

        private void BtnCmdDvdSuppr_Click(object sender, EventArgs e)
        {
            if (cmdDvdCourante == null)
            {
                MessageBox.Show("Sélectionnez une commande.");
                return;
            }

            string lib = (cmdDvdCourante.suivi ?? "").ToLowerInvariant();
            if (lib == "livrée" || lib == "réglée")
            {
                MessageBox.Show("Suppression interdite : commande livrée / réglée.");
                return;
            }

            DialogResult rep = MessageBox.Show("Confirmer la suppression de cette commande ?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rep != DialogResult.Yes) return;

            bool ok = controller.SupprimerCommandeDocument(cmdDvdCourante.id);
            MessageBox.Show(ok ? "Commande supprimée." : "Échec de la suppression.");

            if (ok) ChargerCommandesDvdSelectionne();
        }

        private void BtnCmdDvdRefresh_Click(object sender, EventArgs e)
        {
            ChargerCommandesDvdSelectionne();
        }

        #endregion

        #region Onglet Dvd
        private readonly BindingSource bdgDvdListe = new BindingSource();
        private List<model.Dvd> lesDvd = new List<model.Dvd>();

        /// <summary>
        /// Ouverture de l'onglet Dvds : 
        /// appel des méthodes pour remplir le datagrid des dvd et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabDvd_Enter(object sender, EventArgs e)
        {
            lesDvd = controller.GetAllDvd();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxDvdGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxDvdPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxDvdRayons);
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="Dvds">liste de dvd</param>
        private void RemplirDvdListe(List<model.Dvd> Dvds)
        {
            bdgDvdListe.DataSource = Dvds;
            dgvDvdListe.DataSource = bdgDvdListe;
            dgvDvdListe.Columns["idRayon"].Visible = false;
            dgvDvdListe.Columns["idGenre"].Visible = false;
            dgvDvdListe.Columns["idPublic"].Visible = false;
            dgvDvdListe.Columns["image"].Visible = false;
            dgvDvdListe.Columns["synopsis"].Visible = false;
            dgvDvdListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDvdListe.Columns["id"].DisplayIndex = 0;
            dgvDvdListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage du Dvd dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbDvdNumRecherche.Text.Equals(""))
            {
                txbDvdTitreRecherche.Text = "";
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                Dvd dvd = lesDvd.Find(x => x.Id.Equals(txbDvdNumRecherche.Text));
                if (dvd != null)
                {
                    List<model.Dvd> Dvd = new List<model.Dvd>() { dvd };
                    RemplirDvdListe(Dvd);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirDvdListeComplete();
                }
            }
            else
            {
                RemplirDvdListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des Dvd dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbDvdTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbDvdTitreRecherche.Text.Equals(""))
            {
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
                txbDvdNumRecherche.Text = "";
                List<model.Dvd> lesDvdParTitre;
                lesDvdParTitre = lesDvd.FindAll(x => x.Titre.ToLower().Contains(txbDvdTitreRecherche.Text.ToLower()));
                RemplirDvdListe(lesDvdParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxDvdGenres.SelectedIndex < 0 && cbxDvdPublics.SelectedIndex < 0 && cbxDvdRayons.SelectedIndex < 0
                    && txbDvdNumRecherche.Text.Equals(""))
                {
                    RemplirDvdListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations du dvd sélectionné
        /// </summary>
        /// <param name="dvd">le dvd</param>
        private void AfficheDvdInfos(Dvd dvd)
        {
            txbDvdRealisateur.Text = dvd.Realisateur;
            txbDvdSynopsis.Text = dvd.Synopsis;
            txbDvdImage.Text = dvd.Image;
            txbDvdDuree.Text = dvd.Duree.ToString();
            txbDvdNumero.Text = dvd.Id;
            txbDvdGenre.Text = dvd.Genre;
            txbDvdPublic.Text = dvd.Public;
            txbDvdRayon.Text = dvd.Rayon;
            txbDvdTitre.Text = dvd.Titre;
            string image = dvd.Image;
            try
            {
                pcbDvdImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbDvdImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations du dvd
        /// </summary>
        private void VideDvdInfos()
        {
            txbDvdRealisateur.Text = "";
            txbDvdSynopsis.Text = "";
            txbDvdImage.Text = "";
            txbDvdDuree.Text = "";
            txbDvdNumero.Text = "";
            txbDvdGenre.Text = "";
            txbDvdPublic.Text = "";
            txbDvdRayon.Text = "";
            txbDvdTitre.Text = "";
            pcbDvdImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdGenres.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Genre genre = (Genre)cbxDvdGenres.SelectedItem;
                List<model.Dvd> Dvd = lesDvd.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdPublics.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Public lePublic = (Public)cbxDvdPublics.SelectedItem;
                List<model.Dvd> Dvd = lesDvd.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdRayons.SelectedIndex = -1;
                cbxDvdGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDvdRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDvdRayons.SelectedIndex >= 0)
            {
                txbDvdTitreRecherche.Text = "";
                txbDvdNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxDvdRayons.SelectedItem;
                List<model.Dvd> Dvd = lesDvd.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirDvdListe(Dvd);
                cbxDvdGenres.SelectedIndex = -1;
                cbxDvdPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Sur la sélection d'une ligne ou cellule dans le grid
        /// affichage des informations du dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDvdListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDvdListe.CurrentCell != null)
            {
                try
                {
                    Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
                    AfficheDvdInfos(dvd);
                    ChargerExemplairesDvd(dvd.Id);
                }
                catch
                {
                    VideDvdZones();
                    ChargerExemplairesDvd(null);
                }
            }
            else
            {
                VideDvdInfos();
                ChargerExemplairesDvd(null);
            }
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des Dvd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvdAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirDvdListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des Dvd
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirDvdListeComplete()
        {
            RemplirDvdListe(lesDvd);
            VideDvdZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideDvdZones()
        {
            cbxDvdGenres.SelectedIndex = -1;
            cbxDvdRayons.SelectedIndex = -1;
            cbxDvdPublics.SelectedIndex = -1;
            txbDvdNumRecherche.Text = "";
            txbDvdTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDvdListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideDvdZones();
            string titreColonne = dgvDvdListe.Columns[e.ColumnIndex].HeaderText;
            List<model.Dvd> sortedList = new List<model.Dvd>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesDvd.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesDvd.OrderBy(o => o.Titre).ToList();
                    break;
                case "Duree":
                    sortedList = lesDvd.OrderBy(o => o.Duree).ToList();
                    break;
                case "Realisateur":
                    sortedList = lesDvd.OrderBy(o => o.Realisateur).ToList();
                    break;
                case "Genre":
                    sortedList = lesDvd.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesDvd.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesDvd.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirDvdListe(sortedList);
        }
        #endregion

        #region Onglet Revues
        private readonly BindingSource bdgRevuesListe = new BindingSource();
        private List<model.Revue> lesRevues = new List<model.Revue>();

        /// <summary>
        /// Ouverture de l'onglet Revues : 
        /// appel des méthodes pour remplir le datagrid des revues et des combos (genre, rayon, public)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabRevues_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            RemplirComboCategorie(controller.GetAllGenres(), bdgGenres, cbxRevuesGenres);
            RemplirComboCategorie(controller.GetAllPublics(), bdgPublics, cbxRevuesPublics);
            RemplirComboCategorie(controller.GetAllRayons(), bdgRayons, cbxRevuesRayons);
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Remplit le dategrid avec la liste reçue en paramètre
        /// </summary>
        /// <param name="revues"></param>
        private void RemplirRevuesListe(List<model.Revue> revues)
        {
            bdgRevuesListe.DataSource = revues;
            dgvRevuesListe.DataSource = bdgRevuesListe;
            dgvRevuesListe.Columns["idRayon"].Visible = false;
            dgvRevuesListe.Columns["idGenre"].Visible = false;
            dgvRevuesListe.Columns["idPublic"].Visible = false;
            dgvRevuesListe.Columns["image"].Visible = false;
            dgvRevuesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRevuesListe.Columns["id"].DisplayIndex = 0;
            dgvRevuesListe.Columns["titre"].DisplayIndex = 1;
        }

        /// <summary>
        /// Recherche et affichage de la revue dont on a saisi le numéro.
        /// Si non trouvé, affichage d'un MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesNumRecherche_Click(object sender, EventArgs e)
        {
            if (!txbRevuesNumRecherche.Text.Equals(""))
            {
                txbRevuesTitreRecherche.Text = "";
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                Revue revue = lesRevues.Find(x => x.Id.Equals(txbRevuesNumRecherche.Text));
                if (revue != null)
                {
                    List<model.Revue> revues = new List<model.Revue>() { revue };
                    RemplirRevuesListe(revues);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                    RemplirRevuesListeComplete();
                }
            }
            else
            {
                RemplirRevuesListeComplete();
            }
        }

        /// <summary>
        /// Recherche et affichage des revues dont le titre matche acec la saisie.
        /// Cette procédure est exécutée à chaque ajout ou suppression de caractère
        /// dans le textBox de saisie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbRevuesTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            if (!txbRevuesTitreRecherche.Text.Equals(""))
            {
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
                txbRevuesNumRecherche.Text = "";
                List<model.Revue> lesRevuesParTitre;
                lesRevuesParTitre = lesRevues.FindAll(x => x.Titre.ToLower().Contains(txbRevuesTitreRecherche.Text.ToLower()));
                RemplirRevuesListe(lesRevuesParTitre);
            }
            else
            {
                // si la zone de saisie est vide et aucun élément combo sélectionné, réaffichage de la liste complète
                if (cbxRevuesGenres.SelectedIndex < 0 && cbxRevuesPublics.SelectedIndex < 0 && cbxRevuesRayons.SelectedIndex < 0
                    && txbRevuesNumRecherche.Text.Equals(""))
                {
                    RemplirRevuesListeComplete();
                }
            }
        }

        /// <summary>
        /// Affichage des informations de la revue sélectionné
        /// </summary>
        /// <param name="revue">la revue</param>
        private void AfficheRevuesInfos(Revue revue)
        {
            txbRevuesPeriodicite.Text = revue.Periodicite;
            txbRevuesImage.Text = revue.Image;
            txbRevuesDateMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbRevuesNumero.Text = revue.Id;
            txbRevuesGenre.Text = revue.Genre;
            txbRevuesPublic.Text = revue.Public;
            txbRevuesRayon.Text = revue.Rayon;
            txbRevuesTitre.Text = revue.Titre;
            string image = revue.Image;
            try
            {
                pcbRevuesImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbRevuesImage.Image = null;
            }
        }

        /// <summary>
        /// Vide les zones d'affichage des informations de la reuve
        /// </summary>
        private void VideRevuesInfos()
        {
            txbRevuesPeriodicite.Text = "";
            txbRevuesImage.Text = "";
            txbRevuesDateMiseADispo.Text = "";
            txbRevuesNumero.Text = "";
            txbRevuesGenre.Text = "";
            txbRevuesPublic.Text = "";
            txbRevuesRayon.Text = "";
            txbRevuesTitre.Text = "";
            pcbRevuesImage.Image = null;
        }

        /// <summary>
        /// Filtre sur le genre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesGenres.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Genre genre = (Genre)cbxRevuesGenres.SelectedItem;
                List<model.Revue> revues = lesRevues.FindAll(x => x.Genre.Equals(genre.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur la catégorie de public
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesPublics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesPublics.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Public lePublic = (Public)cbxRevuesPublics.SelectedItem;
                List<model.Revue> revues = lesRevues.FindAll(x => x.Public.Equals(lePublic.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesRayons.SelectedIndex = -1;
                cbxRevuesGenres.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Filtre sur le rayon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRevuesRayons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRevuesRayons.SelectedIndex >= 0)
            {
                txbRevuesTitreRecherche.Text = "";
                txbRevuesNumRecherche.Text = "";
                Rayon rayon = (Rayon)cbxRevuesRayons.SelectedItem;
                List<model.Revue> revues = lesRevues.FindAll(x => x.Rayon.Equals(rayon.Libelle));
                RemplirRevuesListe(revues);
                cbxRevuesGenres.SelectedIndex = -1;
                cbxRevuesPublics.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Sur la sélection d'une ligne ou cellule dans le grid
        /// affichage des informations de la revue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRevuesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRevuesListe.CurrentCell != null)
            {
                try
                {
                    Revue revue = (Revue)bdgRevuesListe.List[bdgRevuesListe.Position];
                    AfficheRevuesInfos(revue);
                }
                catch
                {
                    VideRevuesZones();
                }
            }
            else
            {
                VideRevuesInfos();
            }
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulPublics_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulRayons_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Sur le clic du bouton d'annulation, affichage de la liste complète des revues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevuesAnnulGenres_Click(object sender, EventArgs e)
        {
            RemplirRevuesListeComplete();
        }

        /// <summary>
        /// Affichage de la liste complète des revues
        /// et annulation de toutes les recherches et filtres
        /// </summary>
        private void RemplirRevuesListeComplete()
        {
            RemplirRevuesListe(lesRevues);
            VideRevuesZones();
        }

        /// <summary>
        /// vide les zones de recherche et de filtre
        /// </summary>
        private void VideRevuesZones()
        {
            cbxRevuesGenres.SelectedIndex = -1;
            cbxRevuesRayons.SelectedIndex = -1;
            cbxRevuesPublics.SelectedIndex = -1;
            txbRevuesNumRecherche.Text = "";
            txbRevuesTitreRecherche.Text = "";
        }

        /// <summary>
        /// Tri sur les colonnes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRevuesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VideRevuesZones();
            string titreColonne = dgvRevuesListe.Columns[e.ColumnIndex].HeaderText;
            List<model.Revue> sortedList = new List<model.Revue>();
            switch (titreColonne)
            {
                case "Id":
                    sortedList = lesRevues.OrderBy(o => o.Id).ToList();
                    break;
                case "Titre":
                    sortedList = lesRevues.OrderBy(o => o.Titre).ToList();
                    break;
                case "Periodicite":
                    sortedList = lesRevues.OrderBy(o => o.Periodicite).ToList();
                    break;
                case "DelaiMiseADispo":
                    sortedList = lesRevues.OrderBy(o => o.DelaiMiseADispo).ToList();
                    break;
                case "Genre":
                    sortedList = lesRevues.OrderBy(o => o.Genre).ToList();
                    break;
                case "Public":
                    sortedList = lesRevues.OrderBy(o => o.Public).ToList();
                    break;
                case "Rayon":
                    sortedList = lesRevues.OrderBy(o => o.Rayon).ToList();
                    break;
            }
            RemplirRevuesListe(sortedList);
        }
        #endregion
        #region Onglet Commandes Revues
        private void TabCmdRevues_Enter(object sender, EventArgs e)
        {
            // Recharger la liste des revues à chaque entrée dans l'onglet
            List<Revue> toutesLesRevues = controller.GetAllRevues();
            cbxCmdRevue.DataSource = null;
            cbxCmdRevue.DataSource = toutesLesRevues;
            cbxCmdRevue.DisplayMember = "Titre";
            cbxCmdRevue.ValueMember = "Id";
            cbxCmdRevue.SelectedIndex = (toutesLesRevues != null && toutesLesRevues.Count > 0) ? 0 : -1;

            dgvCmdRevue.AutoGenerateColumns = true;
            dgvCmdRevue.DataSource = bsCmdRevue;

            ChargerCommandesRevueSelectionnee();
        }
        private void CbxCmdRevue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerCommandesRevueSelectionnee();
        }
        private void ChargerCommandesRevueSelectionnee()
        {
            revueCmdCourante = cbxCmdRevue.SelectedItem as Revue;

            if (revueCmdCourante == null)
            {
                bsCmdRevue.DataSource = null;
                btnCmdRevueSuppr.Enabled = false;
                return;
            }

            var commandes = controller.GetCommandesRevue(revueCmdCourante.Id);

            if (commandes != null && commandes.Count > 0)
                commandes = commandes.OrderByDescending(c => c.Datecommande).ToList();

            bsCmdRevue.DataSource = null;
            bsCmdRevue.DataSource = commandes;
            dgvCmdRevue.Refresh();

            btnCmdRevueSuppr.Enabled = commandes != null && commandes.Count > 0;
        }
        private void DgvCmdRevue_SelectionChanged(object sender, EventArgs e)
        {
            cmdRevueCourante = dgvCmdRevue.CurrentRow?.DataBoundItem as CommandeRevue;
            btnCmdRevueSuppr.Enabled = (cmdRevueCourante != null);
        }
        private void BtnCmdRevueAjouter_Click(object sender, EventArgs e)
        {
            if (revueCmdCourante == null)
            {
                MessageBox.Show("Sélectionnez une revue.");
                return;
            }

            if (!double.TryParse(txbCmdRevueMontant.Text.Replace(',', '.'),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out double montant) || montant <= 0)
            {
                MessageBox.Show("Montant invalide.");
                return;
            }

            // Vérification : date de fin > date de commande
            if (dtpCmdRevueFinAbo.Value.Date <= dtpCmdRevueDate.Value.Date)
            {
                MessageBox.Show("La date de fin d'abonnement doit être postérieure à la date de commande.");
                return;
            }

            CommandeRevue cmd = new CommandeRevue
            {
                Id = "",
                Iddocument = revueCmdCourante.Id,
                Datecommande = dtpCmdRevueDate.Value.Date,
                Montant = montant,
                Datefinabonnement = dtpCmdRevueFinAbo.Value.Date
            };

            bool ok = controller.CreerCommandeRevue(cmd);
            MessageBox.Show(ok ? "Abonnement enregistré." : "Échec de l'enregistrement.");

            if (ok) ChargerCommandesRevueSelectionnee();
        }

        private void BtnCmdRevueSuppr_Click(object sender, EventArgs e)
        {
            if (cmdRevueCourante == null)
            {
                MessageBox.Show("Sélectionnez un abonnement.");
                return;
            }

            // Vérification conditionnelle : aucun exemplaire ne doit avoir une date d'achat
            // comprise dans la période de l'abonnement [Datecommande, Datefinabonnement]
            List<Exemplaire> exemplaires = controller.GetExemplairesRevue(cmdRevueCourante.Iddocument);
            if (exemplaires != null)
            {
                foreach (Exemplaire ex in exemplaires)
                {
                    if (AbonnementHelper.ParutionDansAbonnement(
                            cmdRevueCourante.Datecommande,
                            cmdRevueCourante.Datefinabonnement,
                            ex.DateAchat))
                    {
                        MessageBox.Show(
                            "Suppression impossible : un ou plusieurs exemplaires ont été reçus pendant cet abonnement.",
                            "Suppression interdite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            DialogResult rep = MessageBox.Show("Confirmer la suppression de cet abonnement ?",
                "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rep != DialogResult.Yes) return;

            bool ok = controller.SupprimerCommandeRevue(cmdRevueCourante.Id);
            MessageBox.Show(ok ? "Abonnement supprimé." : "Échec de la suppression.");

            if (ok) ChargerCommandesRevueSelectionnee();
        }

        private void BtnCmdRevueRefresh_Click(object sender, EventArgs e)
        {
            ChargerCommandesRevueSelectionnee();
        }
        #endregion
        #region Onglet Parutions
        private readonly BindingSource bdgExemplairesListe = new BindingSource();
        private List<model.Exemplaire> lesExemplaires = new List<model.Exemplaire>();
        const string ETATNEUF = "00001";


        /// <summary>
        /// Ouverture de l'onglet : récupère le revues et vide tous les champs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabReceptionRevue_Enter(object sender, EventArgs e)
        {
            lesRevues = controller.GetAllRevues();
            txbReceptionRevueNumero.Text = "";
        }

        /// <summary>
        /// Remplit le dategrid des exemplaires avec la liste reçue en paramètre
        /// </summary>
        /// <param name="exemplaires">liste d'exemplaires</param>
        private void RemplirReceptionExemplairesListe(List<model.Exemplaire> exemplaires)
        {
            if (exemplaires != null)
            {
                AppliquerLibelleEtat(exemplaires);
                bdgExemplairesListe.DataSource = exemplaires;
                dgvReceptionExemplairesListe.DataSource = bdgExemplairesListe;
                dgvReceptionExemplairesListe.Columns["idEtat"].Visible = false;
                dgvReceptionExemplairesListe.Columns["id"].Visible = false;
                if (dgvReceptionExemplairesListe.Columns["Photo"] != null)
                    dgvReceptionExemplairesListe.Columns["Photo"].Visible = false;
                if (dgvReceptionExemplairesListe.Columns["photo"] != null)
                    dgvReceptionExemplairesListe.Columns["photo"].Visible = false;
                dgvReceptionExemplairesListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvReceptionExemplairesListe.Columns["numero"].DisplayIndex = 0;
                dgvReceptionExemplairesListe.Columns["dateAchat"].DisplayIndex = 1;
                if (dgvReceptionExemplairesListe.Columns["LibelleEtat"] != null)
                    dgvReceptionExemplairesListe.Columns["LibelleEtat"].DisplayIndex = 2;
            }
            else
            {
                bdgExemplairesListe.DataSource = null;
                paritionExemplaireCourant = null;
                if (btnParutionsChgtEtat != null) btnParutionsChgtEtat.Enabled = false;
                if (btnParutionsSupprExemplaire != null) btnParutionsSupprExemplaire.Enabled = false;
            }
        }

        /// <summary>
        /// Recherche d'un numéro de revue et affiche ses informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionRechercher_Click(object sender, EventArgs e)
        {
            if (!txbReceptionRevueNumero.Text.Equals(""))
            {
                if (lesRevues == null || lesRevues.Count == 0)
                    lesRevues = controller.GetAllRevues() ?? new List<model.Revue>();
                Revue revue = lesRevues.Find(x => x.Id != null && x.Id.Equals(txbReceptionRevueNumero.Text));
                if (revue != null)
                {
                    AfficheReceptionRevueInfos(revue);
                }
                else
                {
                    MessageBox.Show("numéro introuvable");
                }
            }
        }

        /// <summary>
        /// Si le numéro de revue est modifié, la zone de l'exemplaire est vidée et inactive
        /// les informations de la revue son aussi effacées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbReceptionRevueNumero_TextChanged(object sender, EventArgs e)
        {
            txbReceptionRevuePeriodicite.Text = "";
            txbReceptionRevueImage.Text = "";
            txbReceptionRevueDelaiMiseADispo.Text = "";
            txbReceptionRevueGenre.Text = "";
            txbReceptionRevuePublic.Text = "";
            txbReceptionRevueRayon.Text = "";
            txbReceptionRevueTitre.Text = "";
            pcbReceptionRevueImage.Image = null;
            RemplirReceptionExemplairesListe(null);
            AccesReceptionExemplaireGroupBox(false);
        }

        /// <summary>
        /// Affichage des informations de la revue sélectionnée et les exemplaires
        /// </summary>
        /// <param name="revue">la revue</param>
        private void AfficheReceptionRevueInfos(Revue revue)
        {
            // informations sur la revue
            txbReceptionRevuePeriodicite.Text = revue.Periodicite;
            txbReceptionRevueImage.Text = revue.Image;
            txbReceptionRevueDelaiMiseADispo.Text = revue.DelaiMiseADispo.ToString();
            txbReceptionRevueNumero.Text = revue.Id;
            txbReceptionRevueGenre.Text = revue.Genre;
            txbReceptionRevuePublic.Text = revue.Public;
            txbReceptionRevueRayon.Text = revue.Rayon;
            txbReceptionRevueTitre.Text = revue.Titre;
            string image = revue.Image;
            try
            {
                pcbReceptionRevueImage.Image = Image.FromFile(image);
            }
            catch
            {
                pcbReceptionRevueImage.Image = null;
            }
            // affiche la liste des exemplaires de la revue
            AfficheReceptionExemplairesRevue();
        }

        /// <summary>
        /// Récupère et affiche les exemplaires d'une revue
        /// </summary>
        private void AfficheReceptionExemplairesRevue()
        {
            string idDocuement = txbReceptionRevueNumero.Text;
            lesExemplaires = controller.GetExemplairesRevue(idDocuement);
            RemplirReceptionExemplairesListe(lesExemplaires);
            AccesReceptionExemplaireGroupBox(true);
        }

        /// <summary>
        /// Permet ou interdit l'accès à la gestion de la réception d'un exemplaire
        /// et vide les objets graphiques
        /// </summary>
        /// <param name="acces">true ou false</param>
        private void AccesReceptionExemplaireGroupBox(bool acces)
        {
            grpReceptionExemplaire.Enabled = acces;
            txbReceptionExemplaireImage.Text = "";
            txbReceptionExemplaireNumero.Text = "";
            pcbReceptionExemplaireImage.Image = null;
            dtpReceptionExemplaireDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Recherche image sur disque (pour l'exemplaire à insérer)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionExemplaireImage_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                // positionnement à la racine du disque où se trouve le dossier actuel
                InitialDirectory = Path.GetPathRoot(Environment.CurrentDirectory),
                Filter = "Files|*.jpg;*.bmp;*.jpeg;*.png;*.gif"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            txbReceptionExemplaireImage.Text = filePath;
            try
            {
                pcbReceptionExemplaireImage.Image = Image.FromFile(filePath);
            }
            catch
            {
                pcbReceptionExemplaireImage.Image = null;
            }
        }

        /// <summary>
        /// Enregistrement du nouvel exemplaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceptionExemplaireValider_Click(object sender, EventArgs e)
        {
            if (!txbReceptionExemplaireNumero.Text.Equals(""))
            {
                try
                {
                    int numero = int.Parse(txbReceptionExemplaireNumero.Text);
                    DateTime dateAchat = dtpReceptionExemplaireDate.Value;
                    string photo = txbReceptionExemplaireImage.Text;
                    string idEtat = ETATNEUF;
                    string idDocument = txbReceptionRevueNumero.Text;
                    Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDocument);
                    if (controller.CreerExemplaire(exemplaire))
                    {
                        AfficheReceptionExemplairesRevue();
                    }
                    else
                    {
                        MessageBox.Show("numéro de publication déjà existant", "Erreur");
                    }
                }
                catch
                {
                    MessageBox.Show("le numéro de parution doit être numérique", "Information");
                    txbReceptionExemplaireNumero.Text = "";
                    txbReceptionExemplaireNumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("numéro de parution obligatoire", "Information");
            }
        }

        /// <summary>
        /// Tri sur une colonne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvExemplairesListe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string titreColonne = dgvReceptionExemplairesListe.Columns[e.ColumnIndex].HeaderText;
            List<model.Exemplaire> sortedList = new List<model.Exemplaire>();
            switch (titreColonne)
            {
                case "Numero":
                    sortedList = lesExemplaires.OrderBy(o => o.Numero).Reverse().ToList();
                    break;
                case "DateAchat":
                    sortedList = lesExemplaires.OrderBy(o => o.DateAchat).Reverse().ToList();
                    break;
                case "LibelleEtat":
                    sortedList = lesExemplaires.OrderBy(o => o.LibelleEtat).ToList();
                    break;
                default:
                    sortedList = lesExemplaires.OrderBy(o => o.DateAchat).Reverse().ToList();
                    break;
            }
            RemplirReceptionExemplairesListe(sortedList);
        }

        /// <summary>
        /// affichage de l'image de l'exemplaire suite à la sélection d'un exemplaire dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReceptionExemplairesListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceptionExemplairesListe.CurrentCell != null)
            {
                Exemplaire exemplaire = (Exemplaire)bdgExemplairesListe.List[bdgExemplairesListe.Position];
                paritionExemplaireCourant = exemplaire;
                if (btnParutionsChgtEtat != null) btnParutionsChgtEtat.Enabled = true;
                if (btnParutionsSupprExemplaire != null) btnParutionsSupprExemplaire.Enabled = true;
                if (cbxParutionsEtat != null && lesEtats.Count > 0)
                    cbxParutionsEtat.SelectedItem = lesEtats.FirstOrDefault(et => et.Id == exemplaire.IdEtat);
                string image = exemplaire.Photo;
                try
                {
                    pcbReceptionExemplaireRevueImage.Image = Image.FromFile(image);
                }
                catch
                {
                    pcbReceptionExemplaireRevueImage.Image = null;
                }
            }
            else
            {
                paritionExemplaireCourant = null;
                if (btnParutionsChgtEtat != null) btnParutionsChgtEtat.Enabled = false;
                if (btnParutionsSupprExemplaire != null) btnParutionsSupprExemplaire.Enabled = false;
                pcbReceptionExemplaireRevueImage.Image = null;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresAjouter_Click(object sender, EventArgs e)
        {
            string id = InputDialog.Show("Id du livre :", "Ajouter un livre");
            if (string.IsNullOrWhiteSpace(id)) return;

            string titre = InputDialog.Show("Titre :", "Ajouter un livre");
            if (titre == null) return;

            string image = InputDialog.Show("Chemin de l'image :", "Ajouter un livre");
            if (image == null) return;

            string isbn = InputDialog.Show("ISBN :", "Ajouter un livre");
            if (isbn == null) return;

            string auteur = InputDialog.Show("Auteur :", "Ajouter un livre");
            if (auteur == null) return;

            string collection = InputDialog.Show("Collection :", "Ajouter un livre");
            if (collection == null) return;

            string idGenre = InputDialog.Show("Id Genre :", "Ajouter un livre");
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Ajouter un livre");
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Ajouter un livre");
            if (idRayon == null) return;

            bool ok = controller.CreerLivre(id, titre, image, isbn, auteur, collection, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "Livre ajouté avec succès." : "Ajout impossible (erreur ou contrôle métier).",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesLivres = controller.GetAllLivres();
                RemplirLivresListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresModifier_Click(object sender, EventArgs e)
        {
            if (dgvLivresListe.CurrentRow == null) return;

            Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
            if (livre == null) return;

            string titre = InputDialog.Show("Titre :", "Modifier un livre", livre.Titre);
            if (titre == null) return;

            string image = InputDialog.Show("Chemin image :", "Modifier un livre", livre.Image);
            if (image == null) return;

            string isbn = InputDialog.Show("ISBN :", "Modifier un livre", livre.Isbn);
            if (isbn == null) return;

            string auteur = InputDialog.Show("Auteur :", "Modifier un livre", livre.Auteur);
            if (auteur == null) return;

            string collection = InputDialog.Show("Collection :", "Modifier un livre", livre.Collection);
            if (collection == null) return;

            string idGenre = InputDialog.Show("Id Genre :", "Modifier un livre", livre.IdGenre);
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Modifier un livre", livre.IdPublic);
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Modifier un livre", livre.IdRayon);
            if (idRayon == null) return;

            bool ok = controller.ModifierLivre(livre.Id, titre, image, isbn, auteur, collection, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "Livre modifié avec succès." : "Modification impossible.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesLivres = controller.GetAllLivres();
                RemplirLivresListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLivresSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvLivresListe.CurrentRow == null) return;

            Livre livre = (Livre)bdgLivresListe.List[bdgLivresListe.Position];
            if (livre == null) return;

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous supprimer le livre :\n{livre.Id} - {livre.Titre} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirmation != DialogResult.Yes) return;

            bool ok = controller.SupprimerLivre(livre.Id);

            MessageBox.Show(
                ok ? "Livre supprimé." : "Suppression refusée (exemplaires ou commandes existantes) ou erreur.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesLivres = controller.GetAllLivres();
                RemplirLivresListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDvdAjouter_Click(object sender, EventArgs e)
        {
            string id = InputDialog.Show("Id du DVD :", "Ajouter un DVD");
            if (string.IsNullOrWhiteSpace(id)) return;

            string titre = InputDialog.Show("Titre :", "Ajouter un DVD");
            if (titre == null) return;

            string image = InputDialog.Show("Chemin de l'image :", "Ajouter un DVD");
            if (image == null) return;

            string synopsis = InputDialog.Show("Synopsis :", "Ajouter un DVD");
            if (synopsis == null) return;

            string realisateur = InputDialog.Show("Réalisateur :", "Ajouter un DVD");
            if (realisateur == null) return;

            string dureeStr = InputDialog.Show("Durée (en minutes) :", "Ajouter un DVD");
            if (dureeStr == null) return;
            if (!int.TryParse(dureeStr, out int duree))
            {
                MessageBox.Show("Durée invalide : veuillez saisir un nombre entier (minutes).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGenre = InputDialog.Show("Id Genre :", "Ajouter un DVD");
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Ajouter un DVD");
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Ajouter un DVD");
            if (idRayon == null) return;

            bool ok = controller.CreerDvd(id, titre, image, synopsis, realisateur, duree, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "DVD ajouté avec succès." : "Ajout impossible (erreur ou contrôle métier).",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesDvd = controller.GetAllDvd();
                RemplirDvdListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDvdModifier_Click(object sender, EventArgs e)
        {
            if (dgvDvdListe.CurrentRow == null) return;

            Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
            if (dvd == null) return;

            string titre = InputDialog.Show("Titre :", "Modifier un DVD", dvd.Titre);
            if (titre == null) return;

            string image = InputDialog.Show("Chemin image :", "Modifier un DVD", dvd.Image);
            if (image == null) return;

            string synopsis = InputDialog.Show("Synopsis :", "Modifier un DVD", dvd.Synopsis);
            if (synopsis == null) return;

            string realisateur = InputDialog.Show("Réalisateur :", "Modifier un DVD", dvd.Realisateur);
            if (realisateur == null) return;

            string dureeStr = InputDialog.Show("Durée (en minutes) :", "Modifier un DVD", dvd.Duree.ToString());
            if (dureeStr == null) return;
            if (!int.TryParse(dureeStr, out int duree))
            {
                MessageBox.Show("Durée invalide : veuillez saisir un nombre entier (minutes).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGenre = InputDialog.Show("Id Genre :", "Modifier un DVD", dvd.IdGenre);
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Modifier un DVD", dvd.IdPublic);
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Modifier un DVD", dvd.IdRayon);
            if (idRayon == null) return;

            bool ok = controller.ModifierDvd(dvd.Id, titre, image, synopsis, realisateur, duree, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "DVD modifié avec succès." : "Modification impossible.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesDvd = controller.GetAllDvd();
                RemplirDvdListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDvdSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDvdListe.CurrentRow == null) return;

            Dvd dvd = (Dvd)bdgDvdListe.List[bdgDvdListe.Position];
            if (dvd == null) return;

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous supprimer le DVD :\n{dvd.Id} - {dvd.Titre} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirmation != DialogResult.Yes) return;

            bool ok = controller.SupprimerDvd(dvd.Id);

            MessageBox.Show(
                ok ? "DVD supprimé." : "Suppression refusée (exemplaires ou commandes existantes) ou erreur.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesDvd = controller.GetAllDvd();
                RemplirDvdListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRevuesAjouter_Click(object sender, EventArgs e)
        {
            string id = InputDialog.Show("Id de la revue :", "Ajouter une revue");
            if (string.IsNullOrWhiteSpace(id)) return;

            string titre = InputDialog.Show("Titre :", "Ajouter une revue");
            if (titre == null) return;

            string image = InputDialog.Show("Chemin de l'image :", "Ajouter une revue");
            if (image == null) return;

            string periodicite = InputDialog.Show("Périodicité :", "Ajouter une revue");
            if (periodicite == null) return;

            string delaiStr = InputDialog.Show("Délai de mise à disposition (jours) :", "Ajouter une revue");
            if (delaiStr == null) return;
            if (!int.TryParse(delaiStr, out int delaiMiseADispo))
            {
                MessageBox.Show("Délai invalide : veuillez saisir un nombre entier (jours).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGenre = InputDialog.Show("Id Genre :", "Ajouter une revue");
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Ajouter une revue");
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Ajouter une revue");
            if (idRayon == null) return;

            bool ok = controller.CreerRevue(id, titre, image, periodicite, delaiMiseADispo, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "Revue ajoutée avec succès." : "Ajout impossible (erreur ou contrôle métier).",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesRevues = controller.GetAllRevues();
                RemplirRevuesListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRevuesModifier_Click(object sender, EventArgs e)
        {
            if (dgvRevuesListe.CurrentRow == null) return;

            Revue revue = (Revue)bdgRevuesListe.List[bdgRevuesListe.Position];
            if (revue == null) return;

            string titre = InputDialog.Show("Titre :", "Modifier une revue", revue.Titre);
            if (titre == null) return;

            string image = InputDialog.Show("Chemin image :", "Modifier une revue", revue.Image);
            if (image == null) return;

            string periodicite = InputDialog.Show("Périodicité :", "Modifier une revue", revue.Periodicite);
            if (periodicite == null) return;

            string delaiStr = InputDialog.Show("Délai de mise à disposition (jours) :", "Modifier une revue", revue.DelaiMiseADispo.ToString());
            if (delaiStr == null) return;
            if (!int.TryParse(delaiStr, out int delaiMiseADispo))
            {
                MessageBox.Show("Délai invalide : veuillez saisir un nombre entier (jours).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idGenre = InputDialog.Show("Id Genre :", "Modifier une revue", revue.IdGenre);
            if (idGenre == null) return;

            string idPublic = InputDialog.Show("Id Public :", "Modifier une revue", revue.IdPublic);
            if (idPublic == null) return;

            string idRayon = InputDialog.Show("Id Rayon :", "Modifier une revue", revue.IdRayon);
            if (idRayon == null) return;

            bool ok = controller.ModifierRevue(revue.Id, titre, image, periodicite, delaiMiseADispo, idGenre, idPublic, idRayon);

            MessageBox.Show(
                ok ? "Revue modifiée avec succès." : "Modification impossible.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesRevues = controller.GetAllRevues();
                RemplirRevuesListeComplete();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRevuesSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvRevuesListe.CurrentRow == null) return;

            Revue revue = (Revue)bdgRevuesListe.List[bdgRevuesListe.Position];
            if (revue == null) return;

            DialogResult confirmation = MessageBox.Show(
                $"Voulez-vous supprimer la revue :\n{revue.Id} - {revue.Titre} ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirmation != DialogResult.Yes) return;

            bool ok = controller.SupprimerRevue(revue.Id);

            MessageBox.Show(
                ok ? "Revue supprimée." : "Suppression refusée (abonnements/exemplaires existants) ou erreur.",
                "Résultat",
                MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (ok)
            {
                lesRevues = controller.GetAllRevues();
                RemplirRevuesListeComplete();
            }
        }

        private void lblCmdLivre_Click(object sender, EventArgs e)
        {

        }

        private void lblCmdDvd_Click(object sender, EventArgs e)
        {

        }

        private void tabCommandesLivres_Click(object sender, EventArgs e)
        {

        }

        private void tabCommandesDvd_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        #region Initialisation contrôles exemplaires (Livres, DVD, Parutions)

        private void InitialiserControlesExemplaires()
        {
            InitLivresExemplairesControles();
            InitDvdExemplairesControles();
            InitParutionsExemplairesControles();
        }

        private void InitLivresExemplairesControles()
        {
            var grp = new GroupBox
            {
                Text = "Exemplaires du livre sélectionné",
                Location = new Point(11, 779),
                Size = new Size(1145, 210),
                TabIndex = 100
            };

            dgvLivresExemplaires = new DataGridView
            {
                Location = new Point(12, 22),
                Size = new Size(820, 140),
                ReadOnly = true,
                AllowUserToAddRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                TabIndex = 0
            };
            dgvLivresExemplaires.SelectionChanged += DgvLivresExemplaires_SelectionChanged;
            dgvLivresExemplaires.ColumnHeaderMouseClick += DgvLivresExemplaires_ColumnHeaderMouseClick;

            var lblEtat = new Label { Text = "État :", Location = new Point(845, 22), AutoSize = true };

            cbxLivresEtats = new ComboBox
            {
                Location = new Point(845, 45),
                Size = new Size(280, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                TabIndex = 1
            };
            cbxLivresEtats.DataSource = lesEtats;
            cbxLivresEtats.DisplayMember = "Libelle";
            cbxLivresEtats.ValueMember = "Id";

            btnLivresChgtEtat = new Button
            {
                Text = "Changer état",
                Location = new Point(845, 82),
                Size = new Size(140, 30),
                Enabled = false,
                TabIndex = 2
            };
            btnLivresChgtEtat.Click += BtnLivresChgtEtat_Click;

            btnLivresSupprExemplaire = new Button
            {
                Text = "Supprimer exemplaire",
                Location = new Point(845, 122),
                Size = new Size(175, 30),
                Enabled = false,
                TabIndex = 3
            };
            btnLivresSupprExemplaire.Click += BtnLivresSupprExemplaire_Click;

            grp.Controls.Add(dgvLivresExemplaires);
            grp.Controls.Add(lblEtat);
            grp.Controls.Add(cbxLivresEtats);
            grp.Controls.Add(btnLivresChgtEtat);
            grp.Controls.Add(btnLivresSupprExemplaire);

            tabLivres.Controls.Add(grp);
        }

        private void InitDvdExemplairesControles()
        {
            var grp = new GroupBox
            {
                Text = "Exemplaires du DVD sélectionné",
                Location = new Point(11, 779),
                Size = new Size(1145, 210),
                TabIndex = 100
            };

            dgvDvdExemplaires = new DataGridView
            {
                Location = new Point(12, 22),
                Size = new Size(820, 140),
                ReadOnly = true,
                AllowUserToAddRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                TabIndex = 0
            };
            dgvDvdExemplaires.SelectionChanged += DgvDvdExemplaires_SelectionChanged;
            dgvDvdExemplaires.ColumnHeaderMouseClick += DgvDvdExemplaires_ColumnHeaderMouseClick;

            var lblEtat = new Label { Text = "État :", Location = new Point(845, 22), AutoSize = true };

            cbxDvdEtats = new ComboBox
            {
                Location = new Point(845, 45),
                Size = new Size(280, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                TabIndex = 1
            };
            cbxDvdEtats.DataSource = lesEtats;
            cbxDvdEtats.DisplayMember = "Libelle";
            cbxDvdEtats.ValueMember = "Id";

            btnDvdChgtEtat = new Button
            {
                Text = "Changer état",
                Location = new Point(845, 82),
                Size = new Size(140, 30),
                Enabled = false,
                TabIndex = 2
            };
            btnDvdChgtEtat.Click += BtnDvdChgtEtat_Click;

            btnDvdSupprExemplaire = new Button
            {
                Text = "Supprimer exemplaire",
                Location = new Point(845, 122),
                Size = new Size(175, 30),
                Enabled = false,
                TabIndex = 3
            };
            btnDvdSupprExemplaire.Click += BtnDvdSupprExemplaire_Click;

            grp.Controls.Add(dgvDvdExemplaires);
            grp.Controls.Add(lblEtat);
            grp.Controls.Add(cbxDvdEtats);
            grp.Controls.Add(btnDvdChgtEtat);
            grp.Controls.Add(btnDvdSupprExemplaire);

            tabDvd.Controls.Add(grp);
        }

        private void InitParutionsExemplairesControles()
        {
            var grp = new GroupBox
            {
                Text = "Gestion état / Suppression de la parution sélectionnée",
                Location = new Point(11, 775),
                Size = new Size(1145, 70),
                TabIndex = 50
            };

            var lblEtat = new Label { Text = "État :", Location = new Point(12, 30), AutoSize = true };

            cbxParutionsEtat = new ComboBox
            {
                Location = new Point(55, 26),
                Size = new Size(250, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                TabIndex = 0
            };
            cbxParutionsEtat.DataSource = lesEtats;
            cbxParutionsEtat.DisplayMember = "Libelle";
            cbxParutionsEtat.ValueMember = "Id";

            btnParutionsChgtEtat = new Button
            {
                Text = "Changer état",
                Location = new Point(320, 24),
                Size = new Size(140, 30),
                Enabled = false,
                TabIndex = 1
            };
            btnParutionsChgtEtat.Click += BtnParutionsChgtEtat_Click;

            btnParutionsSupprExemplaire = new Button
            {
                Text = "Supprimer parution",
                Location = new Point(475, 24),
                Size = new Size(160, 30),
                Enabled = false,
                TabIndex = 2
            };
            btnParutionsSupprExemplaire.Click += BtnParutionsSupprExemplaire_Click;

            grp.Controls.Add(lblEtat);
            grp.Controls.Add(cbxParutionsEtat);
            grp.Controls.Add(btnParutionsChgtEtat);
            grp.Controls.Add(btnParutionsSupprExemplaire);

            tabReceptionRevue.Controls.Add(grp);
        }

        #endregion

        #region Livres – Exemplaires

        private List<Exemplaire> lesExemplairesLivre = new List<Exemplaire>();

        private void ChargerExemplairesLivre(string idLivre)
        {
            livreExemplaireCourant = null;
            btnLivresChgtEtat.Enabled = false;
            btnLivresSupprExemplaire.Enabled = false;

            if (string.IsNullOrEmpty(idLivre))
            {
                bdgLivresExemplaires.DataSource = null;
                return;
            }

            lesExemplairesLivre = controller.GetExemplairesDocument(idLivre) ?? new List<Exemplaire>();
            AppliquerLibelleEtat(lesExemplairesLivre);
            lesExemplairesLivre = lesExemplairesLivre.OrderByDescending(e => e.DateAchat).ToList();

            bdgLivresExemplaires.DataSource = null;
            bdgLivresExemplaires.DataSource = lesExemplairesLivre;
            dgvLivresExemplaires.DataSource = bdgLivresExemplaires;
            MasquerColonnesExemplaire(dgvLivresExemplaires);
        }

        private void DgvLivresExemplaires_SelectionChanged(object sender, EventArgs e)
        {
            livreExemplaireCourant = dgvLivresExemplaires.CurrentRow?.DataBoundItem as Exemplaire;
            bool sel = livreExemplaireCourant != null;
            btnLivresChgtEtat.Enabled = sel;
            btnLivresSupprExemplaire.Enabled = sel;

            if (sel && lesEtats.Count > 0)
                cbxLivresEtats.SelectedItem = lesEtats.FirstOrDefault(et => et.Id == livreExemplaireCourant.IdEtat);
        }

        private void DgvLivresExemplaires_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = dgvLivresExemplaires.Columns[e.ColumnIndex].HeaderText;
            switch (col)
            {
                case "Numero":
                    lesExemplairesLivre = lesExemplairesLivre.OrderByDescending(x => x.Numero).ToList();
                    break;
                case "DateAchat":
                    lesExemplairesLivre = lesExemplairesLivre.OrderByDescending(x => x.DateAchat).ToList();
                    break;
                case "LibelleEtat":
                    lesExemplairesLivre = lesExemplairesLivre.OrderBy(x => x.LibelleEtat).ToList();
                    break;
            }
            bdgLivresExemplaires.DataSource = null;
            bdgLivresExemplaires.DataSource = lesExemplairesLivre;
        }

        private void BtnLivresChgtEtat_Click(object sender, EventArgs e)
        {
            if (livreExemplaireCourant == null) return;
            Etat etatChoisi = cbxLivresEtats.SelectedItem as Etat;
            if (etatChoisi == null) return;

            bool ok = controller.ModifierEtatExemplaire(livreExemplaireCourant.Numero, livreExemplaireCourant.Id, etatChoisi.Id);
            MessageBox.Show(ok ? "État mis à jour." : "Échec de la mise à jour.");
            if (ok) ChargerExemplairesLivre(livreExemplaireCourant.Id);
        }

        private void BtnLivresSupprExemplaire_Click(object sender, EventArgs e)
        {
            if (livreExemplaireCourant == null) return;

            DialogResult rep = MessageBox.Show(
                $"Supprimer l'exemplaire n°{livreExemplaireCourant.Numero} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rep != DialogResult.Yes) return;

            string idDoc = livreExemplaireCourant.Id;
            bool ok = controller.SupprimerExemplaire(livreExemplaireCourant.Numero, idDoc);
            MessageBox.Show(ok ? "Exemplaire supprimé." : "Échec de la suppression.");
            if (ok) ChargerExemplairesLivre(idDoc);
        }

        #endregion

        #region DVD – Exemplaires

        private List<Exemplaire> lesExemplairesDvd = new List<Exemplaire>();

        private void ChargerExemplairesDvd(string idDvd)
        {
            dvdExemplaireCourant = null;
            btnDvdChgtEtat.Enabled = false;
            btnDvdSupprExemplaire.Enabled = false;

            if (string.IsNullOrEmpty(idDvd))
            {
                bdgDvdExemplaires.DataSource = null;
                return;
            }

            lesExemplairesDvd = controller.GetExemplairesDocument(idDvd) ?? new List<Exemplaire>();
            AppliquerLibelleEtat(lesExemplairesDvd);
            lesExemplairesDvd = lesExemplairesDvd.OrderByDescending(e => e.DateAchat).ToList();

            bdgDvdExemplaires.DataSource = null;
            bdgDvdExemplaires.DataSource = lesExemplairesDvd;
            dgvDvdExemplaires.DataSource = bdgDvdExemplaires;
            MasquerColonnesExemplaire(dgvDvdExemplaires);
        }

        private void DgvDvdExemplaires_SelectionChanged(object sender, EventArgs e)
        {
            dvdExemplaireCourant = dgvDvdExemplaires.CurrentRow?.DataBoundItem as Exemplaire;
            bool sel = dvdExemplaireCourant != null;
            btnDvdChgtEtat.Enabled = sel;
            btnDvdSupprExemplaire.Enabled = sel;

            if (sel && lesEtats.Count > 0)
                cbxDvdEtats.SelectedItem = lesEtats.FirstOrDefault(et => et.Id == dvdExemplaireCourant.IdEtat);
        }

        private void DgvDvdExemplaires_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string col = dgvDvdExemplaires.Columns[e.ColumnIndex].HeaderText;
            switch (col)
            {
                case "Numero":
                    lesExemplairesDvd = lesExemplairesDvd.OrderByDescending(x => x.Numero).ToList();
                    break;
                case "DateAchat":
                    lesExemplairesDvd = lesExemplairesDvd.OrderByDescending(x => x.DateAchat).ToList();
                    break;
                case "LibelleEtat":
                    lesExemplairesDvd = lesExemplairesDvd.OrderBy(x => x.LibelleEtat).ToList();
                    break;
            }
            bdgDvdExemplaires.DataSource = null;
            bdgDvdExemplaires.DataSource = lesExemplairesDvd;
        }

        private void BtnDvdChgtEtat_Click(object sender, EventArgs e)
        {
            if (dvdExemplaireCourant == null) return;
            Etat etatChoisi = cbxDvdEtats.SelectedItem as Etat;
            if (etatChoisi == null) return;

            bool ok = controller.ModifierEtatExemplaire(dvdExemplaireCourant.Numero, dvdExemplaireCourant.Id, etatChoisi.Id);
            MessageBox.Show(ok ? "État mis à jour." : "Échec de la mise à jour.");
            if (ok) ChargerExemplairesDvd(dvdExemplaireCourant.Id);
        }

        private void BtnDvdSupprExemplaire_Click(object sender, EventArgs e)
        {
            if (dvdExemplaireCourant == null) return;

            DialogResult rep = MessageBox.Show(
                $"Supprimer l'exemplaire n°{dvdExemplaireCourant.Numero} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rep != DialogResult.Yes) return;

            string idDoc = dvdExemplaireCourant.Id;
            bool ok = controller.SupprimerExemplaire(dvdExemplaireCourant.Numero, idDoc);
            MessageBox.Show(ok ? "Exemplaire supprimé." : "Échec de la suppression.");
            if (ok) ChargerExemplairesDvd(idDoc);
        }

        #endregion

        #region Parutions – Gestion état / Suppression

        private Exemplaire paritionExemplaireCourant;

        private void BtnParutionsChgtEtat_Click(object sender, EventArgs e)
        {
            if (paritionExemplaireCourant == null) return;
            Etat etatChoisi = cbxParutionsEtat.SelectedItem as Etat;
            if (etatChoisi == null) return;

            bool ok = controller.ModifierEtatExemplaire(paritionExemplaireCourant.Numero, paritionExemplaireCourant.Id, etatChoisi.Id);
            MessageBox.Show(ok ? "État mis à jour." : "Échec de la mise à jour.");
            if (ok) AfficheReceptionExemplairesRevue();
        }

        private void BtnParutionsSupprExemplaire_Click(object sender, EventArgs e)
        {
            if (paritionExemplaireCourant == null) return;

            DialogResult rep = MessageBox.Show(
                $"Supprimer la parution n°{paritionExemplaireCourant.Numero} ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rep != DialogResult.Yes) return;

            string idDoc = paritionExemplaireCourant.Id;
            bool ok = controller.SupprimerExemplaire(paritionExemplaireCourant.Numero, idDoc);
            MessageBox.Show(ok ? "Parution supprimée." : "Échec de la suppression.");
            if (ok) AfficheReceptionExemplairesRevue();
        }

        #endregion

        #region Helpers exemplaires

        private void AppliquerLibelleEtat(List<Exemplaire> exemplaires)
        {
            foreach (var ex in exemplaires)
            {
                var etat = lesEtats.FirstOrDefault(et => et.Id == ex.IdEtat);
                ex.LibelleEtat = etat?.Libelle ?? ex.IdEtat;
            }
        }

        private void MasquerColonnesExemplaire(DataGridView dgv)
        {
            if (dgv.Columns["Photo"] != null) dgv.Columns["Photo"].Visible = false;
            if (dgv.Columns["photo"] != null) dgv.Columns["photo"].Visible = false;
            if (dgv.Columns["IdEtat"] != null) dgv.Columns["IdEtat"].Visible = false;
            if (dgv.Columns["idEtat"] != null) dgv.Columns["idEtat"].Visible = false;
            if (dgv.Columns["Id"] != null) dgv.Columns["Id"].Visible = false;
            if (dgv.Columns["id"] != null) dgv.Columns["id"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion
    }
}
