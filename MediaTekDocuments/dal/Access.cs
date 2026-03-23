using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Configuration;
using log4net;

namespace MediaTekDocuments.dal
{
    /// <summary>
    /// Classe d'accès aux données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// instance du logger
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(typeof(Access));
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// instance de ApiRest pour envoyer des demandes vers l'api et recevoir la réponse
        /// </summary>
        private readonly ApiRest api = null;
        /// <summary>
        /// méthode HTTP pour select
        /// </summary>
        private const string GET = "GET";
        /// <summary>
        /// méthode HTTP pour insert
        /// </summary>
        private const string POST = "POST";
        /// <summary>
        /// méthode HTTP pour update
        /// </summary>
        private const string PUT = "PUT";
        /// <summary>
        /// méthode HTTP pour delete
        /// </summary>
        private const string DELETE = "DELETE";

        /// <summary>
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API
        /// </summary>
        private Access()
        {
            String authenticationString;
            String uriApi;
            try
            {
                uriApi = ConfigurationManager.AppSettings["uriApi"];
                authenticationString = ConfigurationManager.AppSettings["credentialsApi"];
                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                log.Fatal("Erreur lors de l'initialisation de l'accès à l'API", e);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création et retour de l'instance unique de la classe
        /// </summary>
        /// <returns>instance unique de la classe</returns>
        public static Access GetInstance()
        {
            if(instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

        /// <summary>
        /// Retourne tous les genres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre", null);
            return new List<Categorie>(lesGenres);
        }

        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon", null);
            return new List<Categorie>(lesRayons);
        }

        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public", null);
            return new List<Categorie>(lesPublics);
        }

        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre", null);
            return lesLivres;
        }

        /// <summary>
        /// Retourne toutes les dvd à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd", null);
            return lesDvd;
        }

        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue", null);
            return lesRevues;
        }


        /// <summary>
        /// Authentifie un utilisateur par login/mot de passe.
        /// Retourne l'objet Utilisateur si les identifiants sont corrects, null sinon.
        /// </summary>
        public Utilisateur GetUtilisateur(string login, string pwd)
        {
            string json2 = JsonConvert.SerializeObject(new Dictionary<string, string>
            {
                { "login", login },
                { "pwd", pwd }
            });
            List<Utilisateur> liste = TraitementRecup<Utilisateur>(GET, "utilisateur/" + json2, null);
            if (liste != null && liste.Count > 0)
                return liste[0];
            return null;
        }

        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocument">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">exemplaire à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            String jsonExemplaire = JsonConvert.SerializeObject(exemplaire, new CustomDateTimeConverter());
            try
            {
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire", "champs=" + jsonExemplaire);
                return (liste != null);
            }
            catch (Exception ex)
            {
                log.Error("Erreur lors de la création d'un exemplaire", ex);
            }
            return false;
        }

        /// <summary>
        /// Retourne tous les états d'usure
        /// </summary>
        public List<Etat> GetAllEtats()
        {
            return TraitementRecup<Etat>(GET, "etat", null);
        }

        /// <summary>
        /// Modifie l'état d'un exemplaire
        /// </summary>
        public bool ModifierEtatExemplaire(int numero, string idDocument, string idEtat)
        {
            var dict = new Dictionary<string, object>
            {
                { "numero", numero },
                { "id", idDocument },
                { "idetat", idEtat }
            };
            string champs = "champs=" + JsonConvert.SerializeObject(dict);
            var res = TraitementRecup<Exemplaire>(PUT, "exemplaire", champs);
            return res != null;
        }

        /// <summary>
        /// Supprime un exemplaire
        /// </summary>
        public bool SupprimerExemplaire(int numero, string idDocument)
        {
            var dict = new Dictionary<string, object>
            {
                { "numero", numero },
                { "id", idDocument }
            };
            string champs = "champs=" + JsonConvert.SerializeObject(dict);
            var res = TraitementRecup<Exemplaire>(DELETE, "exemplaire", champs);
            return res != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<model.Suivi> GetAllSuivis()
        {
            return TraitementRecup<model.Suivi>(GET, "suivi", null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idDocument"></param>
        /// <returns></returns>
        public List<model.CommandeDocument> GetCommandesDocument(string idDocument)
        {
            string json = convertToJson("iddocument", idDocument);
            return TraitementRecup<model.CommandeDocument>(GET, "commandesdoc/" + json, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool CreerCommandeDocument(model.CommandeDocument cmd)
        {
            string json = JsonConvert.SerializeObject(cmd, new CustomDateTimeConverter());
            return TraitementRecup<model.CommandeDocument>(POST, "commandedocument", "champs=" + json) != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="idSuivi"></param>
        /// <returns></returns>
        public bool ModifierSuiviCommandeDocument(string idCommande, int idSuivi)
        {
            string champs = "champs=" + convertToJson("idsuivi", idSuivi);
            var res = TraitementRecup<model.CommandeDocument>(PUT, "commandedocument/" + idCommande, champs);
            return res != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public bool SupprimerCommandeDocument(string idCommande)
        {
            string champs = "champs=" + convertToJson("id", idCommande);
            var res = TraitementRecup<model.CommandeDocument>(DELETE, "commandedocument", champs);
            return res != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRevue"></param>
        /// <returns></returns>
        public List<model.CommandeRevue> GetCommandesRevue(string idRevue)
        {
            string json = convertToJson("iddocument", idRevue);
            return TraitementRecup<model.CommandeRevue>(GET, "commandesrevue/" + json, null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public bool CreerCommandeRevue(model.CommandeRevue cmd)
        {
            string json = JsonConvert.SerializeObject(cmd, new CustomDateTimeConverter());
            return TraitementRecup<model.CommandeRevue>(POST, "commanderevue", "champs=" + json) != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public bool SupprimerCommandeRevue(string idCommande)
        {
            string champs = "champs=" + convertToJson("id", idCommande);
            var res = TraitementRecup<model.CommandeRevue>(DELETE, "commanderevue", champs);
            return res != null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<dynamic> GetRevuesFinAbonnement()
        {
            // modèle simple : titre + datefin
            return TraitementRecup<dynamic>(GET, "revuesFinAbo", null);
        }

        /// <summary>
        /// Traitement de la récupération du retour de l'api, avec conversion du json en liste pour les select (GET)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methode">verbe HTTP (GET, POST, PUT, DELETE)</param>
        /// <param name="message">information envoyée dans l'url</param>
        /// <param name="parametres">paramètres à envoyer dans le body, au format "chp1=val1&chp2=val2&..."</param>
        /// <returns>liste d'objets récupérés (ou liste vide)</returns>
        private List<T> TraitementRecup<T> (String methode, String message, String parametres)
        {
            List<T> liste = new List<T>();
            try
            {
                JObject retour = api.RecupDistant(methode, message, parametres);
                // extraction du code retourné
                String code = retour["code"]?.ToString();
                if (code != null && code.Equals("200"))
                {
                    // dans le cas du GET (select), récupération de la liste d'objets
                    if (methode.Equals(GET))
                    {
                        String resultString = JsonConvert.SerializeObject(retour["result"]);
                        liste = JsonConvert.DeserializeObject<List<T>>(resultString, new CustomBooleanJsonConverter());
                    }
                    // Pour POST, PUT, DELETE : succès → retourne liste vide (non null)
                    // (la liste vide signale le succès pour les appelants qui vérifient != null)
                }
                else
                {
                    log.Warn($"code erreur = {code} message = {retour["message"]?.ToString()}");
                    // Échec → retourner null pour signaler l'erreur
                    return null;
                }
            }
            catch (Exception e)
            {
                log.Fatal("Erreur lors de l'accès à l'API", e);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Convertit en json un couple nom/valeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="valeur"></param>
        /// <returns>couple au format json</returns>
        private String convertToJson(Object nom, Object valeur)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }

        internal bool SupprimerRevue(string id)
        {
            throw new NotImplementedException();
        }

        internal bool SupprimerLivre(string id)
        {
            throw new NotImplementedException();
        }

        internal bool SupprimerDvd(string id)
        {
            throw new NotImplementedException();
        }

        internal bool ModifierRevue(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool ModifierLivre(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool ModifierDvd(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool CreerRevue(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool CreerLivre(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool CreerDvd(string id, string titre, string image, string isbn, string auteur, string collection, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool ModifierRevue(string id, string titre, string image, string periodicite, int delaiMiseADispo, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool CreerRevue(string id, string titre, string image, string periodicite, int delaiMiseADispo, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool ModifierDvd(string id, string titre, string image, string synopsis, string realisateur, int duree, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }

        internal bool CreerDvd(string id, string titre, string image, string synopsis, string realisateur, int duree, string idGenre, string idPublic, string idRayon)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Modification du convertisseur Json pour gérer le format de date
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        /// <summary>
        /// Modification du convertisseur Json pour prendre en compte les booléens
        /// classe trouvée sur le site :
        /// https://www.thecodebuzz.com/newtonsoft-jsonreaderexception-could-not-convert-string-to-boolean/
        /// </summary>
        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }

            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

    }
}
