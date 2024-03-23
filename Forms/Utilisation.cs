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
    /// Formulaire de la partie utilisateur
    /// </summary>
    public partial class Utilisation : Form
    {
        /// <param name="action">Variable qui permet de savoir quelle action est en cours 
        /// (1 = Grille, 2 = Salarié, 3 = Poste)
        /// (11 = Ajout Grille, 12 = Modif Grille)
        /// (21 = Ajout Salarié, 22 = Modif Salarié)
        /// (31 = Ajout Poste, 32 = Modif Poste)
        /// </param>
        private int action;

        /// <summary>
        /// Constructeur du formulaire Utilisation
        /// </summary>
        public Utilisation()
        {
            InitializeComponent();
            this.Load += Utilisation_Load;
        }

        /// <summary>
        /// Chargement du formulaire Utilisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Utilisation_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            if (VariablesGlobales.adminConnecte == null)
            {
                btnAdmin.Visible = false;
            }
        }

        /// <summary>
        /// Fermeture du formulaire CRUDSalarie, mise à jour de la liste des salariés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDSalarieClosedEvent(object sender, EventArgs e)
        {
            ChargerListeSalaries();
        }

        /// <summary>
        /// Fermeture du formulaire CRUDGrille, mise à jour de la liste des grilles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDGrilleClosedEvent(object sender, EventArgs e)
        {
            ChargerGrilles();
        }

        /// <summary>
        /// Fermeture du formulaire CRUDPoste, mise à jour de la liste des postes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDPosteClosedEvent(object sender, EventArgs e)
        {
            ChargerPostes();
        }

        /// <summary>
        /// Affichage des grilles dans la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrille_Click(object sender, EventArgs e)
        {
            this.action = 1;
            listView1.Visible = true;
            ChargerGrilles();
        }

        /// <summary>
        /// Affichage des salariés dans la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalarie_Click(object sender, EventArgs e)
        {
            this.action = 2;
            listView1.Visible = true;
            ChargerListeSalaries();
        }

        /// <summary>
        /// Affichage des postes dans la listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoste_Click(object sender, EventArgs e)
        {
            this.action = 3;
            listView1.Visible = true;
            ChargerPostes();
        }

        /// <summary>
        /// Ajout d'un élément (Grille, Salarié, Poste) en fonction de l'action en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case 1:
                    CRUDGrille crudGrille = new CRUDGrille(11, null);
                    crudGrille.FormClosed += CRUDGrilleClosedEvent;
                    crudGrille.Show();
                    break;
                case 2:
                    CRUDSalarie crudSalarie = new CRUDSalarie(21, null);
                    crudSalarie.FormClosed += CRUDSalarieClosedEvent;
                    crudSalarie.Show();
                    break;
                case 3:
                    CRUDPoste crudPoste = new CRUDPoste(31, null);
                    crudPoste.FormClosed += CRUDPosteClosedEvent;
                    crudPoste.Show();
                    break;
            }
        }

        /// <summary>
        /// Modification d'un élément (Grille, Salarié, Poste) en fonction de l'action en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élément à modifier");
                return;
            }
            else
            {
                switch (this.action)
                {
                    case 1:
                        CRUDGrille crudGrille = new CRUDGrille(12, VariablesGlobales.listeGrilles.Find(grille => grille.getPoste().getLibelle() == listView1.SelectedItems[0].SubItems[0].Text));
                        crudGrille.FormClosed += CRUDGrilleClosedEvent;
                        crudGrille.Show();
                        break;
                    case 2:
                        CRUDSalarie crudSalarie = new CRUDSalarie(22, Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                        crudSalarie.FormClosed += CRUDSalarieClosedEvent;
                        crudSalarie.Show();
                        break;
                    case 3:
                        CRUDPoste crudPoste = new CRUDPoste(32, VariablesGlobales.listePostes.Find(poste => poste.getIdPoste() == Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text)));
                        crudPoste.FormClosed += CRUDPosteClosedEvent;
                        crudPoste.Show();
                        break;
                }
            }

        }

        /// <summary>
        /// Suppression d'un élément (Grille, Salarié, Poste) en fonction de l'action en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élément à supprimer");
                return;
            }
            else
            {
                switch (this.action)
                {
                    case 1:
                        if (VariablesGlobales.listeSalaries.Exists(salarie => salarie.getPoste().getLibelle() == listView1.SelectedItems[0].SubItems[0].Text))
                        {
                            MessageBox.Show("Impossible de supprimer cette grille car elle est associée à un salarié");
                        }
                        else
                        {

                            VariablesGlobales.listeGrilles.RemoveAll(grille => grille.getPoste().getLibelle() == listView1.SelectedItems[0].SubItems[0].Text);
                            Logger.EcrireLog("Suppression de la grille " + listView1.SelectedItems[0].SubItems[0].Text);
                            ChargerGrilles();

                        }
                        break;
                    case 2:
                        VariablesGlobales.listeSalaries.RemoveAll(salarie => salarie.getId() == Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                        Logger.EcrireLog("Suppression du salarié " + listView1.SelectedItems[0].SubItems[1].Text + " " + listView1.SelectedItems[0].SubItems[2].Text);
                        ChargerListeSalaries();
                        break;
                    case 3:
                        VariablesGlobales.listePostes.RemoveAll(poste => poste.getIdPoste() == Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                        Logger.EcrireLog("Suppression du poste " + listView1.SelectedItems[0].SubItems[1].Text);
                        ChargerPostes();
                        break;
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des salariés dans la listView
        /// </summary>
        private void ChargerListeSalaries()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Nom", 130);
            listView1.Columns.Add("Prenom", 130);
            listView1.Columns.Add("Entreprise", 150);
            listView1.Columns.Add("Poste", 200);
            listView1.Columns.Add("Echelon", 70);
            listView1.Columns.Add("Salaire", 100);
            listView1.Columns.Add("Annee", 90);
            foreach (Salarie salarie in VariablesGlobales.listeSalaries)
            {
                Grille grille = salarie.GrilleSelonSalarie(salarie);
                int salaire = grille.getSalaire(salarie.getEchelon());
                ListViewItem item = new ListViewItem(new string[] { salarie.getId().ToString(), salarie.getNom(), salarie.getPrenom(), salarie.getEntreprise().getRaisonSociale(), salarie.getPoste().getLibelle(), salarie.getEchelon().ToString(), salaire.ToString(), salarie.getAnnee().ToString() });
                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Chargement de la liste des grilles dans la listView
        /// </summary>
        private void ChargerGrilles()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Poste", 200);
            listView1.Columns.Add("Echelon", 200);
            listView1.Columns.Add("Salaire", 200);
            listView1.Columns.Add("Année d'ancienneté", 200);

            foreach (Grille grille in VariablesGlobales.listeGrilles)
            {
                int[,] tableau = grille.getGrille();
                for (int i = 0; i < tableau.GetLength(0); i++)
                {
                    int echelon = i + 1; // Calculez l'échelon à partir de l'index de l'itération
                    ListViewItem item = new ListViewItem(new string[] { grille.getPoste().getLibelle(), echelon.ToString(), tableau[i, 0].ToString(), tableau[i, 1].ToString() });
                    listView1.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des postes dans la listView
        /// </summary>
        private void ChargerPostes()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 200);
            listView1.Columns.Add("Libellé", 200);
            listView1.Columns.Add("Poids", 200);

            foreach (Poste poste in VariablesGlobales.listePostes)
            {
                ListViewItem item = new ListViewItem(new string[] { poste.getIdPoste().ToString(), poste.getLibelle(), poste.getPoids().ToString() });
                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Bouton d'ouverture du formulaire de gestion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestion_Click(object sender, EventArgs e)
        {
            Gestion gestion = new Gestion();
            gestion.Show();
        }

        /// <summary>
        /// Bouton de déconnexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Close();
            new Connexion().Show();
            VariablesGlobales.adminConnecte = null;
            VariablesGlobales.utilisateurConnecte = null;
        }

        /// <summary>
        /// Bouton d'accès l'interface administration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Close();
            new Administration().Show();
        }

        
    }
}
