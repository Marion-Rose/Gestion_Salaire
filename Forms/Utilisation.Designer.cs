namespace Gestion_Salaire.Forms
{
    partial class Utilisation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGrille = new Button();
            btnSalarie = new Button();
            listView1 = new ListView();
            btnModifier = new Button();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            btnGestion = new Button();
            btnDeconnexion = new Button();
            btnAdmin = new Button();
            btnPoste = new Button();
            SuspendLayout();
            // 
            // btnGrille
            // 
            btnGrille.BackColor = Color.Lime;
            btnGrille.Location = new Point(99, 238);
            btnGrille.Name = "btnGrille";
            btnGrille.Size = new Size(123, 42);
            btnGrille.TabIndex = 0;
            btnGrille.Text = "Grille";
            btnGrille.UseVisualStyleBackColor = false;
            btnGrille.Click += btnGrille_Click;
            // 
            // btnSalarie
            // 
            btnSalarie.BackColor = Color.Cyan;
            btnSalarie.Location = new Point(99, 337);
            btnSalarie.Name = "btnSalarie";
            btnSalarie.Size = new Size(123, 42);
            btnSalarie.TabIndex = 1;
            btnSalarie.Text = "Employés";
            btnSalarie.UseVisualStyleBackColor = false;
            btnSalarie.Click += btnSalarie_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(308, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(948, 398);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // btnModifier
            // 
            btnModifier.Image = Properties.Resources.modifier_document_signer_l_icone_le_bouton_modifier_le_contenu_l_interface_utilisateur_moderne_bouton_site_web_2c4x5nt_removebg_preview;
            btnModifier.Location = new Point(1293, 293);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(58, 53);
            btnModifier.TabIndex = 4;
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Image = Properties.Resources.unnamed_removebg_preview;
            btnAjouter.Location = new Point(1293, 212);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(58, 53);
            btnAjouter.TabIndex = 5;
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Image = Properties.Resources.images_removebg_preview__1_;
            btnSupprimer.Location = new Point(1293, 371);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(58, 53);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.Salmon;
            btnGestion.Location = new Point(99, 145);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(123, 42);
            btnGestion.TabIndex = 7;
            btnGestion.Text = "Gestion";
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = SystemColors.ActiveBorder;
            btnDeconnexion.Location = new Point(1220, 22);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(145, 53);
            btnDeconnexion.TabIndex = 8;
            btnDeconnexion.Text = "Se déconnecter";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.GradientInactiveCaption;
            btnAdmin.Location = new Point(1049, 22);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(156, 53);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "Basculer vers le mode administrateur";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnPoste
            // 
            btnPoste.BackColor = Color.Violet;
            btnPoste.Location = new Point(99, 438);
            btnPoste.Name = "btnPoste";
            btnPoste.Size = new Size(123, 42);
            btnPoste.TabIndex = 10;
            btnPoste.Text = "Postes";
            btnPoste.UseVisualStyleBackColor = false;
            btnPoste.Click += btnPoste_Click;
            // 
            // Utilisation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 641);
            Controls.Add(btnPoste);
            Controls.Add(btnAdmin);
            Controls.Add(btnDeconnexion);
            Controls.Add(btnGestion);
            Controls.Add(btnSupprimer);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(listView1);
            Controls.Add(btnSalarie);
            Controls.Add(btnGrille);
            Name = "Utilisation";
            Text = "Utilisateur";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGrille;
        private Button btnSalarie;
        private ListView listView1;
        private Button btnModifier;
        private Button btnAjouter;
        private Button btnSupprimer;
        private Button btnGestion;
        private Button btnDeconnexion;
        private Button btnAdmin;
        private Button btnPoste;
    }
}