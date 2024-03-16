using EFTest2.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiniflariGetir_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var liste = ctx.Siniflar.Include(x => x.Ogrenciler).ToList();
                //yukrýda include ekledim

                cbSiniflar.DataSource = liste;
                cbSiniflar.DisplayMember = "Ad";
                cbSiniflar.ValueMember = "Id";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                Sinif yeni = new Sinif();
                yeni.Ad = txtSinif.Text;

                ctx.Siniflar.Add(yeni);
                ctx.SaveChanges();
            }
        }

        private void btnOgrencileriGetir_Click(object sender, EventArgs e)
        {
            Sinif sinif = (Sinif)cbSiniflar.SelectedItem;

            dgvOgrenciler.DataSource = sinif.Ogrenciler;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                int snfId = Convert.ToInt32(cbSiniflar.SelectedValue);

                Sinif sinif = ctx.Siniflar.FirstOrDefault(x => x.Id == snfId);

                Ogrenci yeniOgrenci = new Ogrenci
                {
                    Nu = Convert.ToInt32(txtNu.Text),
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text
                };

                sinif.Ogrenciler.Add(yeniOgrenci);

                ctx.SaveChanges();
            }

        }

        private void btnKlupleriGetir_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var liste = ctx.Klupler.Include(x => x.Ogrenciler).ToList();

                cbKlupler.DataSource = liste;
                cbKlupler.DisplayMember = "Ad";
                cbKlupler.ValueMember = "Id";

            }
        }

        private void btnKlupEkle_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                Klup yeni = new Klup();
                yeni.Ad = txtKlupAdi.Text;

                ctx.Klupler.Add(yeni);
                ctx.SaveChanges();
            }
        }

        private void btnKlubeEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = dgvOgrenciler.CurrentRow.DataBoundItem as Ogrenci;

            if (ogr != null)
            {
                int klpId = Convert.ToInt32(cbKlupler.SelectedValue);

                using (OkulDbContext ctx = new OkulDbContext())
                {
                    Klup klup = ctx.Klupler.FirstOrDefault(x => x.Id == klpId);

                    klup.Ogrenciler.Add(ogr);

                    ctx.SaveChanges();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klup klup = (Klup)cbKlupler.SelectedItem;

            dgvOgrenciler.DataSource = klup.Ogrenciler;
        }
    }
}
