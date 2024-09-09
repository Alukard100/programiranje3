using FIT.Data.IB190103;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmDrzaveIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();

        public frmDrzaveIB190103()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvDrzave.AutoGenerateColumns = false;
            LoadGrid();
        }
        private void LoadGrid()
        {
            var drzave = _db.DrzaveIb190103.ToList();
            foreach (DrzaveIB190103 drzava in drzave)
            {
                drzava.BrojGradova = _db.GradoviIB190103.Where(g => drzava.Id == g.DrzavaId).ToList().Count();
            }
            dgvDrzave.DataSource = drzave;
        }

        private void btnAddDrzava_Click(object sender, EventArgs e)
        {
            new frmNovaDrzavaIB190103(null).ShowDialog();
            LoadData();
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                DrzaveIB190103 odabranaDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as DrzaveIB190103;
                new frmGradoviIB190103(odabranaDrzava).ShowDialog();
                LoadData();
            }
        }

        private void dgvDrzave_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DrzaveIB190103 odabranaDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as DrzaveIB190103;
            new frmNovaDrzavaIB190103(odabranaDrzava).ShowDialog();
            LoadData();

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {

            DrzaveIB190103 selectedDrzava = dgvDrzave.SelectedRows[0].DataBoundItem as DrzaveIB190103;
            List<GradoviIB190103> gradovi = _db.GradoviIB190103.Where(g => g.DrzavaId == selectedDrzava.Id).ToList();
            if (gradovi != null && gradovi.Count() > 0)
            {
                frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(gradovi);
                frmIzvjestaji.ShowDialog();
            }
        }
    }
}
