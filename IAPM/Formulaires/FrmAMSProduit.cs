using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;
using System.IO;
using IAPM.Metier;
using IAPM.Technique;
using Bunifu.Utils;


namespace IAPM
{
    public partial class FrmAMSProduit : BunifuForm
    {
        private bool changeInProgress = false;
        
        public FrmAMSProduit()
        {
            InitializeComponent();
        }

        private void FrmAMSProduit_Load(object sender, EventArgs e)
        {
            dgvAMSProduit.DataSource = GestionProduit.getLesProduitsDG();
            Utilitaire.alimenterComboBox(drpDownFournProduit, GestionFournisseur.getLesFournisseurs(), "idFournisseur", "NomFournisseur");
            Utilitaire.alimenterComboBox(drpDownCategProduit, GestionCategorie.getLesCategories(), "idCategorie", "LibelleCategorie");
            rafraichirAffichage();
        }
        
        private void dgvAMSProduit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changeInProgress)
            {
                rafraichirAffichage();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (tbIdProduit.Text != "")
            {
                string nom = dgvAMSProduit.Rows[dgvAMSProduit.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce fournisseur (" + nom + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GestionProduit.supprimerProduit(Convert.ToInt32(tbIdProduit.Text));
                    dgvAMSProduit.DataSource = GestionProduit.getLesProduitsDG();
                    snackBarAMSProduit.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    rafraichirAffichage();
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Valider")
            {
                int idProduit = Convert.ToInt32(tbIdProduit.Text);
                string libelleProduit = tbLibelleProduit.Text;
                int qteStockProduit = Convert.ToInt32(tbQteStockProduit.Text);
                float prixProduit = (float)Convert.ToDouble(tbPrixProduit.Text);
                int idFournisseurProduit = (int)drpDownFournProduit.SelectedValue;
                int idCategorieProduit = (int)drpDownCategProduit.SelectedValue;
                string imageProduit = tbCheminImageProduit.Text;

                GestionProduit.modifierProduit(idProduit, libelleProduit, prixProduit, qteStockProduit, idFournisseurProduit, idCategorieProduit, imageProduit);
                dgvAMSProduit.DataSource = GestionProduit.getLesProduitsDG();
                snackBarAMSProduit.Show(this, "La modification a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                desactiverTextBox();
                rafraichirAffichage();
                changeInProgress = false;
                btnModif.Text = "Modifier";
                btnAjout.Enabled = true;
                btnSuppr.Enabled = true;
                btnPdf.Enabled = true;
            }
            else
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
                int idProduit = GestionBoutique.genererClePrimaire("idProduit", "produit");
                string libelleProduit = tbLibelleProduit.Text;
                int qteStockProduit = Convert.ToInt32(tbQteStockProduit.Text);
                float prixProduit = (float)Convert.ToDouble(tbPrixProduit.Text);
                int idFournisseurProduit = (int)drpDownFournProduit.SelectedValue;
                int idCategorieProduit = (int)drpDownCategProduit.SelectedValue;
                string imageProduit = tbCheminImageProduit.Text;

                GestionProduit.ajouterProduit(idProduit, libelleProduit, prixProduit, qteStockProduit, idFournisseurProduit, idCategorieProduit, imageProduit);
                dgvAMSProduit.DataSource = GestionProduit.getLesProduitsDG();
                snackBarAMSProduit.Show(this, "L'ajout a bien été effectué.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                desactiverTextBox();
                rafraichirAffichage();
                changeInProgress = false;
                btnAjout.Text = "Ajouter";
                btnModif.Enabled = true;
                btnSuppr.Enabled = true;
                btnPdf.Enabled = true;
            }
            else
            {
                changeInProgress = true;
                btnAjout.Text = "Valider";
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                btnPdf.Enabled = false;
                viderTextBox();
                tbIdProduit.Text = (GestionProduit.getNBProduits() + 1).ToString();
                activerTextBox();
            }
        }
        
        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvAMSProduit, "Liste des produits", saveFileDialogPDF);
            snackBarAMSProduit.Show(this, "Votre PDF à bien été enregistré.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
        }

        private void rafraichirAffichage()
        {
            // Récupère toutes la table produit
            DataTable lesProduits = GestionProduit.getLesProduits();
            // Récupère l'index courant
            int indexCourrant = dgvAMSProduit.CurrentCell.RowIndex;
            // Met à jour les valeurs dans les TextBoxs
            tbIdProduit.Text = lesProduits.Rows[indexCourrant][0].ToString();
            tbLibelleProduit.Text = lesProduits.Rows[indexCourrant][1].ToString();
            tbPrixProduit.Text = lesProduits.Rows[indexCourrant][2].ToString();
            tbQteStockProduit.Text = lesProduits.Rows[indexCourrant][3].ToString();
            drpDownFournProduit.SelectedValue = lesProduits.Rows[indexCourrant][4].ToString();
            drpDownCategProduit.SelectedValue = lesProduits.Rows[indexCourrant][5].ToString();
            tbCheminImageProduit.Text = lesProduits.Rows[indexCourrant][6].ToString();
            pbProduit.ImageLocation = Application.StartupPath + "\\ImagesProduits\\" + lesProduits.Rows[indexCourrant][6].ToString();
        }
        
        public void desactiverTextBox()
        {
            tbLibelleProduit.Enabled = false;
            tbPrixProduit.Enabled = false;
            tbQteStockProduit.Enabled = false;
            drpDownFournProduit.Enabled = false;
            drpDownCategProduit.Enabled = false;
            tbCheminImageProduit.Enabled = false;
        }

        public void activerTextBox()
        {
            tbLibelleProduit.Enabled = true;
            tbPrixProduit.Enabled = true;
            tbQteStockProduit.Enabled = true;
            drpDownFournProduit.Enabled = true;
            drpDownCategProduit.Enabled = true;
            tbCheminImageProduit.Enabled = true;
        }

        public void viderTextBox()
        {
            tbLibelleProduit.Text = "";
            tbPrixProduit.Text = "";
            tbQteStockProduit.Text = "";
            tbCheminImageProduit.Text = "";
        }

        private void FrmAMSProduit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestionBoutique.viderJeuDonnees();
            Utilitaire.retourneAuMenu(this);
        }

        private void FrmAMSProduit_KeyDown(object sender, KeyEventArgs e)
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
    }
}
