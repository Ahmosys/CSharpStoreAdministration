using IAPM.Technique;
using System;
using System.Data;

namespace IAPM.Metier
{
    /// <summary>
    /// Classe de gestion des données de la table "produit".
    /// </summary>
    public static class GestionProduit
    {
        /// <summary>
        /// Permet de récupérer les produits dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesProduits()

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM produit", "TousLesProduits");
        }

        /// <summary>
        /// Permet de récupérer les produits dans la base de données pour l'affichage dans le DGV.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesProduitsDG()

        {
            return GestionBoutique.executerRequeteSelect("SELECT idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, NomFournisseur, LibelleCategorie, " +
                "ImageProduit FROM produit, categorie, fournisseur WHERE(produit.idFourn = fournisseur.idFournisseur) AND (produit.idCat = categorie.idCategorie)",
                "TousLesProduitsDG");
        }

        /// <summary>
        /// Permet de récupérer les produits associés à une catégorie dans la base de données.
        /// </summary>
        /// <param name="idCategorie"></param>
        /// <returns></returns>
        public static DataTable getLesProduitsByCategorie(int idCategorie)

        {
            return GestionBoutique.executerRequeteSelect("SELECT * FROM produit, categorie WHERE (produit.idCat = categorie.idCategorie) AND (idCategorie = " + idCategorie + ")", "TousLesProduitsParCategorie");
        }

        /// <summary>
        /// Permet de le nombre d'occurence de la table produit dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static int getNBProduits()
        {
            int nbProduits = 0;
            GestionBoutique.maRequete = "SELECT Count(*) FROM produit";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbProduits = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbProduits;
        }

        /// <summary>
        /// Permet de récupérer le nombre total de ventes de produit dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static int getNBVentesTotale()
        {
            int nbVentesTotale = 0;
            GestionBoutique.maRequete = "SELECT SUM(nbVenteProduit) FROM produit";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbVentesTotale = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbVentesTotale;
        }

        /// <summary>
        /// Permet de récupérer le chiffre d'affaire total de la boutique.
        /// </summary>
        /// <returns></returns>
        public static int getCaTotal()
        {
            int caTotal = 0;
            GestionBoutique.maRequete = "SELECT ROUND(SUM(produit.PrixHTProduit * QuantiteCom)) FROM produit, lignedecommande, commande WHERE (produit.idProduit = lignedecommande.idProduit) AND (lignedecommande.idCommande = commande.idCommande)";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            caTotal = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return caTotal;
        }

        /// <summary>
        /// Permet de récupérer le nombre de produits mis en favoris par les utilisateurs.
        /// </summary>
        /// <returns></returns>
        public static int getNBProduitsFavoris()
        {
            int nbProduitEnFavoris = 0;
            GestionBoutique.maRequete = "SELECT COUNT(DISTINCT idProduit) FROM favorisutilisateur";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbProduitEnFavoris = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbProduitEnFavoris;
        }

        /// <summary>
        /// Permet d'ajouter un produit dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="libelle"></param>
        /// <param name="prix"></param>
        /// <param name="qte"></param>
        /// <param name="fourn"></param>
        /// <param name="categorie"></param>
        /// <param name="image"></param>
        public static void ajouterProduit(int code, string libelle, float prix, int qte, int fourn, int categorie, string image)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO produit (idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, idFourn, idCat, ImageProduit) VALUES (" + code + ", '" + libelle + "'," + prix + ", " + qte + ", " + fourn + " , " + categorie + " , '" + image + "')");
        }

        /// <summary>
        /// Permet de supprimer un produit dans la base de données.
        /// </summary>
        /// <param name="codeProduit"></param>
        public static void supprimerProduit(int codeProduit)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM produit Where idProduit = " + codeProduit + "");
        }

        /// <summary>
        /// Permet de modifier un produit dans la base de données.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="libelle"></param>
        /// <param name="prix"></param>
        /// <param name="qte"></param>
        /// <param name="cbFournisseurs"></param>
        /// <param name="cbCategories"></param>
        /// <param name="image"></param>
        public static void modifierProduit(int code, string libelle, float prix, int qte, int cbFournisseurs, int cbCategories, string image)
        {
            GestionBoutique.executerRequeteAction("UPDATE produit SET idProduit = " + code + ", LibelleProduit = '" + libelle + "', PrixHTProduit = " + prix + ", QteStockProduit = " + qte + ", idFourn = " + cbFournisseurs + ", idCat =" + cbCategories + " , ImageProduit = '" + image + "' WHERE idProduit = " + code + "");
        }

        /// <summary>
        /// Permet de rechercher un produit dans la base de données.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DataTable rechercherProduit(string text)
        {
            return GestionBoutique.executerRequeteSelect("SELECT idProduit, LibelleProduit, PrixHTProduit, QteStockProduit, NomFournisseur, LibelleCategorie FROM produit, categorie, fournisseur WHERE (idProduit like '" + "%" + text + "%" + "' OR LibelleProduit like '" + "%" + text + "%" + "' OR PrixHTProduit like '" + "%" + text + "%" + "' OR QteStockProduit like '" + "%" + text + "%" + "' OR NomFournisseur like '" + "%" + text + "%" + "' OR LibelleCategorie like '" + "%" + text + "%" + "') AND (produit.idFourn = fournisseur.idFournisseur) AND (produit.idCat = categorie.idCategorie) ", "ProduitRechercher"); ;
        }

        /// <summary>
        /// Permet de récupérer les produits pour l'affichage dans un graphique.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesProduitsChart()

        {
            return GestionBoutique.executerRequeteSelect("SELECT NomFournisseur, COUNT(idFourn) AS Produit FROM produit, fournisseur WHERE (produit.idFourn = fournisseur.idFournisseur) GROUP BY NomFournisseur", "ProduitParFournisseur");
        }
    }
}
