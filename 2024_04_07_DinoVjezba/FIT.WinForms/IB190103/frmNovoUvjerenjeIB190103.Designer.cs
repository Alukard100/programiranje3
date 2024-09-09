namespace FIT.WinForms.IB190103
{
    partial class frmNovoUvjerenjeIB190103
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
            components = new System.ComponentModel.Container();
            cbVrste = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            rtbSvrha = new RichTextBox();
            label3 = new Label();
            pbSlika = new PictureBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbVrste
            // 
            cbVrste.FormattingEnabled = true;
            cbVrste.Items.AddRange(new object[] { "Uvjerenje o polozenim ispitima", "Uvjerenje o statusu studenta", "Uvjerenje o necemu drugom" });
            cbVrste.Location = new Point(12, 31);
            cbVrste.Name = "cbVrste";
            cbVrste.Size = new Size(239, 23);
            cbVrste.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Vrsta uvjerenja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Svrha izdavanja:";
            // 
            // rtbSvrha
            // 
            rtbSvrha.Location = new Point(12, 85);
            rtbSvrha.Name = "rtbSvrha";
            rtbSvrha.Size = new Size(239, 216);
            rtbSvrha.TabIndex = 3;
            rtbSvrha.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 4;
            label3.Text = "Seknirana uplatnica:";
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(275, 31);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(458, 233);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 5;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(658, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovoUvjerenjeIB190103
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 317);
            Controls.Add(button1);
            Controls.Add(pbSlika);
            Controls.Add(label3);
            Controls.Add(rtbSvrha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbVrste);
            Name = "frmNovoUvjerenjeIB190103";
            Text = "frmNovoUvjerenjeIB190103";
            Load += frmNovoUvjerenjeIB190103_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVrste;
        private Label label1;
        private Label label2;
        private RichTextBox rtbSvrha;
        private Label label3;
        private PictureBox pbSlika;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}