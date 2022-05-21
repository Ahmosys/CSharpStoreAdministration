using Kimtoo.Reports;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IAPM.Technique
{
    /// <summary>
    /// Classe interagissant avec l'interface des formulaires.
    /// </summary>
    public static class GestionInterface
    {
        /// <summary>
        /// Permet de générer un PDF.
        /// </summary>
        /// <param name="leReport">L'objet khreport</param>
        /// <param name="leDataGridView">L'objet DataGridView</param>
        /// <param name="leTitre">Le titre du PDF</param>
        /// <param name="leSaveFile">L'objet SaveFileDialog</param>
        public static void genererPdf(ktReport leReport, DataGridView leDataGridView, string leTitre, SaveFileDialog leSaveFile)
        {
            // Ajoute un texte
            leReport.AddString(leTitre);
            // Ajoute deux sauts de lignes
            leReport.AddLineBreak();
            leReport.AddLineBreak();
            // Ajoute le datagridview
            leReport.AddDatagridView(leDataGridView, "border=0;");
            // Ajoute le filtre pour le sfd
            leSaveFile.Filter = "PDF(*.pdf)|*.pdf";
            // Si clic sur bouton OK
            if (leSaveFile.ShowDialog() == DialogResult.OK)
            {
                // Enregistre le PDF
                string path = Path.GetFullPath(leSaveFile.FileName);
                leReport.SavePDF(path);
            }
        }

        /// <summary>
        /// Permet de vérifier si les champs texts des textboxs sont vide ou non.
        /// </summary>
        /// <param name="lesTextbox">Liste des textbox à verifier</param>
        /// <returns>True si toutes les textbox sont remplis, sinon False</returns>
        public static bool textboxsHasText(List<TextBox> lesTextbox)
        {
            foreach (TextBox laTextbox in lesTextbox)
            {
                if (laTextbox.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Permet de vérifier si le champs texte de la textbox est vide ou non.
        /// </summary>
        /// <param name="laTextbox">La textbox</param>
        /// <returns>True si toutes la textbox est remplis, sinon False</returns>
        public static bool hasText(Bunifu.UI.WinForms.BunifuTextBox laTextbox)
        {
            return laTextbox.Text != "";
        }

        /// <summary>
        /// Permet de mettre la première lettre d'un mot en majuscule le reste en minuscule.
        /// </summary>
        /// <param name="laChaine">La chaîne de caractère</param>
        /// <returns>La chaîne de caractère modifiée</returns>
        public static string premiereLettreMaj(string laChaine)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(laChaine);
        }

    }
}
