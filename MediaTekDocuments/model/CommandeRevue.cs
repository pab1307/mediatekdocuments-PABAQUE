using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier représentant une commande d'abonnement à une revue
    /// </summary>
    public class CommandeRevue
    {
        /// <summary>
        /// Identifiant unique de la commande d'abonnement
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Identifiant de la revue concernée par l'abonnement
        /// </summary>
        public string Iddocument { get; set; }

        /// <summary>
        /// Date de début de l'abonnement
        /// </summary>
        public DateTime Datecommande { get; set; }

        /// <summary>
        /// Montant de l'abonnement (en euros)
        /// </summary>
        public double Montant { get; set; }

        /// <summary>
        /// Date de fin de l'abonnement
        /// </summary>
        public DateTime Datefinabonnement { get; set; }
    }
}
