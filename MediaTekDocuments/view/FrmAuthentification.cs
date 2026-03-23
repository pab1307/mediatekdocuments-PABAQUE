using System;
using System.Drawing;
using System.Windows.Forms;
using MediaTekDocuments.controller;
using MediaTekDocuments.model;

namespace MediaTekDocuments.view
{
    /// <summary>
    /// Fenêtre d'authentification : demande login et mot de passe à l'utilisateur.
    /// Retourne DialogResult.OK si l'authentification réussit.
    /// </summary>
    public class FrmAuthentification : Form
    {
        private readonly FrmMediatekController controller;

        private Label lblTitre;
        private Label lblLogin;
        private Label lblPwd;
        private TextBox txbLogin;
        private TextBox txbPwd;
        private Button btnConnexion;
        private Button btnAnnuler;

        /// <summary>
        /// Utilisateur authentifié (valorisé après authentification réussie)
        /// </summary>
        public Utilisateur UtilisateurConnecte { get; private set; }

        public FrmAuthentification()
        {
            controller = new FrmMediatekController();
            InitialiserComposants();
        }

        private void InitialiserComposants()
        {
            // --- Fenêtre ---
            this.Text = "Médiathèque – Connexion";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ClientSize = new Size(360, 220);

            // --- Titre ---
            lblTitre = new Label
            {
                Text = "Authentification",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 15),
                Size = new Size(360, 30)
            };

            // --- Login ---
            lblLogin = new Label
            {
                Text = "Login :",
                Location = new Point(30, 65),
                Size = new Size(80, 23),
                TextAlign = ContentAlignment.MiddleRight
            };
            txbLogin = new TextBox
            {
                Location = new Point(120, 65),
                Size = new Size(200, 23)
            };

            // --- Mot de passe ---
            lblPwd = new Label
            {
                Text = "Mot de passe :",
                Location = new Point(30, 105),
                Size = new Size(80, 23),
                TextAlign = ContentAlignment.MiddleRight
            };
            txbPwd = new TextBox
            {
                Location = new Point(120, 105),
                Size = new Size(200, 23),
                PasswordChar = '*'
            };

            // --- Boutons ---
            btnConnexion = new Button
            {
                Text = "Se connecter",
                Location = new Point(90, 155),
                Size = new Size(110, 30),
                DialogResult = DialogResult.None
            };
            btnConnexion.Click += BtnConnexion_Click;

            btnAnnuler = new Button
            {
                Text = "Annuler",
                Location = new Point(215, 155),
                Size = new Size(90, 30),
                DialogResult = DialogResult.Cancel
            };

            this.Controls.AddRange(new Control[]
            {
                lblTitre, lblLogin, txbLogin, lblPwd, txbPwd, btnConnexion, btnAnnuler
            });

            this.AcceptButton = btnConnexion;
            this.CancelButton = btnAnnuler;
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            string login = txbLogin.Text.Trim();
            string pwd = txbPwd.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Veuillez saisir votre login et votre mot de passe.",
                    "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Utilisateur utilisateur = controller.GetUtilisateur(login, pwd);

            if (utilisateur == null)
            {
                MessageBox.Show("Login ou mot de passe incorrect.",
                    "Authentification échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPwd.Clear();
                txbPwd.Focus();
                return;
            }

            UtilisateurConnecte = utilisateur;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
