using BtkKursUyg.Modeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkKursUyg
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            TblKullanicilar kullanici = 
                DbServisi.OturumAc(txtEPosta.Text, txtParola.Text);

            if(kullanici != null )
            {
                //Login Dialog penceresini olumlu bir şekilde kapatır
                DialogResult =  DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunmadı");
            }

        }
    }
}
