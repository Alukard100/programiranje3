namespace FIT.WinForms.IB190103
{
    partial class frmPretragaIB190103
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
            label1 = new Label();
            cbSpol = new ComboBox();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            label3 = new Label();
            dtpTo = new DateTimePicker();
            dgvPretraga = new DataGridView();
            Indeks = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Uvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Spol:";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Items.AddRange(new object[] { "Musko", "Zensko", "Svi" });
            cbSpol.Location = new Point(51, 6);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(101, 23);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 14);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Rodjen u periodu od ";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(282, 8);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 3;
            dtpFrom.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 16);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 4;
            label3.Text = "do";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(515, 10);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 5;
            dtpTo.Value = new DateTime(2024, 8, 29, 0, 0, 0, 0);
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // dgvPretraga
            // 
            dgvPretraga.AllowUserToAddRows = false;
            dgvPretraga.AllowUserToDeleteRows = false;
            dgvPretraga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPretraga.Columns.AddRange(new DataGridViewColumn[] { Indeks, ImePrezime, Prosjek, DatumRodjenja, Aktivan, Uvjerenja });
            dgvPretraga.Location = new Point(12, 39);
            dgvPretraga.Name = "dgvPretraga";
            dgvPretraga.ReadOnly = true;
            dgvPretraga.RowTemplate.Height = 25;
            dgvPretraga.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPretraga.Size = new Size(703, 228);
            dgvPretraga.TabIndex = 6;
            dgvPretraga.CellContentClick += dgvPretraga_CellContentClick;
            // 
            // Indeks
            // 
            Indeks.DataPropertyName = "Indeks";
            Indeks.HeaderText = "Broj Indeksa";
            Indeks.Name = "Indeks";
            Indeks.ReadOnly = true;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i Prezime";
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum Rodjenja";
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // Uvjerenja
            // 
            Uvjerenja.HeaderText = "";
            Uvjerenja.Name = "Uvjerenja";
            Uvjerenja.ReadOnly = true;
            Uvjerenja.Text = "Uvjerenja";
            Uvjerenja.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB190103
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 278);
            Controls.Add(dgvPretraga);
            Controls.Add(dtpTo);
            Controls.Add(label3);
            Controls.Add(dtpFrom);
            Controls.Add(label2);
            Controls.Add(cbSpol);
            Controls.Add(label1);
            Name = "frmPretragaIB190103";
            Text = "frmPretragaIB190103";
            Load += frmPretragaIB190103_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPretraga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSpol;
        private Label label2;
        private DateTimePicker dtpFrom;
        private Label label3;
        private DateTimePicker dtpTo;
        private DataGridView dgvPretraga;
        private DataGridViewTextBoxColumn Indeks;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn Prosjek;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Uvjerenja;
    }
}