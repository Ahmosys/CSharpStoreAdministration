using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IAPM.Metier;
using IAPM.Technique;
using Bunifu.Utils;

namespace IAPM
{
    public partial class FrmRechClient : BunifuForm
    {
        public FrmRechClient()
        {
            InitializeComponent();
        }

        private void FrmRechClient_Load(object sender, EventArgs e)
        {
            dgvRechClient.DataSource = GestionClient.getLesClients1();
        }

        private void tbMotCle_TextChange(object sender, EventArgs e)
        {
            Utilitaire.rechercheDatagridView(tbMotCle, dgvRechClient, GestionClient.rechercherClient(tbMotCle.Text));
        }
        
        private void dgvRechClient_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Index de la ligne actuelle
            int rowIndex = e.Row.Index;
            // Récupération de l'id de la ligne
            int id = Convert.ToInt32(dgvRechClient.Rows[rowIndex].Cells[0].Value);
            // Récupération du nom du client
            string nom = dgvRechClient.Rows[rowIndex].Cells[4].Value.ToString() + " " + dgvRechClient.Rows[rowIndex].Cells[3].Value.ToString();
            // Confirmation supression BDD
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce client (" + (nom) + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Supprime le client en base de données
                GestionClient.supprimerClient(id);
                snackBarClient.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
            }
            else
            {
                // Annule la suppression
                e.Cancel = true;
            }
        }

        private void FrmRechClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }
    }
}
