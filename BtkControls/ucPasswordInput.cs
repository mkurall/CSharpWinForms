using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkControls
{
    public partial class ucPasswordInput : UserControl
    {
        bool passwordIsShowing;

        public bool PasswordIsShowing
        {
            get
            {
                return passwordIsShowing;
            }
            set
            {
                passwordIsShowing = value;

                if (passwordIsShowing)
                    txtInput.PasswordChar = '●';
                else
                    txtInput.PasswordChar = '\0';
            }
        }

        public ucPasswordInput()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(PasswordIsShowing)
            {
                PasswordIsShowing = false;
            }
            else
            {
                PasswordIsShowing = true;
            }
            
            //PasswordIsShowing = !PasswordIsShowing;
        }
    }
}
