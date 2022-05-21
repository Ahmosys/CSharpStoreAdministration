using IAPM.Technique;
using System;
using System.Data;

namespace IAPM.Metier
{
    /// <summary>
    /// Classe de gestion des données de la table "fournisseur".
    /// </summary>
    public static class GestionFournisseur
    {
        /// <summary>
        /// Permet de récupérer les fournisseurs dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesFournisseurs()

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM fournisseur", "ToutLesFournisseurs");
        }

        /// <summary>
        /// Permet de le nombre d'occurence de la table fournisseur dans la base de données. 
        /// </summary>
        /// <returns></returns>
        public static int getNBFournisseurs()
        {
            int nbFournisseurs = 0;
            GestionBoutique.maRequete = "SELECT Count(*) FROM fournisseur";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbFournisseurs = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbFournisseurs;
        }

        /// <summary>
        /// Permet d'ajouter un fournisseur dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="nom"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        public static void ajouterFournisseur(int code, string nom, string ville, int codePostal)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO fournisseur VALUES (" + code + ", '" + nom + "','" + ville + "', " + codePostal + ")");
        }

        /// <summary>
        /// Permet de supprimer un fournisseur dans la base de données.
        /// </summary>
        /// <param name="codeFournisseur"></param>
        public static void supprimerFournisseur(int codeFournisseur)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM fournisseur Where idFournisseur = " + codeFournisseur + "");
        }

        /// <summary>
        /// Permet de modifier un fournisseur dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="nom"></param>
        /// <param name="ville"></param>
        /// <param name="codePostal"></param>
        public static void modifierFournisseur(int code, string nom, string ville, int codePostal)
        {
            GestionBoutique.executerRequeteAction("UPDATE fournisseur Set idFournisseur = " + code + ", NomFournisseur = '" + nom + "', VilleFournisseur = '" + ville + "' , CPFournisseur = " + codePostal + " where idFournisseur = " + code + "");
        }

        /// <summary>
        /// Permet de rechercher un fournisseur dans la base de données.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DataTable rechercherFournisseur(string text)

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM fournisseur WHERE (idFournisseur like '" + "%" + text + "%" + "' OR NomFournisseur like '" + "%" + text + "%" + "' OR VilleFournisseur like '" + "%" + text + "%" + "' OR CPFournisseur like '" + "%" + text + "%" + "')", "FournisseurRechercher"); ;
        }
    }
}
