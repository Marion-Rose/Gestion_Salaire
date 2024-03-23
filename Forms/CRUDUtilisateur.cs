using Gestion_Salaire.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Salaire.Forms
{
    /// <summary>
    /// Formulaire de gestion des utilisateurs
    /// </summary>
    public partial class CRUDUtilisateur : Form
    {
        private int action;
        private Utilisateur utilisateur;
        private Salarie salarie;
        public event EventHandler FormClosedEvent;

        /// <summary>
        /// Constructeur du formulaire de gestion des utilisateurs
        /// </summary>
        /// <param name="action">Action à effectuer (ajout ou modification)</param>
        /// <param name="idUtilisateur">Identifiant de l'utilisateur à modifier</param>
        public CRUDUtilisateur(int action, int? idUtilisateur)
        {
            this.action = action;
            this.utilisateur = VariablesGlobales.listeUtilisateurs.Find(utilisateur => utilisateur.GetSalarie().getId() == idUtilisateur);
            InitializeComponent();
            this.Load += CRUDUtilisateur_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDUtilisateur_Load(object sender, EventArgs e)
        {
            //Si il s'agit d'une modification, chargement des informations de l'utilisateur
            if(this.utilisateur != null)
            {
                comboBoxUtilisateur.Text = this.utilisateur.GetSalarie().getNomPrenom();
                lbEntrepriseActuelle.Text = this.utilisateur.GetSalarie().getEntreprise().getRaisonSociale();
                txtIdentifiant.Text = this.utilisateur.GetLogin();
                txtMdp.Text = this.utilisateur.GetMotDePasse();
            }
            //Si il s'agit d'un ajout, chargement des salariés non utilisateurs
            else
            {
                List<Salarie> salarieNonUtilisateur = new List<Salarie>();
                foreach (Salarie salarie in VariablesGlobales.listeSalaries)
                {
                    bool utilisateurExiste = false;
                    foreach (Utilisateur utilisateur in VariablesGlobales.listeUtilisateurs)
                    {
                        if (utilisateur.GetSalarie() == salarie)
                        {
                            utilisateurExiste = true;
                            break;
                        }
                    }
                    if (!utilisateurExiste)
                    {
                        salarieNonUtilisateur.Add(salarie);
                    }   
                }
                comboBoxUtilisateur.DisplayMember = "nomPrenom";//Ne fonctionne pas
                comboBoxUtilisateur.DataSource = salarieNonUtilisateur;
            }

        }

        /// <summary>
        /// Mettre à jour les informations du salarié sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUtilisateur.SelectedItem != null)
            {
                this.salarie = (Salarie)comboBoxUtilisateur.SelectedItem;

                lbEntrepriseActuelle.Text = salarie.getEntreprise().getRaisonSociale();
                
            }
        }

        /// <summary>
        /// Fermeture du forumlaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDUtilisateur_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ajouter un utilisateur
        /// </summary>
        private void AjouterUtilisateur()
        {
            Utilisateur utilisateur = new Utilisateur(this.salarie, txtIdentifiant.Text, txtMdp.Text);
            VariablesGlobales.listeUtilisateurs.Add(utilisateur);
            Logger.EcrireLog("Ajout de l'utilisateur " + utilisateur.GetSalarie().getNomPrenom());
        }

        /// <summary>
        /// Modifier un utilisateur
        /// </summary>
        private void ModifierUtilisateur()
        {
            this.utilisateur.SetLogin(txtIdentifiant.Text);
            this.utilisateur.SetMotDePasse(txtMdp.Text);
            Logger.EcrireLog("Modification de l'utilisateur " + this.utilisateur.GetSalarie().getNomPrenom());
        }

        /// <summary>
        /// Bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.action == 21)
            {
                AjouterUtilisateur();
            }
            else if (this.action == 22)
            {
                ModifierUtilisateur();
            }
            Close();
        }
    }
}
