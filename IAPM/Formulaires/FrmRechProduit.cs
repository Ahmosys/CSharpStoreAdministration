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
using IAPM.Technique;
using IAPM.Metier;

namespace IAPM
{
    public partial class FrmRechProduit : BunifuForm
    {
        public FrmRechProduit()
        {
            InitializeComponent();
        }

        private void FrmRechProduit_Load(object sender, EventArgs e)
        {
            dgvRechProduit.DataSource = GestionProduit.getLesProduitsDG();
        }

        private void tbMotCle_TextChange(object sender, EventArgs e)
        {
            Utilitaire.rechercheDatagridView(tbMotCle, dgvRechProduit, GestionProduit.rechercherProduit(tbMotCle.Text));
        }

        private void FrmRechProduit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }
    }
}
