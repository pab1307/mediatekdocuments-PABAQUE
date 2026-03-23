
using System;
using System.Windows.Forms;

namespace MediaTekDocuments.view
{
    partial class FrmMediatek
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCommandesRevues = new System.Windows.Forms.TabPage();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.cbxCmdRevue = new System.Windows.Forms.ComboBox();
            this.dgvCmdRevue = new System.Windows.Forms.DataGridView();
            this.dtpCmdRevueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCmdRevueFinAbo = new System.Windows.Forms.DateTimePicker();
            this.txbCmdRevueMontant = new System.Windows.Forms.TextBox();
            this.btnCmdRevueAjouter = new System.Windows.Forms.Button();
            this.btnCmdRevueSuppr = new System.Windows.Forms.Button();
            this.btnCmdRevueRefresh = new System.Windows.Forms.Button();
            this.tabCommandesDvd = new System.Windows.Forms.TabPage();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.btnCmdDvdSuppr = new System.Windows.Forms.Button();
            this.txbCmdDvdMontant = new System.Windows.Forms.TextBox();
            this.dtpCmdDvdDate = new System.Windows.Forms.DateTimePicker();
            this.nudCmdDvdNbEx = new System.Windows.Forms.NumericUpDown();
            this.cbxCmdDvdSuivi = new System.Windows.Forms.ComboBox();
            this.btnCmdDvdMajSuivi = new System.Windows.Forms.Button();
            this.btnCmdDvdAjouter = new System.Windows.Forms.Button();
            this.btnCmdDvdRefresh = new System.Windows.Forms.Button();
            this.cbxCmdDvd = new System.Windows.Forms.ComboBox();
            this.dgvCmdDvd = new System.Windows.Forms.DataGridView();
            this.label60 = new System.Windows.Forms.Label();
            this.tabCommandesLivres = new System.Windows.Forms.TabPage();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.btnCmdLivreSuppr = new System.Windows.Forms.Button();
            this.txbCmdLivreMontant = new System.Windows.Forms.TextBox();
            this.dtpCmdLivreDate = new System.Windows.Forms.DateTimePicker();
            this.nudCmdLivreNbEx = new System.Windows.Forms.NumericUpDown();
            this.cbxCmdLivreSuivi = new System.Windows.Forms.ComboBox();
            this.btnCmdLivreMajSuivi = new System.Windows.Forms.Button();
            this.btnCmdLivreAjouter = new System.Windows.Forms.Button();
            this.btnCmdLivreRefresh = new System.Windows.Forms.Button();
            this.cbxCmdLivre = new System.Windows.Forms.ComboBox();
            this.lblCmdLivre = new System.Windows.Forms.Label();
            this.dgvCmdLivre = new System.Windows.Forms.DataGridView();
            this.tabReceptionRevue = new System.Windows.Forms.TabPage();
            this.grpReceptionExemplaire = new System.Windows.Forms.GroupBox();
            this.label55 = new System.Windows.Forms.Label();
            this.btnReceptionExemplaireImage = new System.Windows.Forms.Button();
            this.pcbReceptionExemplaireImage = new System.Windows.Forms.PictureBox();
            this.btnReceptionExemplaireValider = new System.Windows.Forms.Button();
            this.txbReceptionExemplaireImage = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txbReceptionExemplaireNumero = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpReceptionExemplaireDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.grpReceptionRevue = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.pcbReceptionExemplaireRevueImage = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvReceptionExemplairesListe = new System.Windows.Forms.DataGridView();
            this.txbReceptionRevueImage = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueRayon = new System.Windows.Forms.TextBox();
            this.txbReceptionRevuePublic = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueGenre = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueDelaiMiseADispo = new System.Windows.Forms.TextBox();
            this.txbReceptionRevuePeriodicite = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueTitre = new System.Windows.Forms.TextBox();
            this.txbReceptionRevueNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbReceptionRevueImage = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.btnReceptionRechercher = new System.Windows.Forms.Button();
            this.tabRevues = new System.Windows.Forms.TabPage();
            this.grpRevuesInfos = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.txbRevuesImage = new System.Windows.Forms.TextBox();
            this.txbRevuesRayon = new System.Windows.Forms.TextBox();
            this.txbRevuesPublic = new System.Windows.Forms.TextBox();
            this.txbRevuesGenre = new System.Windows.Forms.TextBox();
            this.txbRevuesDateMiseADispo = new System.Windows.Forms.TextBox();
            this.txbRevuesPeriodicite = new System.Windows.Forms.TextBox();
            this.txbRevuesTitre = new System.Windows.Forms.TextBox();
            this.txbRevuesNumero = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.pcbRevuesImage = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.grpRevuesRecherche = new System.Windows.Forms.GroupBox();
            this.BtnRevuesSupprimer = new System.Windows.Forms.Button();
            this.BtnRevuesModifier = new System.Windows.Forms.Button();
            this.BtnRevuesAjouter = new System.Windows.Forms.Button();
            this.btnRevuesAnnulRayons = new System.Windows.Forms.Button();
            this.btnRevuesAnnulPublics = new System.Windows.Forms.Button();
            this.btnRevuesNumRecherche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRevuesNumRecherche = new System.Windows.Forms.TextBox();
            this.btnRevuesAnnulGenres = new System.Windows.Forms.Button();
            this.cbxRevuesRayons = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRevuesPublics = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbxRevuesGenres = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dgvRevuesListe = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.txbRevuesTitreRecherche = new System.Windows.Forms.TextBox();
            this.tabDvd = new System.Windows.Forms.TabPage();
            this.grpDvdInfos = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.txbDvdDuree = new System.Windows.Forms.TextBox();
            this.txbDvdImage = new System.Windows.Forms.TextBox();
            this.txbDvdRayon = new System.Windows.Forms.TextBox();
            this.txbDvdPublic = new System.Windows.Forms.TextBox();
            this.txbDvdGenre = new System.Windows.Forms.TextBox();
            this.txbDvdSynopsis = new System.Windows.Forms.TextBox();
            this.txbDvdRealisateur = new System.Windows.Forms.TextBox();
            this.txbDvdTitre = new System.Windows.Forms.TextBox();
            this.txbDvdNumero = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pcbDvdImage = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.grpDvdRecherche = new System.Windows.Forms.GroupBox();
            this.BtnDVDSupprimer = new System.Windows.Forms.Button();
            this.BtnDVDModifier = new System.Windows.Forms.Button();
            this.BtnDVDAjouter = new System.Windows.Forms.Button();
            this.btnDvdAnnulRayons = new System.Windows.Forms.Button();
            this.btnDvdAnnulPublics = new System.Windows.Forms.Button();
            this.btnDvdNumRecherche = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.txbDvdNumRecherche = new System.Windows.Forms.TextBox();
            this.btnDvdAnnulGenres = new System.Windows.Forms.Button();
            this.cbxDvdRayons = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cbxDvdPublics = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.cbxDvdGenres = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dgvDvdListe = new System.Windows.Forms.DataGridView();
            this.label42 = new System.Windows.Forms.Label();
            this.txbDvdTitreRecherche = new System.Windows.Forms.TextBox();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.grpLivresInfos = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txbLivresIsbn = new System.Windows.Forms.TextBox();
            this.txbLivresImage = new System.Windows.Forms.TextBox();
            this.txbLivresRayon = new System.Windows.Forms.TextBox();
            this.txbLivresPublic = new System.Windows.Forms.TextBox();
            this.txbLivresGenre = new System.Windows.Forms.TextBox();
            this.txbLivresCollection = new System.Windows.Forms.TextBox();
            this.txbLivresAuteur = new System.Windows.Forms.TextBox();
            this.txbLivresTitre = new System.Windows.Forms.TextBox();
            this.txbLivresNumero = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.pcbLivresImage = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpLivresRecherche = new System.Windows.Forms.GroupBox();
            this.BtnLivresSupprimer = new System.Windows.Forms.Button();
            this.BtnLivresModifier = new System.Windows.Forms.Button();
            this.BtnLivresAjouter = new System.Windows.Forms.Button();
            this.btnLivresAnnulRayons = new System.Windows.Forms.Button();
            this.btnlivresAnnulPublics = new System.Windows.Forms.Button();
            this.btnLivresNumRecherche = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLivresNumRecherche = new System.Windows.Forms.TextBox();
            this.btnLivresAnnulGenres = new System.Windows.Forms.Button();
            this.cbxLivresRayons = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbxLivresPublics = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxLivresGenres = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLivresListe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLivresTitreRecherche = new System.Windows.Forms.TextBox();
            this.tabOngletsApplication = new System.Windows.Forms.TabControl();
            this.tabCommandesRevues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdRevue)).BeginInit();
            this.tabCommandesDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCmdDvdNbEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDvd)).BeginInit();
            this.tabCommandesLivres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCmdLivreNbEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdLivre)).BeginInit();
            this.tabReceptionRevue.SuspendLayout();
            this.grpReceptionExemplaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).BeginInit();
            this.grpReceptionRevue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).BeginInit();
            this.tabRevues.SuspendLayout();
            this.grpRevuesInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).BeginInit();
            this.grpRevuesRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).BeginInit();
            this.tabDvd.SuspendLayout();
            this.grpDvdInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).BeginInit();
            this.grpDvdRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).BeginInit();
            this.tabLivres.SuspendLayout();
            this.grpLivresInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).BeginInit();
            this.grpLivresRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).BeginInit();
            this.tabOngletsApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCommandesRevues
            // 
            this.tabCommandesRevues.Controls.Add(this.label66);
            this.tabCommandesRevues.Controls.Add(this.label65);
            this.tabCommandesRevues.Controls.Add(this.label62);
            this.tabCommandesRevues.Controls.Add(this.label61);
            this.tabCommandesRevues.Controls.Add(this.cbxCmdRevue);
            this.tabCommandesRevues.Controls.Add(this.dgvCmdRevue);
            this.tabCommandesRevues.Controls.Add(this.dtpCmdRevueDate);
            this.tabCommandesRevues.Controls.Add(this.dtpCmdRevueFinAbo);
            this.tabCommandesRevues.Controls.Add(this.txbCmdRevueMontant);
            this.tabCommandesRevues.Controls.Add(this.btnCmdRevueAjouter);
            this.tabCommandesRevues.Controls.Add(this.btnCmdRevueSuppr);
            this.tabCommandesRevues.Controls.Add(this.btnCmdRevueRefresh);
            this.tabCommandesRevues.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesRevues.Name = "tabCommandesRevues";
            this.tabCommandesRevues.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesRevues.Size = new System.Drawing.Size(1169, 785);
            this.tabCommandesRevues.TabIndex = 7;
            this.tabCommandesRevues.Text = "Abonnement Revues";
            this.tabCommandesRevues.UseVisualStyleBackColor = true;
            this.tabCommandesRevues.Enter += new System.EventHandler(this.TabCmdRevues_Enter);
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(9, 111);
            this.label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(54, 17);
            this.label66.TabIndex = 28;
            this.label66.Text = "Revue";
            this.label66.Click += new System.EventHandler(this.label66_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(20, 143);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(35, 17);
            this.label65.TabIndex = 27;
            this.label65.Text = "Prix";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(588, 145);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(195, 17);
            this.label62.TabIndex = 9;
            this.label62.Text = "Date de fin d\'abonnement";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(221, 143);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(158, 17);
            this.label61.TabIndex = 8;
            this.label61.Text = "Début d\'abonnement";
            this.label61.Click += new System.EventHandler(this.label61_Click);
            // 
            // cbxCmdRevue
            // 
            this.cbxCmdRevue.FormattingEnabled = true;
            this.cbxCmdRevue.Location = new System.Drawing.Point(78, 104);
            this.cbxCmdRevue.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCmdRevue.Name = "cbxCmdRevue";
            this.cbxCmdRevue.Size = new System.Drawing.Size(275, 24);
            this.cbxCmdRevue.TabIndex = 1;
            this.cbxCmdRevue.SelectedIndexChanged += new System.EventHandler(this.CbxCmdRevue_SelectedIndexChanged);
            // 
            // dgvCmdRevue
            // 
            this.dgvCmdRevue.AllowUserToAddRows = false;
            this.dgvCmdRevue.AllowUserToDeleteRows = false;
            this.dgvCmdRevue.AllowUserToResizeColumns = false;
            this.dgvCmdRevue.AllowUserToResizeRows = false;
            this.dgvCmdRevue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdRevue.Location = new System.Drawing.Point(22, 176);
            this.dgvCmdRevue.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCmdRevue.MultiSelect = false;
            this.dgvCmdRevue.Name = "dgvCmdRevue";
            this.dgvCmdRevue.ReadOnly = true;
            this.dgvCmdRevue.RowHeadersVisible = false;
            this.dgvCmdRevue.RowHeadersWidth = 51;
            this.dgvCmdRevue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdRevue.Size = new System.Drawing.Size(1125, 246);
            this.dgvCmdRevue.TabIndex = 2;
            this.dgvCmdRevue.SelectionChanged += new System.EventHandler(this.DgvCmdRevue_SelectionChanged);
            // 
            // dtpCmdRevueDate
            // 
            this.dtpCmdRevueDate.Location = new System.Drawing.Point(387, 141);
            this.dtpCmdRevueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCmdRevueDate.Name = "dtpCmdRevueDate";
            this.dtpCmdRevueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCmdRevueDate.TabIndex = 4;
            // 
            // dtpCmdRevueFinAbo
            // 
            this.dtpCmdRevueFinAbo.Location = new System.Drawing.Point(791, 143);
            this.dtpCmdRevueFinAbo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCmdRevueFinAbo.Name = "dtpCmdRevueFinAbo";
            this.dtpCmdRevueFinAbo.Size = new System.Drawing.Size(200, 22);
            this.dtpCmdRevueFinAbo.TabIndex = 5;
            // 
            // txbCmdRevueMontant
            // 
            this.txbCmdRevueMontant.Location = new System.Drawing.Point(63, 138);
            this.txbCmdRevueMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txbCmdRevueMontant.Name = "txbCmdRevueMontant";
            this.txbCmdRevueMontant.Size = new System.Drawing.Size(150, 22);
            this.txbCmdRevueMontant.TabIndex = 3;
            // 
            // btnCmdRevueAjouter
            // 
            this.btnCmdRevueAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdRevueAjouter.Location = new System.Drawing.Point(361, 101);
            this.btnCmdRevueAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdRevueAjouter.Name = "btnCmdRevueAjouter";
            this.btnCmdRevueAjouter.Size = new System.Drawing.Size(168, 27);
            this.btnCmdRevueAjouter.TabIndex = 6;
            this.btnCmdRevueAjouter.Text = "Nouvel Abonnement";
            this.btnCmdRevueAjouter.UseVisualStyleBackColor = true;
            this.btnCmdRevueAjouter.Click += new System.EventHandler(this.BtnCmdRevueAjouter_Click);
            // 
            // btnCmdRevueSuppr
            // 
            this.btnCmdRevueSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdRevueSuppr.Location = new System.Drawing.Point(537, 101);
            this.btnCmdRevueSuppr.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdRevueSuppr.Name = "btnCmdRevueSuppr";
            this.btnCmdRevueSuppr.Size = new System.Drawing.Size(145, 27);
            this.btnCmdRevueSuppr.TabIndex = 7;
            this.btnCmdRevueSuppr.Text = "Supprimer";
            this.btnCmdRevueSuppr.UseVisualStyleBackColor = true;
            this.btnCmdRevueSuppr.Click += new System.EventHandler(this.BtnCmdRevueSuppr_Click);
            // 
            // btnCmdRevueRefresh
            // 
            this.btnCmdRevueRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdRevueRefresh.Location = new System.Drawing.Point(692, 101);
            this.btnCmdRevueRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdRevueRefresh.Name = "btnCmdRevueRefresh";
            this.btnCmdRevueRefresh.Size = new System.Drawing.Size(130, 27);
            this.btnCmdRevueRefresh.TabIndex = 8;
            this.btnCmdRevueRefresh.Text = "Rafraîchir";
            this.btnCmdRevueRefresh.UseVisualStyleBackColor = true;
            this.btnCmdRevueRefresh.Click += new System.EventHandler(this.BtnCmdRevueRefresh_Click);
            // 
            // tabCommandesDvd
            // 
            this.tabCommandesDvd.Controls.Add(this.label70);
            this.tabCommandesDvd.Controls.Add(this.label69);
            this.tabCommandesDvd.Controls.Add(this.label63);
            this.tabCommandesDvd.Controls.Add(this.btnCmdDvdSuppr);
            this.tabCommandesDvd.Controls.Add(this.txbCmdDvdMontant);
            this.tabCommandesDvd.Controls.Add(this.dtpCmdDvdDate);
            this.tabCommandesDvd.Controls.Add(this.nudCmdDvdNbEx);
            this.tabCommandesDvd.Controls.Add(this.cbxCmdDvdSuivi);
            this.tabCommandesDvd.Controls.Add(this.btnCmdDvdMajSuivi);
            this.tabCommandesDvd.Controls.Add(this.btnCmdDvdAjouter);
            this.tabCommandesDvd.Controls.Add(this.btnCmdDvdRefresh);
            this.tabCommandesDvd.Controls.Add(this.cbxCmdDvd);
            this.tabCommandesDvd.Controls.Add(this.dgvCmdDvd);
            this.tabCommandesDvd.Controls.Add(this.label60);
            this.tabCommandesDvd.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesDvd.Name = "tabCommandesDvd";
            this.tabCommandesDvd.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesDvd.Size = new System.Drawing.Size(1169, 785);
            this.tabCommandesDvd.TabIndex = 6;
            this.tabCommandesDvd.Text = "Commandes Dvd";
            this.tabCommandesDvd.UseVisualStyleBackColor = true;
            this.tabCommandesDvd.Click += new System.EventHandler(this.tabCommandesDvd_Click);
            this.tabCommandesDvd.Enter += new System.EventHandler(this.TabCmdDvd_Enter);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(236, 142);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(147, 17);
            this.label70.TabIndex = 31;
            this.label70.Text = "Date de commande";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(597, 140);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(70, 17);
            this.label69.TabIndex = 30;
            this.label69.Text = "Quantité";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(19, 144);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(35, 17);
            this.label63.TabIndex = 26;
            this.label63.Text = "Prix";
            // 
            // btnCmdDvdSuppr
            // 
            this.btnCmdDvdSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdDvdSuppr.Location = new System.Drawing.Point(675, 101);
            this.btnCmdDvdSuppr.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdDvdSuppr.Name = "btnCmdDvdSuppr";
            this.btnCmdDvdSuppr.Size = new System.Drawing.Size(145, 27);
            this.btnCmdDvdSuppr.TabIndex = 21;
            this.btnCmdDvdSuppr.Text = "Supprimer";
            this.btnCmdDvdSuppr.UseVisualStyleBackColor = true;
            this.btnCmdDvdSuppr.Click += new System.EventHandler(this.BtnCmdDvdSuppr_Click);
            // 
            // txbCmdDvdMontant
            // 
            this.txbCmdDvdMontant.Location = new System.Drawing.Point(63, 138);
            this.txbCmdDvdMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txbCmdDvdMontant.Name = "txbCmdDvdMontant";
            this.txbCmdDvdMontant.Size = new System.Drawing.Size(150, 22);
            this.txbCmdDvdMontant.TabIndex = 23;
            // 
            // dtpCmdDvdDate
            // 
            this.dtpCmdDvdDate.Location = new System.Drawing.Point(391, 138);
            this.dtpCmdDvdDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCmdDvdDate.Name = "dtpCmdDvdDate";
            this.dtpCmdDvdDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCmdDvdDate.TabIndex = 24;
            // 
            // nudCmdDvdNbEx
            // 
            this.nudCmdDvdNbEx.Location = new System.Drawing.Point(675, 139);
            this.nudCmdDvdNbEx.Margin = new System.Windows.Forms.Padding(4);
            this.nudCmdDvdNbEx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCmdDvdNbEx.Name = "nudCmdDvdNbEx";
            this.nudCmdDvdNbEx.Size = new System.Drawing.Size(80, 22);
            this.nudCmdDvdNbEx.TabIndex = 25;
            this.nudCmdDvdNbEx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxCmdDvdSuivi
            // 
            this.cbxCmdDvdSuivi.FormattingEnabled = true;
            this.cbxCmdDvdSuivi.Location = new System.Drawing.Point(522, 69);
            this.cbxCmdDvdSuivi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCmdDvdSuivi.Name = "cbxCmdDvdSuivi";
            this.cbxCmdDvdSuivi.Size = new System.Drawing.Size(145, 24);
            this.cbxCmdDvdSuivi.TabIndex = 25;
            // 
            // btnCmdDvdMajSuivi
            // 
            this.btnCmdDvdMajSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdDvdMajSuivi.Location = new System.Drawing.Point(522, 101);
            this.btnCmdDvdMajSuivi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdDvdMajSuivi.Name = "btnCmdDvdMajSuivi";
            this.btnCmdDvdMajSuivi.Size = new System.Drawing.Size(145, 27);
            this.btnCmdDvdMajSuivi.TabIndex = 20;
            this.btnCmdDvdMajSuivi.Text = "Modifier Suivi";
            this.btnCmdDvdMajSuivi.UseVisualStyleBackColor = true;
            this.btnCmdDvdMajSuivi.Click += new System.EventHandler(this.BtnCmdDvdMajSuivi_Click);
            // 
            // btnCmdDvdAjouter
            // 
            this.btnCmdDvdAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdDvdAjouter.Location = new System.Drawing.Point(346, 101);
            this.btnCmdDvdAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdDvdAjouter.Name = "btnCmdDvdAjouter";
            this.btnCmdDvdAjouter.Size = new System.Drawing.Size(168, 27);
            this.btnCmdDvdAjouter.TabIndex = 19;
            this.btnCmdDvdAjouter.Text = "Nouvelle Commande";
            this.btnCmdDvdAjouter.UseVisualStyleBackColor = true;
            this.btnCmdDvdAjouter.Click += new System.EventHandler(this.BtnCmdDvdAjouter_Click);
            // 
            // btnCmdDvdRefresh
            // 
            this.btnCmdDvdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdDvdRefresh.Location = new System.Drawing.Point(830, 101);
            this.btnCmdDvdRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdDvdRefresh.Name = "btnCmdDvdRefresh";
            this.btnCmdDvdRefresh.Size = new System.Drawing.Size(130, 27);
            this.btnCmdDvdRefresh.TabIndex = 22;
            this.btnCmdDvdRefresh.Text = "Rafraîchir";
            this.btnCmdDvdRefresh.UseVisualStyleBackColor = true;
            this.btnCmdDvdRefresh.Click += new System.EventHandler(this.BtnCmdDvdRefresh_Click);
            // 
            // cbxCmdDvd
            // 
            this.cbxCmdDvd.FormattingEnabled = true;
            this.cbxCmdDvd.Location = new System.Drawing.Point(63, 101);
            this.cbxCmdDvd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCmdDvd.Name = "cbxCmdDvd";
            this.cbxCmdDvd.Size = new System.Drawing.Size(275, 24);
            this.cbxCmdDvd.TabIndex = 9;
            this.cbxCmdDvd.SelectedIndexChanged += new System.EventHandler(this.CbxCmdDvd_SelectedIndexChanged);
            // 
            // dgvCmdDvd
            // 
            this.dgvCmdDvd.AllowUserToAddRows = false;
            this.dgvCmdDvd.AllowUserToDeleteRows = false;
            this.dgvCmdDvd.AllowUserToResizeColumns = false;
            this.dgvCmdDvd.AllowUserToResizeRows = false;
            this.dgvCmdDvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdDvd.Location = new System.Drawing.Point(22, 176);
            this.dgvCmdDvd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCmdDvd.MultiSelect = false;
            this.dgvCmdDvd.Name = "dgvCmdDvd";
            this.dgvCmdDvd.ReadOnly = true;
            this.dgvCmdDvd.RowHeadersVisible = false;
            this.dgvCmdDvd.RowHeadersWidth = 51;
            this.dgvCmdDvd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdDvd.Size = new System.Drawing.Size(1125, 246);
            this.dgvCmdDvd.TabIndex = 8;
            this.dgvCmdDvd.SelectionChanged += new System.EventHandler(this.DgvCmdDvd_SelectionChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(19, 103);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(36, 17);
            this.label60.TabIndex = 7;
            this.label60.Text = "Dvd";
            this.label60.Click += new System.EventHandler(this.lblCmdDvd_Click);
            // 
            // tabCommandesLivres
            // 
            this.tabCommandesLivres.Controls.Add(this.label68);
            this.tabCommandesLivres.Controls.Add(this.label67);
            this.tabCommandesLivres.Controls.Add(this.label64);
            this.tabCommandesLivres.Controls.Add(this.btnCmdLivreSuppr);
            this.tabCommandesLivres.Controls.Add(this.txbCmdLivreMontant);
            this.tabCommandesLivres.Controls.Add(this.dtpCmdLivreDate);
            this.tabCommandesLivres.Controls.Add(this.nudCmdLivreNbEx);
            this.tabCommandesLivres.Controls.Add(this.cbxCmdLivreSuivi);
            this.tabCommandesLivres.Controls.Add(this.btnCmdLivreMajSuivi);
            this.tabCommandesLivres.Controls.Add(this.btnCmdLivreAjouter);
            this.tabCommandesLivres.Controls.Add(this.btnCmdLivreRefresh);
            this.tabCommandesLivres.Controls.Add(this.cbxCmdLivre);
            this.tabCommandesLivres.Controls.Add(this.lblCmdLivre);
            this.tabCommandesLivres.Controls.Add(this.dgvCmdLivre);
            this.tabCommandesLivres.Location = new System.Drawing.Point(4, 22);
            this.tabCommandesLivres.Name = "tabCommandesLivres";
            this.tabCommandesLivres.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesLivres.Size = new System.Drawing.Size(1169, 785);
            this.tabCommandesLivres.TabIndex = 5;
            this.tabCommandesLivres.Text = "Commandes Livres";
            this.tabCommandesLivres.UseVisualStyleBackColor = true;
            this.tabCommandesLivres.Click += new System.EventHandler(this.tabCommandesLivres_Click);
            this.tabCommandesLivres.Enter += new System.EventHandler(this.TabCmdLivres_Enter);
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(585, 144);
            this.label68.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(70, 17);
            this.label68.TabIndex = 29;
            this.label68.Text = "Quantité";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(227, 140);
            this.label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(147, 17);
            this.label67.TabIndex = 28;
            this.label67.Text = "Date de commande";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(26, 140);
            this.label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(35, 17);
            this.label64.TabIndex = 27;
            this.label64.Text = "Prix";
            // 
            // btnCmdLivreSuppr
            // 
            this.btnCmdLivreSuppr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdLivreSuppr.Location = new System.Drawing.Point(681, 103);
            this.btnCmdLivreSuppr.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdLivreSuppr.Name = "btnCmdLivreSuppr";
            this.btnCmdLivreSuppr.Size = new System.Drawing.Size(145, 27);
            this.btnCmdLivreSuppr.TabIndex = 20;
            this.btnCmdLivreSuppr.Text = "Supprimer";
            this.btnCmdLivreSuppr.UseVisualStyleBackColor = true;
            this.btnCmdLivreSuppr.Click += new System.EventHandler(this.BtnCmdLivreSuppr_Click);
            // 
            // txbCmdLivreMontant
            // 
            this.txbCmdLivreMontant.Location = new System.Drawing.Point(69, 135);
            this.txbCmdLivreMontant.Margin = new System.Windows.Forms.Padding(4);
            this.txbCmdLivreMontant.Name = "txbCmdLivreMontant";
            this.txbCmdLivreMontant.Size = new System.Drawing.Size(150, 22);
            this.txbCmdLivreMontant.TabIndex = 23;
            // 
            // dtpCmdLivreDate
            // 
            this.dtpCmdLivreDate.Location = new System.Drawing.Point(382, 140);
            this.dtpCmdLivreDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCmdLivreDate.Name = "dtpCmdLivreDate";
            this.dtpCmdLivreDate.Size = new System.Drawing.Size(200, 22);
            this.dtpCmdLivreDate.TabIndex = 24;
            // 
            // nudCmdLivreNbEx
            // 
            this.nudCmdLivreNbEx.Location = new System.Drawing.Point(663, 140);
            this.nudCmdLivreNbEx.Margin = new System.Windows.Forms.Padding(4);
            this.nudCmdLivreNbEx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCmdLivreNbEx.Name = "nudCmdLivreNbEx";
            this.nudCmdLivreNbEx.Size = new System.Drawing.Size(80, 22);
            this.nudCmdLivreNbEx.TabIndex = 25;
            this.nudCmdLivreNbEx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxCmdLivreSuivi
            // 
            this.cbxCmdLivreSuivi.FormattingEnabled = true;
            this.cbxCmdLivreSuivi.Location = new System.Drawing.Point(528, 73);
            this.cbxCmdLivreSuivi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCmdLivreSuivi.Name = "cbxCmdLivreSuivi";
            this.cbxCmdLivreSuivi.Size = new System.Drawing.Size(145, 24);
            this.cbxCmdLivreSuivi.TabIndex = 26;
            // 
            // btnCmdLivreMajSuivi
            // 
            this.btnCmdLivreMajSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdLivreMajSuivi.Location = new System.Drawing.Point(528, 105);
            this.btnCmdLivreMajSuivi.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdLivreMajSuivi.Name = "btnCmdLivreMajSuivi";
            this.btnCmdLivreMajSuivi.Size = new System.Drawing.Size(145, 27);
            this.btnCmdLivreMajSuivi.TabIndex = 19;
            this.btnCmdLivreMajSuivi.Text = "Modifier Suivi";
            this.btnCmdLivreMajSuivi.UseVisualStyleBackColor = true;
            this.btnCmdLivreMajSuivi.Click += new System.EventHandler(this.BtnCmdLivreMajSuivi_Click);
            // 
            // btnCmdLivreAjouter
            // 
            this.btnCmdLivreAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdLivreAjouter.Location = new System.Drawing.Point(352, 103);
            this.btnCmdLivreAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdLivreAjouter.Name = "btnCmdLivreAjouter";
            this.btnCmdLivreAjouter.Size = new System.Drawing.Size(168, 27);
            this.btnCmdLivreAjouter.TabIndex = 18;
            this.btnCmdLivreAjouter.Text = "Nouvelle Commande";
            this.btnCmdLivreAjouter.UseVisualStyleBackColor = true;
            this.btnCmdLivreAjouter.Click += new System.EventHandler(this.BtnCmdLivreAjouter_Click);
            // 
            // btnCmdLivreRefresh
            // 
            this.btnCmdLivreRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCmdLivreRefresh.Location = new System.Drawing.Point(836, 103);
            this.btnCmdLivreRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnCmdLivreRefresh.Name = "btnCmdLivreRefresh";
            this.btnCmdLivreRefresh.Size = new System.Drawing.Size(130, 27);
            this.btnCmdLivreRefresh.TabIndex = 23;
            this.btnCmdLivreRefresh.Text = "Rafraîchir";
            this.btnCmdLivreRefresh.UseVisualStyleBackColor = true;
            this.btnCmdLivreRefresh.Click += new System.EventHandler(this.BtnCmdLivreRefresh_Click);
            // 
            // cbxCmdLivre
            // 
            this.cbxCmdLivre.FormattingEnabled = true;
            this.cbxCmdLivre.Location = new System.Drawing.Point(69, 103);
            this.cbxCmdLivre.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCmdLivre.Name = "cbxCmdLivre";
            this.cbxCmdLivre.Size = new System.Drawing.Size(275, 24);
            this.cbxCmdLivre.TabIndex = 7;
            this.cbxCmdLivre.SelectedIndexChanged += new System.EventHandler(this.CbxCmdLivre_SelectedIndexChanged);
            // 
            // lblCmdLivre
            // 
            this.lblCmdLivre.AutoSize = true;
            this.lblCmdLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmdLivre.Location = new System.Drawing.Point(17, 103);
            this.lblCmdLivre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmdLivre.Name = "lblCmdLivre";
            this.lblCmdLivre.Size = new System.Drawing.Size(44, 17);
            this.lblCmdLivre.TabIndex = 6;
            this.lblCmdLivre.Text = "Livre";
            this.lblCmdLivre.Click += new System.EventHandler(this.lblCmdLivre_Click);
            // 
            // dgvCmdLivre
            // 
            this.dgvCmdLivre.AllowUserToAddRows = false;
            this.dgvCmdLivre.AllowUserToDeleteRows = false;
            this.dgvCmdLivre.AllowUserToResizeColumns = false;
            this.dgvCmdLivre.AllowUserToResizeRows = false;
            this.dgvCmdLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmdLivre.Location = new System.Drawing.Point(20, 181);
            this.dgvCmdLivre.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCmdLivre.MultiSelect = false;
            this.dgvCmdLivre.Name = "dgvCmdLivre";
            this.dgvCmdLivre.ReadOnly = true;
            this.dgvCmdLivre.RowHeadersVisible = false;
            this.dgvCmdLivre.RowHeadersWidth = 51;
            this.dgvCmdLivre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmdLivre.Size = new System.Drawing.Size(1125, 246);
            this.dgvCmdLivre.TabIndex = 5;
            this.dgvCmdLivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCmdLivre_CellContentClick);
            this.dgvCmdLivre.SelectionChanged += new System.EventHandler(this.DgvCmdLivre_SelectionChanged);
            // 
            // tabReceptionRevue
            // 
            this.tabReceptionRevue.Controls.Add(this.grpReceptionExemplaire);
            this.tabReceptionRevue.Controls.Add(this.grpReceptionRevue);
            this.tabReceptionRevue.Location = new System.Drawing.Point(4, 22);
            this.tabReceptionRevue.Margin = new System.Windows.Forms.Padding(4);
            this.tabReceptionRevue.Name = "tabReceptionRevue";
            this.tabReceptionRevue.Size = new System.Drawing.Size(1169, 785);
            this.tabReceptionRevue.TabIndex = 4;
            this.tabReceptionRevue.Text = "Parutions des revues";
            this.tabReceptionRevue.UseVisualStyleBackColor = true;
            this.tabReceptionRevue.Enter += new System.EventHandler(this.tabReceptionRevue_Enter);
            // 
            // grpReceptionExemplaire
            // 
            this.grpReceptionExemplaire.Controls.Add(this.label55);
            this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.pcbReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.btnReceptionExemplaireValider);
            this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireImage);
            this.grpReceptionExemplaire.Controls.Add(this.label18);
            this.grpReceptionExemplaire.Controls.Add(this.txbReceptionExemplaireNumero);
            this.grpReceptionExemplaire.Controls.Add(this.label17);
            this.grpReceptionExemplaire.Controls.Add(this.dtpReceptionExemplaireDate);
            this.grpReceptionExemplaire.Controls.Add(this.label16);
            this.grpReceptionExemplaire.Location = new System.Drawing.Point(11, 468);
            this.grpReceptionExemplaire.Margin = new System.Windows.Forms.Padding(4);
            this.grpReceptionExemplaire.Name = "grpReceptionExemplaire";
            this.grpReceptionExemplaire.Padding = new System.Windows.Forms.Padding(4);
            this.grpReceptionExemplaire.Size = new System.Drawing.Size(1145, 300);
            this.grpReceptionExemplaire.TabIndex = 16;
            this.grpReceptionExemplaire.TabStop = false;
            this.grpReceptionExemplaire.Text = "Nouvelle parution réceptionnée pour cette revue";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(743, 12);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(144, 17);
            this.label55.TabIndex = 57;
            this.label55.Text = "Image exemplaire :";
            // 
            // btnReceptionExemplaireImage
            // 
            this.btnReceptionExemplaireImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionExemplaireImage.Location = new System.Drawing.Point(595, 85);
            this.btnReceptionExemplaireImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceptionExemplaireImage.Name = "btnReceptionExemplaireImage";
            this.btnReceptionExemplaireImage.Size = new System.Drawing.Size(128, 27);
            this.btnReceptionExemplaireImage.TabIndex = 43;
            this.btnReceptionExemplaireImage.Text = "Rechercher";
            this.btnReceptionExemplaireImage.UseVisualStyleBackColor = true;
            this.btnReceptionExemplaireImage.Click += new System.EventHandler(this.btnReceptionExemplaireImage_Click);
            // 
            // pcbReceptionExemplaireImage
            // 
            this.pcbReceptionExemplaireImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionExemplaireImage.Location = new System.Drawing.Point(747, 32);
            this.pcbReceptionExemplaireImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbReceptionExemplaireImage.Name = "pcbReceptionExemplaireImage";
            this.pcbReceptionExemplaireImage.Size = new System.Drawing.Size(378, 258);
            this.pcbReceptionExemplaireImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionExemplaireImage.TabIndex = 42;
            this.pcbReceptionExemplaireImage.TabStop = false;
            // 
            // btnReceptionExemplaireValider
            // 
            this.btnReceptionExemplaireValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionExemplaireValider.Location = new System.Drawing.Point(8, 117);
            this.btnReceptionExemplaireValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceptionExemplaireValider.Name = "btnReceptionExemplaireValider";
            this.btnReceptionExemplaireValider.Size = new System.Drawing.Size(713, 27);
            this.btnReceptionExemplaireValider.TabIndex = 17;
            this.btnReceptionExemplaireValider.Text = "Valider la réception";
            this.btnReceptionExemplaireValider.UseVisualStyleBackColor = true;
            this.btnReceptionExemplaireValider.Click += new System.EventHandler(this.btnReceptionExemplaireValider_Click);
            // 
            // txbReceptionExemplaireImage
            // 
            this.txbReceptionExemplaireImage.Location = new System.Drawing.Point(200, 86);
            this.txbReceptionExemplaireImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionExemplaireImage.Name = "txbReceptionExemplaireImage";
            this.txbReceptionExemplaireImage.ReadOnly = true;
            this.txbReceptionExemplaireImage.Size = new System.Drawing.Size(385, 22);
            this.txbReceptionExemplaireImage.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 86);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Emplacement image :";
            // 
            // txbReceptionExemplaireNumero
            // 
            this.txbReceptionExemplaireNumero.Location = new System.Drawing.Point(200, 25);
            this.txbReceptionExemplaireNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionExemplaireNumero.Name = "txbReceptionExemplaireNumero";
            this.txbReceptionExemplaireNumero.Size = new System.Drawing.Size(132, 22);
            this.txbReceptionExemplaireNumero.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 55);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Date de parution :";
            // 
            // dtpReceptionExemplaireDate
            // 
            this.dtpReceptionExemplaireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceptionExemplaireDate.Location = new System.Drawing.Point(200, 55);
            this.dtpReceptionExemplaireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReceptionExemplaireDate.Name = "dtpReceptionExemplaireDate";
            this.dtpReceptionExemplaireDate.Size = new System.Drawing.Size(132, 22);
            this.dtpReceptionExemplaireDate.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Numéro réceptionné :";
            // 
            // grpReceptionRevue
            // 
            this.grpReceptionRevue.Controls.Add(this.label48);
            this.grpReceptionRevue.Controls.Add(this.label56);
            this.grpReceptionRevue.Controls.Add(this.pcbReceptionExemplaireRevueImage);
            this.grpReceptionRevue.Controls.Add(this.label13);
            this.grpReceptionRevue.Controls.Add(this.dgvReceptionExemplairesListe);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueImage);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueRayon);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePublic);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueGenre);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueDelaiMiseADispo);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevuePeriodicite);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueTitre);
            this.grpReceptionRevue.Controls.Add(this.txbReceptionRevueNumero);
            this.grpReceptionRevue.Controls.Add(this.label3);
            this.grpReceptionRevue.Controls.Add(this.pcbReceptionRevueImage);
            this.grpReceptionRevue.Controls.Add(this.label15);
            this.grpReceptionRevue.Controls.Add(this.label49);
            this.grpReceptionRevue.Controls.Add(this.label50);
            this.grpReceptionRevue.Controls.Add(this.label51);
            this.grpReceptionRevue.Controls.Add(this.label52);
            this.grpReceptionRevue.Controls.Add(this.label53);
            this.grpReceptionRevue.Controls.Add(this.label54);
            this.grpReceptionRevue.Controls.Add(this.btnReceptionRechercher);
            this.grpReceptionRevue.Location = new System.Drawing.Point(11, 16);
            this.grpReceptionRevue.Margin = new System.Windows.Forms.Padding(4);
            this.grpReceptionRevue.Name = "grpReceptionRevue";
            this.grpReceptionRevue.Padding = new System.Windows.Forms.Padding(4);
            this.grpReceptionRevue.Size = new System.Drawing.Size(1145, 444);
            this.grpReceptionRevue.TabIndex = 15;
            this.grpReceptionRevue.TabStop = false;
            this.grpReceptionRevue.Text = "Recherche revue";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(743, 156);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(144, 17);
            this.label48.TabIndex = 56;
            this.label48.Text = "Image exemplaire :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(743, 25);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(107, 17);
            this.label56.TabIndex = 55;
            this.label56.Text = "Image revue :";
            // 
            // pcbReceptionExemplaireRevueImage
            // 
            this.pcbReceptionExemplaireRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionExemplaireRevueImage.Location = new System.Drawing.Point(747, 178);
            this.pcbReceptionExemplaireRevueImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbReceptionExemplaireRevueImage.Name = "pcbReceptionExemplaireRevueImage";
            this.pcbReceptionExemplaireRevueImage.Size = new System.Drawing.Size(378, 258);
            this.pcbReceptionExemplaireRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionExemplaireRevueImage.TabIndex = 54;
            this.pcbReceptionExemplaireRevueImage.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 271);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Parutions :";
            // 
            // dgvReceptionExemplairesListe
            // 
            this.dgvReceptionExemplairesListe.AllowUserToAddRows = false;
            this.dgvReceptionExemplairesListe.AllowUserToDeleteRows = false;
            this.dgvReceptionExemplairesListe.AllowUserToResizeColumns = false;
            this.dgvReceptionExemplairesListe.AllowUserToResizeRows = false;
            this.dgvReceptionExemplairesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionExemplairesListe.Location = new System.Drawing.Point(200, 272);
            this.dgvReceptionExemplairesListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceptionExemplairesListe.MultiSelect = false;
            this.dgvReceptionExemplairesListe.Name = "dgvReceptionExemplairesListe";
            this.dgvReceptionExemplairesListe.ReadOnly = true;
            this.dgvReceptionExemplairesListe.RowHeadersVisible = false;
            this.dgvReceptionExemplairesListe.RowHeadersWidth = 51;
            this.dgvReceptionExemplairesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceptionExemplairesListe.Size = new System.Drawing.Size(521, 165);
            this.dgvReceptionExemplairesListe.TabIndex = 52;
            this.dgvReceptionExemplairesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvExemplairesListe_ColumnHeaderMouseClick);
            this.dgvReceptionExemplairesListe.SelectionChanged += new System.EventHandler(this.dgvReceptionExemplairesListe_SelectionChanged);
            // 
            // txbReceptionRevueImage
            // 
            this.txbReceptionRevueImage.Location = new System.Drawing.Point(200, 240);
            this.txbReceptionRevueImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueImage.Name = "txbReceptionRevueImage";
            this.txbReceptionRevueImage.ReadOnly = true;
            this.txbReceptionRevueImage.Size = new System.Drawing.Size(520, 22);
            this.txbReceptionRevueImage.TabIndex = 50;
            // 
            // txbReceptionRevueRayon
            // 
            this.txbReceptionRevueRayon.Location = new System.Drawing.Point(200, 209);
            this.txbReceptionRevueRayon.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueRayon.Name = "txbReceptionRevueRayon";
            this.txbReceptionRevueRayon.ReadOnly = true;
            this.txbReceptionRevueRayon.Size = new System.Drawing.Size(275, 22);
            this.txbReceptionRevueRayon.TabIndex = 49;
            // 
            // txbReceptionRevuePublic
            // 
            this.txbReceptionRevuePublic.Location = new System.Drawing.Point(200, 178);
            this.txbReceptionRevuePublic.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevuePublic.Name = "txbReceptionRevuePublic";
            this.txbReceptionRevuePublic.ReadOnly = true;
            this.txbReceptionRevuePublic.Size = new System.Drawing.Size(275, 22);
            this.txbReceptionRevuePublic.TabIndex = 48;
            // 
            // txbReceptionRevueGenre
            // 
            this.txbReceptionRevueGenre.Location = new System.Drawing.Point(200, 148);
            this.txbReceptionRevueGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueGenre.Name = "txbReceptionRevueGenre";
            this.txbReceptionRevueGenre.ReadOnly = true;
            this.txbReceptionRevueGenre.Size = new System.Drawing.Size(275, 22);
            this.txbReceptionRevueGenre.TabIndex = 47;
            // 
            // txbReceptionRevueDelaiMiseADispo
            // 
            this.txbReceptionRevueDelaiMiseADispo.Location = new System.Drawing.Point(200, 117);
            this.txbReceptionRevueDelaiMiseADispo.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueDelaiMiseADispo.Name = "txbReceptionRevueDelaiMiseADispo";
            this.txbReceptionRevueDelaiMiseADispo.ReadOnly = true;
            this.txbReceptionRevueDelaiMiseADispo.Size = new System.Drawing.Size(132, 22);
            this.txbReceptionRevueDelaiMiseADispo.TabIndex = 46;
            // 
            // txbReceptionRevuePeriodicite
            // 
            this.txbReceptionRevuePeriodicite.Location = new System.Drawing.Point(200, 86);
            this.txbReceptionRevuePeriodicite.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevuePeriodicite.Name = "txbReceptionRevuePeriodicite";
            this.txbReceptionRevuePeriodicite.ReadOnly = true;
            this.txbReceptionRevuePeriodicite.Size = new System.Drawing.Size(132, 22);
            this.txbReceptionRevuePeriodicite.TabIndex = 45;
            // 
            // txbReceptionRevueTitre
            // 
            this.txbReceptionRevueTitre.Location = new System.Drawing.Point(200, 55);
            this.txbReceptionRevueTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueTitre.Name = "txbReceptionRevueTitre";
            this.txbReceptionRevueTitre.ReadOnly = true;
            this.txbReceptionRevueTitre.Size = new System.Drawing.Size(520, 22);
            this.txbReceptionRevueTitre.TabIndex = 44;
            // 
            // txbReceptionRevueNumero
            // 
            this.txbReceptionRevueNumero.Location = new System.Drawing.Point(200, 25);
            this.txbReceptionRevueNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbReceptionRevueNumero.Name = "txbReceptionRevueNumero";
            this.txbReceptionRevueNumero.Size = new System.Drawing.Size(132, 22);
            this.txbReceptionRevueNumero.TabIndex = 43;
            this.txbReceptionRevueNumero.TextChanged += new System.EventHandler(this.TxbReceptionRevueNumero_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Genre :";
            // 
            // pcbReceptionRevueImage
            // 
            this.pcbReceptionRevueImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbReceptionRevueImage.Location = new System.Drawing.Point(920, 25);
            this.pcbReceptionRevueImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbReceptionRevueImage.Name = "pcbReceptionRevueImage";
            this.pcbReceptionRevueImage.Size = new System.Drawing.Size(205, 140);
            this.pcbReceptionRevueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbReceptionRevueImage.TabIndex = 41;
            this.pcbReceptionRevueImage.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 178);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "Public :";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(8, 209);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 17);
            this.label49.TabIndex = 39;
            this.label49.Text = "Rayon :";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(8, 55);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(52, 17);
            this.label50.TabIndex = 36;
            this.label50.Text = "Titre :";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(8, 25);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(120, 17);
            this.label51.TabIndex = 33;
            this.label51.Text = "Numéro revue :";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(8, 86);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(95, 17);
            this.label52.TabIndex = 37;
            this.label52.Text = "Périodicité :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(8, 240);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(150, 17);
            this.label53.TabIndex = 34;
            this.label53.Text = "Chemin de l\'image :";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(8, 117);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(151, 17);
            this.label54.TabIndex = 38;
            this.label54.Text = "Délai mise à dispo :";
            // 
            // btnReceptionRechercher
            // 
            this.btnReceptionRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionRechercher.Location = new System.Drawing.Point(348, 23);
            this.btnReceptionRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceptionRechercher.Name = "btnReceptionRechercher";
            this.btnReceptionRechercher.Size = new System.Drawing.Size(128, 27);
            this.btnReceptionRechercher.TabIndex = 16;
            this.btnReceptionRechercher.Text = "Rechercher";
            this.btnReceptionRechercher.UseVisualStyleBackColor = true;
            this.btnReceptionRechercher.Click += new System.EventHandler(this.btnReceptionRechercher_Click);
            // 
            // tabRevues
            // 
            this.tabRevues.Controls.Add(this.grpRevuesInfos);
            this.tabRevues.Controls.Add(this.grpRevuesRecherche);
            this.tabRevues.Location = new System.Drawing.Point(4, 22);
            this.tabRevues.Margin = new System.Windows.Forms.Padding(4);
            this.tabRevues.Name = "tabRevues";
            this.tabRevues.Padding = new System.Windows.Forms.Padding(4);
            this.tabRevues.Size = new System.Drawing.Size(1169, 785);
            this.tabRevues.TabIndex = 1;
            this.tabRevues.Text = "Revues";
            this.tabRevues.UseVisualStyleBackColor = true;
            this.tabRevues.Enter += new System.EventHandler(this.TabRevues_Enter);
            // 
            // grpRevuesInfos
            // 
            this.grpRevuesInfos.Controls.Add(this.label57);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesImage);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesRayon);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesPublic);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesGenre);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesDateMiseADispo);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesPeriodicite);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesTitre);
            this.grpRevuesInfos.Controls.Add(this.txbRevuesNumero);
            this.grpRevuesInfos.Controls.Add(this.label35);
            this.grpRevuesInfos.Controls.Add(this.pcbRevuesImage);
            this.grpRevuesInfos.Controls.Add(this.label36);
            this.grpRevuesInfos.Controls.Add(this.label37);
            this.grpRevuesInfos.Controls.Add(this.label43);
            this.grpRevuesInfos.Controls.Add(this.label44);
            this.grpRevuesInfos.Controls.Add(this.label45);
            this.grpRevuesInfos.Controls.Add(this.label46);
            this.grpRevuesInfos.Controls.Add(this.label47);
            this.grpRevuesInfos.Location = new System.Drawing.Point(11, 469);
            this.grpRevuesInfos.Margin = new System.Windows.Forms.Padding(4);
            this.grpRevuesInfos.Name = "grpRevuesInfos";
            this.grpRevuesInfos.Padding = new System.Windows.Forms.Padding(4);
            this.grpRevuesInfos.Size = new System.Drawing.Size(1145, 302);
            this.grpRevuesInfos.TabIndex = 20;
            this.grpRevuesInfos.TabStop = false;
            this.grpRevuesInfos.Text = "Informations détaillées";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(743, 14);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(61, 17);
            this.label57.TabIndex = 32;
            this.label57.Text = "Image :";
            // 
            // txbRevuesImage
            // 
            this.txbRevuesImage.Location = new System.Drawing.Point(200, 240);
            this.txbRevuesImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesImage.Name = "txbRevuesImage";
            this.txbRevuesImage.ReadOnly = true;
            this.txbRevuesImage.Size = new System.Drawing.Size(520, 22);
            this.txbRevuesImage.TabIndex = 31;
            // 
            // txbRevuesRayon
            // 
            this.txbRevuesRayon.Location = new System.Drawing.Point(200, 209);
            this.txbRevuesRayon.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesRayon.Name = "txbRevuesRayon";
            this.txbRevuesRayon.ReadOnly = true;
            this.txbRevuesRayon.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesRayon.TabIndex = 30;
            // 
            // txbRevuesPublic
            // 
            this.txbRevuesPublic.Location = new System.Drawing.Point(200, 178);
            this.txbRevuesPublic.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesPublic.Name = "txbRevuesPublic";
            this.txbRevuesPublic.ReadOnly = true;
            this.txbRevuesPublic.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesPublic.TabIndex = 29;
            // 
            // txbRevuesGenre
            // 
            this.txbRevuesGenre.Location = new System.Drawing.Point(200, 148);
            this.txbRevuesGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesGenre.Name = "txbRevuesGenre";
            this.txbRevuesGenre.ReadOnly = true;
            this.txbRevuesGenre.Size = new System.Drawing.Size(275, 22);
            this.txbRevuesGenre.TabIndex = 28;
            // 
            // txbRevuesDateMiseADispo
            // 
            this.txbRevuesDateMiseADispo.Location = new System.Drawing.Point(200, 117);
            this.txbRevuesDateMiseADispo.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesDateMiseADispo.Name = "txbRevuesDateMiseADispo";
            this.txbRevuesDateMiseADispo.ReadOnly = true;
            this.txbRevuesDateMiseADispo.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesDateMiseADispo.TabIndex = 27;
            // 
            // txbRevuesPeriodicite
            // 
            this.txbRevuesPeriodicite.Location = new System.Drawing.Point(200, 86);
            this.txbRevuesPeriodicite.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesPeriodicite.Name = "txbRevuesPeriodicite";
            this.txbRevuesPeriodicite.ReadOnly = true;
            this.txbRevuesPeriodicite.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesPeriodicite.TabIndex = 26;
            // 
            // txbRevuesTitre
            // 
            this.txbRevuesTitre.Location = new System.Drawing.Point(200, 55);
            this.txbRevuesTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesTitre.Name = "txbRevuesTitre";
            this.txbRevuesTitre.ReadOnly = true;
            this.txbRevuesTitre.Size = new System.Drawing.Size(520, 22);
            this.txbRevuesTitre.TabIndex = 25;
            // 
            // txbRevuesNumero
            // 
            this.txbRevuesNumero.Location = new System.Drawing.Point(200, 25);
            this.txbRevuesNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesNumero.Name = "txbRevuesNumero";
            this.txbRevuesNumero.ReadOnly = true;
            this.txbRevuesNumero.Size = new System.Drawing.Size(132, 22);
            this.txbRevuesNumero.TabIndex = 24;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 148);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(63, 17);
            this.label35.TabIndex = 22;
            this.label35.Text = "Genre :";
            // 
            // pcbRevuesImage
            // 
            this.pcbRevuesImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbRevuesImage.Location = new System.Drawing.Point(747, 33);
            this.pcbRevuesImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbRevuesImage.Name = "pcbRevuesImage";
            this.pcbRevuesImage.Size = new System.Drawing.Size(378, 258);
            this.pcbRevuesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRevuesImage.TabIndex = 21;
            this.pcbRevuesImage.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(8, 178);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(62, 17);
            this.label36.TabIndex = 19;
            this.label36.Text = "Public :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(8, 209);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 17);
            this.label37.TabIndex = 17;
            this.label37.Text = "Rayon :";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(8, 55);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 17);
            this.label43.TabIndex = 8;
            this.label43.Text = "Titre :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(8, 25);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(172, 17);
            this.label44.TabIndex = 5;
            this.label44.Text = "Numéro de document :";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(8, 86);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 17);
            this.label45.TabIndex = 9;
            this.label45.Text = "Périodicité :";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(8, 240);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(150, 17);
            this.label46.TabIndex = 6;
            this.label46.Text = "Chemin de l\'image :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(8, 117);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(151, 17);
            this.label47.TabIndex = 10;
            this.label47.Text = "Délai mise à dispo :";
            // 
            // grpRevuesRecherche
            // 
            this.grpRevuesRecherche.Controls.Add(this.BtnRevuesSupprimer);
            this.grpRevuesRecherche.Controls.Add(this.BtnRevuesModifier);
            this.grpRevuesRecherche.Controls.Add(this.BtnRevuesAjouter);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulRayons);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulPublics);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesNumRecherche);
            this.grpRevuesRecherche.Controls.Add(this.label2);
            this.grpRevuesRecherche.Controls.Add(this.txbRevuesNumRecherche);
            this.grpRevuesRecherche.Controls.Add(this.btnRevuesAnnulGenres);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesRayons);
            this.grpRevuesRecherche.Controls.Add(this.label4);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesPublics);
            this.grpRevuesRecherche.Controls.Add(this.label32);
            this.grpRevuesRecherche.Controls.Add(this.cbxRevuesGenres);
            this.grpRevuesRecherche.Controls.Add(this.label33);
            this.grpRevuesRecherche.Controls.Add(this.dgvRevuesListe);
            this.grpRevuesRecherche.Controls.Add(this.label34);
            this.grpRevuesRecherche.Controls.Add(this.txbRevuesTitreRecherche);
            this.grpRevuesRecherche.Location = new System.Drawing.Point(11, 16);
            this.grpRevuesRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.grpRevuesRecherche.Name = "grpRevuesRecherche";
            this.grpRevuesRecherche.Padding = new System.Windows.Forms.Padding(4);
            this.grpRevuesRecherche.Size = new System.Drawing.Size(1145, 446);
            this.grpRevuesRecherche.TabIndex = 19;
            this.grpRevuesRecherche.TabStop = false;
            this.grpRevuesRecherche.Text = "Recherches";
            // 
            // BtnRevuesSupprimer
            // 
            this.BtnRevuesSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevuesSupprimer.Location = new System.Drawing.Point(404, 133);
            this.BtnRevuesSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRevuesSupprimer.Name = "BtnRevuesSupprimer";
            this.BtnRevuesSupprimer.Size = new System.Drawing.Size(199, 27);
            this.BtnRevuesSupprimer.TabIndex = 19;
            this.BtnRevuesSupprimer.Text = "Supprimer une Revue";
            this.BtnRevuesSupprimer.UseVisualStyleBackColor = true;
            this.BtnRevuesSupprimer.Click += new System.EventHandler(this.BtnRevuesSupprimer_Click);
            // 
            // BtnRevuesModifier
            // 
            this.BtnRevuesModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevuesModifier.Location = new System.Drawing.Point(219, 133);
            this.BtnRevuesModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRevuesModifier.Name = "BtnRevuesModifier";
            this.BtnRevuesModifier.Size = new System.Drawing.Size(177, 27);
            this.BtnRevuesModifier.TabIndex = 18;
            this.BtnRevuesModifier.Text = "Modifier une Revue";
            this.BtnRevuesModifier.UseVisualStyleBackColor = true;
            this.BtnRevuesModifier.Click += new System.EventHandler(this.BtnRevuesModifier_Click);
            // 
            // BtnRevuesAjouter
            // 
            this.BtnRevuesAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRevuesAjouter.Location = new System.Drawing.Point(37, 133);
            this.BtnRevuesAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRevuesAjouter.Name = "BtnRevuesAjouter";
            this.BtnRevuesAjouter.Size = new System.Drawing.Size(174, 27);
            this.BtnRevuesAjouter.TabIndex = 17;
            this.BtnRevuesAjouter.Text = "Ajouter une Revue";
            this.BtnRevuesAjouter.UseVisualStyleBackColor = true;
            this.BtnRevuesAjouter.Click += new System.EventHandler(this.BtnRevuesAjouter_Click);
            // 
            // btnRevuesAnnulRayons
            // 
            this.btnRevuesAnnulRayons.Location = new System.Drawing.Point(1111, 128);
            this.btnRevuesAnnulRayons.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevuesAnnulRayons.Name = "btnRevuesAnnulRayons";
            this.btnRevuesAnnulRayons.Size = new System.Drawing.Size(29, 27);
            this.btnRevuesAnnulRayons.TabIndex = 16;
            this.btnRevuesAnnulRayons.Text = "X";
            this.btnRevuesAnnulRayons.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulRayons.Click += new System.EventHandler(this.btnRevuesAnnulRayons_Click);
            // 
            // btnRevuesAnnulPublics
            // 
            this.btnRevuesAnnulPublics.Location = new System.Drawing.Point(1111, 74);
            this.btnRevuesAnnulPublics.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevuesAnnulPublics.Name = "btnRevuesAnnulPublics";
            this.btnRevuesAnnulPublics.Size = new System.Drawing.Size(29, 27);
            this.btnRevuesAnnulPublics.TabIndex = 15;
            this.btnRevuesAnnulPublics.Text = "X";
            this.btnRevuesAnnulPublics.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulPublics.Click += new System.EventHandler(this.btnRevuesAnnulPublics_Click);
            // 
            // btnRevuesNumRecherche
            // 
            this.btnRevuesNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevuesNumRecherche.Location = new System.Drawing.Point(419, 73);
            this.btnRevuesNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevuesNumRecherche.Name = "btnRevuesNumRecherche";
            this.btnRevuesNumRecherche.Size = new System.Drawing.Size(128, 27);
            this.btnRevuesNumRecherche.TabIndex = 14;
            this.btnRevuesNumRecherche.Text = "Rechercher";
            this.btnRevuesNumRecherche.UseVisualStyleBackColor = true;
            this.btnRevuesNumRecherche.Click += new System.EventHandler(this.btnRevuesNumRecherche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Saisir un numéro de document :";
            // 
            // txbRevuesNumRecherche
            // 
            this.txbRevuesNumRecherche.Location = new System.Drawing.Point(293, 74);
            this.txbRevuesNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesNumRecherche.Name = "txbRevuesNumRecherche";
            this.txbRevuesNumRecherche.Size = new System.Drawing.Size(88, 22);
            this.txbRevuesNumRecherche.TabIndex = 12;
            // 
            // btnRevuesAnnulGenres
            // 
            this.btnRevuesAnnulGenres.Location = new System.Drawing.Point(1111, 21);
            this.btnRevuesAnnulGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevuesAnnulGenres.Name = "btnRevuesAnnulGenres";
            this.btnRevuesAnnulGenres.Size = new System.Drawing.Size(29, 27);
            this.btnRevuesAnnulGenres.TabIndex = 11;
            this.btnRevuesAnnulGenres.Text = "X";
            this.btnRevuesAnnulGenres.UseVisualStyleBackColor = true;
            this.btnRevuesAnnulGenres.Click += new System.EventHandler(this.btnRevuesAnnulGenres_Click);
            // 
            // cbxRevuesRayons
            // 
            this.cbxRevuesRayons.FormattingEnabled = true;
            this.cbxRevuesRayons.Location = new System.Drawing.Point(827, 129);
            this.cbxRevuesRayons.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRevuesRayons.Name = "cbxRevuesRayons";
            this.cbxRevuesRayons.Size = new System.Drawing.Size(275, 24);
            this.cbxRevuesRayons.TabIndex = 10;
            this.cbxRevuesRayons.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesRayons_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ou sélectionner le rayon :";
            // 
            // cbxRevuesPublics
            // 
            this.cbxRevuesPublics.FormattingEnabled = true;
            this.cbxRevuesPublics.Location = new System.Drawing.Point(827, 74);
            this.cbxRevuesPublics.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRevuesPublics.Name = "cbxRevuesPublics";
            this.cbxRevuesPublics.Size = new System.Drawing.Size(275, 24);
            this.cbxRevuesPublics.TabIndex = 8;
            this.cbxRevuesPublics.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesPublics_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(611, 78);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(199, 17);
            this.label32.TabIndex = 7;
            this.label32.Text = "Ou sélectionner le public :";
            // 
            // cbxRevuesGenres
            // 
            this.cbxRevuesGenres.FormattingEnabled = true;
            this.cbxRevuesGenres.Location = new System.Drawing.Point(827, 22);
            this.cbxRevuesGenres.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRevuesGenres.Name = "cbxRevuesGenres";
            this.cbxRevuesGenres.Size = new System.Drawing.Size(275, 24);
            this.cbxRevuesGenres.TabIndex = 6;
            this.cbxRevuesGenres.SelectedIndexChanged += new System.EventHandler(this.cbxRevuesGenres_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(613, 26);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(198, 17);
            this.label33.TabIndex = 5;
            this.label33.Text = "Ou sélectionner le genre :";
            // 
            // dgvRevuesListe
            // 
            this.dgvRevuesListe.AllowUserToAddRows = false;
            this.dgvRevuesListe.AllowUserToDeleteRows = false;
            this.dgvRevuesListe.AllowUserToResizeColumns = false;
            this.dgvRevuesListe.AllowUserToResizeRows = false;
            this.dgvRevuesListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevuesListe.Location = new System.Drawing.Point(12, 185);
            this.dgvRevuesListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRevuesListe.MultiSelect = false;
            this.dgvRevuesListe.Name = "dgvRevuesListe";
            this.dgvRevuesListe.ReadOnly = true;
            this.dgvRevuesListe.RowHeadersVisible = false;
            this.dgvRevuesListe.RowHeadersWidth = 51;
            this.dgvRevuesListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevuesListe.Size = new System.Drawing.Size(1125, 246);
            this.dgvRevuesListe.TabIndex = 4;
            this.dgvRevuesListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRevuesListe_ColumnHeaderMouseClick);
            this.dgvRevuesListe.SelectionChanged += new System.EventHandler(this.dgvRevuesListe_SelectionChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(8, 26);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(269, 17);
            this.label34.TabIndex = 2;
            this.label34.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // txbRevuesTitreRecherche
            // 
            this.txbRevuesTitreRecherche.Location = new System.Drawing.Point(293, 22);
            this.txbRevuesTitreRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbRevuesTitreRecherche.Name = "txbRevuesTitreRecherche";
            this.txbRevuesTitreRecherche.Size = new System.Drawing.Size(252, 22);
            this.txbRevuesTitreRecherche.TabIndex = 3;
            this.txbRevuesTitreRecherche.TextChanged += new System.EventHandler(this.TxbRevuesTitreRecherche_TextChanged);
            // 
            // tabDvd
            // 
            this.tabDvd.Controls.Add(this.grpDvdInfos);
            this.tabDvd.Controls.Add(this.grpDvdRecherche);
            this.tabDvd.Location = new System.Drawing.Point(4, 22);
            this.tabDvd.Margin = new System.Windows.Forms.Padding(4);
            this.tabDvd.Name = "tabDvd";
            this.tabDvd.Size = new System.Drawing.Size(1169, 785);
            this.tabDvd.TabIndex = 3;
            this.tabDvd.Text = "DVD";
            this.tabDvd.UseVisualStyleBackColor = true;
            this.tabDvd.Enter += new System.EventHandler(this.tabDvd_Enter);
            // 
            // grpDvdInfos
            // 
            this.grpDvdInfos.Controls.Add(this.label58);
            this.grpDvdInfos.Controls.Add(this.txbDvdDuree);
            this.grpDvdInfos.Controls.Add(this.txbDvdImage);
            this.grpDvdInfos.Controls.Add(this.txbDvdRayon);
            this.grpDvdInfos.Controls.Add(this.txbDvdPublic);
            this.grpDvdInfos.Controls.Add(this.txbDvdGenre);
            this.grpDvdInfos.Controls.Add(this.txbDvdSynopsis);
            this.grpDvdInfos.Controls.Add(this.txbDvdRealisateur);
            this.grpDvdInfos.Controls.Add(this.txbDvdTitre);
            this.grpDvdInfos.Controls.Add(this.txbDvdNumero);
            this.grpDvdInfos.Controls.Add(this.label23);
            this.grpDvdInfos.Controls.Add(this.pcbDvdImage);
            this.grpDvdInfos.Controls.Add(this.label24);
            this.grpDvdInfos.Controls.Add(this.label25);
            this.grpDvdInfos.Controls.Add(this.label26);
            this.grpDvdInfos.Controls.Add(this.label27);
            this.grpDvdInfos.Controls.Add(this.label28);
            this.grpDvdInfos.Controls.Add(this.label29);
            this.grpDvdInfos.Controls.Add(this.label30);
            this.grpDvdInfos.Controls.Add(this.label31);
            this.grpDvdInfos.Location = new System.Drawing.Point(11, 469);
            this.grpDvdInfos.Margin = new System.Windows.Forms.Padding(4);
            this.grpDvdInfos.Name = "grpDvdInfos";
            this.grpDvdInfos.Padding = new System.Windows.Forms.Padding(4);
            this.grpDvdInfos.Size = new System.Drawing.Size(1145, 302);
            this.grpDvdInfos.TabIndex = 21;
            this.grpDvdInfos.TabStop = false;
            this.grpDvdInfos.Text = "Informations détaillées";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(743, 14);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(61, 17);
            this.label58.TabIndex = 33;
            this.label58.Text = "Image :";
            // 
            // txbDvdDuree
            // 
            this.txbDvdDuree.Location = new System.Drawing.Point(588, 25);
            this.txbDvdDuree.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdDuree.Name = "txbDvdDuree";
            this.txbDvdDuree.ReadOnly = true;
            this.txbDvdDuree.Size = new System.Drawing.Size(132, 22);
            this.txbDvdDuree.TabIndex = 32;
            // 
            // txbDvdImage
            // 
            this.txbDvdImage.Location = new System.Drawing.Point(200, 265);
            this.txbDvdImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdImage.Name = "txbDvdImage";
            this.txbDvdImage.ReadOnly = true;
            this.txbDvdImage.Size = new System.Drawing.Size(520, 22);
            this.txbDvdImage.TabIndex = 31;
            // 
            // txbDvdRayon
            // 
            this.txbDvdRayon.Location = new System.Drawing.Point(200, 234);
            this.txbDvdRayon.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdRayon.Name = "txbDvdRayon";
            this.txbDvdRayon.ReadOnly = true;
            this.txbDvdRayon.Size = new System.Drawing.Size(275, 22);
            this.txbDvdRayon.TabIndex = 30;
            // 
            // txbDvdPublic
            // 
            this.txbDvdPublic.Location = new System.Drawing.Point(200, 203);
            this.txbDvdPublic.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdPublic.Name = "txbDvdPublic";
            this.txbDvdPublic.ReadOnly = true;
            this.txbDvdPublic.Size = new System.Drawing.Size(275, 22);
            this.txbDvdPublic.TabIndex = 29;
            // 
            // txbDvdGenre
            // 
            this.txbDvdGenre.Location = new System.Drawing.Point(200, 172);
            this.txbDvdGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdGenre.Name = "txbDvdGenre";
            this.txbDvdGenre.ReadOnly = true;
            this.txbDvdGenre.Size = new System.Drawing.Size(275, 22);
            this.txbDvdGenre.TabIndex = 28;
            // 
            // txbDvdSynopsis
            // 
            this.txbDvdSynopsis.AcceptsReturn = true;
            this.txbDvdSynopsis.Location = new System.Drawing.Point(200, 117);
            this.txbDvdSynopsis.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdSynopsis.Multiline = true;
            this.txbDvdSynopsis.Name = "txbDvdSynopsis";
            this.txbDvdSynopsis.ReadOnly = true;
            this.txbDvdSynopsis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDvdSynopsis.Size = new System.Drawing.Size(520, 47);
            this.txbDvdSynopsis.TabIndex = 27;
            // 
            // txbDvdRealisateur
            // 
            this.txbDvdRealisateur.Location = new System.Drawing.Point(200, 86);
            this.txbDvdRealisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdRealisateur.Name = "txbDvdRealisateur";
            this.txbDvdRealisateur.ReadOnly = true;
            this.txbDvdRealisateur.Size = new System.Drawing.Size(275, 22);
            this.txbDvdRealisateur.TabIndex = 26;
            // 
            // txbDvdTitre
            // 
            this.txbDvdTitre.Location = new System.Drawing.Point(200, 55);
            this.txbDvdTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdTitre.Name = "txbDvdTitre";
            this.txbDvdTitre.ReadOnly = true;
            this.txbDvdTitre.Size = new System.Drawing.Size(520, 22);
            this.txbDvdTitre.TabIndex = 25;
            // 
            // txbDvdNumero
            // 
            this.txbDvdNumero.Location = new System.Drawing.Point(200, 25);
            this.txbDvdNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdNumero.Name = "txbDvdNumero";
            this.txbDvdNumero.ReadOnly = true;
            this.txbDvdNumero.Size = new System.Drawing.Size(132, 22);
            this.txbDvdNumero.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 172);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Genre :";
            // 
            // pcbDvdImage
            // 
            this.pcbDvdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbDvdImage.Location = new System.Drawing.Point(747, 33);
            this.pcbDvdImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDvdImage.Name = "pcbDvdImage";
            this.pcbDvdImage.Size = new System.Drawing.Size(378, 258);
            this.pcbDvdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDvdImage.TabIndex = 21;
            this.pcbDvdImage.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 203);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 17);
            this.label24.TabIndex = 19;
            this.label24.Text = "Public :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(8, 234);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 17);
            this.label25.TabIndex = 17;
            this.label25.Text = "Rayon :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(8, 55);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 17);
            this.label26.TabIndex = 8;
            this.label26.Text = "Titre :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 25);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(172, 17);
            this.label27.TabIndex = 5;
            this.label27.Text = "Numéro de document :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(8, 86);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(145, 17);
            this.label28.TabIndex = 9;
            this.label28.Text = "Réalisateur(trice) :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(8, 265);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 17);
            this.label29.TabIndex = 6;
            this.label29.Text = "Chemin de l\'image :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 117);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 17);
            this.label30.TabIndex = 10;
            this.label30.Text = "Synopsis :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(476, 25);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(62, 17);
            this.label31.TabIndex = 7;
            this.label31.Text = "Durée :";
            // 
            // grpDvdRecherche
            // 
            this.grpDvdRecherche.Controls.Add(this.BtnDVDSupprimer);
            this.grpDvdRecherche.Controls.Add(this.BtnDVDModifier);
            this.grpDvdRecherche.Controls.Add(this.BtnDVDAjouter);
            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulRayons);
            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulPublics);
            this.grpDvdRecherche.Controls.Add(this.btnDvdNumRecherche);
            this.grpDvdRecherche.Controls.Add(this.label38);
            this.grpDvdRecherche.Controls.Add(this.txbDvdNumRecherche);
            this.grpDvdRecherche.Controls.Add(this.btnDvdAnnulGenres);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdRayons);
            this.grpDvdRecherche.Controls.Add(this.label39);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdPublics);
            this.grpDvdRecherche.Controls.Add(this.label40);
            this.grpDvdRecherche.Controls.Add(this.cbxDvdGenres);
            this.grpDvdRecherche.Controls.Add(this.label41);
            this.grpDvdRecherche.Controls.Add(this.dgvDvdListe);
            this.grpDvdRecherche.Controls.Add(this.label42);
            this.grpDvdRecherche.Controls.Add(this.txbDvdTitreRecherche);
            this.grpDvdRecherche.Location = new System.Drawing.Point(11, 16);
            this.grpDvdRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.grpDvdRecherche.Name = "grpDvdRecherche";
            this.grpDvdRecherche.Padding = new System.Windows.Forms.Padding(4);
            this.grpDvdRecherche.Size = new System.Drawing.Size(1145, 446);
            this.grpDvdRecherche.TabIndex = 20;
            this.grpDvdRecherche.TabStop = false;
            this.grpDvdRecherche.Text = "Recherches";
            // 
            // BtnDVDSupprimer
            // 
            this.BtnDVDSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDVDSupprimer.Location = new System.Drawing.Point(403, 133);
            this.BtnDVDSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDVDSupprimer.Name = "BtnDVDSupprimer";
            this.BtnDVDSupprimer.Size = new System.Drawing.Size(184, 27);
            this.BtnDVDSupprimer.TabIndex = 19;
            this.BtnDVDSupprimer.Text = "Supprimer un DVD";
            this.BtnDVDSupprimer.UseVisualStyleBackColor = true;
            this.BtnDVDSupprimer.Click += new System.EventHandler(this.BtnDvdSupprimer_Click);
            // 
            // BtnDVDModifier
            // 
            this.BtnDVDModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDVDModifier.Location = new System.Drawing.Point(229, 133);
            this.BtnDVDModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDVDModifier.Name = "BtnDVDModifier";
            this.BtnDVDModifier.Size = new System.Drawing.Size(166, 27);
            this.BtnDVDModifier.TabIndex = 18;
            this.BtnDVDModifier.Text = "Modifier un DVD";
            this.BtnDVDModifier.UseVisualStyleBackColor = true;
            this.BtnDVDModifier.Click += new System.EventHandler(this.BtnDvdModifier_Click);
            // 
            // BtnDVDAjouter
            // 
            this.BtnDVDAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDVDAjouter.Location = new System.Drawing.Point(74, 133);
            this.BtnDVDAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDVDAjouter.Name = "BtnDVDAjouter";
            this.BtnDVDAjouter.Size = new System.Drawing.Size(147, 27);
            this.BtnDVDAjouter.TabIndex = 17;
            this.BtnDVDAjouter.Text = "Ajouter un DVD";
            this.BtnDVDAjouter.UseVisualStyleBackColor = true;
            this.BtnDVDAjouter.Click += new System.EventHandler(this.BtnDvdAjouter_Click);
            // 
            // btnDvdAnnulRayons
            // 
            this.btnDvdAnnulRayons.Location = new System.Drawing.Point(1111, 128);
            this.btnDvdAnnulRayons.Margin = new System.Windows.Forms.Padding(4);
            this.btnDvdAnnulRayons.Name = "btnDvdAnnulRayons";
            this.btnDvdAnnulRayons.Size = new System.Drawing.Size(29, 27);
            this.btnDvdAnnulRayons.TabIndex = 16;
            this.btnDvdAnnulRayons.Text = "X";
            this.btnDvdAnnulRayons.UseVisualStyleBackColor = true;
            this.btnDvdAnnulRayons.Click += new System.EventHandler(this.btnDvdAnnulRayons_Click);
            // 
            // btnDvdAnnulPublics
            // 
            this.btnDvdAnnulPublics.Location = new System.Drawing.Point(1111, 74);
            this.btnDvdAnnulPublics.Margin = new System.Windows.Forms.Padding(4);
            this.btnDvdAnnulPublics.Name = "btnDvdAnnulPublics";
            this.btnDvdAnnulPublics.Size = new System.Drawing.Size(29, 27);
            this.btnDvdAnnulPublics.TabIndex = 15;
            this.btnDvdAnnulPublics.Text = "X";
            this.btnDvdAnnulPublics.UseVisualStyleBackColor = true;
            this.btnDvdAnnulPublics.Click += new System.EventHandler(this.btnDvdAnnulPublics_Click);
            // 
            // btnDvdNumRecherche
            // 
            this.btnDvdNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDvdNumRecherche.Location = new System.Drawing.Point(419, 73);
            this.btnDvdNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnDvdNumRecherche.Name = "btnDvdNumRecherche";
            this.btnDvdNumRecherche.Size = new System.Drawing.Size(128, 27);
            this.btnDvdNumRecherche.TabIndex = 14;
            this.btnDvdNumRecherche.Text = "Rechercher";
            this.btnDvdNumRecherche.UseVisualStyleBackColor = true;
            this.btnDvdNumRecherche.Click += new System.EventHandler(this.btnDvdNumRecherche_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(8, 78);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(239, 17);
            this.label38.TabIndex = 13;
            this.label38.Text = "Saisir un numéro de document :";
            // 
            // txbDvdNumRecherche
            // 
            this.txbDvdNumRecherche.Location = new System.Drawing.Point(293, 74);
            this.txbDvdNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdNumRecherche.Name = "txbDvdNumRecherche";
            this.txbDvdNumRecherche.Size = new System.Drawing.Size(88, 22);
            this.txbDvdNumRecherche.TabIndex = 12;
            // 
            // btnDvdAnnulGenres
            // 
            this.btnDvdAnnulGenres.Location = new System.Drawing.Point(1111, 21);
            this.btnDvdAnnulGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnDvdAnnulGenres.Name = "btnDvdAnnulGenres";
            this.btnDvdAnnulGenres.Size = new System.Drawing.Size(29, 27);
            this.btnDvdAnnulGenres.TabIndex = 11;
            this.btnDvdAnnulGenres.Text = "X";
            this.btnDvdAnnulGenres.UseVisualStyleBackColor = true;
            this.btnDvdAnnulGenres.Click += new System.EventHandler(this.btnDvdAnnulGenres_Click);
            // 
            // cbxDvdRayons
            // 
            this.cbxDvdRayons.FormattingEnabled = true;
            this.cbxDvdRayons.Location = new System.Drawing.Point(827, 129);
            this.cbxDvdRayons.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDvdRayons.Name = "cbxDvdRayons";
            this.cbxDvdRayons.Size = new System.Drawing.Size(275, 24);
            this.cbxDvdRayons.TabIndex = 10;
            this.cbxDvdRayons.SelectedIndexChanged += new System.EventHandler(this.cbxDvdRayons_SelectedIndexChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(611, 133);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(197, 17);
            this.label39.TabIndex = 9;
            this.label39.Text = "Ou sélectionner le rayon :";
            // 
            // cbxDvdPublics
            // 
            this.cbxDvdPublics.FormattingEnabled = true;
            this.cbxDvdPublics.Location = new System.Drawing.Point(827, 74);
            this.cbxDvdPublics.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDvdPublics.Name = "cbxDvdPublics";
            this.cbxDvdPublics.Size = new System.Drawing.Size(275, 24);
            this.cbxDvdPublics.TabIndex = 8;
            this.cbxDvdPublics.SelectedIndexChanged += new System.EventHandler(this.cbxDvdPublics_SelectedIndexChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(611, 78);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(199, 17);
            this.label40.TabIndex = 7;
            this.label40.Text = "Ou sélectionner le public :";
            // 
            // cbxDvdGenres
            // 
            this.cbxDvdGenres.FormattingEnabled = true;
            this.cbxDvdGenres.Location = new System.Drawing.Point(827, 22);
            this.cbxDvdGenres.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDvdGenres.Name = "cbxDvdGenres";
            this.cbxDvdGenres.Size = new System.Drawing.Size(275, 24);
            this.cbxDvdGenres.TabIndex = 6;
            this.cbxDvdGenres.SelectedIndexChanged += new System.EventHandler(this.cbxDvdGenres_SelectedIndexChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(613, 26);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(198, 17);
            this.label41.TabIndex = 5;
            this.label41.Text = "Ou sélectionner le genre :";
            // 
            // dgvDvdListe
            // 
            this.dgvDvdListe.AllowUserToAddRows = false;
            this.dgvDvdListe.AllowUserToDeleteRows = false;
            this.dgvDvdListe.AllowUserToResizeColumns = false;
            this.dgvDvdListe.AllowUserToResizeRows = false;
            this.dgvDvdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvdListe.Location = new System.Drawing.Point(12, 185);
            this.dgvDvdListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDvdListe.MultiSelect = false;
            this.dgvDvdListe.Name = "dgvDvdListe";
            this.dgvDvdListe.ReadOnly = true;
            this.dgvDvdListe.RowHeadersVisible = false;
            this.dgvDvdListe.RowHeadersWidth = 51;
            this.dgvDvdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDvdListe.Size = new System.Drawing.Size(1125, 246);
            this.dgvDvdListe.TabIndex = 4;
            this.dgvDvdListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDvdListe_ColumnHeaderMouseClick);
            this.dgvDvdListe.SelectionChanged += new System.EventHandler(this.dgvDvdListe_SelectionChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(8, 26);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(269, 17);
            this.label42.TabIndex = 2;
            this.label42.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // txbDvdTitreRecherche
            // 
            this.txbDvdTitreRecherche.Location = new System.Drawing.Point(293, 22);
            this.txbDvdTitreRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbDvdTitreRecherche.Name = "txbDvdTitreRecherche";
            this.txbDvdTitreRecherche.Size = new System.Drawing.Size(252, 22);
            this.txbDvdTitreRecherche.TabIndex = 3;
            this.txbDvdTitreRecherche.TextChanged += new System.EventHandler(this.TxbDvdTitreRecherche_TextChanged);
            // 
            // tabLivres
            // 
            this.tabLivres.Controls.Add(this.grpLivresInfos);
            this.tabLivres.Controls.Add(this.grpLivresRecherche);
            this.tabLivres.Location = new System.Drawing.Point(4, 22);
            this.tabLivres.Margin = new System.Windows.Forms.Padding(4);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(1169, 785);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.TabLivres_Enter);
            // 
            // grpLivresInfos
            // 
            this.grpLivresInfos.Controls.Add(this.label59);
            this.grpLivresInfos.Controls.Add(this.txbLivresIsbn);
            this.grpLivresInfos.Controls.Add(this.txbLivresImage);
            this.grpLivresInfos.Controls.Add(this.txbLivresRayon);
            this.grpLivresInfos.Controls.Add(this.txbLivresPublic);
            this.grpLivresInfos.Controls.Add(this.txbLivresGenre);
            this.grpLivresInfos.Controls.Add(this.txbLivresCollection);
            this.grpLivresInfos.Controls.Add(this.txbLivresAuteur);
            this.grpLivresInfos.Controls.Add(this.txbLivresTitre);
            this.grpLivresInfos.Controls.Add(this.txbLivresNumero);
            this.grpLivresInfos.Controls.Add(this.label22);
            this.grpLivresInfos.Controls.Add(this.pcbLivresImage);
            this.grpLivresInfos.Controls.Add(this.label19);
            this.grpLivresInfos.Controls.Add(this.label1);
            this.grpLivresInfos.Controls.Add(this.label10);
            this.grpLivresInfos.Controls.Add(this.label7);
            this.grpLivresInfos.Controls.Add(this.label11);
            this.grpLivresInfos.Controls.Add(this.label8);
            this.grpLivresInfos.Controls.Add(this.label12);
            this.grpLivresInfos.Controls.Add(this.label9);
            this.grpLivresInfos.Location = new System.Drawing.Point(11, 469);
            this.grpLivresInfos.Margin = new System.Windows.Forms.Padding(4);
            this.grpLivresInfos.Name = "grpLivresInfos";
            this.grpLivresInfos.Padding = new System.Windows.Forms.Padding(4);
            this.grpLivresInfos.Size = new System.Drawing.Size(1145, 302);
            this.grpLivresInfos.TabIndex = 19;
            this.grpLivresInfos.TabStop = false;
            this.grpLivresInfos.Text = "Informations détaillées";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(743, 14);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(61, 17);
            this.label59.TabIndex = 33;
            this.label59.Text = "Image :";
            // 
            // txbLivresIsbn
            // 
            this.txbLivresIsbn.Location = new System.Drawing.Point(588, 25);
            this.txbLivresIsbn.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresIsbn.Name = "txbLivresIsbn";
            this.txbLivresIsbn.ReadOnly = true;
            this.txbLivresIsbn.Size = new System.Drawing.Size(132, 22);
            this.txbLivresIsbn.TabIndex = 32;
            // 
            // txbLivresImage
            // 
            this.txbLivresImage.Location = new System.Drawing.Point(200, 240);
            this.txbLivresImage.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresImage.Name = "txbLivresImage";
            this.txbLivresImage.ReadOnly = true;
            this.txbLivresImage.Size = new System.Drawing.Size(520, 22);
            this.txbLivresImage.TabIndex = 31;
            // 
            // txbLivresRayon
            // 
            this.txbLivresRayon.Location = new System.Drawing.Point(200, 209);
            this.txbLivresRayon.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresRayon.Name = "txbLivresRayon";
            this.txbLivresRayon.ReadOnly = true;
            this.txbLivresRayon.Size = new System.Drawing.Size(275, 22);
            this.txbLivresRayon.TabIndex = 30;
            // 
            // txbLivresPublic
            // 
            this.txbLivresPublic.Location = new System.Drawing.Point(200, 178);
            this.txbLivresPublic.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresPublic.Name = "txbLivresPublic";
            this.txbLivresPublic.ReadOnly = true;
            this.txbLivresPublic.Size = new System.Drawing.Size(275, 22);
            this.txbLivresPublic.TabIndex = 29;
            // 
            // txbLivresGenre
            // 
            this.txbLivresGenre.Location = new System.Drawing.Point(200, 148);
            this.txbLivresGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresGenre.Name = "txbLivresGenre";
            this.txbLivresGenre.ReadOnly = true;
            this.txbLivresGenre.Size = new System.Drawing.Size(275, 22);
            this.txbLivresGenre.TabIndex = 28;
            // 
            // txbLivresCollection
            // 
            this.txbLivresCollection.Location = new System.Drawing.Point(200, 117);
            this.txbLivresCollection.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresCollection.Name = "txbLivresCollection";
            this.txbLivresCollection.ReadOnly = true;
            this.txbLivresCollection.Size = new System.Drawing.Size(520, 22);
            this.txbLivresCollection.TabIndex = 27;
            // 
            // txbLivresAuteur
            // 
            this.txbLivresAuteur.Location = new System.Drawing.Point(200, 86);
            this.txbLivresAuteur.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresAuteur.Name = "txbLivresAuteur";
            this.txbLivresAuteur.ReadOnly = true;
            this.txbLivresAuteur.Size = new System.Drawing.Size(275, 22);
            this.txbLivresAuteur.TabIndex = 26;
            // 
            // txbLivresTitre
            // 
            this.txbLivresTitre.Location = new System.Drawing.Point(200, 55);
            this.txbLivresTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresTitre.Name = "txbLivresTitre";
            this.txbLivresTitre.ReadOnly = true;
            this.txbLivresTitre.Size = new System.Drawing.Size(520, 22);
            this.txbLivresTitre.TabIndex = 25;
            // 
            // txbLivresNumero
            // 
            this.txbLivresNumero.Location = new System.Drawing.Point(200, 25);
            this.txbLivresNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresNumero.Name = "txbLivresNumero";
            this.txbLivresNumero.ReadOnly = true;
            this.txbLivresNumero.Size = new System.Drawing.Size(132, 22);
            this.txbLivresNumero.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 148);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "Genre :";
            // 
            // pcbLivresImage
            // 
            this.pcbLivresImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbLivresImage.Location = new System.Drawing.Point(747, 33);
            this.pcbLivresImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLivresImage.Name = "pcbLivresImage";
            this.pcbLivresImage.Size = new System.Drawing.Size(378, 258);
            this.pcbLivresImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLivresImage.TabIndex = 21;
            this.pcbLivresImage.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 178);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 19;
            this.label19.Text = "Public :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rayon :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Titre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Numéro de document :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Auteur(e) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Chemin de l\'image :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Collection :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(476, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Code ISBN :";
            // 
            // grpLivresRecherche
            // 
            this.grpLivresRecherche.Controls.Add(this.BtnLivresSupprimer);
            this.grpLivresRecherche.Controls.Add(this.BtnLivresModifier);
            this.grpLivresRecherche.Controls.Add(this.BtnLivresAjouter);
            this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulRayons);
            this.grpLivresRecherche.Controls.Add(this.btnlivresAnnulPublics);
            this.grpLivresRecherche.Controls.Add(this.btnLivresNumRecherche);
            this.grpLivresRecherche.Controls.Add(this.label5);
            this.grpLivresRecherche.Controls.Add(this.txbLivresNumRecherche);
            this.grpLivresRecherche.Controls.Add(this.btnLivresAnnulGenres);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresRayons);
            this.grpLivresRecherche.Controls.Add(this.label21);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresPublics);
            this.grpLivresRecherche.Controls.Add(this.label20);
            this.grpLivresRecherche.Controls.Add(this.cbxLivresGenres);
            this.grpLivresRecherche.Controls.Add(this.label14);
            this.grpLivresRecherche.Controls.Add(this.dgvLivresListe);
            this.grpLivresRecherche.Controls.Add(this.label6);
            this.grpLivresRecherche.Controls.Add(this.txbLivresTitreRecherche);
            this.grpLivresRecherche.Location = new System.Drawing.Point(11, 16);
            this.grpLivresRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.grpLivresRecherche.Name = "grpLivresRecherche";
            this.grpLivresRecherche.Padding = new System.Windows.Forms.Padding(4);
            this.grpLivresRecherche.Size = new System.Drawing.Size(1145, 446);
            this.grpLivresRecherche.TabIndex = 18;
            this.grpLivresRecherche.TabStop = false;
            this.grpLivresRecherche.Text = "Recherches";
            // 
            // BtnLivresSupprimer
            // 
            this.BtnLivresSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivresSupprimer.Location = new System.Drawing.Point(403, 133);
            this.BtnLivresSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLivresSupprimer.Name = "BtnLivresSupprimer";
            this.BtnLivresSupprimer.Size = new System.Drawing.Size(181, 27);
            this.BtnLivresSupprimer.TabIndex = 19;
            this.BtnLivresSupprimer.Text = "Supprimer un Livre";
            this.BtnLivresSupprimer.UseVisualStyleBackColor = true;
            this.BtnLivresSupprimer.Click += new System.EventHandler(this.BtnLivresSupprimer_Click);
            // 
            // BtnLivresModifier
            // 
            this.BtnLivresModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivresModifier.Location = new System.Drawing.Point(239, 133);
            this.BtnLivresModifier.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLivresModifier.Name = "BtnLivresModifier";
            this.BtnLivresModifier.Size = new System.Drawing.Size(156, 27);
            this.BtnLivresModifier.TabIndex = 18;
            this.BtnLivresModifier.Text = "Modifier un Livre";
            this.BtnLivresModifier.UseVisualStyleBackColor = true;
            this.BtnLivresModifier.Click += new System.EventHandler(this.BtnLivresModifier_Click);
            // 
            // BtnLivresAjouter
            // 
            this.BtnLivresAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivresAjouter.Location = new System.Drawing.Point(86, 133);
            this.BtnLivresAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLivresAjouter.Name = "BtnLivresAjouter";
            this.BtnLivresAjouter.Size = new System.Drawing.Size(145, 27);
            this.BtnLivresAjouter.TabIndex = 17;
            this.BtnLivresAjouter.Text = "Ajouter un Livre";
            this.BtnLivresAjouter.UseVisualStyleBackColor = true;
            this.BtnLivresAjouter.Click += new System.EventHandler(this.BtnLivresAjouter_Click);
            // 
            // btnLivresAnnulRayons
            // 
            this.btnLivresAnnulRayons.Location = new System.Drawing.Point(1111, 128);
            this.btnLivresAnnulRayons.Margin = new System.Windows.Forms.Padding(4);
            this.btnLivresAnnulRayons.Name = "btnLivresAnnulRayons";
            this.btnLivresAnnulRayons.Size = new System.Drawing.Size(29, 27);
            this.btnLivresAnnulRayons.TabIndex = 16;
            this.btnLivresAnnulRayons.Text = "X";
            this.btnLivresAnnulRayons.UseVisualStyleBackColor = true;
            this.btnLivresAnnulRayons.Click += new System.EventHandler(this.BtnLivresAnnulRayons_Click);
            // 
            // btnlivresAnnulPublics
            // 
            this.btnlivresAnnulPublics.Location = new System.Drawing.Point(1111, 74);
            this.btnlivresAnnulPublics.Margin = new System.Windows.Forms.Padding(4);
            this.btnlivresAnnulPublics.Name = "btnlivresAnnulPublics";
            this.btnlivresAnnulPublics.Size = new System.Drawing.Size(29, 27);
            this.btnlivresAnnulPublics.TabIndex = 15;
            this.btnlivresAnnulPublics.Text = "X";
            this.btnlivresAnnulPublics.UseVisualStyleBackColor = true;
            this.btnlivresAnnulPublics.Click += new System.EventHandler(this.BtnLivresAnnulPublics_Click);
            // 
            // btnLivresNumRecherche
            // 
            this.btnLivresNumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivresNumRecherche.Location = new System.Drawing.Point(419, 73);
            this.btnLivresNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.btnLivresNumRecherche.Name = "btnLivresNumRecherche";
            this.btnLivresNumRecherche.Size = new System.Drawing.Size(128, 27);
            this.btnLivresNumRecherche.TabIndex = 14;
            this.btnLivresNumRecherche.Text = "Rechercher";
            this.btnLivresNumRecherche.UseVisualStyleBackColor = true;
            this.btnLivresNumRecherche.Click += new System.EventHandler(this.BtnLivresNumRecherche_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saisir un numéro de document :";
            // 
            // txbLivresNumRecherche
            // 
            this.txbLivresNumRecherche.Location = new System.Drawing.Point(293, 74);
            this.txbLivresNumRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresNumRecherche.Name = "txbLivresNumRecherche";
            this.txbLivresNumRecherche.Size = new System.Drawing.Size(88, 22);
            this.txbLivresNumRecherche.TabIndex = 12;
            // 
            // btnLivresAnnulGenres
            // 
            this.btnLivresAnnulGenres.Location = new System.Drawing.Point(1111, 21);
            this.btnLivresAnnulGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnLivresAnnulGenres.Name = "btnLivresAnnulGenres";
            this.btnLivresAnnulGenres.Size = new System.Drawing.Size(29, 27);
            this.btnLivresAnnulGenres.TabIndex = 11;
            this.btnLivresAnnulGenres.Text = "X";
            this.btnLivresAnnulGenres.UseVisualStyleBackColor = true;
            this.btnLivresAnnulGenres.Click += new System.EventHandler(this.BtnLivresAnnulGenres_Click);
            // 
            // cbxLivresRayons
            // 
            this.cbxLivresRayons.FormattingEnabled = true;
            this.cbxLivresRayons.Location = new System.Drawing.Point(827, 129);
            this.cbxLivresRayons.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLivresRayons.Name = "cbxLivresRayons";
            this.cbxLivresRayons.Size = new System.Drawing.Size(275, 24);
            this.cbxLivresRayons.TabIndex = 10;
            this.cbxLivresRayons.SelectedIndexChanged += new System.EventHandler(this.CbxLivresRayons_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(611, 133);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 17);
            this.label21.TabIndex = 9;
            this.label21.Text = "Ou sélectionner le rayon :";
            // 
            // cbxLivresPublics
            // 
            this.cbxLivresPublics.FormattingEnabled = true;
            this.cbxLivresPublics.Location = new System.Drawing.Point(827, 74);
            this.cbxLivresPublics.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLivresPublics.Name = "cbxLivresPublics";
            this.cbxLivresPublics.Size = new System.Drawing.Size(275, 24);
            this.cbxLivresPublics.TabIndex = 8;
            this.cbxLivresPublics.SelectedIndexChanged += new System.EventHandler(this.CbxLivresPublics_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(611, 78);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(199, 17);
            this.label20.TabIndex = 7;
            this.label20.Text = "Ou sélectionner le public :";
            // 
            // cbxLivresGenres
            // 
            this.cbxLivresGenres.FormattingEnabled = true;
            this.cbxLivresGenres.Location = new System.Drawing.Point(827, 22);
            this.cbxLivresGenres.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLivresGenres.Name = "cbxLivresGenres";
            this.cbxLivresGenres.Size = new System.Drawing.Size(275, 24);
            this.cbxLivresGenres.TabIndex = 6;
            this.cbxLivresGenres.SelectedIndexChanged += new System.EventHandler(this.CbxLivresGenres_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(613, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ou sélectionner le genre :";
            // 
            // dgvLivresListe
            // 
            this.dgvLivresListe.AllowUserToAddRows = false;
            this.dgvLivresListe.AllowUserToDeleteRows = false;
            this.dgvLivresListe.AllowUserToResizeColumns = false;
            this.dgvLivresListe.AllowUserToResizeRows = false;
            this.dgvLivresListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivresListe.Location = new System.Drawing.Point(12, 185);
            this.dgvLivresListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLivresListe.MultiSelect = false;
            this.dgvLivresListe.Name = "dgvLivresListe";
            this.dgvLivresListe.ReadOnly = true;
            this.dgvLivresListe.RowHeadersVisible = false;
            this.dgvLivresListe.RowHeadersWidth = 51;
            this.dgvLivresListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivresListe.Size = new System.Drawing.Size(1125, 246);
            this.dgvLivresListe.TabIndex = 4;
            this.dgvLivresListe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLivresListe_ColumnHeaderMouseClick);
            this.dgvLivresListe.SelectionChanged += new System.EventHandler(this.DgvLivresListe_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // txbLivresTitreRecherche
            // 
            this.txbLivresTitreRecherche.Location = new System.Drawing.Point(293, 22);
            this.txbLivresTitreRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txbLivresTitreRecherche.Name = "txbLivresTitreRecherche";
            this.txbLivresTitreRecherche.Size = new System.Drawing.Size(252, 22);
            this.txbLivresTitreRecherche.TabIndex = 3;
            this.txbLivresTitreRecherche.TextChanged += new System.EventHandler(this.TxbLivresTitreRecherche_TextChanged);
            // 
            // tabOngletsApplication
            // 
            this.tabOngletsApplication.Controls.Add(this.tabLivres);
            this.tabOngletsApplication.Controls.Add(this.tabDvd);
            this.tabOngletsApplication.Controls.Add(this.tabRevues);
            this.tabOngletsApplication.Controls.Add(this.tabReceptionRevue);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesLivres);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesDvd);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesRevues);
            this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOngletsApplication.ItemSize = new System.Drawing.Size(49, 18);
            this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tabOngletsApplication.Margin = new System.Windows.Forms.Padding(4);
            this.tabOngletsApplication.Name = "tabOngletsApplication";
            this.tabOngletsApplication.SelectedIndex = 0;
            this.tabOngletsApplication.Size = new System.Drawing.Size(1177, 1061);
            this.tabOngletsApplication.TabIndex = 0;
            // 
            // FrmMediatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 1061);
            this.Controls.Add(this.tabOngletsApplication);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMediatek";
            this.Text = "Gestion des documents de la médiathèque";
            this.tabCommandesRevues.ResumeLayout(false);
            this.tabCommandesRevues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdRevue)).EndInit();
            this.tabCommandesDvd.ResumeLayout(false);
            this.tabCommandesDvd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCmdDvdNbEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdDvd)).EndInit();
            this.tabCommandesLivres.ResumeLayout(false);
            this.tabCommandesLivres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCmdLivreNbEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmdLivre)).EndInit();
            this.tabReceptionRevue.ResumeLayout(false);
            this.grpReceptionExemplaire.ResumeLayout(false);
            this.grpReceptionExemplaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireImage)).EndInit();
            this.grpReceptionRevue.ResumeLayout(false);
            this.grpReceptionRevue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionExemplaireRevueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionExemplairesListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceptionRevueImage)).EndInit();
            this.tabRevues.ResumeLayout(false);
            this.grpRevuesInfos.ResumeLayout(false);
            this.grpRevuesInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRevuesImage)).EndInit();
            this.grpRevuesRecherche.ResumeLayout(false);
            this.grpRevuesRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevuesListe)).EndInit();
            this.tabDvd.ResumeLayout(false);
            this.grpDvdInfos.ResumeLayout(false);
            this.grpDvdInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDvdImage)).EndInit();
            this.grpDvdRecherche.ResumeLayout(false);
            this.grpDvdRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvdListe)).EndInit();
            this.tabLivres.ResumeLayout(false);
            this.grpLivresInfos.ResumeLayout(false);
            this.grpLivresInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLivresImage)).EndInit();
            this.grpLivresRecherche.ResumeLayout(false);
            this.grpLivresRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivresListe)).EndInit();
            this.tabOngletsApplication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void TabCmdDvd_Enter(object sender, EventArgs e)
        {
            // Charger les suivis (une seule fois)
            if (lesSuivis == null || lesSuivis.Count == 0)
            {
                lesSuivis = controller.GetAllSuivis();
            }

            cbxCmdDvdSuivi.DataSource = null;
            cbxCmdDvdSuivi.DataSource = lesSuivis;
            cbxCmdDvdSuivi.DisplayMember = "libelle";
            cbxCmdDvdSuivi.ValueMember = "id";

            if (cbxCmdDvd.DataSource == null)
            {
                if (lesDvd == null || lesDvd.Count == 0)
                    lesDvd = controller.GetAllDvd();
                cbxCmdDvd.DataSource = lesDvd;
                cbxCmdDvd.DisplayMember = "Titre";
                cbxCmdDvd.ValueMember = "Id";
                cbxCmdDvd.SelectedIndex = (lesDvd.Count > 0) ? 0 : -1;
            }

            dgvCmdDvd.AutoGenerateColumns = true;
            dgvCmdDvd.DataSource = bsCmdDvd;

            foreach (DataGridViewColumn col in dgvCmdDvd.Columns)
                col.SortMode = DataGridViewColumnSortMode.Automatic;

            ChargerCommandesDvdSelectionne();
        }

        private void dgvCmdLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Rien à faire ici
        }

        private void TxbReceptionRevueNumero_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void TxbRevuesTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        private void TabRevues_Enter(object sender, EventArgs e)
        {
            tabRevues_Enter(sender, e);
        }

        private void TxbDvdTitreRecherche_TextChanged(object sender, EventArgs e)
        {
            // Pas d'action nécessaire
        }

        #endregion

        private TabPage tabCommandesRevues;
        private TabPage tabCommandesDvd;
        private TabPage tabCommandesLivres;
        private Label lblCmdLivre;
        private DataGridView dgvCmdLivre;
        private TabPage tabReceptionRevue;
        private GroupBox grpReceptionExemplaire;
        private Label label55;
        private Button btnReceptionExemplaireImage;
        private PictureBox pcbReceptionExemplaireImage;
        private Button btnReceptionExemplaireValider;
        private TextBox txbReceptionExemplaireImage;
        private Label label18;
        private TextBox txbReceptionExemplaireNumero;
        private Label label17;
        private DateTimePicker dtpReceptionExemplaireDate;
        private Label label16;
        private GroupBox grpReceptionRevue;
        private Label label48;
        private Label label56;
        private PictureBox pcbReceptionExemplaireRevueImage;
        private Label label13;
        private DataGridView dgvReceptionExemplairesListe;
        private TextBox txbReceptionRevueImage;
        private TextBox txbReceptionRevueRayon;
        private TextBox txbReceptionRevuePublic;
        private TextBox txbReceptionRevueGenre;
        private TextBox txbReceptionRevueDelaiMiseADispo;
        private TextBox txbReceptionRevuePeriodicite;
        private TextBox txbReceptionRevueTitre;
        private TextBox txbReceptionRevueNumero;
        private Label label3;
        private PictureBox pcbReceptionRevueImage;
        private Label label15;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Button btnReceptionRechercher;
        private TabPage tabRevues;
        private GroupBox grpRevuesInfos;
        private Label label57;
        private TextBox txbRevuesImage;
        private TextBox txbRevuesRayon;
        private TextBox txbRevuesPublic;
        private TextBox txbRevuesGenre;
        private TextBox txbRevuesDateMiseADispo;
        private TextBox txbRevuesPeriodicite;
        private TextBox txbRevuesTitre;
        private TextBox txbRevuesNumero;
        private Label label35;
        private PictureBox pcbRevuesImage;
        private Label label36;
        private Label label37;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private GroupBox grpRevuesRecherche;
        private Button BtnRevuesSupprimer;
        private Button BtnRevuesModifier;
        private Button BtnRevuesAjouter;
        private Button btnRevuesAnnulRayons;
        private Button btnRevuesAnnulPublics;
        private Button btnRevuesNumRecherche;
        private Label label2;
        private TextBox txbRevuesNumRecherche;
        private Button btnRevuesAnnulGenres;
        private ComboBox cbxRevuesRayons;
        private Label label4;
        private ComboBox cbxRevuesPublics;
        private Label label32;
        private ComboBox cbxRevuesGenres;
        private Label label33;
        private DataGridView dgvRevuesListe;
        private Label label34;
        private TextBox txbRevuesTitreRecherche;
        private TabPage tabDvd;
        private GroupBox grpDvdInfos;
        private Label label58;
        private TextBox txbDvdDuree;
        private TextBox txbDvdImage;
        private TextBox txbDvdRayon;
        private TextBox txbDvdPublic;
        private TextBox txbDvdGenre;
        private TextBox txbDvdSynopsis;
        private TextBox txbDvdRealisateur;
        private TextBox txbDvdTitre;
        private TextBox txbDvdNumero;
        private Label label23;
        private PictureBox pcbDvdImage;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private GroupBox grpDvdRecherche;
        private Button BtnDVDSupprimer;
        private Button BtnDVDModifier;
        private Button BtnDVDAjouter;
        private Button btnDvdAnnulRayons;
        private Button btnDvdAnnulPublics;
        private Button btnDvdNumRecherche;
        private Label label38;
        private TextBox txbDvdNumRecherche;
        private Button btnDvdAnnulGenres;
        private ComboBox cbxDvdRayons;
        private Label label39;
        private ComboBox cbxDvdPublics;
        private Label label40;
        private ComboBox cbxDvdGenres;
        private Label label41;
        private DataGridView dgvDvdListe;
        private Label label42;
        private TextBox txbDvdTitreRecherche;
        private TabPage tabLivres;
        private GroupBox grpLivresInfos;
        private Label label59;
        private TextBox txbLivresIsbn;
        private TextBox txbLivresImage;
        private TextBox txbLivresRayon;
        private TextBox txbLivresPublic;
        private TextBox txbLivresGenre;
        private TextBox txbLivresCollection;
        private TextBox txbLivresAuteur;
        private TextBox txbLivresTitre;
        private TextBox txbLivresNumero;
        private Label label22;
        private PictureBox pcbLivresImage;
        private Label label19;
        private Label label1;
        private Label label10;
        private Label label7;
        private Label label11;
        private Label label8;
        private Label label12;
        private Label label9;
        private GroupBox grpLivresRecherche;
        private Button BtnLivresSupprimer;
        private Button BtnLivresModifier;
        private Button BtnLivresAjouter;
        private Button btnLivresAnnulRayons;
        private Button btnlivresAnnulPublics;
        private Button btnLivresNumRecherche;
        private Label label5;
        private TextBox txbLivresNumRecherche;
        private Button btnLivresAnnulGenres;
        private ComboBox cbxLivresRayons;
        private Label label21;
        private ComboBox cbxLivresPublics;
        private Label label20;
        private ComboBox cbxLivresGenres;
        private Label label14;
        private DataGridView dgvLivresListe;
        private Label label6;
        private TextBox txbLivresTitreRecherche;
        private TabControl tabOngletsApplication;
        private ComboBox cbxCmdLivre;
        private Button btnCmdLivreSuppr;
        private Button btnCmdLivreMajSuivi	;
        private Button btnCmdLivreAjouter	;
        private Label label60;
        private ComboBox cbxCmdDvd;
        private DataGridView dgvCmdDvd;
        private Button btnCmdDvdMajSuivi;
        private Button btnCmdDvdAjouter;
        private Button btnCmdDvdSuppr;
        private ComboBox cbxCmdLivreSuivi;
        private ComboBox cbxCmdDvdSuivi;
        private TextBox txbCmdLivreMontant;
        private DateTimePicker dtpCmdLivreDate;
        private NumericUpDown nudCmdLivreNbEx;
        private TextBox txbCmdDvdMontant;
        private DateTimePicker dtpCmdDvdDate;
        private NumericUpDown nudCmdDvdNbEx;
        private ComboBox cbxCmdRevue;
        private DataGridView dgvCmdRevue;
        private DateTimePicker dtpCmdRevueDate;
        private DateTimePicker dtpCmdRevueFinAbo;
        private TextBox txbCmdRevueMontant;
        private Button btnCmdRevueAjouter;
        private Button btnCmdRevueSuppr;
        private Button btnCmdRevueRefresh;
        private Button btnCmdDvdRefresh;
        private Button btnCmdLivreRefresh;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label68;
        private Label label67;
        private Label label70;
        private Label label69;
    }
}

