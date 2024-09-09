using FIT.Data;
using FIT.Data.IB190103;
using FIT.Infrastructure;
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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext _db = new DLWMSDbContext();
        private List<DrzaveIB190103> drzave;
        private List<GradoviIB190103> gradovi;
        private List<Student> studenti;
        private List<PolozeniPredmetiIB190103> predmeti;
        public frmPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            drzave = _db.DrzaveIb190103.ToList();
            cbDrzave.DataSource = drzave;
            LoadGradovi();
            LoadGrid();
        }

        private void LoadGrid()
        {
            var trenutnaDrzava = cbDrzave.SelectedItem as DrzaveIB190103;
            predmeti = _db.PolozeniPredmeti.ToList();
            var trenutniGrad = cbGradovi.SelectedItem as GradoviIB190103;
            studenti = _db.Studenti.ToList();
            List<Pretraga> listaStudenata = new List<Pretraga>();
            if (studenti.Where(s => s.GradId == trenutniGrad.Id).Count() == 0)
            {
                MessageBox.Show("Nema zadovoljavajucih studenata");
            }
                foreach (var student in studenti)
                {
                    if (student.GradId == trenutniGrad.Id)
                    {
                        var prosjek = 0;
                        int brojac = 0;
                        foreach (var predmet in predmeti)
                        {
                            if (predmet.StudentId == student.Id)
                            {
                                prosjek = prosjek + predmet.Ocjena;
                                brojac++;
                            }
                        }
                        if (brojac == 0)
                        {
                            prosjek = 5;
                        }
                        else
                        {
                            prosjek = prosjek / brojac;
                        }
                        listaStudenata.Add(new Pretraga { Drzava = trenutnaDrzava.Naziv, Grad = trenutniGrad.Naziv, Ime = student.Ime, Prezime = student.Prezime, Prosjek = prosjek });
                    }
            }
            dgvStudenti.DataSource = listaStudenata;

        }

        private void cbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGradovi();
            if (cbGradovi.Items.Count > 0)
            {
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Nema zadovoljavajucih studenata");
                List<Pretraga> tempLista = new List<Pretraga>();
                dgvStudenti.DataSource = tempLista;
            }

        }
        private void LoadGradovi()
        {
            var trenutnaDrzava = cbDrzave.SelectedItem as DrzaveIB190103;
            gradovi = _db.GradoviIB190103.Where(g => g.DrzavaId == trenutnaDrzava.Id).ToList();
            cbGradovi.DataSource = gradovi;
        }

        private void cbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
