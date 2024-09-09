namespace FIT.WinForms.IB190103
{
    partial class frmGradoviIB190103
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            dgvGradoviDrzave = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            label1 = new Label();
            txtbNazivGrada = new TextBox();
            btnAddGrad = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradoviDrzave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(122, 73);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNazivDrzave.Location = new Point(140, 55);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(85, 30);
            lblNazivDrzave.TabIndex = 1;
            lblNazivDrzave.Text = "Drzava";
            // 
            // dgvGradoviDrzave
            // 
            dgvGradoviDrzave.AllowUserToAddRows = false;
            dgvGradoviDrzave.AllowUserToDeleteRows = false;
            dgvGradoviDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradoviDrzave.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, PromjeniStatus });
            dgvGradoviDrzave.Location = new Point(12, 127);
            dgvGradoviDrzave.Name = "dgvGradoviDrzave";
            dgvGradoviDrzave.ReadOnly = true;
            dgvGradoviDrzave.RowTemplate.Height = 25;
            dgvGradoviDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradoviDrzave.Size = new Size(389, 150);
            dgvGradoviDrzave.TabIndex = 2;
            dgvGradoviDrzave.CellContentClick += dgvGradoviDrzave_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 100);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 3;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // txtbNazivGrada
            // 
            txtbNazivGrada.Location = new Point(167, 101);
            txtbNazivGrada.Name = "txtbNazivGrada";
            txtbNazivGrada.Size = new Size(137, 23);
            txtbNazivGrada.TabIndex = 4;
            // 
            // btnAddGrad
            // 
            btnAddGrad.Location = new Point(326, 100);
            btnAddGrad.Name = "btnAddGrad";
            btnAddGrad.Size = new Size(75, 23);
            btnAddGrad.TabIndex = 5;
            btnAddGrad.Text = "Dodaj";
            btnAddGrad.UseVisualStyleBackColor = true;
            btnAddGrad.Click += btnAddGrad_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmGradoviIB190103
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(btnAddGrad);
            Controls.Add(txtbNazivGrada);
            Controls.Add(label1);
            Controls.Add(dgvGradoviDrzave);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB190103";
            Text = "frmGradoviIB190103";
            Load += frmGradoviIB190103_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradoviDrzave).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private DataGridView dgvGradoviDrzave;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn PromjeniStatus;
        private Label label1;
        private TextBox txtbNazivGrada;
        private Button btnAddGrad;
        private ErrorProvider errorProvider1;
    }
}