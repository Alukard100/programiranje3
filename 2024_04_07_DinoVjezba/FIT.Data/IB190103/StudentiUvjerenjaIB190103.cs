using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB190103
{
    public class StudentiUvjerenjaIB190103
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime DatumKReiranja { get; set; }
        public string VrstaUvjerenja { get; set; }
        public string SvrhaIzdavanja { get; set; }
        public byte[] Uplatnica { get; set; }
        public bool Printano { get; set; }
        public bool Deleted { get; set; }
    }
}
