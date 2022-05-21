using Bunifu.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace IAPM.Technique
{
    /// <summary>
    /// Classe utilitaire 
    /// </summary>
    public static class Utilitaire
    {
        /// <summary>
        /// Permet d'appeller une API.
        /// </summary>
        /// <param name="url">URL de l'API</param>
        /// <returns>Objet JSON (sérialiser) correspondant à la réponse de l'API</returns>
        /// <exception cref="Exception">Erreur venant de l'API</exception>
        public static dynamic getJson(string url)
        {
            try
            {
                WebRequest wr = WebRequest.Create(url);
                WebResponse res = wr.GetResponse();
                using (StreamReader reader = new StreamReader(res.GetResponseStream()))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject(json);
                }
            }
            catch (Exception)
            {
                throw new Exception("La requête à l'API a échouée.");
            }
        }

        /// <summary>
        /// Permet de revenir sur le formulaire FrmMenu
        /// en fermant celui en cours et en affichant le menu.
        /// </summary>
        /// <param name="leForm">Le formulaire courant</param>
        public static void retourneAuMenu(Form leForm)
        {
            FrmMenu frmMenu = new FrmMenu();
            leForm.Visible = false;
            frmMenu.ShowDialog();
            leForm.Close();
        }

        /// <summary>
        /// Permet d'afficher un formulaire en fermant celui en cours.
        /// </summary>
        /// <param name="leFormProchain">Le formulaire voulant être affiché</param>
        /// <param name="leFormCourant">Le formulaire courant</param>
        public static void afficherForm(Form leFormCourant, Form leFormProchain)
        {
            leFormCourant.Visible = false;
            leFormProchain.ShowDialog();
            leFormCourant.Close();
        }

        /// <summary>
        /// Permet d'actualiser la DataSource du DataGridView selon
        /// l'entrée texte du TextBox.
        /// </summary>
        /// <param name="leTextBox">Le TextBox fesant office de zone de recherche</param>
        /// <param name="leDataGridView">Le DataGridView affichant le/les résultats</param>
        /// <param name="laDataTable">La DataTable alimentant le DataGridView</param>
        public static void rechercheDatagridView(BunifuTextBox leTextBox, DataGridView leDataGridView, DataTable laDataTable)
        {
            string motCle;
            try
            {
                motCle = leTextBox.Text;
            }
            catch (InvalidCastException)
            {

                return;
            }
            leDataGridView.DataSource = laDataTable;
        }

        /// <summary>
        /// Permet de revenir en arrière de 1 position par rapport à la position courante du DataGridView.
        /// </summary>
        /// <param name="laPositionCourrante">Position actuelle de l'index de la ligne courrante</param>
        /// <returns>Position précedente</returns>
        public static int allerLignePrecedente(int laPositionCourrante)
        {
            if (laPositionCourrante > 0)
            {
                return laPositionCourrante -= 1;
            }
            else
            {
                return laPositionCourrante;
            }
        }

        /// <summary>
        /// Permet de d'avancer de 1 position par rapport à la position courante du DataGridView.
        /// </summary>
        /// <param name="laPositionCourrante">La position courante</param>
        /// <param name="positionMaximale">La plus grande position</param>
        /// <returns>Position suivante</returns>
        public static int allerLigneSuivante(int laPositionCourrante, int positionMaximale)
        {
            if (laPositionCourrante < positionMaximale - 1)
            {
                return laPositionCourrante += 1;
            }
            else
            {
                return laPositionCourrante;
            }
        }

        /// <summary>
        /// Permet de revenir au début.
        /// </summary>
        /// <returns>Première position</returns>
        public static int allerLigneDebut()
        {
            return 0;
        }

        /// <summary>
        /// Permet d'aller à la fin.
        /// </summary>
        /// <param name="laPositionMaximale">La plus grande position</param>
        /// <returns>Dernière position</returns>
        public static int allerLigneFin(int laPositionMaximale)
        {
            return laPositionMaximale - 1;
        }

        /// <summary>
        /// Permet d'alimenter une combobox.
        /// </summary>
        /// <param name="maCombo">La combobox</param>
        /// <param name="maDataTable">La DataTable</param>
        /// <param name="valueMember">La valeur à retourner</param>
        /// <param name="displayMember">La valeur à afficher</param>
        public static void alimenterComboBox(ComboBox maCombo, DataTable maDataTable, string valueMember, string displayMember)
        {
            maCombo.DataSource = maDataTable;
            maCombo.ValueMember = valueMember;
            maCombo.DisplayMember = displayMember;
        }
    }
}
