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
    public partial class FrmAMSClient : BunifuForm
    {
        // Permet de savoir si une modification/supression/ajout est en cours.
        private bool changeInProgress = false;
        
        public FrmAMSClient()
        {
            InitializeComponent();
        }

        private void FrmAMSClient_Load(object sender, EventArgs e)
        {
            dgvAMSClient.DataSource = GestionClient.getLesClients1();
        }

        private void dgvAMSClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changeInProgress)
            {
                rafraichirAffichage();    
            }
        }
        
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            // Vérifie qu'un client soit sélectionné
            if (tbIdClient.Text != "")
            {
                // Récupère le nom du client
                string nom = dgvAMSClient.Rows[dgvAMSClient.CurrentCell.RowIndex].Cells[4].Value.ToString() + " " + dgvAMSClient.Rows[dgvAMSClient.CurrentCell.RowIndex].Cells[3].Value.ToString();
                // Demande confirmation de la suppression
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce client (" + nom + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Supprime le client en base de données
                    GestionClient.supprimerClient(Convert.ToInt32(tbIdClient.Text));
                    dgvAMSClient.DataSource = GestionClient.getLesClients1();
                    snackBarAMSClient.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    rafraichirAffichage();
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Valider")
            {
                int idClient = Convert.ToInt32(tbIdClient.Text);
                string loginClient = tbLoginClient.Text;
                string mdpClient = tbMdpClient.Text;
                string nomClient = tbNomClient.Text;
                string prenomClient = tbPrenomClient.Text;
                string emailClient = tbEmailClient.Text;
                string telClient = tbTelClient.Text;
                string rueClient = tbRueClient.Text;
                int cpClient = Convert.ToInt32(tbCpClient.Text);
                string villeClient = tbVilleClient.Text;
                GestionClient.modifierClient(idClient, loginClient, mdpClient, nomClient, prenomClient, emailClient, telClient, rueClient, cpClient, villeClient);
                dgvAMSClient.DataSource = GestionClient.getLesClients1();
                snackBarAMSClient.Show(this, "La modification a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                desactiverTextBox();
                rafraichirAffichage();
                btnModif.Text = "Modifier";
                btnAjout.Enabled = true;
                btnSuppr.Enabled = true;
                btnPdf.Enabled = true;
            } else
            {
                changeInProgress = true;
                btnModif.Text = "Valider";
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                btnPdf.Enabled = false;
                activerTextBox();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Valider")
            {
                string loginClient = tbLoginClient.Text;
                string mdpClient = tbMdpClient.Text;
                string nomClient = tbNomClient.Text;
                string prenomClient = tbPrenomClient.Text;
                string emailClient = tbEmailClient.Text;
                string telClient = tbTelClient.Text;
                string rueClient = tbRueClient.Text;
                int cpClient = Convert.ToInt32(tbCpClient.Text);
                string villeClient = tbVilleClient.Text;
                GestionClient.ajouterClient(loginClient, mdpClient, nomClient, prenomClient, emailClient, telClient, rueClient, cpClient, villeClient);
                dgvAMSClient.DataSource = GestionClient.getLesClients1();
                snackBarAMSClient.Show(this, "L'ajout a bien été effectué.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                desactiverTextBox();
                rafraichirAffichage();
                changeInProgress = false;
                btnAjout.Text = "Ajouter";
                btnModif.Enabled = true;
                btnSuppr.Enabled = true;
                btnPdf.Enabled = true;
            } else
            {
                changeInProgress = true;
                btnAjout.Text = "Valider";
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                btnPdf.Enabled = false;
                viderTextBox();
                tbIdClient.Text = (GestionClient.getNBClients() + 1).ToString();
                activerTextBox();
            }
        }
        private void FrmAMSClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (changeInProgress && e.KeyCode == Keys.Escape)
            {
                changeInProgress = false;
                btnAjout.Text = "Ajouter";
                btnModif.Text = "Modifier";
                btnAjout.Enabled = true;
                btnModif.Enabled = true;
                btnSuppr.Enabled = true;
                btnPdf.Enabled = true;
                desactiverTextBox();
                rafraichirAffichage();
            }
        }
        
        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvAMSClient, "Liste des clients", saveFileDialogPDF);
            snackBarAMSClient.Show(this, "Votre PDF à bien été enregistré.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
        }

        private void rafraichirAffichage()
        {
            // Récupère l'index courant
            int indexCourrant = dgvAMSClient.CurrentCell.RowIndex;
            // Met à jour les valeurs dans les TextBoxs
            tbIdClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[0].Value.ToString();
            tbLoginClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[1].Value.ToString();
            tbMdpClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[2].Value.ToString();
            tbNomClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[3].Value.ToString();
            tbPrenomClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[4].Value.ToString();
            tbEmailClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[5].Value.ToString();
            tbTelClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[6].Value.ToString();
            tbRueClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[7].Value.ToString();
            tbCpClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[8].Value.ToString();
            tbVilleClient.Text = dgvAMSClient.Rows[indexCourrant].Cells[9].Value.ToString();
        }
        
        public void desactiverTextBox()
        {
            tbLoginClient.Enabled = false;
            tbMdpClient.Enabled = false;
            tbNomClient.Enabled = false;
            tbPrenomClient.Enabled = false;
            tbEmailClient.Enabled = false;
            tbTelClient.Enabled = false;
            tbRueClient.Enabled = false;
            tbCpClient.Enabled = false;
            tbVilleClient.Enabled = false;
        }

        public void activerTextBox()
        {
            tbLoginClient.Enabled = true;
            tbMdpClient.Enabled = true;
            tbNomClient.Enabled = true;
            tbPrenomClient.Enabled = true;
            tbEmailClient.Enabled = true;
            tbTelClient.Enabled = true;
            tbRueClient.Enabled = true;
            tbCpClient.Enabled = true;
            tbVilleClient.Enabled = true;
        }

        public void viderTextBox()
        {
            tbLoginClient.Text = "";
            tbMdpClient.Text = "";
            tbNomClient.Text = "";
            tbPrenomClient.Text = "";
            tbEmailClient.Text = "";
            tbTelClient.Text = "";
            tbRueClient.Text = "";
            tbCpClient.Text = "";
            tbVilleClient.Text = "";
        }

        private void FrmAMSClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestionBoutique.viderJeuDonnees();
            Utilitaire.retourneAuMenu(this);
        }
    }               
}
