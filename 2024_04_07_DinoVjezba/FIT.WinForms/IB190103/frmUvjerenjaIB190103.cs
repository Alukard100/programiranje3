using FIT.Data;
using FIT.Data.IB190103;
using FIT.Infrastructure;
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
    public partial class frmUvjerenjaIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        Student _student = new Student();
        List<StudentiUvjerenjaIB190103> _uvjerenja = new List<StudentiUvjerenjaIB190103>();
        public frmUvjerenjaIB190103()
        {
            InitializeComponent();
            dgvUvjerenja.AutoGenerateColumns = false;
        }

        public frmUvjerenjaIB190103(Student odabranStudent) : this()
        {
            _student = odabranStudent;
        }

        private void frmUvjerenjaIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            _uvjerenja = _db.StudentiUvjerenjaIB190103.Where(x => x.StudentId == _student.Id && x.Deleted != true).ToList();
            dgvUvjerenja.DataSource = _uvjerenja;
            this.Text = "Broj uvjerenja -> " + _uvjerenja.Count.ToString();
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Are you sure about this?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentiUvjerenjaIB190103 kliknut = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB190103;
                    kliknut.Deleted = true;
                    _db.Update(kliknut);
                    _db.SaveChanges();
                    LoadGrid();
                }

            }
            if (e.ColumnIndex == 6)
            {
                StudentiUvjerenjaIB190103 kliknut = dgvUvjerenja.SelectedRows[0].DataBoundItem as StudentiUvjerenjaIB190103;
                kliknut.Printano = !kliknut.Printano;
                _db.Update(kliknut);
                _db.SaveChanges();
                LoadGrid();
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            new frmNovoUvjerenjeIB190103(_student).ShowDialog();
            LoadGrid();
        }
    }
}
