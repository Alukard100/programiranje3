using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB190103
{
    public class PolozeniPredmetiIB190103
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB190103 Predmet { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
        public string Napomena { get; set; }

    }
}
