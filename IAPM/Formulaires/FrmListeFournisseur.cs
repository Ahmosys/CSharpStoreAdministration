using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Utils;
using IAPM.Metier;
using IAPM.Technique;

namespace IAPM
{
    public partial class FrmListeFournisseur : BunifuForm
    {
        public FrmListeFournisseur()
        {
            InitializeComponent();
        }

        private void FrmListeFournisseur_Load(object sender, EventArgs e)
        {
            dgvFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();
        }

        private void FrmListeFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvFournisseur, "Liste des fournisseurs", saveFileDialogPDF);
        }
    }
}
