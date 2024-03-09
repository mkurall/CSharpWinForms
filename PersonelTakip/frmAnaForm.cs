using PersonelTakip.Modeller;

namespace PersonelTakip
{
    public partial class frmAnaForm : Form
    {
        int siradakiId = 1;
        Personel duzenlenenPersonel=null;

        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel(siradakiId);
            p.Ad = txtAd.Text;
            p.Soyad = txtSoyad.Text;
            p.Tel = txtTel.Text;
            p.Adres = txtAdres.Text;
            p.BirimId = cbBirim.SelectedIndex;
            p.IseGiris = dtIseGirisTarihi.Value;
            p.CocukSayisi = (int)numCocukSayisi.Value;
            p.AskerlikDurumu = chkAskerlik.Checked;
            p.YabanciDilDurumu = chkYabanciDil.Checked;
            p.ISGEgitimiDurumu = rdISGEvet.Checked;
            p.UstalikBelgesiDurumu = rdUstaEvet.Checked;

            //oluþturduðum personeli liste kutusuna ekle
            lbPersoneller.Items.Add(p);

            lblPersonelSayisi.Text = $"{lbPersoneller.Items.Count} Kiþi";
            siradakiId++;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //eger null personel gonderirsek form temizlenir
            PersonelGoster(null);

        }

        void PersonelGoster(Personel p)
        {   
            //ileriki gunceleme vb durumlar icin bunu sakla
            duzenlenenPersonel = p;

            if (p != null)
            {

                lblKayitBilgi.Text = "Düzenlenen Kayýt";
                txtAd.Text = p.Ad;
                txtSoyad.Text = p.Soyad;
                txtTel.Text = p.Tel;
                txtAdres.Text = p.Adres;

                cbBirim.SelectedIndex = p.BirimId;
                dtIseGirisTarihi.Value = p.IseGiris;
                numCocukSayisi.Value = p.CocukSayisi;
                chkAskerlik.Checked = p.AskerlikDurumu;
                chkYabanciDil.Checked = p.YabanciDilDurumu;

                rdISGEvet.Checked = p.ISGEgitimiDurumu;
                rdISGHayir.Checked = !p.ISGEgitimiDurumu;

                rdUstaEvet.Checked = p.UstalikBelgesiDurumu;
                rdUstaHayir.Checked = !p.UstalikBelgesiDurumu;
            }
            else
            {
                lblKayitBilgi.Text = "Yeni Kayýt";
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTel.Text = "";
                txtAdres.Text = "";

                cbBirim.SelectedIndex = -1;
                dtIseGirisTarihi.Value = DateTime.Now;
                numCocukSayisi.Value = 0;
                chkAskerlik.Checked = false;
                chkYabanciDil.Checked = false;

                rdISGEvet.Checked = false;
                rdISGHayir.Checked = false;
                rdUstaEvet.Checked = false;
                rdUstaHayir.Checked = false;
            }

        }


        private void lbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPersoneller.SelectedIndex;

            //liste kutusundan personeli al
            Personel p = (Personel)lbPersoneller.Items[index];

            PersonelGoster(p);

        }
    }
}
