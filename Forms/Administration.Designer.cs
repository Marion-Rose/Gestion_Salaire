namespace Gestion_Salaire.Forms
{
    partial class Administration
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
            btLogs = new Button();
            btUtilisateur = new Button();
            btEntreprise = new Button();
            listView1 = new ListView();
            comboBox1 = new ComboBox();
            btnDeconnexion = new Button();
            btnUtilisateur = new Button();
            btnSupprimer = new Button();
            btnAjouter = new Button();
            btnModifier = new Button();
            SuspendLayout();
            // 
            // btLogs
            // 
            btLogs.BackColor = Color.PowderBlue;
            btLogs.Image = Properties.Resources._2621231_removebg_preview1;
            btLogs.Location = new Point(106, 367);
            btLogs.Name = "btLogs";
            btLogs.Size = new Size(88, 84);
            btLogs.TabIndex = 0;
            btLogs.UseVisualStyleBackColor = false;
            btLogs.Click += btLogs_Click;
            // 
            // btUtilisateur
            // 
            btUtilisateur.BackColor = Color.PowderBlue;
            btUtilisateur.Image = Properties.Resources.téléchargement_removebg_preview1;
            btUtilisateur.Location = new Point(106, 246);
            btUtilisateur.Name = "btUtilisateur";
            btUtilisateur.Size = new Size(88, 84);
            btUtilisateur.TabIndex = 1;
            btUtilisateur.UseVisualStyleBackColor = false;
            btUtilisateur.Click += btUtilisateur_Click;
            // 
            // btEntreprise
            // 
            btEntreprise.BackColor = Color.PowderBlue;
            btEntreprise.Image = Properties.Resources.images_removebg_preview;
            btEntreprise.Location = new Point(106, 121);
            btEntreprise.Name = "btEntreprise";
            btEntreprise.Size = new Size(88, 84);
            btEntreprise.TabIndex = 2;
            btEntreprise.UseVisualStyleBackColor = false;
            btEntreprise.Click += btEntreprise_Click;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(344, 136);
            listView1.Name = "listView1";
            listView1.Size = new Size(890, 374);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(376, 28);
            comboBox1.TabIndex = 4;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = SystemColors.ActiveBorder;
            btnDeconnexion.Location = new Point(1205, 21);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(145, 53);
            btnDeconnexion.TabIndex = 5;
            btnDeconnexion.Text = "Se déconnecter";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // btnUtilisateur
            // 
            btnUtilisateur.BackColor = SystemColors.GradientInactiveCaption;
            btnUtilisateur.Location = new Point(1054, 21);
            btnUtilisateur.Name = "btnUtilisateur";
            btnUtilisateur.Size = new Size(129, 53);
            btnUtilisateur.TabIndex = 6;
            btnUtilisateur.Text = "Basculer vers le mode utilisateur";
            btnUtilisateur.UseVisualStyleBackColor = false;
            btnUtilisateur.Click += btnUtilisateur_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Image = Properties.Resources.images_removebg_preview__1_;
            btnSupprimer.Location = new Point(1279, 371);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(58, 53);
            btnSupprimer.TabIndex = 9;
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAjouter
            // 
            btnAjouter.Image = Properties.Resources.unnamed_removebg_preview;
            btnAjouter.Location = new Point(1279, 212);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(58, 53);
            btnAjouter.TabIndex = 8;
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Image = Properties.Resources.modifier_document_signer_l_icone_le_bouton_modifier_le_contenu_l_interface_utilisateur_moderne_bouton_site_web_2c4x5nt_removebg_preview;
            btnModifier.Location = new Point(1279, 293);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(58, 53);
            btnModifier.TabIndex = 7;
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 592);
            Controls.Add(btnSupprimer);
            Controls.Add(btnAjouter);
            Controls.Add(btnModifier);
            Controls.Add(btnUtilisateur);
            Controls.Add(btnDeconnexion);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(btEntreprise);
            Controls.Add(btUtilisateur);
            Controls.Add(btLogs);
            Name = "Administration";
            Text = "Administrateur";
            ResumeLayout(false);
        }

        #endregion

        private Button btLogs;
        private Button btUtilisateur;
        private Button btEntreprise;
        private ListView listView1;
        private ComboBox comboBox1;
        private Button btnDeconnexion;
        private Button btnUtilisateur;
        private Button btnSupprimer;
        private Button btnAjouter;
        private Button btnModifier;
    }
}