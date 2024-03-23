using System;
using Gestion_Salaire.Classes;
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
    /// Formulaire de gestion des postes
    /// </summary>
    public partial class CRUDPoste : Form
    {
        private int action;
        private Poste poste;
        public event EventHandler FormClosedEvent;

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        /// <param name="action">Action à effectuer (ajout ou modification)</param>
        /// <param name="poste">Poste à modifier (factultatif)</param>
        public CRUDPoste(int action, Poste? poste)
        {
            this.action = action;
            this.poste = poste;
            InitializeComponent();
            this.Load += CRUDPoste_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDPoste_Load(object sender, EventArgs e)
        {
            // Si il s'agit d'une modification, on charge les informations du poste
            if (this.poste != null)
            {
                lbIdActuel.Text = this.poste.getIdPoste().ToString();
                txtLibelle.Text = this.poste.getLibelle();
                numericUpDown1.Value = this.poste.getPoids();
            }
            // Sinon on affiche l'id du prochain poste
            else
            {
                lbIdActuel.Text = (VariablesGlobales.listePostes.Count + 1).ToString();
            }
        }

        /// <summary>
        /// Fermeture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDPoste_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ajout d'un poste
        /// </summary>
        private void AjouterPoste()
        {
            int idPoste = VariablesGlobales.listePostes.Count + 1;
            string libelle = txtLibelle.Text;
            int poids = (int)numericUpDown1.Value;
            Poste poste = new Poste(idPoste, libelle, poids);
            VariablesGlobales.listePostes.Add(poste);
            Logger.EcrireLog("Ajout du poste " + poste.getLibelle());
        }

        /// <summary>
        /// Modification d'un poste
        /// </summary>
        private void ModifierPoste()
        {
            this.poste.setLibelle(txtLibelle.Text);
            this.poste.setPoids((int)numericUpDown1.Value);
            Logger.EcrireLog("Modification du poste " + this.poste.getLibelle());
        }

        /// <summary>
        /// Bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.action == 31)
            {
                AjouterPoste();
            }
            else if (this.action == 32)
            {
                ModifierPoste();
            }
            Close();
        }
    }
}
