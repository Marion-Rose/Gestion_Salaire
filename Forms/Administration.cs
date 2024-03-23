using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Salaire.Classes;
using System.Diagnostics;

namespace Gestion_Salaire.Forms
{
    /// <summary>
    /// Formulaire de gestion des entreprises et des utilisateurs
    /// </summary>
    public partial class Administration : Form
    {
        private int action;
        /// <summary>
        /// Constructeur du formulaire Administration
        /// </summary>
        public Administration()
        {
            InitializeComponent();
            this.Load += Administration_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Administration_Load(object sender, EventArgs e)
        {
            listView1.Visible = false;
            comboBox1.Visible = false;
        }

        /// <summary>
        /// Evenement de fermeture du formulaire CRUDEntreprise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDEntrepriseClosedEvent(object sender, EventArgs e)
        {
            ChargerEntreprises();
        }

        /// <summary>
        /// Evenement de fermeture du formulaire CRUDUtilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRUDUtilisateurClosedEvent(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        /// <summary>
        /// Bouton de consultation des logs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogs_Click(object sender, EventArgs e)
        {
            Logger.OuvrirLogs();
        }

        /// <summary>
        /// Bouton de consultation des entreprises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEntreprise_Click(object sender, EventArgs e)
        {
            this.action = 1;
            ChargerEntreprises();
        }

        /// <summary>
        /// Bouton de consultation des utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btUtilisateur_Click(object sender, EventArgs e)
        {
            this.action = 2;
            ChargerUtilisateurs();
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
        }

        /// <summary>
        /// Bouton de passage au mode utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            Close();
            new Utilisation().Show();
        }

        /// <summary>
        /// Bouton d'ajout d'un élément (Entreprise ou Utilisateur)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            switch (this.action)
            {
                // Ajout d'une entreprise, ouverture du formulaire CRUDEntreprise
                case 1:
                    CRUDEntreprise crudEntreprise = new CRUDEntreprise(11, null);
                    crudEntreprise.FormClosed += CRUDEntrepriseClosedEvent;
                    crudEntreprise.Show();
                    break;
                // Ajout d'un utilisateur, ouverture du formulaire CRUDUtilisateur
                case 2:
                    CRUDUtilisateur crudUtilisateur = new CRUDUtilisateur(21, null);
                    crudUtilisateur.FormClosed += CRUDUtilisateurClosedEvent;
                    crudUtilisateur.Show();
                    break;
            }
        }

       /// <summary>
       /// Bouton de modification d'un élément (Entreprise ou Utilisateur)
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Verifie si un élément est sélectionné
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un élément à modifier");
                return;
            }
            else
            {
                switch (this.action)
                {
                    // Modification d'une entreprise, ouverture du formulaire CRUDEntreprise
                    case 1:
                        CRUDEntreprise crudEntreprise = new CRUDEntreprise(12, VariablesGlobales.listeEntreprises.Find(entreprise => entreprise.getRaisonSociale() == listView1.SelectedItems[0].SubItems[0].Text));
                        crudEntreprise.FormClosed += CRUDEntrepriseClosedEvent;
                        crudEntreprise.Show();
                        break;
                    // Modification d'un utilisateur, ouverture du formulaire CRUDUtilisateur
                    case 2:
                        CRUDUtilisateur crudUtilisateur = new CRUDUtilisateur(22, Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                        crudUtilisateur.FormClosed += CRUDUtilisateurClosedEvent;
                        crudUtilisateur.Show();
                        break;
                }
            }
        }

        /// <summary>
        /// Bouton de suppression d'un élément (Entreprise ou Utilisateur)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Verifie si un élément est sélectionné
            if (listView1.SelectedItems.Count > 0)
            {
                switch (this.action)
                {
                    // Suppression d'une entreprise si elle n'est pas associée à un salarié
                    case 1:
                        if (VariablesGlobales.listeSalaries.Exists(salarie => salarie.getEntreprise().getRaisonSociale() == listView1.SelectedItems[0].SubItems[0].Text))
                        {
                            MessageBox.Show("Impossible de supprimer cette entreprise car elle est associée à un salarié");
                        }
                        else
                        {
                            Logger.EcrireLog("Suppression de l'entreprise " + listView1.SelectedItems[0].SubItems[0].Text);
                            VariablesGlobales.listeEntreprises.RemoveAt(listView1.SelectedItems[0].Index);
                            ChargerEntreprises();
                        }
                        break;
                    // Suppression d'un utilisateur
                    case 2:
                        Logger.EcrireLog("Suppression de l'utilisateur " + listView1.SelectedItems[0].SubItems[1].Text + " " + listView1.SelectedItems[0].SubItems[2].Text);
                        VariablesGlobales.listeUtilisateurs.RemoveAt(listView1.SelectedItems[0].Index);
                        ChargerUtilisateurs();
                        break;
                }
            }
        }

        /// <summary>
        /// Chargement de la liste des entreprises dans la listView
        /// </summary>
        private void ChargerEntreprises()
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Raison Sociale", 300);
            listView1.Columns.Add("Adresse", 500);
            foreach (Entreprise entreprise in VariablesGlobales.listeEntreprises)
            {
                ListViewItem item = new ListViewItem(new string[] { entreprise.getRaisonSociale(), entreprise.getAdresse() });
                listView1.Items.Add(item);
            }
        }

        /// <summary>
        /// Chargement de la liste des utilisateurs dans la listView
        /// </summary>
        private void ChargerUtilisateurs()
        {
            listView1.Visible = true;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 30);
            listView1.Columns.Add("Nom", 200);
            listView1.Columns.Add("Prenom", 200);
            listView1.Columns.Add("Login", 170);
            listView1.Columns.Add("Mot de passe", 200);
            foreach (Utilisateur utilisateur in VariablesGlobales.listeUtilisateurs)
            {
                ListViewItem item = new ListViewItem(new string[] { utilisateur.GetSalarie().getId().ToString(), utilisateur.GetSalarie().getNom(), utilisateur.GetSalarie().getPrenom(), utilisateur.GetLogin(), utilisateur.GetMotDePasse() });
                listView1.Items.Add(item);
            }
        }

    }
}
