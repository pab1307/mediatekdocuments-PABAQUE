using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier représentant une commande de document (livre ou DVD)
    /// </summary>
    public class CommandeDocument
    {
        /// <summary>
        /// Identifiant unique de la commande
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Identifiant du document commandé (livre ou DVD)
        /// </summary>
        public string iddocument { get; set; }

        /// <summary>
        /// Date de la commande
        /// </summary>
        public DateTime datecommande { get; set; }

        /// <summary>
        /// Montant total de la commande (en euros)
        /// </summary>
        public double montant { get; set; }

        /// <summary>
        /// Nombre d'exemplaires commandés
        /// </summary>
        public int nbexemplaire { get; set; }

        /// <summary>
        /// Identifiant de l'étape de suivi courante
        /// </summary>
        public int idsuivi { get; set; }

        /// <summary>
        /// Libellé de l'étape de suivi courante (ex : En cours, Livrée, Réglée)
        /// </summary>
        public string suivi { get; set; }
    }
}

