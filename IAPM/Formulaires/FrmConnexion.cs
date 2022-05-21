using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Bunifu.Utils;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using IAPM.Technique;

namespace IAPM
{
    public partial class FrmConnexion : BunifuForm
    {
        private bool isPasswordChar = false;
        // private string descriptionMeteo = Task<string>.Run(() => API.getDescriptionMeteo()).Result;

        public FrmConnexion()
        {
            InitializeComponent();
        }

        private async void FrmConnexion_Load(object sender, EventArgs e)
        {
            // Animation sur les textbox au démarrage.
            await Task.Delay(500);
            /*transitionConnexion.ShowSync(tbServeur, false, Animation.ScaleAndHorizSlide);
            transitionConnexion.ShowSync(tbBdd, false, Animation.ScaleAndHorizSlide);
            transitionConnexion.ShowSync(tbUtilisateur, false, Animation.ScaleAndHorizSlide);
            transitionConnexion.ShowSync(tbMdp, false, Animation.ScaleAndHorizSlide);
            transitionConnexion.ShowSync(btnShowMdp, false, Animation.Scale);*/
            btnConnexion.Enabled = true;        
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (GestionInterface.hasText(tbBdd) && GestionInterface.hasText(tbServeur) && GestionInterface.hasText(tbUtilisateur))
            {
                try
                {
                    GestionBoutique.seConnecter(tbServeur.Text, tbBdd.Text, tbUtilisateur.Text, tbMdp.Text);
                    snackBarConnexion.Show(this, "La connexion a réussie, redirection vers l'application...", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2500);
                    GestionBoutique.isConnecter = true;
                    ldrConnexion.Visible = true;
                    await Task.Delay(3000);
                    // descriptionMeterologique = API.getDescriptionMeteo();
                    FrmMenu frmMenu = new FrmMenu();
                    this.Visible = false;
                    frmMenu.ShowDialog();
                    this.Close();
                }
                catch (Exception)
                {
                    snackBarConnexion.Show(this, "La connexion a échouée un des champs n'est pas correct.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);

                }
            } else
            {
                snackBarConnexion.Show(this, "Veuillez remplir tous les champs.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void tbMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Touche entrer appuyée dans la texbox du mot de passe
            if (e.KeyChar == (char)13)
            {
                btnConnexion.PerformClick();
            }
        }

        private void tbMdp_TextChange(object sender, EventArgs e)
        {
            // Active le PasswordChar si le la textbox se remplit sinon le désactive
            if (tbMdp.Text != "")
            {
               isPasswordChar = true;
               tbMdp.PasswordChar = Convert.ToChar("●");
            } else
            {
                isPasswordChar = false;
                tbMdp.PasswordChar = '\0';
            }
        }

        private void btnShowMdp_Click(object sender, EventArgs e)
        {
            if (isPasswordChar)
            {
                // Permet d'afficher en clair le mot de passe si il ne l'était pas
                isPasswordChar = false;
                tbMdp.PasswordChar = '\0';
            } else
            {
                isPasswordChar = true;
                tbMdp.PasswordChar = Convert.ToChar("●");
            }
                
        }

        // Bypass connexion
        private void pbSeparateur_Click(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter("localhost", "robin3", "root", "root");
            GestionBoutique.isConnecter = true;
            FrmMenu frmMenu = new FrmMenu();
            this.Visible = false;
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
