using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EFTest2.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string Ad { get; set; }
        [MaxLength(20)]
        public string Soyad { get; set; }
        public int Nu { get; set; }

        public int? SinifId { get; set; }

        public Sinif Sinifi { get; set; }

        public List<Klup> Klupler { get; set; } = new List<Klup>();
    }
}
