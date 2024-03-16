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
                var liste = ctx.Siniflar.Include(x=>x.Ogrenciler).ToList();
                //yuakrýda include ekledim

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
    }
}
