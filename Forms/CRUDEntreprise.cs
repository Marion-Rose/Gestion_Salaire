using Gestion_Salaire.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Salaire.Forms
{
    /// <summary>
    /// Formulaire de création, modification et suppression d'une entreprise
    /// </summary>
    public partial class CRUDEntreprise : Form
    {
        private int action;
        private Entreprise entreprise;
        public event EventHandler FormClosedEvent;

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        /// <param name="action">Action à effctuer (ajout ou modification)</param>
        /// <param name="entreprise">Entreprise à modifier (facultative)</param>
        public CRUDEntreprise(int action, Entreprise? entreprise)
        {
            this.action = action;
            this.entreprise = entreprise;
            InitializeComponent();
            this.Load += CRUDEntreprise_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDEntreprise_Load(object sender, EventArgs e)
        {
            // Si l'action est une modification, chargement des informations de l'entreprise
            if (this.entreprise != null)
            {
                lbIdActuel.Text = this.entreprise.getIdEntreprise().ToString();
                txtRS.Text = this.entreprise.getRaisonSociale();
                txtAdresse.Text = this.entreprise.getAdresse();
            }
            // Sinon, affichage de l'id de la nouvelle entreprise
            else
            {
                lbIdActuel.Text = (VariablesGlobales.listeEntreprises.Count + 1).ToString();
            }
        }

        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDEntreprise_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ajout d'une entreprise
        /// </summary>
        private void AjouterEntreprise()
        {
            int idEntreprise = VariablesGlobales.listeEntreprises.Count + 1;
            string raisonSociale = txtRS.Text;
            string adresse = txtAdresse.Text;
            Entreprise entreprise = new Entreprise(idEntreprise, raisonSociale, adresse);
            VariablesGlobales.listeEntreprises.Add(entreprise);
            Logger.EcrireLog("Ajout de l'entreprise " + entreprise.getRaisonSociale());
        }

        /// <summary>
        /// Modification d'une entreprise
        /// </summary>
        private void ModifierEntreprise()
        {
            this.entreprise.setRaisonSociale(txtRS.Text);
            this.entreprise.setAdresse(txtAdresse.Text);
            Logger.EcrireLog("Modification de l'entreprise " + this.entreprise.getRaisonSociale());
        }

        /// <summary>
        /// Boutton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (this.action == 11)
            {
                AjouterEntreprise();
            }
            else if (this.action == 12)
            {
                ModifierEntreprise();
            }
            Close();
        }

    }
}
