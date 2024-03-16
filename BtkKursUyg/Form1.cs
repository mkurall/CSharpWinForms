using BtkKursUyg.Modeller;

namespace BtkKursUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void btnKurslariListele_Click(object sender, EventArgs e)
        {
            List<TblKurslar> kursListesi = DbServisi.KursListesiniGetir();

            lbKurslar.DataSource = kursListesi;
            lbKurslar.DisplayMember = "KursAdi";//Ekranda ne gorunecek
            lbKurslar.ValueMember = "Id";//iliþkiyi saðlayan anahtar ne

        }

        private void btnKursEkle_Click(object sender, EventArgs e)
        {
            TblKurslar kurs = DbServisi.KursEkle(new TblKurslar()
            {
                KursAdi = txtKursAd.Text,
                KursTarihi = dtKursTarih.Value,
                EgitmenBilgisi = txtKursEgitmen.Text
            });

        }
    }
}
