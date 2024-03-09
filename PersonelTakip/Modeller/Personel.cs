using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.Modeller
{
    public class Personel : object
    {
        private int cocukSayisi;
        public int Id { get; private set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public int BirimId { get; set; }
        public DateTime IseGiris { get; set; }
        public int CocukSayisi
        {
            get { return cocukSayisi; }
            set
            {
                if (value < 0)
                    throw new Exception("Çocuk sayısı geçerli değil!");
            }
        }
        public bool AskerlikDurumu { get; set; }
        public bool YabanciDilDurumu { get; set; }
        public bool ISGEgitimiDurumu { get; set; }
        public bool UstalikBelgesiDurumu { get; set; }

        public Personel(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id} - {Ad} {Soyad}";
            //return Id + " - " + Ad + " " + Soyad;
        }
    }
}
