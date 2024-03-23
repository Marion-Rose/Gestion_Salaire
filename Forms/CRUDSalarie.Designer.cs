namespace Gestion_Salaire.Forms
{
    partial class CRUDSalarie
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
            lbNom = new Label();
            lbPrenom = new Label();
            lbPoste = new Label();
            lbEchelon = new Label();
            lbAnnee = new Label();
            lbEntreprise = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            comboBoxEntreprise = new ComboBox();
            comboBoxPoste = new ComboBox();
            numericUpDownEchelon = new NumericUpDown();
            numericUpDownAnnee = new NumericUpDown();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEchelon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnnee).BeginInit();
            SuspendLayout();
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(54, 42);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 0;
            lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(311, 42);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 1;
            lbPrenom.Text = "Prenom";
            // 
            // lbPoste
            // 
            lbPoste.AutoSize = true;
            lbPoste.Location = new Point(52, 113);
            lbPoste.Name = "lbPoste";
            lbPoste.Size = new Size(44, 20);
            lbPoste.TabIndex = 2;
            lbPoste.Text = "Poste";
            // 
            // lbEchelon
            // 
            lbEchelon.AutoSize = true;
            lbEchelon.Location = new Point(311, 113);
            lbEchelon.Name = "lbEchelon";
            lbEchelon.Size = new Size(61, 20);
            lbEchelon.TabIndex = 3;
            lbEchelon.Text = "Echelon";
            // 
            // lbAnnee
            // 
            lbAnnee.AutoSize = true;
            lbAnnee.Location = new Point(529, 113);
            lbAnnee.Name = "lbAnnee";
            lbAnnee.Size = new Size(51, 20);
            lbAnnee.TabIndex = 4;
            lbAnnee.Text = "Annee";
            // 
            // lbEntreprise
            // 
            lbEntreprise.AutoSize = true;
            lbEntreprise.Location = new Point(529, 42);
            lbEntreprise.Name = "lbEntreprise";
            lbEntreprise.Size = new Size(75, 20);
            lbEntreprise.TabIndex = 5;
            lbEntreprise.Text = "Entreprise";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(116, 39);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 6;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(377, 42);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 7;
            // 
            // comboBoxEntreprise
            // 
            comboBoxEntreprise.FormattingEnabled = true;
            comboBoxEntreprise.Location = new Point(619, 42);
            comboBoxEntreprise.Name = "comboBoxEntreprise";
            comboBoxEntreprise.Size = new Size(151, 28);
            comboBoxEntreprise.TabIndex = 8;
            // 
            // comboBoxPoste
            // 
            comboBoxPoste.FormattingEnabled = true;
            comboBoxPoste.Location = new Point(116, 105);
            comboBoxPoste.Name = "comboBoxPoste";
            comboBoxPoste.Size = new Size(151, 28);
            comboBoxPoste.TabIndex = 9;
            // 
            // numericUpDownEchelon
            // 
            numericUpDownEchelon.Location = new Point(377, 111);
            numericUpDownEchelon.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownEchelon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEchelon.Name = "numericUpDownEchelon";
            numericUpDownEchelon.Size = new Size(116, 27);
            numericUpDownEchelon.TabIndex = 10;
            numericUpDownEchelon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownAnnee
            // 
            numericUpDownAnnee.Location = new Point(586, 111);
            numericUpDownAnnee.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownAnnee.Name = "numericUpDownAnnee";
            numericUpDownAnnee.Size = new Size(116, 27);
            numericUpDownAnnee.TabIndex = 11;
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ActiveCaption;
            btnOk.Location = new Point(345, 183);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 12;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // CRUDSalarie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 231);
            Controls.Add(btnOk);
            Controls.Add(numericUpDownAnnee);
            Controls.Add(numericUpDownEchelon);
            Controls.Add(comboBoxPoste);
            Controls.Add(comboBoxEntreprise);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(lbEntreprise);
            Controls.Add(lbAnnee);
            Controls.Add(lbEchelon);
            Controls.Add(lbPoste);
            Controls.Add(lbPrenom);
            Controls.Add(lbNom);
            Name = "CRUDSalarie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDSalarie";
            ((System.ComponentModel.ISupportInitialize)numericUpDownEchelon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnnee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNom;
        private Label lbPrenom;
        private Label lbPoste;
        private Label lbEchelon;
        private Label lbAnnee;
        private Label lbEntreprise;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private ComboBox comboBoxEntreprise;
        private ComboBox comboBoxPoste;
        private NumericUpDown numericUpDownEchelon;
        private NumericUpDown numericUpDownAnnee;
        private Button btnOk;
    }
}