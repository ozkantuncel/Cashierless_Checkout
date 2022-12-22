using Cashierless_Checkout.entity.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashierless_Checkout
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private string nick;
        private string pass;
        private bool checkM=false;
        private CashierlessCheckoutAdminEntities db = new CashierlessCheckoutAdminEntities();

        private void cstbtnLogin_Click(object sender, EventArgs e)
        {
            nick = txtNick.Text;
            pass = txtPass.Text;
            

            if(nick != "" || pass != "")
            {
                foreach(var i in db.TBL_Admin)
                {
                    if(i.admin_nick == nick && i.admin_password == pass)
                    {
                        checkM = true;
                        ManagerFrm managerFrm = new ManagerFrm(nick);
                        this.Close();
                        managerFrm.Show();
                    }
                }

                if (!checkM)
                {
                    MessageBox.Show("Bilgileriniz yanlış");
                }
                 
            }
        }

        

        private void customPictureBox1_Click(object sender, EventArgs e)
        {
            MainFrm mainFrm = new MainFrm();
            this.Close();
            mainFrm.Show();
        }
    }
}
