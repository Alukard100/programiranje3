using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB190103
{
    [Table("DrzaveIB190103")]
    public class DrzaveIB190103
    {
        public int Id { get; set; }
        [Column("Naziv")]
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public  byte[] Zastava { get; set; }
        [NotMapped]
        public int BrojGradova { get; set; }
        public void ReturnBrojGradova()
        {
            
            int PrebrojaniGradovi = 0;
            BrojGradova = PrebrojaniGradovi;
        }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
