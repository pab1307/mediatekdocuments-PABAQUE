using MediaTekDocuments.model;
using MediaTekDocuments.view;
using System;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace MediaTekDocuments
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Afficher la fenêtre d'authentification en premier
            FrmAuthentification frmAuth = new FrmAuthentification();
            if (frmAuth.ShowDialog() != DialogResult.OK)
            {
                // L'utilisateur a annulé : on quitte
                return;
            }

            Utilisateur utilisateur = frmAuth.UtilisateurConnecte;

            // Service "Culture" : droits insuffisants → message + fermeture
            if (utilisateur.LibelleService?.ToLower() == "culture")
            {
                MessageBox.Show(
                    "Vos droits ne sont pas suffisants pour accéder à cette application.",
                    "Accès refusé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new FrmMediatek(utilisateur));
        }
    }
}
