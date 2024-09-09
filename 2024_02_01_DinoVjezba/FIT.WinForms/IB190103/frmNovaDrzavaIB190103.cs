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
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB190103
{
    public partial class frmNovaDrzavaIB190103 : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        private DrzaveIB190103? editovanaDrzava;

        public frmNovaDrzavaIB190103(DrzaveIB190103 odabranaDrzava)
        {
            InitializeComponent();

            if (odabranaDrzava != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(odabranaDrzava.Zastava);
                txtbNaziv.Text = odabranaDrzava.Naziv;
                cbAktivna.Checked = odabranaDrzava.Status;
                editovanaDrzava = odabranaDrzava;
            }


        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {   
                if (editovanaDrzava == null)
                {
                    var novaDrzava = new DrzaveIB190103
                    {
                        Naziv = txtbNaziv.Text,
                        Status = cbAktivna.Checked,
                        Zastava = Ekstenzije.ToByteArray(pbZastava.Image)
                    };
                    _db.DrzaveIb190103.Add(novaDrzava);
                    _db.SaveChanges();
                    Close();
                } else
                {
                    editovanaDrzava.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                    editovanaDrzava.Status = cbAktivna.Checked;
                    editovanaDrzava.Naziv = txtbNaziv.Text;
                    _db.DrzaveIb190103.Update(editovanaDrzava);
                    _db.SaveChanges();
                    Close();
                }
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtbNaziv, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
