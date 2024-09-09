namespace FIT.WinForms.IB190103
{
    partial class frmStudentInfoIB190103
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
            pbStudentSlika = new PictureBox();
            lblNazivStudenta = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbStudentSlika).BeginInit();
            SuspendLayout();
            // 
            // pbStudentSlika
            // 
            pbStudentSlika.Location = new Point(12, 12);
            pbStudentSlika.Name = "pbStudentSlika";
            pbStudentSlika.Size = new Size(224, 226);
            pbStudentSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStudentSlika.TabIndex = 0;
            pbStudentSlika.TabStop = false;
            // 
            // lblNazivStudenta
            // 
            lblNazivStudenta.AutoSize = true;
            lblNazivStudenta.Font = new Font("Segoe UI", 18F);
            lblNazivStudenta.Location = new Point(51, 253);
            lblNazivStudenta.Name = "lblNazivStudenta";
            lblNazivStudenta.Size = new Size(149, 32);
            lblNazivStudenta.TabIndex = 1;
            lblNazivStudenta.Text = "ImeStudenta";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Font = new Font("Segoe UI", 12F);
            lblProsjek.Location = new Point(69, 285);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(64, 21);
            lblProsjek.TabIndex = 2;
            lblProsjek.Text = "Prosjek:";
            // 
            // frmStudentInfoIB190103
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 318);
            Controls.Add(lblProsjek);
            Controls.Add(lblNazivStudenta);
            Controls.Add(pbStudentSlika);
            Name = "frmStudentInfoIB190103";
            Text = "frmStudentInfoIB190103";
            Load += frmStudentInfoIB190103_Load;
            ((System.ComponentModel.ISupportInitialize)pbStudentSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbStudentSlika;
        private Label lblNazivStudenta;
        private Label lblProsjek;
    }
}