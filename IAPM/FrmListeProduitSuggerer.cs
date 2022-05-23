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
    public partial class FrmListeProduitSuggerer : BunifuForm
    {
        public FrmListeProduitSuggerer()
        {
            InitializeComponent();
        }

        private void FrmListeProduitSuggerer_Load(object sender, EventArgs e)
        {
            Utilitaire.alimenterComboBox(drpDownProduit, GestionProduit.getLesProduitsSuggestion(), "idProduit", "LibelleProduit");
            Utilitaire.alimenterComboBox(drpDownProduitSuggestion, GestionProduit.getLesProduitsNonSuggererByIdProduitSuggestion(Convert.ToInt32(drpDownProduit.SelectedValue)), "idProduit", "LibelleProduit");
        }

        private void drpDownProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            rafraichirAffichage();
        }

        public void rafraichirAffichage()
        {
            try
            {
                dgvProduitSuggerer.DataSource = GestionProduit.getLesProduitsSuggererByIdProduitSuggestion(Convert.ToInt32(drpDownProduit.SelectedValue));
                Utilitaire.alimenterComboBox(drpDownProduitSuggestion, GestionProduit.getLesProduitsNonSuggererByIdProduitSuggestion(Convert.ToInt32(drpDownProduit.SelectedValue)), "idProduit", "LibelleProduit");
            } catch {
                dgvProduitSuggerer.DataSource = null;
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Ajouter")
            {
                btnAjout.Text = "Valider";
                drpDownProduitSuggestion.Enabled = true;
                drpDownProduitSuggestion.SelectedIndex = -1;
                btnSuppr.Enabled = false;
            } else
            {
                try
                {
                    GestionProduit.ajouterProduitSuggerer(Convert.ToInt32(drpDownProduit.SelectedValue), Convert.ToInt32(drpDownProduitSuggestion.SelectedValue));
                    btnAjout.Text = "Ajouter";
                    btnSuppr.Enabled = true;
                    drpDownProduitSuggestion.Enabled = false;
                    rafraichirAffichage();
                    snackBarListeProduitSuggestion.Show(this, "L'ajout a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                }
                catch (Exception ex)
                {
                    snackBarListeProduitSuggestion.Show(this, ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2500);
                    btnAjout.Text = "Ajouter";
                    btnSuppr.Enabled = true;
                    drpDownProduitSuggestion.Enabled = false;
                }
                
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            string libelleProduitSuggerer = dgvProduitSuggerer.Rows[dgvProduitSuggerer.CurrentCell.RowIndex].Cells[1].Value.ToString();
            int idProduitSuggerer = (int)dgvProduitSuggerer.Rows[dgvProduitSuggerer.CurrentCell.RowIndex].Cells[0].Value;
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce produit (" + libelleProduitSuggerer + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GestionProduit.supprimerProduitSuggerer(Convert.ToInt32(drpDownProduit.SelectedValue), idProduitSuggerer);
                snackBarListeProduitSuggestion.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                rafraichirAffichage();
            }

        }

        private void FrmListeProduitSuggerer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilitaire.retourneAuMenu(this);
        }
    }
}
