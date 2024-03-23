using Gestion_Salaire.Forms;
using Gestion_Salaire.Classes;

namespace Gestion_Salaire
{
    /// <summary>
    /// Formulaire de connexion
    /// </summary>
    public partial class Connexion : Form
    {
        /// <summary>
        /// Constructeur du Forumlaire de Connexion
        /// </summary>
        public Connexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            bool connexionReussie = false;
            //Verifie si les identifants correspondent à un administrateur
            foreach (Administrateur admin in VariablesGlobales.listeAdministrateurs)
            {
                if (txtUtilisateur.Text == admin.getLogin() && txtMdp.Text == admin.getMdp())
                {
                    connexionReussie = true;
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vous connecter comme Administrateur ?", "Connexion Administrateur", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Hide();
                        new Administration().Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Hide();
                        new Utilisation().Show();
                        
                    }
                    VariablesGlobales.adminConnecte = admin;
                    Logger.EcrireLog("Connexion Administrateur " + admin.getNomPrenom());
                }
            }
            //Verifie si les identifants correspondent à un utilisateur
            foreach (Utilisateur user in VariablesGlobales.listeUtilisateurs)
            {
                if (txtUtilisateur.Text == user.GetLogin() && txtMdp.Text == user.GetMotDePasse())
                {
                    connexionReussie = true;
                    this.Hide();
                    new Utilisation().Show();
                    VariablesGlobales.utilisateurConnecte = user;
                    Logger.EcrireLog("Connexion Utilisateur " + user.GetSalarie().getNomPrenom());
                }
            }
            if (!connexionReussie) { MessageBox.Show("Identifiants incorrects"); }

        }
    }
}
