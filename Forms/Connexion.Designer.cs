namespace Gestion_Salaire
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUtilisateur = new Label();
            txtUtilisateur = new TextBox();
            lbMdp = new Label();
            txtMdp = new TextBox();
            btnConnexion = new Button();
            SuspendLayout();
            // 
            // lbUtilisateur
            // 
            lbUtilisateur.AutoSize = true;
            lbUtilisateur.Location = new Point(78, 68);
            lbUtilisateur.Name = "lbUtilisateur";
            lbUtilisateur.Size = new Size(76, 20);
            lbUtilisateur.TabIndex = 0;
            lbUtilisateur.Text = "Utilisateur";
            // 
            // txtUtilisateur
            // 
            txtUtilisateur.BackColor = SystemColors.GradientInactiveCaption;
            txtUtilisateur.Location = new Point(178, 65);
            txtUtilisateur.Name = "txtUtilisateur";
            txtUtilisateur.Size = new Size(258, 27);
            txtUtilisateur.TabIndex = 1;
            // 
            // lbMdp
            // 
            lbMdp.AutoSize = true;
            lbMdp.Location = new Point(56, 123);
            lbMdp.Name = "lbMdp";
            lbMdp.Size = new Size(98, 20);
            lbMdp.TabIndex = 2;
            lbMdp.Text = "Mot de passe";
            // 
            // txtMdp
            // 
            txtMdp.BackColor = SystemColors.GradientInactiveCaption;
            txtMdp.Location = new Point(178, 116);
            txtMdp.Name = "txtMdp";
            txtMdp.Size = new Size(258, 27);
            txtMdp.TabIndex = 3;
            // 
            // btnConnexion
            // 
            btnConnexion.BackColor = SystemColors.AppWorkspace;
            btnConnexion.Location = new Point(178, 189);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(135, 40);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 266);
            Controls.Add(btnConnexion);
            Controls.Add(txtMdp);
            Controls.Add(lbMdp);
            Controls.Add(txtUtilisateur);
            Controls.Add(lbUtilisateur);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUtilisateur;
        private TextBox txtUtilisateur;
        private Label lbMdp;
        private TextBox txtMdp;
        private Button btnConnexion;
    }
}
