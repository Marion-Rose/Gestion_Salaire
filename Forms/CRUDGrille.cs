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
    /// Formulaire de gestion des grilles
    /// </summary>
    public partial class CRUDGrille : Form
    {
        private int action;
        private Grille grille;
        public event EventHandler FormClosedEvent;

        /// <summary>
        /// Constructeur du formulaire de gestion des grilles
        /// </summary>
        /// <param name="action">Action à effectuer (ajout ou modification)</param>
        /// <param name="grille">Grille à modifier (facultative)</param>
        public CRUDGrille(int action, Grille? grille)
        {
            this.action = action;
            this.grille = grille;
            InitializeComponent();
            this.Load += CRUDGrille_Load;
        }

        /// <summary>
        /// Chargement du formulaire de gestion des grilles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDGrille_Load(object sender, EventArgs e)
        {
            // Si il s'agait d'une modification, chargement des données de la grille
            if (this.grille != null)
            {
                List<string> libelles = new List<string>();
                libelles.Add(this.grille.getPoste().getLibelle());
                comboBoxPoste.DataSource = libelles;
                int index = comboBoxPoste.FindStringExact(this.grille.getPoste().getLibelle());
                comboBoxPoste.SelectedIndex = index;

                int[,] grille = this.grille.getGrille();
                txtSalaire1.Text = grille[0, 0].ToString();
                txtSalaire2.Text = grille[1, 0].ToString();
                txtSalaire3.Text = grille[2, 0].ToString();
                txtSalaire4.Text = grille[3, 0].ToString();
                txtSalaire5.Text = grille[4, 0].ToString();
                numUpDownAnnee1.Value = grille[0, 1];
                numUpDownAnnee2.Value = grille[1, 1];
                numUpDownAnnee3.Value = grille[2, 1];
                numUpDownAnnee4.Value = grille[3, 1];
                numUpDownAnnee5.Value = grille[4, 1];

            }
            //Si il s'agit d'un ajout, chargement des postes qui n'ont pas de grille dans le comboBox
            else
            {
                List<string> libelles = new List<string>();

                foreach (Poste poste in VariablesGlobales.listePostes)
                {
                    bool grilleExiste = false;
                    foreach (Grille grille in VariablesGlobales.listeGrilles)
                    {
                        if (grille.getPoste() == poste)
                        {
                            grilleExiste = true;
                            break;
                        }
                    }
                    if (!grilleExiste)
                    {
                        libelles.Add(poste.getLibelle());
                    }
                }
                comboBoxPoste.DataSource = libelles;
            }
        }

        /// <summary>
        /// Fermeture du formulaire de gestion des grilles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDGrille_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Ajout d'une grille
        /// </summary>
        private void AjouterGrille()
        {
            Poste poste = VariablesGlobales.listePostes.FirstOrDefault(poste => poste.getLibelle() == comboBoxPoste.SelectedItem.ToString());
            int[,] grille = new int[,] { {Convert.ToInt32(txtSalaire1.Text), Convert.ToInt32(numUpDownAnnee1.Value) },
                                         {Convert.ToInt32(txtSalaire2.Text), Convert.ToInt32(numUpDownAnnee2.Value) },
                                         {Convert.ToInt32(txtSalaire3.Text), Convert.ToInt32(numUpDownAnnee3.Value) },
                                         {Convert.ToInt32(txtSalaire4.Text), Convert.ToInt32(numUpDownAnnee4.Value) },
                                         {Convert.ToInt32(txtSalaire5.Text), Convert.ToInt32(numUpDownAnnee5.Value) }};
            VariablesGlobales.listeGrilles.Add(new Grille(poste, grille));

            Logger.EcrireLog("Ajout d'une grille pour le poste " + poste.getLibelle());
        }

        /// <summary>
        /// Modification d'une grille
        /// </summary>
        private void ModifierGrille()
        {
            int[,] grille = new int[,] { {Convert.ToInt32(txtSalaire1.Text), Convert.ToInt32(numUpDownAnnee1.Value) },
                                         {Convert.ToInt32(txtSalaire2.Text), Convert.ToInt32(numUpDownAnnee2.Value) },
                                         {Convert.ToInt32(txtSalaire3.Text), Convert.ToInt32(numUpDownAnnee3.Value) },
                                         {Convert.ToInt32(txtSalaire4.Text), Convert.ToInt32(numUpDownAnnee4.Value) },
                                         {Convert.ToInt32(txtSalaire5.Text), Convert.ToInt32(numUpDownAnnee5.Value) }};
            this.grille.setGrille(grille);

            Logger.EcrireLog("Modification d'une grille pour le poste " + this.grille.getPoste().getLibelle());
        }

        /// <summary>
        /// Bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (this.action == 11)
            {
                AjouterGrille();
            }
            else if (this.action == 12)
            {
                ModifierGrille();
            }
            Close();
        }

    }
}
