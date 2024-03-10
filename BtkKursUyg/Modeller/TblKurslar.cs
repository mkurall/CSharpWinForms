using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkKursUyg.Modeller
{
    public class TblKurslar
    {
        public int Id { get; set; }
        public string KursAdi { get; set; }
        public DateTime KursTarihi { get; set; }
        public string EgitmenBilgisi { get; set; }
    }
}
