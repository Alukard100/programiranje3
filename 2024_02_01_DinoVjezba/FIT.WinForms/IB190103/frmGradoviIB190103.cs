using FIT.Data;
using FIT.Data.IB190103;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB190103
{
    public partial class frmGradoviIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        public DrzaveIB190103 drzaveGradovi = new DrzaveIB190103();
        public frmGradoviIB190103(DrzaveIB190103 odabranaDrzava)
        {
            InitializeComponent();
            pbZastava.Image = Ekstenzije.ToImage(odabranaDrzava.Zastava);
            drzaveGradovi = odabranaDrzava;
            dgvGradoviDrzave.AutoGenerateColumns = false;

        }

        private void frmGradoviIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvGradoviDrzave.DataSource = null;
            var gradoviDrzave = _db.GradoviIB190103.Where(x => x.DrzavaId == drzaveGradovi.Id).ToList();
            dgvGradoviDrzave.DataSource = gradoviDrzave;

        }

        private void btnAddGrad_Click(object sender, EventArgs e)
        {
            if (validacija() == true)
            {
                var noviGrad = new GradoviIB190103
                {
                    Naziv = txtbNazivGrada.Text,
                    DrzavaId = drzaveGradovi.Id,
                    Status = true
                };
                foreach (var grad in _db.GradoviIB190103)
                {
                    if (noviGrad.Naziv == grad.Naziv)
                    {
                        MessageBox.Show("Grad vec postoji");
                        return;
                    }
                }
                _db.Add(noviGrad);
                _db.SaveChanges();
                LoadData();

            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(txtbNazivGrada, errorProvider1, Kljucevi.ReqiredValue);
        }

        private void dgvGradoviDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                GradoviIB190103 grad = dgvGradoviDrzave.SelectedRows[0].DataBoundItem as GradoviIB190103;
                grad.Status = !grad.Status;
                _db.GradoviIB190103.Update(grad);
                _db.SaveChanges();
                LoadData();
            }
        }
    }
}
