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
    public partial class FrmRechFournisseur : BunifuForm
    {
        public FrmRechFournisseur()
        {
            InitializeComponent();
        }

        private void FrmRechFournisseur_Load(object sender, EventArgs e)
        {
            dgvRechFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();            
        }

        private void tbMotCle_TextChange(object sender, EventArgs e)
        {
            Utilitaire.rechercheDatagridView(tbMotCle, dgvRechFournisseur, GestionFournisseur.rechercherFournisseur(tbMotCle.Text));
        }

        private void FrmRechFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }
    }
}
