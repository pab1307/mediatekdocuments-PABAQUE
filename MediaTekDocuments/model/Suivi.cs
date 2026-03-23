namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente une étape de suivi d'une commande
    /// </summary>
    public class Suivi
    {
        /// <summary>
        /// Identifiant du suivi
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Libellé du suivi (en cours, livrée, réglée, etc.)
        /// </summary>
        public string libelle { get; set; }
    }
}
