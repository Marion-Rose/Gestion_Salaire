namespace Gestion_Salaire.Forms
{
    partial class CRUDEntreprise
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
            lbId = new Label();
            lbIdActuel = new Label();
            lbRS = new Label();
            txtRS = new TextBox();
            lbAdresse = new Label();
            txtAdresse = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(24, 33);
            lbId.Name = "lbId";
            lbId.Size = new Size(77, 20);
            lbId.TabIndex = 0;
            lbId.Text = "Identifiant";
            // 
            // lbIdActuel
            // 
            lbIdActuel.AutoSize = true;
            lbIdActuel.Location = new Point(118, 33);
            lbIdActuel.Name = "lbIdActuel";
            lbIdActuel.Size = new Size(23, 20);
            lbIdActuel.TabIndex = 1;
            lbIdActuel.Text = "??";
            // 
            // lbRS
            // 
            lbRS.AutoSize = true;
            lbRS.Location = new Point(191, 33);
            lbRS.Name = "lbRS";
            lbRS.Size = new Size(103, 20);
            lbRS.TabIndex = 2;
            lbRS.Text = "Raison sociale";
            // 
            // txtRS
            // 
            txtRS.Location = new Point(300, 30);
            txtRS.Name = "txtRS";
            txtRS.Size = new Size(175, 27);
            txtRS.TabIndex = 3;
            // 
            // lbAdresse
            // 
            lbAdresse.AutoSize = true;
            lbAdresse.Location = new Point(67, 87);
            lbAdresse.Name = "lbAdresse";
            lbAdresse.Size = new Size(61, 20);
            lbAdresse.TabIndex = 4;
            lbAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(150, 87);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(325, 27);
            txtAdresse.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ActiveCaption;
            btnOk.Location = new Point(222, 159);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 26;
            btnOk.Text = "ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // CRUDEntreprise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 223);
            Controls.Add(btnOk);
            Controls.Add(txtAdresse);
            Controls.Add(lbAdresse);
            Controls.Add(txtRS);
            Controls.Add(lbRS);
            Controls.Add(lbIdActuel);
            Controls.Add(lbId);
            Name = "CRUDEntreprise";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUDEntreprise";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbIdActuel;
        private Label lbRS;
        private TextBox txtRS;
        private Label lbAdresse;
        private TextBox txtAdresse;
        private Button btnOk;
    }
}