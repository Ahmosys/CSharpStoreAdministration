using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Bunifu.Utils;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using IAPM.Metier;
using IAPM.Technique;

namespace IAPM
{
    public partial class FrmMenu : BunifuForm
    {
        private string descriptionMeterologique = "Inconnue";

        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(string descriptionMeterologique)
        {
            InitializeComponent();
            this.descriptionMeterologique = descriptionMeterologique;
        }

        private async void FrmMenu_Load(object sender, EventArgs e)
        {
            // Remplis la valeur text des labels statistique avec les bonnes valeurs
            lblSoustitre.Text = lblSoustitre.Text.Replace("USERNAME", GestionBoutique.nomUtilisateur.ToUpper());
            lblNbProduit.Text = GestionProduit.getNBProduits().ToString();
            lblNbClient.Text = GestionClient.getNBClients().ToString();
            lblNbCommande.Text = GestionCommande.getNBCommandes().ToString();
            rdlGgeNbFavoris.Maximum = GestionProduit.getNBProduits();

            // Si c'est la première fois que le formulaire est ouvert
            if (!GestionBoutique.formHasAlreadyOpen)
            {
                // Boolean permettant de savoir si le formulaire à déjà était ouvert
                GestionBoutique.formHasAlreadyOpen = true;
                // Animation sur les cards au premier démarrage
                await Task.Delay(500);
                transitionMenu.ShowSync(cardProduit, false, Animation.ScaleAndHorizSlide);
                transitionMenu.ShowSync(cardCommande, false, Animation.ScaleAndHorizSlide);
                transitionMenu.ShowSync(cardClient, false, Animation.ScaleAndHorizSlide);
                transitionMenu.ShowSync(cardVente, false, Animation.ScaleAndHorizSlide);
                transitionMenu.ShowSync(cardCa, false, Animation.ScaleAndHorizSlide);
                transitionMenu.ShowSync(cardNbFavoris, false, Animation.ScaleAndHorizSlide);
                await Task.Delay(300);
                rdlGgeNbVentes.ValueByTransition = GestionProduit.getNBVentesTotale();
                rdlGgeNbFavoris.ValueByTransition = GestionProduit.getNBProduitsFavoris();
                pgrBarCa.ValueByTransition = GestionProduit.getCaTotal();
            } else
            {
                cardProduit.Visible = true;
                cardCommande.Visible = true;
                cardClient.Visible = true;
                cardVente.Visible = true;
                cardCa.Visible = true;
                cardNbFavoris.Visible = true;
                await Task.Delay(300);
                rdlGgeNbVentes.ValueByTransition = GestionProduit.getNBVentesTotale();
                rdlGgeNbFavoris.ValueByTransition = GestionProduit.getNBProduitsFavoris();
                pgrBarCa.ValueByTransition = GestionProduit.getCaTotal();
            }
        }

        private void FrmMenu_Activated(object sender, EventArgs e)
        {
            // Réinitialise les valeurs des comboboxs quand retour sur menu
            drpDwnClient.Text = "Choisir ...";
            drpDwnCommande.Text = "Choisir ...";
            drpDwnProduit.Text = "Choisir ...";
            drpDwnFournisseur.Text = "Choisir ...";
            drpDwnStats.Text = "Choisir ...";
        }

        private void drpDwnClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = drpDwnClient.Text.ToLower();
            // Switch permettant de gérer le menu sous forme de combobox
            switch (choix)
            {
                case "liste":
                    FrmListeClient frmListeClient = new FrmListeClient();
                    Utilitaire.afficherForm(this, frmListeClient);
                    break;
                case "ajout • suppr • modif":
                    FrmAMSClient frmAmsClient = new FrmAMSClient();
                    Utilitaire.afficherForm(this, frmAmsClient);
                    break;
                case "rechercher":
                    FrmRechClient frmRechClient = new FrmRechClient();
                    Utilitaire.afficherForm(this, frmRechClient);
                    break;
                default:
                    return;
            }
        }

        private void drpDwnProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = drpDwnProduit.Text.ToLower();
            switch (choix)
            {
                case "liste":
                    FrmListeProduit frmListeProduit = new FrmListeProduit();
                    Utilitaire.afficherForm(this, frmListeProduit);
                    break;
                case "ajout • suppr • modif":
                    FrmAMSProduit frmAmProduit = new FrmAMSProduit();
                    Utilitaire.afficherForm(this, frmAmProduit);
                    break;
                case "rechercher":
                    FrmRechProduit frmRechProduit = new FrmRechProduit();
                    Utilitaire.afficherForm(this, frmRechProduit);
                    break;
                default:
                    return;
            }
        }
        private void drpDwnCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = drpDwnCommande.Text.ToLower();
            switch (choix)
            {
                case "liste":
                    FrmListeCommande frmListeCommande = new FrmListeCommande();
                    Utilitaire.afficherForm(this, frmListeCommande);
                    break;
                case "ajout • suppr • modif":
                    FrmAMSCommande frmAMSCommande = new FrmAMSCommande();
                    Utilitaire.afficherForm(this, frmAMSCommande);
                    break;
                case "rechercher":
                    FrmRechCommande frmRechCommande = new FrmRechCommande();
                    Utilitaire.afficherForm(this, frmRechCommande);
                    break;
                default:
                    return;
            }
        }

        private void drpDwnFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = drpDwnFournisseur.Text.ToLower();
            switch (choix)
            {
                case "liste":
                    FrmListeFournisseur frmListeFournisseur = new FrmListeFournisseur();
                    Utilitaire.afficherForm(this, frmListeFournisseur);
                    break;
                case "ajout • suppr • modif":
                    FrmAMSFournisseur frmAMSFournisseur = new FrmAMSFournisseur();
                    Utilitaire.afficherForm(this, frmAMSFournisseur);
                    break;
                case "rechercher":
                    FrmRechFournisseur frmRechFournisseur = new FrmRechFournisseur();
                    Utilitaire.afficherForm(this, frmRechFournisseur);
                    break;
                default:
                    return;
            }
        }

        private void drpDwnStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = drpDwnStats.Text.ToLower();
            switch (choix)
            {
                case "commandes par client":
                    FrmListeClient frmListeClient = new FrmListeClient();
                    Utilitaire.afficherForm(this, frmListeClient);
                    break;
                case "produits par fournisseur":
                    break;
                default:
                    return;
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            // S'assure que la connexion est ouverture pour la fermer
            if (GestionBoutique.maConnexion.State == ConnectionState.Open)
            {
                GestionBoutique.maConnexion.Close();
                GestionBoutique.isConnecter = false;
                FrmConnexion frmConnexion = new FrmConnexion();
                this.Visible = false;
                frmConnexion.ShowDialog();
                this.Close();
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Application.StartupPath + "\\Son\\son_mickey.wav";
            player.PlayLooping();*/
        }
    }
}
