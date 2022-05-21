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
    public partial class FrmListeProduit : BunifuForm
    {
        public FrmListeProduit()
        {
            InitializeComponent();
        }

        private void FrmListeProduit_Load(object sender, EventArgs e)
        {
            dgvProduit.DataSource = GestionProduit.getLesProduitsDG();
        }

        private void FrmListeProduit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvProduit, "Liste des produits", saveFileDialogPDF);
        }
    }
}
