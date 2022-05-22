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
    public partial class FrmAMSCommande : BunifuForm
    {
        private bool changeInProgress = false;
        
        public FrmAMSCommande()
        {
            InitializeComponent();
        }

        private void FrmAMSCommande_Load(object sender, EventArgs e)
        {
            dgvAMSCommande.DataSource = GestionCommande.getLesCommandesDG();
            Utilitaire.alimenterComboBox(drpDownClientCommande, GestionClient.getLesClientsCommandes(), "idUtilisateur", "Patronyme");
            rafraichirAffichage();
        }

        private void FrmAMSCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestionBoutique.viderJeuDonnees();
            Utilitaire.retourneAuMenu(this);
        }
        private void dgvAMSCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changeInProgress)
            {
                rafraichirAffichage();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (tbIdCommande.Text != "")
            {
                string nom = dgvAMSCommande.Rows[dgvAMSCommande.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette commande (" + nom + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvAMSCommande.DataSource = GestionCommande.getLesCommandesDG();
                    snackBarAMSCommande.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    rafraichirAffichage();
                }
            }
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {
            FrmDetailCommande frmDetailCommande = new FrmDetailCommande(Convert.ToInt32(tbIdCommande.Text), dtPickerCommande.Text, drpDownClientCommande.Text);
            Utilitaire.afficherForm(this, frmDetailCommande);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Valider")
            {
                try // Capture l'exception soulevé par le déclencheur
                {
                    int idCommande = GestionBoutique.genererClePrimaire("idCommande", "commande");
                    int idClient = Convert.ToInt32(drpDownClientCommande.SelectedValue);
                    string patronymeClient = drpDownClientCommande.Text;
                    string dateCommande = dtPickerCommande.Value.ToShortDateString();

                    GestionCommande.ajouterCommande(idCommande, dateCommande, idClient);
                    snackBarAMSCommande.Show(this, "L'ajout a bien été effectué, redirection vers le formulaire d'ajout de produit...", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    desactiverTextBox();
                    rafraichirAffichage();
                    changeInProgress = false;
                    btnAjouter.Text = "Nouvelle commande";
                    btnModif.Enabled = true;
                    btnSuppr.Enabled = true;
                    btnConsulter.Enabled = true;
                    Task.Delay(500);
                    FrmDetailCommande frmDetailCommande = new FrmDetailCommande(idCommande, dateCommande, patronymeClient);
                    Utilitaire.afficherForm(this, frmDetailCommande);
                }
                catch (Exception ex) // Affiche le message d'erreur provenant du déclencheur (!verifSoldeInsert)
                {
                    snackBarAMSCommande.Show(this, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2500);
                }      
            }
            else
            {
                changeInProgress = true;
                btnAjouter.Text = "Valider";
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                btnConsulter.Enabled = false;
                tbIdCommande.Text = (GestionCommande.getNBCommandes() + 1).ToString();
                Utilitaire.alimenterComboBox(drpDownClientCommande, GestionClient.getLesClients(), "idUtilisateur", "Patronyme");
                activerTextBox();
            }
        }

        public void rafraichirAffichage()
        {
            DataTable lesCommandes = GestionCommande.getLesCommandes();
            int indexCourrant = dgvAMSCommande.CurrentCell.RowIndex;
            tbIdCommande.Text = lesCommandes.Rows[indexCourrant][0].ToString();
            dtPickerCommande.Value = Convert.ToDateTime(lesCommandes.Rows[indexCourrant][1].ToString());
            drpDownClientCommande.SelectedValue = lesCommandes.Rows[indexCourrant][3].ToString();
        }

        public void desactiverTextBox()
        {
            drpDownClientCommande.Enabled = false;
            dtPickerCommande.Enabled = false;
        }

        public void activerTextBox()
        {
            drpDownClientCommande.Enabled = true;
            dtPickerCommande.Enabled = true;
        }

    }
}

