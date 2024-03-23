namespace Gestion_Salaire.Forms
{
    partial class CRUDUtilisateur
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
            comboBoxUtilisateur = new ComboBox();
            txtMdp = new TextBox();
            txtIdentifiant = new TextBox();
            lbEntreprise = new Label();
            lbMDP = new Label();
            lbIdentifiant = new Label();
            lbEntrepriseActuelle = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // comboBoxUtilisateur
            // 
            comboBoxUtilisateur.FormattingEnabled = true;
            comboBoxUtilisateur.Location = new Point(42, 36);
            comboBoxUtilisateur.Name = "comboBoxUtilisateur";
            comboBoxUtilisateur.Size = new Size(360, 28);
            comboBoxUtilisateur.TabIndex = 0;
            comboBoxUtilisateur.SelectedIndexChanged += comboBoxUtilisateur_SelectedIndexChanged;
            // 
            // txtMdp
            // 
            txtMdp.Location = new Point(426, 103);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(202, 27);
            txtMdp.TabIndex = 13;
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(125, 100);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(125, 27);
            txtIdentifiant.TabIndex = 12;
            // 
            // lbEntreprise
            // 
            lbEntreprise.AutoSize = true;
            lbEntreprise.Location = new Point(472, 44);
            lbEntreprise.Name = "lbEntreprise";
            lbEntreprise.Size = new Size(75, 20);
            lbEntreprise.TabIndex = 11;
            lbEntreprise.Text = "Entreprise";
            // 
            // lbMDP
            // 
            lbMDP.AutoSize = true;
            lbMDP.Location = new Point(312, 103);
            lbMDP.Name = "lbMDP";
            lbMDP.Size = new Size(98, 20);
            lbMDP.TabIndex = 10;
            lbMDP.Text = "Mot de passe";
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(42, 103);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(77, 20);
            lbIdentifiant.TabIndex = 9;
            lbIdentifiant.Text = "Identifiant";
            // 
            // lbEntrepriseActuelle
            // 
            lbEntrepriseActuelle.AutoSize = true;
            lbEntrepriseActuelle.Location = new Point(553, 44);
            lbEntrepriseActuelle.Name = "lbEntrepriseActuelle";
            lbEntrepriseActuelle.Size = new Size(75, 20);
            lbEntrepriseActuelle.TabIndex = 14;
            lbEntrepriseActuelle.Text = "entreprise";
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ActiveCaption;
            btnOk.Location = new Point(282, 166);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 15;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // CRUDUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 226);
            Controls.Add(btnOk);
            Controls.Add(lbEntrepriseActuelle);
            Controls.Add(txtMdp);
            Controls.Add(txtIdentifiant);
            Controls.Add(lbEntreprise);
            Controls.Add(lbMDP);
            Controls.Add(lbIdentifiant);
            Controls.Add(comboBoxUtilisateur);
            Name = "CRUDUtilisateur";
            Text = "CRUDUtilisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUtilisateur;
        private TextBox txtMdp;
        private TextBox txtIdentifiant;
        private Label lbEntreprise;
        private Label lbMDP;
        private Label lbIdentifiant;
        private Label lbEntrepriseActuelle;
        private Button btnOk;
    }
}