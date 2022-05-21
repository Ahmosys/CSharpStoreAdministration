using IAPM.Technique;
using System;
using System.Data;


namespace IAPM.Metier
{
    /// <summary>
    /// Classe de gestion des données de la table "commande".
    /// </summary>
    public static class GestionCommande
    {
        /// <summary>
        /// Permet de récupérer les commandes dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesCommandes()

        {
            return GestionBoutique.executerRequeteSelect("SELECT idCommande, DateCommande, CONCAT(nomUtilisateur,' ',prenomUtilisateur) AS Patronyme, commande.idUtilisateur FROM commande, utilisateur WHERE (commande.idUtilisateur = utilisateur.idUtilisateur) ORDER BY idCommande ASC", "TouteLesCommandes");
        }

        /// <summary>
        /// Permet de récupérer les commandes dans la base de données pour l'affichage dans DGV.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesCommandesDG()

        {
            return GestionBoutique.executerRequeteSelect("SELECT commande.idCommande, DateCommande ,CONCAT(nomUtilisateur,' ',prenomUtilisateur) AS Patronyme, SUM(QuantiteCom*PrixHTProduit) AS MontantHT FROM utilisateur, commande, produit, lignedecommande WHERE (utilisateur.idUtilisateur = commande.idUtilisateur) AND (commande.idCommande = lignedecommande.idCommande) AND (lignedecommande.idProduit = produit.idProduit) GROUP BY commande.idCommande", "ToutesLesCommandesDG");
        }

        /// <summary>
        /// Permet de récupérer une commande dans la base de données pour l'affichage dans DGV.
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public static DataTable getLaCommandeByIdDG(int idCommande)

        {
            return GestionBoutique.executerRequeteSelect("SELECT lignedecommande.idCommande, LibelleProduit, QuantiteCom, CONCAT(QuantiteCom*PrixHTProduit, ' ', '€') AS MontantHT FROM lignedecommande, commande, produit WHERE (lignedecommande.idCommande = commande.idCommande) AND (lignedecommande.idProduit = produit.idProduit) AND (lignedecommande.idCommande = " + idCommande + ")", "ProduitsParIdCommandeDG");
        }

        /// <summary>
        /// Permet de récupérer une commande dans la base de données.
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public static DataTable getLaCommandeById(int idCommande)

        {
            return GestionBoutique.executerRequeteSelect("SELECT lignedecommande.idCommande, LibelleProduit, QuantiteCom, produit.idCat, produit.idProduit,  CONCAT(QuantiteCom*PrixHTProduit, ' ', '€') AS MontantHT FROM lignedecommande, commande, produit WHERE (lignedecommande.idCommande = commande.idCommande) AND (lignedecommande.idProduit = produit.idProduit) AND (lignedecommande.idCommande =" + idCommande + ")", "ProduitsParIdCommande");
        }

        /// <summary>
        /// Permet de récupérer le montant total en euros d'une commande.
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public static int getMontantHTByCommande(int idCommande)

        {
            int montantHT;
            GestionBoutique.maRequete = "SELECT SUM(QuantiteCom*PrixHTProduit) AS MontantHT FROM lignedecommande, commande, produit WHERE (lignedecommande.idCommande = commande.idCommande) AND (lignedecommande.idProduit = produit.idProduit) AND (lignedecommande.idCommande = " + idCommande + ")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            montantHT = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return montantHT;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de commande par client pour l'affichage dans un graphique.
        /// </summary>
        /// <returns></returns>
        public static DataTable getLesCommandesChart()

        {
            return GestionBoutique.executerRequeteSelect("SELECT nomUtilisateur, COUNT(utilisateur.idUtilisateur) AS Commande FROM commande, utilisateur WHERE(utilisateur.idUtilisateur = commande.idUtilisateur) GROUP BY nomUtilisateur", "CommandeParClient");
        }

        /// <summary>
        /// Permet de le nombre d'occurence de la table commande dans la base de données.
        /// </summary>
        /// <returns></returns>
        public static int getNBCommandes()
        {
            int nbCommandes = 0;
            GestionBoutique.maRequete = "SELECT Count(*) FROM commande";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            nbCommandes = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return nbCommandes;
        }

        /// <summary>
        ///  Permet  d'ajouter une commande dans la base de données. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="date"></param>
        /// <param name="client"></param>
        public static void ajouterCommande(int code, string date, int client)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO commande (idCommande, DateCommande, idUtilisateur) VALUES (" + code + ", '" + date + "'," + client + ")");
        }

        /// <summary>
        ///  Permet  de supprimer une commande dans la base de données.
        /// </summary>
        /// <param name="codeCommande"></param>
        public static void supprimerCommande(int codeCommande)
        {

            GestionBoutique.executerRequeteAction("DELETE FROM commande Where idCommande = " + codeCommande + "");
        }

        /// <summary>
        /// Permet d'ajouter une produit à une commande.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idProduit"></param>
        /// <param name="qteCommande"></param>
        public static void ajouterProduitByCommande(int id, int idProduit, int qteCommande)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO lignedecommande VALUES (" + id + ", " + idProduit + "," + qteCommande + ")");
        }

        /// <summary>
        /// Permet de modifier la quantité d'un produit dans une commande.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idProduit"></param>
        /// <param name="qte"></param>
        public static void modifierQteByCommande(int id, int idProduit, int qte)
        {
            GestionBoutique.executerRequeteAction("UPDATE lignedecommande  SET QuantiteCom = QuantiteCom + " + qte + " WHERE (idCommande = " + id + ") AND (idProduit = " + idProduit + ")");
        }

        /// <summary>
        /// Permet de supprimer un produit dans une commande.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idProduit"></param>
        public static void supprimerProduitByCommande(int id, int idProduit)
        {
            GestionBoutique.executerRequeteAction("DELETE FROM lignedecommande WHERE (idCommande = " + id + ") AND (idProduit = " + idProduit + ")");
        }

        /// <summary>
        /// Permet de récupérer la quantité en stock d'un produit.
        /// </summary>
        /// <param name="idProduit"></param>
        /// <returns></returns>
        public static int getQteProduitStock(int idProduit)
        {
            GestionBoutique.maRequete = "SELECT QteStockProduit FROM produit WHERE (idProduit = " + idProduit + ")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
    }
}
