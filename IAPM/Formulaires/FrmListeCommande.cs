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
    public partial class FrmListeCommande : BunifuForm
    {
        public FrmListeCommande()
        {
            InitializeComponent();
        }

        private void FrmListeCommande_Load(object sender, EventArgs e)
        {
            dgvCommande.DataSource = GestionCommande.getLesCommandesDG();
        }

        private void FrmListeCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            this.Visible = false;
            frmMenu.ShowDialog();
            this.Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvCommande, "Liste des commandes", saveFileDialogPDF);
        }
    }
}
