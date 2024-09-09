using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB190103
{
    public class PredmetiIB190103
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int SemestarId { get; set; }
        public SemestriIB190103 Semestar { get; set; }
    }
}
