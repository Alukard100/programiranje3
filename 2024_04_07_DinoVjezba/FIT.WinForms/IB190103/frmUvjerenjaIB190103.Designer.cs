namespace FIT.WinForms.IB190103
{
    partial class frmUvjerenjaIB190103
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
            btnNovi = new Button();
            dgvUvjerenja = new DataGridView();
            DatumKreiranja = new DataGridViewTextBoxColumn();
            VrstaUvjerenja = new DataGridViewTextBoxColumn();
            SvrhaIzdavanja = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            Brisi = new DataGridViewButtonColumn();
            Printaj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).BeginInit();
            SuspendLayout();
            // 
            // btnNovi
            // 
            btnNovi.Location = new Point(684, 12);
            btnNovi.Name = "btnNovi";
            btnNovi.Size = new Size(104, 23);
            btnNovi.TabIndex = 0;
            btnNovi.Text = "Novi Zahtjev";
            btnNovi.UseVisualStyleBackColor = true;
            btnNovi.Click += btnNovi_Click;
            // 
            // dgvUvjerenja
            // 
            dgvUvjerenja.AllowUserToAddRows = false;
            dgvUvjerenja.AllowUserToDeleteRows = false;
            dgvUvjerenja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjerenja.Columns.AddRange(new DataGridViewColumn[] { DatumKreiranja, VrstaUvjerenja, SvrhaIzdavanja, Uplatnica, Printano, Brisi, Printaj });
            dgvUvjerenja.Location = new Point(12, 39);
            dgvUvjerenja.Name = "dgvUvjerenja";
            dgvUvjerenja.ReadOnly = true;
            dgvUvjerenja.RowTemplate.Height = 25;
            dgvUvjerenja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjerenja.Size = new Size(776, 208);
            dgvUvjerenja.TabIndex = 1;
            dgvUvjerenja.CellContentClick += dgvUvjerenja_CellContentClick;
            // 
            // DatumKreiranja
            // 
            DatumKreiranja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumKreiranja.DataPropertyName = "DatumKreiranja";
            DatumKreiranja.HeaderText = "Datum";
            DatumKreiranja.Name = "DatumKreiranja";
            DatumKreiranja.ReadOnly = true;
            // 
            // VrstaUvjerenja
            // 
            VrstaUvjerenja.DataPropertyName = "VrstaUvjerenja";
            VrstaUvjerenja.HeaderText = "Vrsta";
            VrstaUvjerenja.Name = "VrstaUvjerenja";
            VrstaUvjerenja.ReadOnly = true;
            // 
            // SvrhaIzdavanja
            // 
            SvrhaIzdavanja.DataPropertyName = "SvrhaIzdavanja";
            SvrhaIzdavanja.HeaderText = "Svrha";
            SvrhaIzdavanja.Name = "SvrhaIzdavanja";
            SvrhaIzdavanja.ReadOnly = true;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            // 
            // Brisi
            // 
            Brisi.HeaderText = "";
            Brisi.Name = "Brisi";
            Brisi.ReadOnly = true;
            Brisi.Text = "Brisi";
            Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            Printaj.HeaderText = "";
            Printaj.Name = "Printaj";
            Printaj.ReadOnly = true;
            Printaj.Text = "Printaj";
            Printaj.UseColumnTextForButtonValue = true;
            // 
            // frmUvjerenjaIB190103
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 308);
            Controls.Add(dgvUvjerenja);
            Controls.Add(btnNovi);
            Name = "frmUvjerenjaIB190103";
            Text = "Broj uvjerenja -> 0";
            Load += frmUvjerenjaIB190103_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjerenja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovi;
        private DataGridView dgvUvjerenja;
        private DataGridViewTextBoxColumn DatumKreiranja;
        private DataGridViewTextBoxColumn VrstaUvjerenja;
        private DataGridViewTextBoxColumn SvrhaIzdavanja;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}