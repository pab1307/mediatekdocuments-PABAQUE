using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;
using System;
using MediaTekDocuments.view;
using SuiviModel = MediaTekDocuments.model.Suivi;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Authentifie un utilisateur. Retourne l'objet Utilisateur ou null si échec.
        /// </summary>
        public model.Utilisateur GetUtilisateur(string login, string pwd)
        {
            return access.GetUtilisateur(login, pwd);
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Récupère les exemplaires d'un document (livre, dvd ou revue)
        /// </summary>
        public List<Exemplaire> GetExemplairesDocument(string idDocument)
        {
            return access.GetExemplairesRevue(idDocument);
        }

        /// <summary>
        /// Retourne tous les états d'usure
        /// </summary>
        public List<Etat> GetAllEtats()
        {
            return access.GetAllEtats();
        }

        /// <summary>
        /// Modifie l'état d'un exemplaire
        /// </summary>
        public bool ModifierEtatExemplaire(int numero, string idDocument, string idEtat)
        {
            return access.ModifierEtatExemplaire(numero, idDocument, idEtat);
        }

        /// <summary>
        /// Supprime un exemplaire
        /// </summary>
        public bool SupprimerExemplaire(int numero, string idDocument)
        {
            return access.SupprimerExemplaire(numero, idDocument);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Ajoute un Livre dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="isbn"></param>
        /// <param name="auteur"></param>
        /// <param name="collection"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        public bool CreerLivre(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            return access.CreerLivre(id, titre, image, isbn, auteur, collection, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Modifie un Livre dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="isbn"></param>
        /// <param name="auteur"></param>
        /// <param name="collection"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        public bool ModifierLivre(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            return access.ModifierLivre(id, titre, image, isbn, auteur, collection, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Supprime un Livre dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerLivre(string id)
        {
            return access.SupprimerLivre(id);
        }

        /// <summary>
        /// Ajoute un Dvd dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="synopsis"></param>
        /// <param name="realisateur"></param>
        /// <param name="duree"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal bool CreerDvd(string id, string titre, string image, string synopsis, string realisateur, int duree, string idGenre, string idPublic, string idRayon)
        {
            return access.CreerDvd(id, titre, image, synopsis, realisateur, duree, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Modifie un Dvd dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="synopsis"></param>
        /// <param name="realisateur"></param>
        /// <param name="duree"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal bool ModifierDvd(string id, string titre, string image, string synopsis, string realisateur, int duree, string idGenre, string idPublic, string idRayon)
        {
            return access.ModifierDvd(id, titre, image, synopsis, realisateur, duree, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Supprime un Dvd dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerDvd(string id)
        {
            return access.SupprimerDvd(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<MediaTekDocuments.model.Suivi> GetAllSuivis()
        {
            return access.GetAllSuivis();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idDoc"></param>
        /// <returns></returns>
        public List<model.CommandeDocument> GetCommandesDocument(string idDoc) => access.GetCommandesDocument(idDoc);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool CreerCommandeDocument(model.CommandeDocument cmd) => access.CreerCommandeDocument(cmd);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        /// <returns></returns>
        public bool ModifierSuiviCommandeDocument(string idCommande, int idSuivi) => access.ModifierSuiviCommandeDocument(idCommande, idSuivi);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public bool SupprimerCommandeDocument(string idCommande) => access.SupprimerCommandeDocument(idCommande);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRevue"></param>
        /// <returns></returns>
        public List<MediaTekDocuments.model.CommandeRevue> GetCommandesRevue(string idRevue)
            => access.GetCommandesRevue(idRevue);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool CreerCommandeRevue(CommandeRevue cmd) => access.CreerCommandeRevue(cmd);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public bool SupprimerCommandeRevue(string idCommande) => access.SupprimerCommandeRevue(idCommande);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<dynamic> GetRevuesFinAbonnement() => access.GetRevuesFinAbonnement();


        /// <summary>
        /// Ajoute une revue dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="periodicite"></param>
        /// <param name="delaiMiseADispo"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal bool CreerRevue(string id, string titre, string image, string periodicite, int delaiMiseADispo, string idGenre, string idPublic, string idRayon)
        {
            return access.CreerRevue(id, titre, image, periodicite, delaiMiseADispo, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Modifie une revue dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="image"></param>
        /// <param name="periodicite"></param>
        /// <param name="delaiMiseADispo"></param>
        /// <param name="idGenre"></param>
        /// <param name="idPublic"></param>
        /// <param name="idRayon"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal bool ModifierRevue(string id, string titre, string image, string periodicite, int delaiMiseADispo, string idGenre, string idPublic, string idRayon)
        {
            return access.ModifierRevue(id, titre, image, periodicite, delaiMiseADispo, idGenre, idPublic, idRayon);
        }

        /// <summary>
        /// Supprime une revue dans la Bdd
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool SupprimerRevue(string id)
        {
            return access.SupprimerRevue(id);
        }

    }
}
