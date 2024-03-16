using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest2.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int? Seviye { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
    }
}
