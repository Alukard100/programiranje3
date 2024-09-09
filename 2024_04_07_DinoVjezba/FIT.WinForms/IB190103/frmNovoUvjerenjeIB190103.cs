using FIT.Data;
using FIT.Data.IB190103;
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
    public partial class frmNovoUvjerenjeIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        Student _student = new Student();
        public frmNovoUvjerenjeIB190103()
        {
            InitializeComponent();
        }
        public frmNovoUvjerenjeIB190103(Student zaKoga) : this()
        {
            _student = zaKoga;
        }


        private void frmNovoUvjerenjeIB190103_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var noviStudent = new StudentiUvjerenjaIB190103
                {
                    StudentId = _student.Id,
                    DatumKReiranja = DateTime.Now,
                    VrstaUvjerenja = cbVrste.Text,
                    SvrhaIzdavanja = rtbSvrha.Text,
                    Uplatnica = Helpers.Ekstenzije.ToByteArray(pbSlika.Image),
                    Printano = false,
                    Deleted = false
                };
                _db.StudentiUvjerenjaIB190103.Add(noviStudent);
                _db.SaveChanges();
                Close();
            }
        }
        
        private bool validacija()
        {
            return (Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(rtbSvrha, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cbVrste, errorProvider1, Kljucevi.ReqiredValue));
        }
    }
}
