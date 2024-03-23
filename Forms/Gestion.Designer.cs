namespace Gestion_Salaire.Forms
{
    partial class Gestion
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
            lbAnnee = new Label();
            numUpDownAnnee = new NumericUpDown();
            lbEmploye = new Label();
            comboBoxEmploye = new ComboBox();
            lbPoste = new Label();
            lbEntreprise = new Label();
            label1 = new Label();
            lbEchelon = new Label();
            btnAugEchelon = new Button();
            btnAugPoste = new Button();
            lbEntrepriseEmploye = new Label();
            lbPosteEmploye = new Label();
            lbEchelonEmploye = new Label();
            lbAnneeEmploye = new Label();
            lbSalaireAn = new Label();
            lbSalAnnuel = new Label();
            lbSalMenAct = new Label();
            lbSalaireMensuel = new Label();
            lbEuro = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUpDownAnnee).BeginInit();
            SuspendLayout();
            // 
            // lbAnnee
            // 
            lbAnnee.AutoSize = true;
            lbAnnee.Location = new Point(160, 36);
            lbAnnee.Name = "lbAnnee";
            lbAnnee.Size = new Size(51, 20);
            lbAnnee.TabIndex = 0;
            lbAnnee.Text = "Annee";
            // 
            // numUpDownAnnee
            // 
            numUpDownAnnee.Location = new Point(242, 34);
            numUpDownAnnee.Maximum = new decimal(new int[] { 2045, 0, 0, 0 });
            numUpDownAnnee.Minimum = new decimal(new int[] { 2024, 0, 0, 0 });
            numUpDownAnnee.Name = "numUpDownAnnee";
            numUpDownAnnee.Size = new Size(150, 27);
            numUpDownAnnee.TabIndex = 1;
            numUpDownAnnee.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            numUpDownAnnee.ValueChanged += numericUpDownAnnee_ValueChanged;
            // 
            // lbEmploye
            // 
            lbEmploye.AutoSize = true;
            lbEmploye.Location = new Point(144, 94);
            lbEmploye.Name = "lbEmploye";
            lbEmploye.Size = new Size(67, 20);
            lbEmploye.TabIndex = 2;
            lbEmploye.Text = "Employé";
            // 
            // comboBoxEmploye
            // 
            comboBoxEmploye.FormattingEnabled = true;
            comboBoxEmploye.Location = new Point(242, 91);
            comboBoxEmploye.Name = "comboBoxEmploye";
            comboBoxEmploye.Size = new Size(278, 28);
            comboBoxEmploye.TabIndex = 3;
            comboBoxEmploye.SelectedIndexChanged += comboBoxEmploye_SelectedIndexChanged;
            // 
            // lbPoste
            // 
            lbPoste.AutoSize = true;
            lbPoste.Location = new Point(434, 154);
            lbPoste.Name = "lbPoste";
            lbPoste.Size = new Size(44, 20);
            lbPoste.TabIndex = 23;
            lbPoste.Text = "Poste";
            // 
            // lbEntreprise
            // 
            lbEntreprise.AutoSize = true;
            lbEntreprise.Location = new Point(71, 154);
            lbEntreprise.Name = "lbEntreprise";
            lbEntreprise.Size = new Size(75, 20);
            lbEntreprise.TabIndex = 25;
            lbEntreprise.Text = "Entreprise";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 207);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 28;
            label1.Text = "Annee";
            // 
            // lbEchelon
            // 
            lbEchelon.AutoSize = true;
            lbEchelon.Location = new Point(83, 209);
            lbEchelon.Name = "lbEchelon";
            lbEchelon.Size = new Size(61, 20);
            lbEchelon.TabIndex = 27;
            lbEchelon.Text = "Echelon";
            // 
            // btnAugEchelon
            // 
            btnAugEchelon.BackColor = SystemColors.InactiveCaption;
            btnAugEchelon.Location = new Point(128, 318);
            btnAugEchelon.Name = "btnAugEchelon";
            btnAugEchelon.Size = new Size(191, 39);
            btnAugEchelon.TabIndex = 31;
            btnAugEchelon.Text = "Augmenter d'un échelon";
            btnAugEchelon.UseVisualStyleBackColor = false;
            btnAugEchelon.Click += btnAugEchelon_Click;
            // 
            // btnAugPoste
            // 
            btnAugPoste.BackColor = SystemColors.InactiveCaption;
            btnAugPoste.Location = new Point(376, 318);
            btnAugPoste.Name = "btnAugPoste";
            btnAugPoste.Size = new Size(191, 39);
            btnAugPoste.TabIndex = 32;
            btnAugPoste.Text = "Augmenter le poste";
            btnAugPoste.UseVisualStyleBackColor = false;
            btnAugPoste.Click += btnAugPoste_Click;
            // 
            // lbEntrepriseEmploye
            // 
            lbEntrepriseEmploye.AutoSize = true;
            lbEntrepriseEmploye.Location = new Point(173, 154);
            lbEntrepriseEmploye.Name = "lbEntrepriseEmploye";
            lbEntrepriseEmploye.Size = new Size(75, 20);
            lbEntrepriseEmploye.TabIndex = 33;
            lbEntrepriseEmploye.Text = "Entreprise";
            // 
            // lbPosteEmploye
            // 
            lbPosteEmploye.AutoSize = true;
            lbPosteEmploye.Location = new Point(498, 154);
            lbPosteEmploye.Name = "lbPosteEmploye";
            lbPosteEmploye.Size = new Size(44, 20);
            lbPosteEmploye.TabIndex = 34;
            lbPosteEmploye.Text = "Poste";
            // 
            // lbEchelonEmploye
            // 
            lbEchelonEmploye.AutoSize = true;
            lbEchelonEmploye.Location = new Point(173, 209);
            lbEchelonEmploye.Name = "lbEchelonEmploye";
            lbEchelonEmploye.Size = new Size(61, 20);
            lbEchelonEmploye.TabIndex = 35;
            lbEchelonEmploye.Text = "Echelon";
            // 
            // lbAnneeEmploye
            // 
            lbAnneeEmploye.AutoSize = true;
            lbAnneeEmploye.Location = new Point(498, 205);
            lbAnneeEmploye.Name = "lbAnneeEmploye";
            lbAnneeEmploye.Size = new Size(51, 20);
            lbAnneeEmploye.TabIndex = 36;
            lbAnneeEmploye.Text = "Annee";
            // 
            // lbSalaireAn
            // 
            lbSalaireAn.AutoSize = true;
            lbSalaireAn.Location = new Point(376, 252);
            lbSalaireAn.Name = "lbSalaireAn";
            lbSalaireAn.Size = new Size(102, 20);
            lbSalaireAn.TabIndex = 37;
            lbSalaireAn.Text = "Salaire annuel";
            // 
            // lbSalAnnuel
            // 
            lbSalAnnuel.AutoSize = true;
            lbSalAnnuel.Location = new Point(498, 252);
            lbSalAnnuel.Name = "lbSalAnnuel";
            lbSalAnnuel.Size = new Size(102, 20);
            lbSalAnnuel.TabIndex = 38;
            lbSalAnnuel.Text = "Salaire annuel";
            // 
            // lbSalMenAct
            // 
            lbSalMenAct.AutoSize = true;
            lbSalMenAct.Location = new Point(173, 256);
            lbSalMenAct.Name = "lbSalMenAct";
            lbSalMenAct.Size = new Size(113, 20);
            lbSalMenAct.TabIndex = 40;
            lbSalMenAct.Text = "Salaire mensuel";
            // 
            // lbSalaireMensuel
            // 
            lbSalaireMensuel.AutoSize = true;
            lbSalaireMensuel.Location = new Point(33, 256);
            lbSalaireMensuel.Name = "lbSalaireMensuel";
            lbSalaireMensuel.Size = new Size(113, 20);
            lbSalaireMensuel.TabIndex = 39;
            lbSalaireMensuel.Text = "Salaire mensuel";
            // 
            // lbEuro
            // 
            lbEuro.AutoSize = true;
            lbEuro.Location = new Point(292, 256);
            lbEuro.Name = "lbEuro";
            lbEuro.Size = new Size(17, 20);
            lbEuro.TabIndex = 41;
            lbEuro.Text = "€";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(606, 252);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 42;
            label2.Text = "€";
            // 
            // Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 398);
            Controls.Add(label2);
            Controls.Add(lbEuro);
            Controls.Add(lbSalMenAct);
            Controls.Add(lbSalaireMensuel);
            Controls.Add(lbSalAnnuel);
            Controls.Add(lbSalaireAn);
            Controls.Add(lbAnneeEmploye);
            Controls.Add(lbEchelonEmploye);
            Controls.Add(lbPosteEmploye);
            Controls.Add(lbEntrepriseEmploye);
            Controls.Add(btnAugPoste);
            Controls.Add(btnAugEchelon);
            Controls.Add(label1);
            Controls.Add(lbEchelon);
            Controls.Add(lbEntreprise);
            Controls.Add(lbPoste);
            Controls.Add(comboBoxEmploye);
            Controls.Add(lbEmploye);
            Controls.Add(numUpDownAnnee);
            Controls.Add(lbAnnee);
            Name = "Gestion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion";
            ((System.ComponentModel.ISupportInitialize)numUpDownAnnee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAnnee;
        private NumericUpDown numUpDownAnnee;
        private Label lbEmploye;
        private ComboBox comboBoxEmploye;
        private Label lbPoste;
        private Label lbEntreprise;
        private Label label1;
        private Label lbEchelon;
        private Button btnAugEchelon;
        private Button btnAugPoste;
        private Label lbEntrepriseEmploye;
        private Label lbPosteEmploye;
        private Label lbEchelonEmploye;
        private Label lbAnneeEmploye;
        private Label lbSalaireAn;
        private Label lbSalAnnuel;
        private Label lbSalMenAct;
        private Label lbSalaireMensuel;
        private Label lbEuro;
        private Label label2;
    }
}