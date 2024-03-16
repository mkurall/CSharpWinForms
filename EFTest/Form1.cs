using EFTest.Modeller;

namespace EFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKurslariGetir_Click(object sender, EventArgs e)
        {
            using (BtkKursDbContext ctx = new BtkKursDbContext())
            {
                var liste = ctx.TblKurslars.ToList();

                cbKurslar.DataSource = liste;
                cbKurslar.DisplayMember = "KursAdi";
                cbKurslar.ValueMember = "Id";
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (BtkKursDbContext ctx = new BtkKursDbContext())
            {
                TblKurslar kurs = new TblKurslar();
                kurs.KursAdi = txtKursAd.Text;
                kurs.KursTarihi = DateTime.Parse("01.04.2024");
                kurs.EgitmenBilgisi = "Mustafa KURAL";

                ctx.TblKurslars.Add(kurs);
                ctx.SaveChanges();
            }
        }

        private void btnKursGuncelle_Click(object sender, EventArgs e)
        {
            using (BtkKursDbContext ctx = new BtkKursDbContext())
            {
                int id = Convert.ToInt32(cbKurslar.SelectedValue);

                //Veritabanýndan id si bu olan tek kayýt getirir
                TblKurslar kurs = ctx.TblKurslars.FirstOrDefault(x => x.Id == id);

                kurs.KursAdi = txtKursAd.Text;

                ctx.SaveChanges();
            }

        }

        private void btnKursSil_Click(object sender, EventArgs e)
        {
            using(BtkKursDbContext ctx = new BtkKursDbContext())
            {
                int id = Convert.ToInt32(cbKurslar.SelectedValue);

                var kurs = ctx.TblKurslars.FirstOrDefault(x => x.Id == id);

                ctx.TblKurslars.Remove(kurs);
                ctx.SaveChanges();
            }
        }
    }
}
