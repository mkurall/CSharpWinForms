using PersonelTakip.Modeller;

namespace PersonelTakip
{
    public partial class frmAnaForm : Form
    {
        int siradakiId = 1;
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

            //olu�turdu�um personeli liste kutusuna ekle
            lbPersoneller.Items.Add(p);

            lblPersonelSayisi.Text = $"{lbPersoneller.Items.Count} Ki�i";
            siradakiId++;

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void lbPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbPersoneller.SelectedIndex;

            //liste kutusundan personeli al
            Personel p = (Personel)lbPersoneller.Items[index];

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
    }
}
