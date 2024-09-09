using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmStudentInfoIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        Student _student = new Student();
        public frmStudentInfoIB190103()
        {
            InitializeComponent();
        }

        public frmStudentInfoIB190103(Student odabranStudent) : this() {
            _student = odabranStudent;
        }

        private void frmStudentInfoIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lblNazivStudenta.Text = _student.ImePrezime;
            lblProsjek.Text = "Prosjek: " + _student.Prosjek.ToString();
            pbStudentSlika.Image = _student.Slika.ToImage(); 
        }
    }
}
