using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe utilitaire statique pour les calculs liés aux abonnements de revues
    /// </summary>
    public static class AbonnementHelper
    {
        /// <summary>
        /// Vérifie si une date de parution est couverte par un abonnement
        /// </summary>
        /// <param name="dateCommande">Date de début de l'abonnement (incluse)</param>
        /// <param name="dateFin">Date de fin de l'abonnement (incluse)</param>
        /// <param name="dateParution">Date de la parution à vérifier</param>
        /// <returns>True si la parution est dans la période d'abonnement, false sinon</returns>
        public static bool ParutionDansAbonnement(DateTime dateCommande, DateTime dateFin, DateTime dateParution)
        {
            return dateParution.Date >= dateCommande.Date && dateParution.Date <= dateFin.Date;
        }
    }
}
