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
    public partial class frmPretragaIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        public List<Student> studenti = new List<Student>();
        public List<PolozeniPredmetiIB190103> predmeti = new List<PolozeniPredmetiIB190103>();

        public frmPretragaIB190103()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var from = dtpFrom.Value;
            var to = dtpTo.Value;
            var spol = cbSpol.SelectedItem;

            if (spol == null)
            {

            }
            else if (spol != "Svi")
            {
                studenti = _db.Studenti.Where(s => s.DatumRodjenja > from && s.DatumRodjenja < to && s.Spol == spol.ToString()).ToList();
                predmeti = _db.PolozeniPredmeti.ToList();

                foreach (var student in studenti)
                {
                    var prosjek = 0;
                    var brojac = 0;
                    foreach (var predmet in predmeti)
                    {
                        if (predmet.StudentId == student.Id)
                        {
                            prosjek = prosjek + predmet.Ocjena;
                            brojac++;
                        }
                    }
                    if (brojac > 0)
                    {
                        prosjek = prosjek / brojac;
                    }
                    else
                    {
                        prosjek = 5;
                    }
                    student.Prosjek = prosjek;

                }
                if (studenti.Count() == 0)
                {
                    MessageBox.Show("Nema ni jedan student po datom kriteriju");
                }
                dgvPretraga.DataSource = studenti;
            }
            else
            {
                studenti = _db.Studenti.Where(s => s.DatumRodjenja > from && s.DatumRodjenja < to).ToList();
                predmeti = _db.PolozeniPredmeti.ToList();

                foreach (var student in studenti)
                {
                    var prosjek = 0;
                    var brojac = 0;
                    foreach (var predmet in predmeti)
                    {
                        if (predmet.StudentId == student.Id)
                        {
                            prosjek = prosjek + predmet.Ocjena;
                            brojac++;
                        }
                    }
                    if (brojac > 0)
                    {
                        prosjek = prosjek / brojac;
                    }
                    else
                    {
                        prosjek = 5;
                    }
                    student.Prosjek = prosjek;

                }
                if (studenti.Count() == 0)
                {
                    MessageBox.Show("Nema ni jedan student po datom kriteriju");
                }
                dgvPretraga.DataSource = studenti;
            }

        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5)
            {
                Student odabranStudent = dgvPretraga.SelectedRows[0].DataBoundItem as Student;
                new frmStudentInfoIB190103(odabranStudent).ShowDialog();
            }
            if (e.ColumnIndex == 5)
            {
                Student odabranStudent = dgvPretraga.SelectedRows[0].DataBoundItem as Student;
                new frmUvjerenjaIB190103(odabranStudent).ShowDialog();
            }
        }
    }
}
