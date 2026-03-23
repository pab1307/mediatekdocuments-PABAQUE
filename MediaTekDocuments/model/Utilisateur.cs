namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier représentant un utilisateur de l'application
    /// </summary>
    public class Utilisateur
    {
        public string Login { get; set; }
        public string Pwd { get; set; }
        public int IdService { get; set; }
        public string LibelleService { get; set; }

        /// <summary>
        /// Retourne true si l'utilisateur gère les commandes
        /// (services Administrateur et Responsable)
        /// </summary>
        public bool GereCommandes()
        {
            string s = LibelleService?.ToLower() ?? "";
            return s == "administrateur" || s == "responsable";
        }
    }
}
