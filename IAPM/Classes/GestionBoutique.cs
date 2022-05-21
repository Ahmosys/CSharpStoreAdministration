using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace IAPM.Technique
{
    /// <summary>
    /// Classe interagissant avec la base de données SQL.
    /// </summary>
    public static class GestionBoutique
    {
        #region Champs statiques
        public static MySqlConnection maConnexion = new MySqlConnection();
        public static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        public static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        public static DataSet monJeuDeDonnees = new DataSet();
        public static string maRequete;
        public static bool isConnecter = false;
        public static string nomUtilisateur = "Inconnue";
        public static bool formHasAlreadyOpen = false;
        #endregion

        #region Méthodes statiques
        /// <summary>
        /// Méthode pour crée une connexion à la BDD.
        /// </summary>
        /// <param name="nomServeur">IP / DNS du serveur de base de données</param>
        /// <param name="nomBdd">Nom de la base de données</param>
        /// <param name="nomUtilisateur">Nom d'utilisateur</param>
        /// <param name="motDePasse">Mot de passe</param>
        public static void seConnecter(String nomServeur, String nomBdd, String nomUtilisateur, String motDePasse)
        {
            string maChaine = "Server=" + nomServeur + ";Database=" + nomBdd + "; Uid=" + nomUtilisateur + ";Pwd=" + motDePasse + ";";
            if (maConnexion.State == ConnectionState.Closed)
            {
                maConnexion.ConnectionString = maChaine;
                maConnexion.Open();
                monJeuDeDonnees = new DataSet("IAMP_DATASET");
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;
                GestionBoutique.nomUtilisateur = nomUtilisateur;
            }

        }

        /// <summary>
        /// Méthode pour vider le jeu de données (mémoire).
        /// </summary>
        public static void viderJeuDonnees()
        {
            monJeuDeDonnees.Clear();
        }

        /// <summary>
        /// Fonction pour éxécuter requête select.
        /// </summary>
        /// <param name="texteRequete">La requête</param>
        /// <param name="monJeuDonnees">Le nom du jeu de données</param>
        /// <returns>DataTable</returns>
        public static DataTable executerRequeteSelect(string texteRequete, string monJeuDonnees)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            if (GestionBoutique.monJeuDeDonnees.Tables.Contains(monJeuDonnees))
            {
                monJeuDeDonnees.Tables[monJeuDonnees].Clear();
            }
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, monJeuDonnees);
            return GestionBoutique.monJeuDeDonnees.Tables[monJeuDonnees];
        }

        /// <summary>
        /// Méthode pour éxécuter requête action.
        /// </summary>
        /// <param name="texteRequete">La requête</param>
        public static void executerRequeteAction(string texteRequete)
        {
            GestionBoutique.maRequete = texteRequete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        /// <summary>
        /// Fonction permettant de générer une clé primaire.
        /// </summary>
        /// <param name="nomcle">Nom de l'attribut clé primaire</param>
        /// <param name="nomtable">Nom de ta table</param>
        /// <returns></returns>
        public static int genererClePrimaire(string nomcle, string nomtable)
        {
            int Cle;
            GestionBoutique.maRequete = "SELECT Max(" + nomcle + ") FROM " + nomtable;
            GestionBoutique.maCommandeSpecialRequete.CommandText = maRequete;
            // Utilisez la ExecuteScalar méthode pour récupérer une valeur unique (par exemple, une valeur d’agrégation) à partir d’une base de données.
            Cle = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return (Cle + 1);
        }
        #endregion
    }
}
