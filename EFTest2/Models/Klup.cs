using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest2.Models
{
    public class Klup
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}
