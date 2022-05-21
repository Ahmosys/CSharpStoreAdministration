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
    public partial class FrmAMSFournisseur : BunifuForm
    {
        private bool changeInProgress = false;

        public FrmAMSFournisseur()
        {
            InitializeComponent();
        }

        private void FrmAMSFournisseur_Load(object sender, EventArgs e)
        {
            dgvAMSFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();
        }

        private void dgvAMSFournisseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changeInProgress)
            {
                rafraichirAffichage();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (tbIdFournisseur.Text != "")
            {
                string nom = dgvAMSFournisseur.Rows[dgvAMSFournisseur.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce fournisseur (" + nom + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GestionFournisseur.supprimerFournisseur(Convert.ToInt32(tbIdFournisseur.Text));
                    dgvAMSFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();
                    snackBarAMSFournisseur.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    rafraichirAffichage();
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Valider")
            {
                int idFournisseur = Convert.ToInt32(tbIdFournisseur.Text);
                int codePostalFournisseur = Convert.ToInt32(tbCpFournisseur.Text);
                string nomFournisseur = tbNomFournisseur.Text;
                string villeFournisseur = tbVilleFournisseur.Text;
             
                GestionFournisseur.modifierFournisseur(idFournisseur, nomFournisseur, villeFournisseur, codePostalFournisseur);
                dgvAMSFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();
                snackBarAMSFournisseur.Show(this, "La modification a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
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
                int idFournisseur = GestionBoutique.genererClePrimaire("idFournisseur", "fournisseur") ;
                int codePostalFournisseur = Convert.ToInt32(tbCpFournisseur.Text);
                string nomFournisseur = tbNomFournisseur.Text;
                string villeFournisseur = tbVilleFournisseur.Text;

                GestionFournisseur.ajouterFournisseur(idFournisseur, nomFournisseur, villeFournisseur, codePostalFournisseur);
                dgvAMSFournisseur.DataSource = GestionFournisseur.getLesFournisseurs();
                snackBarAMSFournisseur.Show(this, "L'ajout a bien été effectué.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
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
                tbIdFournisseur.Text = (GestionFournisseur.getNBFournisseurs() + 1).ToString();
                activerTextBox();
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            GestionInterface.genererPdf(ktReportPDF, dgvAMSFournisseur, "Liste des fournisseurs", saveFileDialogPDF);
            snackBarAMSFournisseur.Show(this, "Votre PDF à bien été enregistré.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
        }

        private void rafraichirAffichage()
        {
            // Récupère l'index courant
            int indexCourrant = dgvAMSFournisseur.CurrentCell.RowIndex;
            // Met à jour les valeurs dans les TextBoxs
            tbIdFournisseur.Text = dgvAMSFournisseur.Rows[indexCourrant].Cells[0].Value.ToString();
            tbNomFournisseur.Text = dgvAMSFournisseur.Rows[indexCourrant].Cells[1].Value.ToString();
            tbVilleFournisseur.Text = dgvAMSFournisseur.Rows[indexCourrant].Cells[2].Value.ToString();
            tbCpFournisseur.Text = dgvAMSFournisseur.Rows[indexCourrant].Cells[3].Value.ToString();
        }
        public void desactiverTextBox()
        {
            tbNomFournisseur.Enabled = false;
            tbVilleFournisseur.Enabled = false;
            tbCpFournisseur.Enabled = false;
        }

        public void activerTextBox()
        {
            tbNomFournisseur.Enabled = true;
            tbVilleFournisseur.Enabled = true;
            tbCpFournisseur.Enabled = true;
        }

        public void viderTextBox()
        {
            tbNomFournisseur.Text = "";
            tbVilleFournisseur.Text = "";
            tbCpFournisseur.Text = "";
        }

        private void FrmAMSFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestionBoutique.viderJeuDonnees();
            Utilitaire.retourneAuMenu(this);
        }
    }
}
