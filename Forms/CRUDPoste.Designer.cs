namespace Gestion_Salaire.Forms
{
    partial class CRUDPoste
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
            lbPoids = new Label();
            txtLibelle = new TextBox();
            lbLibelle = new Label();
            lbIdActuel = new Label();
            lbId = new Label();
            btnOk = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lbPoids
            // 
            lbPoids.AutoSize = true;
            lbPoids.Location = new Point(558, 45);
            lbPoids.Name = "lbPoids";
            lbPoids.Size = new Size(44, 20);
            lbPoids.TabIndex = 10;
            lbPoids.Text = "Poids";
            // 
            // txtLibelle
            // 
            txtLibelle.Location = new Point(281, 42);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(225, 27);
            txtLibelle.TabIndex = 9;
            // 
            // lbLibelle
            // 
            lbLibelle.AutoSize = true;
            lbLibelle.Location = new Point(222, 45);
            lbLibelle.Name = "lbLibelle";
            lbLibelle.Size = new Size(53, 20);
            lbLibelle.TabIndex = 8;
            lbLibelle.Text = "Libellé";
            // 
            // lbIdActuel
            // 
            lbIdActuel.AutoSize = true;
            lbIdActuel.Location = new Point(149, 45);
            lbIdActuel.Name = "lbIdActuel";
            lbIdActuel.Size = new Size(23, 20);
            lbIdActuel.TabIndex = 7;
            lbIdActuel.Text = "??";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(55, 45);
            lbId.Name = "lbId";
            lbId.Size = new Size(77, 20);
            lbId.TabIndex = 6;
            lbId.Text = "Identifiant";
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ActiveCaption;
            btnOk.Location = new Point(341, 107);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 27;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(609, 43);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(42, 27);
            numericUpDown1.TabIndex = 28;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CRUDPoste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 169);
            Controls.Add(numericUpDown1);
            Controls.Add(btnOk);
            Controls.Add(lbPoids);
            Controls.Add(txtLibelle);
            Controls.Add(lbLibelle);
            Controls.Add(lbIdActuel);
            Controls.Add(lbId);
            Name = "CRUDPoste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDPoste";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbPoids;
        private TextBox txtLibelle;
        private Label lbLibelle;
        private Label lbIdActuel;
        private Label lbId;
        private Button btnOk;
        private NumericUpDown numericUpDown1;
    }
}