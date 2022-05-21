using IAPM.Technique;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace IAPM.Metier
{
    /// <summary>
    /// Classe de gestion des données de la table "utilisateur".
    /// </summary>
    public static class GestionClient
    {
        /// <summary>
        /// Permet de récupérer les clients dans la base de données.
        /// </summary>
        /// <returns>DataTable des clients</returns>
        public static DataTable getLesClients1()
        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM utilisateur", "TousLesClient1");
        }

        /// <summary>
        /// Permet de récupérer les clients (patronyme) dans la base de données.
        /// </summary>
        /// <returns>DataTable des clients</returns>
        public static DataTable getLesClients()
        {
            return GestionBoutique.executerRequeteSelect("SELECT utilisateur.idUtilisateur, CONCAT(nomUtilisateur,' ',prenomUtilisateur) AS Patronyme FROM utilisateur", "TousLesClient");
        }

        /// <summary>
        /// Permet de récupérer les clients associé à des commandes dans la base de données.
        /// </summary>
        /// <returns>DataTable des clients</returns>
        public static DataTable getLesClientsCommandes()
        {
            return GestionBoutique.executerRequeteSelect("SELECT DISTINCT utilisateur.idUtilisateur, CONCAT(nomUtilisateur,' ',prenomUtilisateur) AS Patronyme  FROM utilisateur, commande WHERE (utilisateur.idUtilisateur = commande.idUtilisateur)", "TousLesClientCommandes");
        }

        /// <summary>
        /// Permet de le nombre d'occurence de la table utilisateur dans la base de données.
        /// </summary>
        /// <returns>Nombre d'occurences</returns>
        public static int getNBClients()
        {
            int nbClients = 0;
            GestionBoutique.maRequete = "SELECT Count(*) FROM utilisateur";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbClients = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbClients;
        }

        /// <summary>
        /// Permet  d'ajouter un utilisateur dans la base de données.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <param name="tel"></param>
        /// <param name="adresseRue"></param>
        /// <param name="adresseCp"></param>
        /// <param name="adresseVille"></param>
        public static void ajouterClient(string login, string pass, string nom, string prenom, string email, string tel, string adresseRue, int adresseCp, string adresseVille)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO utilisateur (loginUtilisateur, passUtilisateur, nomUtilisateur, prenomUtilisateur, emailUtilisateur, telUtilisateur, adresseRueUtilisateur, adresseCpUtilisateur, adresseVilleUtilisateur) VALUES ('" + login + "','" + pass + "', '" + nom + "', '" + prenom + "' , '" + email + "', '" + tel + "', '" + adresseRue + "', " + adresseCp + ", '" + adresseVille + "')");
        }

        /// <summary>
        /// Permet de supprimer un utilisateur dans la base de données.
        /// </summary>
        /// <param name="id"></param>
        public static void supprimerClient(int id)
        {
            //Mettre sur la clé étrangère ON DELETE CASCADE pour que quand l'on supprime un client cela supprime sa commande et le contenue de
            //celle-ci.
            GestionBoutique.executerRequeteAction("DELETE FROM utilisateur WHERE idUtilisateur = " + id + "");
        }

        /// <summary>
        /// Permet de modifier un utilisateur dans la base de données.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <param name="tel"></param>
        /// <param name="adresseRue"></param>
        /// <param name="adresseCp"></param>
        /// <param name="adresseVille"></param>
        public static void modifierClient(int id, string login, string pass, string nom, string prenom, string email, string tel, string adresseRue, int adresseCp, string adresseVille)
        {
            GestionBoutique.executerRequeteAction("UPDATE utilisateur SET idUtilisateur = " + id + ", loginUtilisateur = '" + login + "', passUtilisateur = '" + pass + "', nomUtilisateur = '" + nom + "', prenomUtilisateur = '" + prenom + "' , emailUtilisateur ='" + email + "', telUtilisateur ='" + tel + "', adresseRueUtilisateur ='" + adresseRue + "', adresseCpUtilisateur =" + adresseCp + ", adresseVilleUtilisateur ='" + adresseVille + "' WHERE idUtilisateur = " + id + "");
        }

        /// <summary>
        /// Permet de rechercher un utilisateur dans la base de données.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DataTable rechercherClient(string text)

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM utilisateur WHERE (idUtilisateur LIKE '" + "%" + text + "%" + "' OR loginUtilisateur LIKE '" + "%" + text + "%" + "' OR passUtilisateur LIKE '" + "%" + text + "%" + "' OR nomUtilisateur LIKE '" + "%" + text + "%" + "' OR prenomUtilisateur LIKE '" + "%" + text + "%" + "' OR emailUtilisateur LIKE '" + "%" + text + "%" + "' OR telUtilisateur LIKE '" + "%" + text + "%" + "' OR adresseRueUtilisateur LIKE '" + "%" + text + "%" + "' OR adresseCpUtilisateur LIKE '" + "%" + text + "%" + "' OR adresseVilleUtilisateur LIKE '" + "%" + text + "%" + "' OR adresseIpUtilisateur LIKE '" + "%" + text + "%" + "')", "ClientRechercher"); ;
        }

        /// <summary>
        /// Permet de vérifier la conformité du nom de l'utilisateur.
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static bool validNom(string nom)
        {
            System.Text.RegularExpressions.Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");
            return myRegex.IsMatch(nom);
        }

        /// <summary>
        /// Permet de vérifier la conformité du prénom de l'utilisateur.
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static bool validPrenom(string prenom)
        {
            System.Text.RegularExpressions.Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");
            return myRegex.IsMatch(prenom);
        }

        /// <summary>
        /// Permet de vérifier la conformité du code postal de l'utilisateur.
        /// </summary>
        /// <param name="nom"></param>
        /// <returns></returns>
        public static bool validCp(string codePostal)
        {
            System.Text.RegularExpressions.Regex myRegex;
            myRegex = new Regex("^[0-9]");
            return myRegex.IsMatch(codePostal); // retourne true ou false selon la vérification
        }
    }
}
