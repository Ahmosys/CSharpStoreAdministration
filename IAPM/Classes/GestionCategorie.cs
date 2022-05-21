using IAPM.Technique;
using System;
using System.Data;

namespace IAPM.Metier
{
    /// <summary>
    /// Classe de gestion des données de la table "categorie".
    /// </summary>
    public static class GestionCategorie
    {
        /// <summary>
        /// Permet de récupérer les catégorie dans la base de données.
        /// </summary>
        /// <returns>DataTable des catégorie</returns>
        public static DataTable getLesCategories()

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM categorie", "TouteLesCategories");
        }

        /// <summary>
        /// Permet de le nombre d'occurence de la table categorie dans la base de données.
        /// </summary>
        /// <returns>Nombre d'occurences</returns>
        public static int getNBCategories()
        {
            int nbCategories = 0;
            GestionBoutique.maRequete = "SELECT Count(*) FROM categorie";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbCategories = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbCategories;
        }

        /// <summary>
        /// Permet  d'ajouter une catégorie dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="libelle"></param>
        public static void ajouterCategorie(int code, string libelle)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO categorie VALUES (" + code + ", '" + libelle + "')");
        }

        /// <summary>
        /// Permet de supprimer une catégorie dans la base de données.
        /// </summary>
        /// <param name="codeCategorie"></param>
        public static void supprimerCategorie(int codeCategorie)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM categorie Where idCategorie = " + codeCategorie + "");
        }

        /// <summary>
        /// Permet de modifier une catégorie dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="libelle"></param>
        public static void modifierCategorie(int code, string libelle)
        {
            GestionBoutique.executerRequeteAction("UPDATE categorie Set idCategorie = " + code + ", LibelleCategorie = '" + libelle + "' where idCategorie = " + code + "");
        }
    }
}
