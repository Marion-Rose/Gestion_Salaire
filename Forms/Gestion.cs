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
    /// Formulaire de gestion des informations de poste des employés
    /// </summary>
    public partial class Gestion : Form
    {
        private Salarie employeSelectionne;
        private int anneeActuelle = VariablesGlobales.anneeActuelle;

        /// <summary>
        /// Constructeur du formulaire
        /// </summary>
        public Gestion()
        {
            InitializeComponent();
            this.Load += Gestion_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gestion_Load(object sender, EventArgs e)
        {
            List<Salarie> listeSalaries = VariablesGlobales.listeSalaries;
            comboBoxEmploye.DisplayMember = "nomPrenom";
            comboBoxEmploye.DataSource = VariablesGlobales.listeSalaries;
            numUpDownAnnee.Minimum= VariablesGlobales.anneeActuelle;
        }

        /// <summary>
        /// Mise à jour des informations de l'employé sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmploye.SelectedItem != null)
            {
                this.employeSelectionne = (Salarie)comboBoxEmploye.SelectedItem;

                lbEntrepriseEmploye.Text = employeSelectionne.getEntreprise().getRaisonSociale();
                lbPosteEmploye.Text = employeSelectionne.getPoste().getLibelle();
                lbEchelonEmploye.Text = employeSelectionne.getEchelon().ToString();
                lbAnneeEmploye.Text = employeSelectionne.getAnnee().ToString();

                int [,] grille = VariablesGlobales.listeGrilles.Find(grille => grille.getPoste().getLibelle() == employeSelectionne.getPoste().getLibelle()).getGrille();
                int salaireAnnuel = grille[employeSelectionne.getEchelon()-1, 0]*12;
                lbSalAnnuel.Text = salaireAnnuel.ToString();
                lbSalMenAct.Text = grille[employeSelectionne.getEchelon()-1, 0].ToString();
                
            }
        }

        /// <summary>
        /// Augmentation de l'année actuelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownAnnee_ValueChanged(object sender, EventArgs e)
        {
            int nouvelleAnnee = (int)numUpDownAnnee.Value;
            
            //Si l'utilisateur augmente l'année
            if (nouvelleAnnee > this.anneeActuelle)
            {
                Logger.EcrireLog("Annee " + nouvelleAnnee);

                //Augmentatdion d'une année pour tous les salariés
                foreach (Salarie salarie in VariablesGlobales.listeSalaries)
                {
                    salarie.AugmenterAnnee();
                    numUpDownAnnee.Minimum = nouvelleAnnee;
                }
            }
            //Blocage pour que l'utilisateur ne puisse pas diminuer l'année
            else if (nouvelleAnnee < this.anneeActuelle)
            {
                numUpDownAnnee.Value = numUpDownAnnee.Minimum;
            }

            VariablesGlobales.anneeActuelle = nouvelleAnnee;

            comboBoxEmploye_SelectedIndexChanged(sender, e);

        }

        /// <summary>
        /// Bouton pour augmenter l'échelon de l'employé sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAugEchelon_Click(object sender, EventArgs e)
        {
            employeSelectionne.AugmenterEchelon();
            comboBoxEmploye_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Bouton pour augmenter le poste de l'employé sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAugPoste_Click(object sender, EventArgs e)
        {
            employeSelectionne.AugmenterPoste();
            comboBoxEmploye_SelectedIndexChanged(sender, e);
        }
    }
}
