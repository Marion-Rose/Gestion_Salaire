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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Salaire.Forms
{
    /// <summary>
    /// Formulaire de gestion des salariés
    /// </summary>
    public partial class CRUDSalarie : Form
    {
        private int action;
        private Salarie salarie;
        public event EventHandler FormClosedEvent;

        /// <summary>
        /// Constructeur du formulaire de gestion des salariés
        /// </summary>
        /// <param name="action">Action à effectuer (ajout ou modification)</param>
        /// <param name="idSalarie">Identifiant du salarié à modifier (facultatif)</param>
        public CRUDSalarie(int action, int? idSalarie)
        {
            this.action = action;
            this.salarie = VariablesGlobales.listeSalaries.Where(salarie => salarie.getId() == idSalarie).FirstOrDefault();
            InitializeComponent();
            this.Load += CRUDSalarie_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDSalarie_Load(object sender, EventArgs e)
        {
            // Chargement des entreprises et des postes dans les comboBox
            List<string> raisonsSociales = VariablesGlobales.listeEntreprises.Select(entreprise => entreprise.getRaisonSociale()).ToList();
            comboBoxEntreprise.DataSource = raisonsSociales;

            List<string> libelles = VariablesGlobales.listePostes.Select(poste => poste.getLibelle()).ToList();
            comboBoxPoste.DataSource = libelles;

            // Si on est en mode modification, on charge les informations du salarié
            if (this.salarie != null)
            {
                txtNom.Text = this.salarie.getNom();
                txtPrenom.Text = this.salarie.getPrenom();
                numericUpDownEchelon.Value = this.salarie.getEchelon();
                comboBoxEntreprise.SelectedIndex = VariablesGlobales.listeEntreprises.IndexOf(this.salarie.getEntreprise());
                comboBoxPoste.SelectedIndex = VariablesGlobales.listePostes.IndexOf(this.salarie.getPoste());
                numericUpDownAnnee.Value = this.salarie.getAnnee();
            }   

        }

        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDSalarie_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ajout d'un salarié
        /// </summary>
        private void AjouterSalarie()
        {
            int id = VariablesGlobales.listeSalaries.Count + 1;
            VariablesGlobales.listeSalaries.Add(new Salarie(id, txtNom.Text, txtPrenom.Text, Convert.ToInt32(numericUpDownEchelon.Value), VariablesGlobales.listeEntreprises[comboBoxEntreprise.SelectedIndex], VariablesGlobales.listePostes[comboBoxPoste.SelectedIndex], Convert.ToInt32(numericUpDownAnnee.Value)));
            Logger.EcrireLog("Ajout d'un salarié");
        }

        /// <summary>
        /// Modification d'un salarié
        /// </summary>
        private void ModifierSalarie()
        {
            this.salarie.setNom(txtNom.Text);
            this.salarie.setPrenom(txtPrenom.Text);
            this.salarie.setEchelon(Convert.ToInt32(numericUpDownEchelon.Value));
            this.salarie.setEntreprise(VariablesGlobales.listeEntreprises[comboBoxEntreprise.SelectedIndex]);
            this.salarie.setPoste(VariablesGlobales.listePostes[comboBoxPoste.SelectedIndex]);
            this.salarie.setAnnee(Convert.ToInt32(numericUpDownAnnee.Value));

            Logger.EcrireLog("Le salarie " + this.salarie.getNomPrenom() + " a été modifié.");
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
                AjouterSalarie();
            }
            else if (this.action == 22)
            {
                ModifierSalarie();
            }
            Close();
        }
    }
}
