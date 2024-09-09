using FIT.Data.IB190103;
using FIT.WinForms.IB190103;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        List<GradoviIB190103> _gradovi;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }
        public frmIzvjestaji(List<GradoviIB190103> gradovi) :this()
        {
            _gradovi = gradovi; 
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tblGradovi = new dsDLWMS.GradoviDataTable();
            for (int i = 0; i < _gradovi.Count(); i++)
            {
                var red = tblGradovi.NewGradoviRow();
                red.Rb = (i+1).ToString();
                red.Grad = _gradovi[i].Naziv;
                red.Drzava = _gradovi[i].Drzava.Naziv;
                if (_gradovi[i].Status == true)
                {
                    red.Aktivan = "Da";
                }
                else red.Aktivan = "Ne";
                tblGradovi.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblGradovi;

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }
    }
}
