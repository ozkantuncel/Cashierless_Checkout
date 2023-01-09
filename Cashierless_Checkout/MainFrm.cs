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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void customPictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CheckoutFrm chkFrm = new CheckoutFrm();
            chkFrm.Show();
            this.Hide();
           
        }

        private void lnkYntGr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
