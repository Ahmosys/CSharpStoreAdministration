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
    public partial class FrmDetailCommande : BunifuForm
    {
        private bool changeInProgress = false;
        
        public FrmDetailCommande()
        {
            InitializeComponent();
        }
        public FrmDetailCommande(int idCommande, string dateCommande, string patronymeClient)
        {
            InitializeComponent();
            // Permet de passer les informations du précédent formulaire à celui-ci.
            tbIdCommande.Text = idCommande.ToString();
            tbDateCommande.Text = dateCommande;
            tbClientCommande.Text = patronymeClient;
        }

        private void FrmDetailCommande_Load(object sender, EventArgs e)
        {
            dgvAMSProduitCommande.DataSource = GestionCommande.getLaCommandeByIdDG(Convert.ToInt32(tbIdCommande.Text));
            remplirComboBox();
            // rafraichirAffichage();
        }
        
        private void dgvAMSProduitCommande_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!changeInProgress)
            {
                rafraichirAffichage();
            }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "Valider")
            {    
                int idCommande = Convert.ToInt32(tbIdCommande.Text);
                int idProduit = Convert.ToInt32(drpDownProduit.SelectedValue);
                int quantiteCommande = Convert.ToInt32(tbQuantiteProduit.Text);
                int quantiteStock = GestionCommande.getQteProduitStock(idProduit);

                if (quantiteCommande <= 0)
                {
                    snackBarDetailCommande.Show(this, "La quantité commandée ne peut pas être inférieure ou égale à zéro.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 3000);
                } else if (quantiteCommande > quantiteStock)
                {
                    snackBarDetailCommande.Show(this, "La quantité commandée ne peut pas être supérieure à la quantité en stock (" + quantiteStock + ").", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 3000);
                } else
                {
                    try
                    {
                        GestionCommande.ajouterProduitByCommande(idCommande, idProduit, quantiteCommande);
                        dgvAMSProduitCommande.DataSource = GestionCommande.getLaCommandeByIdDG(Convert.ToInt32(tbIdCommande.Text));
                        snackBarDetailCommande.Show(this, "L'ajout a bien été effectué.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                        changeInProgress = false;
                        btnAjout.Text = "Ajouter";
                        btnModif.Enabled = true;
                        btnSuppr.Enabled = true;
                        desactiverTextBox();
                        rafraichirAffichage();
                        remplirComboBox();
                    }
                    catch (Exception)
                    {
                        if (MessageBox.Show("Le produit est déjà dans votre commande, voulez-vous ajouter + " + quantiteCommande + " à la quantité commandée ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            GestionCommande.modifierQteByCommande(idCommande, idProduit, quantiteCommande);
                            dgvAMSProduitCommande.DataSource = GestionCommande.getLaCommandeByIdDG(Convert.ToInt32(tbIdCommande.Text));
                            snackBarDetailCommande.Show(this, "La modification de la quantité a été modifiée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                            changeInProgress = false;
                            btnAjout.Text = "Ajouter";
                            btnModif.Enabled = true;
                            btnSuppr.Enabled = true;
                            desactiverTextBox();
                            remplirComboBox();
                            rafraichirAffichage();
                        }
                    }
                }
            }
            else
            {
                changeInProgress = true;
                btnAjout.Text = "Valider";
                btnModif.Enabled = false;
                btnSuppr.Enabled = false;
                drpDownCategorie.Enabled = true;
                viderTextBox();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (tbIdCommande.Text != "")
            {
                string nom = dgvAMSProduitCommande.Rows[dgvAMSProduitCommande.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer le produit (" + nom + ") de cette commande ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GestionCommande.supprimerProduitByCommande(Convert.ToInt32(tbIdCommande.Text), Convert.ToInt32(drpDownProduit.SelectedValue));
                    dgvAMSProduitCommande.DataSource = GestionCommande.getLaCommandeByIdDG(Convert.ToInt32(tbIdCommande.Text));
                    snackBarDetailCommande.Show(this, "La supression a bien été effectuée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    rafraichirAffichage();
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (btnModif.Text == "Valider")
            {
                // TODO : Vérifier la quantité ne soit pas supérieure au stock !
                int idCommande = Convert.ToInt32(tbIdCommande.Text);
                int idProduit = Convert.ToInt32(drpDownProduit.SelectedValue);
                int quantiteCommande = Convert.ToInt32(tbQuantiteProduit.Text);
                GestionCommande.modifierQteByCommande(idCommande, idProduit, quantiteCommande);
                dgvAMSProduitCommande.DataSource = GestionCommande.getLaCommandeByIdDG(Convert.ToInt32(tbIdCommande.Text));
                snackBarDetailCommande.Show(this, "La modification de la quantité a été modifiée.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                changeInProgress = false;
                btnModif.Text = "Modifier";
                btnAjout.Enabled = true;
                btnModif.Enabled = true;
                btnSuppr.Enabled = true;
                desactiverTextBox();
                remplirComboBox();
                rafraichirAffichage();
            } else
            {
                changeInProgress = true;
                btnModif.Text = "Valider";
                btnAjout.Enabled = false;
                btnSuppr.Enabled = false;
                tbQuantiteProduit.Enabled = true;
            }
        }

        private void drpDownCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si un changement est en cours (ajout/modification)
            if (changeInProgress)
            {
                try
                {
                    // Donne en source de la ComboBox les produits associés à la catégorie sélectionnée
                    Utilitaire.alimenterComboBox(drpDownProduit, GestionProduit.getLesProduitsByCategorie(Convert.ToInt32(drpDownCategorie.SelectedValue))
                        , "idProduit", "LibelleProduit");
                    drpDownProduit.Enabled = true;
                    drpDownProduit.SelectedIndex = drpDownProduit.Items.Count - 1;
                    tbQuantiteProduit.Enabled = true;
                }

                catch
                {
                    return;
                }
            }
        }
        
        private void FrmDetailCommande_KeyDown(object sender, KeyEventArgs e)
        {
            if (changeInProgress && e.KeyCode == Keys.Escape)
            {
                changeInProgress = false;
                btnAjout.Text = "Ajouter";
                btnModif.Text = "Modifier";
                btnAjout.Enabled = true;
                btnModif.Enabled = true;
                btnSuppr.Enabled = true;
                desactiverTextBox();
                rafraichirAffichage();
            }
        }
        
        private void FrmDetailCommande_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Permet de vérifier si la DataTable est vide, si c'est le cas c'est que la commande ajouter ne contient pas de produit, donc supprimé.
            if (dgvAMSProduitCommande.Rows.Count == 0)
            {
                GestionCommande.supprimerCommande(Convert.ToInt32(tbIdCommande.Text));
            }
            GestionBoutique.viderJeuDonnees();
            FrmAMSCommande frmAmsCommande = new FrmAMSCommande();
            Utilitaire.afficherForm(this, frmAmsCommande);
        }

        public void rafraichirAffichage()
        {
            DataTable lesProduitsCommande = GestionCommande.getLaCommandeById(Convert.ToInt32(tbIdCommande.Text));
            int indexCourrant = dgvAMSProduitCommande.CurrentCell.RowIndex;
            tbQuantiteProduit.Text = lesProduitsCommande.Rows[indexCourrant][2].ToString();
            drpDownCategorie.SelectedValue = lesProduitsCommande.Rows[indexCourrant][3].ToString();
            drpDownProduit.SelectedValue = lesProduitsCommande.Rows[indexCourrant][4].ToString();
        }

        public void viderTextBox()
        {
            tbQuantiteProduit.Text = "";
        }


        public void desactiverTextBox() {
            drpDownCategorie.Enabled = false;
            drpDownProduit.Enabled = false;
            tbQuantiteProduit.Enabled = false;
        }

        public void remplirComboBox()
        {
            Utilitaire.alimenterComboBox(drpDownProduit, GestionProduit.getLesProduits(), "idProduit", "LibelleProduit");
            Utilitaire.alimenterComboBox(drpDownCategorie, GestionCategorie.getLesCategories(), "idCategorie", "LibelleCategorie");
        }


    }
}
