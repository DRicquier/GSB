// ------------------------------------------
// Nom du fichier : Passerelle.cs
// Objet : classe Passerelle assurant l'alimentation des objets en mémoire
// Auteur :
// Date  : 
// ------------------------------------------

using System;
using System.Data; // pour ParameterDirection
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using lesClasses;
using LesClasses;

namespace GSB {
    static class Passerelle {
        private static MySqlConnection cnx;

        // Vérifier les paramètres de connexion et alimente l'objet globale leVisiteur
        static public bool seConnecter(string login, string mdp, out string message) {
            string chaineConnexion = $"Data Source=localhost;Database=gsb; User Id={login}; Password={mdp}";
            cnx = new MySqlConnection(chaineConnexion);
            bool ok = true;
            message = null;

            try {
                // etablit une connexion saut si une connexion existe déjà 
                cnx.Open();
            }
            catch (MySqlException e) {
                ok = false;
                if (e.Message.Contains("Accès refusé")) {
                    message = "Vos identifiants sont incorrects.";
                }
                else {
                    message = "Problème lors de la tentative de connexion au serveur.\n";
                    message += "Prière de contacter le service informatique";
                }
            }
            catch (Exception e) {
                message = e.ToString();
                ok = false;
            }

            if (ok) {
                // récupération des informations sur le visiteurs depuis la vue leVisiteur           
                MySqlCommand cmd = new MySqlCommand("Select nomPrenom from leVisiteur;", cnx);
                try {
                    Globale.nomVisiteur = cmd.ExecuteScalar().ToString();
                }
                catch (MySqlException e) {
                    message = "Erreur lors de la récupération de vos paramètres \n";
                    message += "Veuillez contacter le service informatique\n";
                    ok = false;
                }
            }

            if (ok) message = "Visiteur authentifié";
            return ok;
        }

        // se déconnecter
        static public void seDeConnecter() => cnx.Close();


        // chargement des données de la base dans les différentes collections statiques de la classe Globale 
        // dans cette méthode pas de bloc try catch car aucune erreur imprévisible en production ne doit se produire
        // en cas d'erreur en développement il faut laisser faire le debogueur de VS qui va signaler la ligne en erreur
        // le chargement des données concernant tous les visiteurs (médicament, type praticien, specialite, motif) ne doit être fait qu'une fois
        // si elles sont déja chargées on ne les recherche pas.
        // le chargement des données spécifiques au visiteur connecté doit se faire à chaque fois en vidant les anciennes données 
        static public void chargerDonnees() {
            List<Specialite> lesSpecialites = new List<Specialite>();
            MySqlCommand command = new MySqlCommand("select id, libelle from specialite", cnx);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Specialite specialite = new Specialite(reader.GetString("id"), reader.GetString("libelle"));
                lesSpecialites.Add(specialite);
            }

            reader.Close();

            List<TypePraticien> lesTypesPraticiens = new List<TypePraticien>();
            command.CommandText = "select id, libelle, lieu from typepraticien";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                TypePraticien typePraticien = new TypePraticien(reader.GetString("id"), reader.GetString("libelle"));
                lesTypesPraticiens.Add(typePraticien);
            }

            reader.Close();

            List<Motif> lesMotifs = new List<Motif>();
            command.CommandText = "select id, libelle from motif";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Motif motif = new Motif(reader.GetInt32("id"), reader.GetString("libelle"));
                lesMotifs.Add(motif);
            }

            reader.Close();

            SortedDictionary<string, Famille> lesFamilles = new SortedDictionary<string, Famille>();
            command.CommandText = "select id, libelle from famille";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Famille famille = new Famille(reader.GetString("id"), reader.GetString("libelle"));
                lesFamilles.Add(famille.Id, famille);
            }

            reader.Close();

            List<Praticien> lesPraticiens = new List<Praticien>();
            command.CommandText = "select id, nom, prenom, rue, codePostal, ville, telephone, email, idType, idSpecialite from mespraticiens";
            reader = command.ExecuteReader();
            
            while (reader.Read()) {
                int id = reader.GetInt32("id");
                string nom = reader.GetString("nom");
                string prenom = reader.GetString("prenom");
                string rue = reader.GetString("rue");
                string codePostal = reader.GetString("codePostal");
                string ville = reader.GetString("ville");
                string telephone = reader.GetString("telephone");
                string email = reader.GetString("email");
                string idType = reader.GetString("idType");
                TypePraticien typePraticien = lesTypesPraticiens.Find(x => x.Id.Equals(idType));
                Specialite specialite = reader.IsDBNull(9) ? null : lesSpecialites.Find(x => x.Id.Equals(reader.GetString("idSpecialite")));

                Praticien praticien = new Praticien(id, nom, prenom, rue, codePostal, ville, email, telephone, typePraticien, specialite);
                lesPraticiens.Add(praticien);
            }

            reader.Close();

            List<Ville> lesVilles = new List<Ville>();
            command.CommandText = "select nom, codePostal from mesvilles";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Ville ville = new Ville(reader.GetString("nom"), reader.GetString("codePostal"));
                lesVilles.Add(ville);
            }

            reader.Close();

            List<Medicament> lesMedicaments = new List<Medicament>();
            command.CommandText = "select id, nom, composition, effets, contreIndication, idFamille from medicament";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                string id = reader.GetString("id");
                string nom = reader.GetString("nom");
                string composition = reader.GetString("composition");
                string effets = reader.GetString("effets");
                string contreIndication = reader.GetString("contreIndication");
                string idFamille = reader.GetString("idFamille");

                // On vérifie que la famille du médicament
                if (!lesFamilles.ContainsKey(idFamille))
                    continue;
                
                Famille famille = lesFamilles[idFamille];
                Medicament medicament = new Medicament(id, nom, composition, effets, contreIndication, famille);
                lesMedicaments.Add(medicament);
            }

            reader.Close();

            List<Visite> lesVisites = new List<Visite>();
            command.CommandText = "select id, dateEtHeure, bilan, idMotif, idVisiteur, idPraticien, premierMedicament, secondMedicament from mesvisites";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                int id = reader.GetInt32("id");
                DateTime dateEtHeure = reader.GetDateTime("dateEtHeure");
                int idMotif = reader.GetInt32("idMotif");
                int idPraticien = reader.GetInt32("idPraticien");

                Praticien praticien = lesPraticiens.First(x => x.Id.Equals(idPraticien));
                Motif motif = lesMotifs.First(x => x.Id.Equals(idMotif));
                Visite visite = new Visite(id, praticien, motif, dateEtHeure);

                // Le bilan n'est pas null
                if (!reader.IsDBNull(2))
                {
                    visite.Bilan = reader.GetString(2);
                }

                // Le premier médicament n'est pas null
                if (!reader.IsDBNull(6))
                {
                    string idPremierMedicament = reader.GetString(6);
                    Medicament premierMedicament = lesMedicaments.Find(x => x.Id.Equals(idPremierMedicament));

                    // Si le medicament existe bien et a bien été chargé à partir de la base de données
                    if (premierMedicament != null)
                    {
                        visite.PremierMedicament = premierMedicament;
                    }
                }
                
                // Le second médicament n'est pas null
                if (!reader.IsDBNull(7))
                {
                    string idSecondMedicament = reader.GetString(7);
                    Medicament secondMedicament = lesMedicaments.Find(x => x.Id.Equals(idSecondMedicament));
                    
                    // Si le medicament existe bien et a bien été chargé à partir de la base de données
                    if (secondMedicament != null)
                    {
                        visite.SecondMedicament = secondMedicament;
                    }
                }
                
                lesVisites.Add(visite);
            }

            reader.Close();

            List<Presentation> lesPresentations = new List<Presentation>();
            command.CommandText = "select id, date, sujet from presentation";
            reader = command.ExecuteReader();
            while (reader.Read()) {
                Presentation presentation = new Presentation(reader.GetInt32("id"), reader.GetDateTime("date"), reader.GetString("sujet"));
                lesPresentations.Add(presentation);
            }

            reader.Close();


            Globale.lesSpecialites = lesSpecialites;
            Globale.lesTypes = lesTypesPraticiens;
            Globale.lesMotifs = lesMotifs;
            Globale.lesFamilles = lesFamilles;
            Globale.mesPraticiens = lesPraticiens;
            Globale.mesVilles = lesVilles;
            Globale.lesMedicaments = lesMedicaments;
            Globale.mesVisites = lesVisites;
            Globale.lesPresentations = lesPresentations;
        }

        /**
         *When a stored procedure is called using MySqlCommand.ExecuteReader,
         * and the stored procedure has output parameters,
         * the output parameters are set only after the MySqlDataReader returned by ExecuteReader
         * is closed.
         * 
         */
        /// <summary>
        ///     Ajout d'une nouvelle visite
        /// </summary>
        /// <param name="idPraticien"></param>
        /// <param name="idMotif"></param>
        /// <param name="uneDate"></param>
        /// <param name="uneHeure"></param>
        /// <param name="message"></param>
        /// <returns>identifiant de la nouvelle visite ou 0 si erreur lors de la création</returns>
        static public int ajouterRendezVous(int idPraticien, int idMotif, DateTime uneDate, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("ajouterRendezVous", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idPraticien", idPraticien);
            command.Parameters.AddWithValue("_idMotif", idMotif);
            command.Parameters.AddWithValue("_dateEtHeure", uneDate);
            Console.WriteLine(uneDate);
            
            MySqlParameter idVisiteParameter = command.Parameters.Add("_idVisite", MySqlDbType.Int32);
            idVisiteParameter.Direction = ParameterDirection.Output;

            try {
                command.ExecuteNonQuery();
                int idVisite = int.Parse(idVisiteParameter.Value.ToString());
                return idVisite;
            }
            catch (Exception e) {
                message = e.Message;
                return 0;
            }
        }

        static public bool supprimerRendezVous(int idVisite, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("supprimerRendezVous", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idVisite", idVisite);

            try {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

        static public bool modifierRendezVous(int idVisite, DateTime uneDateEtHeure, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("modifierRendezVous", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idVisite", idVisite);
            command.Parameters.AddWithValue("_dateEtHeure", uneDateEtHeure);

            try {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

        static public bool enregistrerBilan(Visite uneVisite, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("enregistrerBilanVisite", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idVisite", uneVisite.Id);
            command.Parameters.AddWithValue("_bilan", uneVisite.Bilan);
            command.Parameters.AddWithValue("_premierMedicament", uneVisite.PremierMedicament.Id);
            
            // Le second médicament est optionel
            command.Parameters.AddWithValue("_secondMedicament", uneVisite.SecondMedicament == null ? "" : uneVisite.SecondMedicament.Id);

            try {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                message = e.Message;
                return false;
            }
        }


        static public int ajouterPraticien(string nom, string prenom, string rue, string codePostal, string ville,
            string telephone, string email, string unType,
            string uneSpecialite, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("ajouterPraticien", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_nom", nom);
            command.Parameters.AddWithValue("_prenom", prenom);
            command.Parameters.AddWithValue("_rue", rue);
            command.Parameters.AddWithValue("_codePostal", codePostal);
            command.Parameters.AddWithValue("_ville", ville);
            command.Parameters.AddWithValue("_telephone", telephone);
            command.Parameters.AddWithValue("_email", email);
            command.Parameters.AddWithValue("_idType", unType);
            command.Parameters.AddWithValue("_idSpecialite", uneSpecialite);

            MySqlParameter idPraticienParameter = command.Parameters.Add("_idPraticien", MySqlDbType.Int32);
            idPraticienParameter.Direction = ParameterDirection.Output;

            try {
                command.ExecuteNonQuery();
                int idPraticien = int.Parse(idPraticienParameter.Value.ToString());
                return idPraticien;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                message = e.Message;
                return 0;
            }
        }


        static public bool modifierPraticien(int id, string nom, string rue, string codePostal, string ville,
            string telephone, string email, string unType,
            string uneSpecialite, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("modifierPraticien", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_id", id);
            command.Parameters.AddWithValue("_nom", nom);
            command.Parameters.AddWithValue("_rue", rue);
            command.Parameters.AddWithValue("_codePostal", codePostal);
            command.Parameters.AddWithValue("_ville", ville);
            command.Parameters.AddWithValue("_telephone", telephone);
            command.Parameters.AddWithValue("_email", email);
            command.Parameters.AddWithValue("_idType", unType);
            command.Parameters.AddWithValue("_idSpecialite", uneSpecialite);

            try {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

        static public bool supprimerPraticien(int id, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("supprimerPraticien", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idPraticien", id);

            try {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

        static public bool ajouterEchantillon(int idVisite, string idMedicament, int quantite, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("ajouterEchantillon", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idVisite", idVisite);
            command.Parameters.AddWithValue("_idMedicament", idMedicament);
            command.Parameters.AddWithValue("_quantite", quantite);

            try {
                command.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

        static public bool ajouterInscription(int idPresentation, out string message) {
            message = string.Empty;
            MySqlCommand command = new MySqlCommand("ajouterInscription", cnx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("_idPresentation", idPresentation);
            try {
                command.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                message = e.Message;
                return false;
            }
        }

    }
}