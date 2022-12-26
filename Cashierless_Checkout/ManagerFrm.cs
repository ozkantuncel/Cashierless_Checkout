using Cashierless_Checkout.entity;
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
    public partial class ManagerFrm : Form
    {
        private string managerN;
        public ManagerFrm(string managerN)
        {
            InitializeComponent();
            this.managerN = managerN;
        }

        private void ManagerFrm_Load(object sender, EventArgs e)
        {
            lblHsg.Text = $"Hoşgeldiniz {char.ToUpper(managerN[0])}{managerN.Substring(1)}";
        }

        private void lnkCks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            this.Close();
            loginFrm.Show();
        }

        private void cstbtnUrn_Click(object sender, EventArgs e)
        {
            ProductManagerFrm productmanager = new ProductManagerFrm(managerN);
            this.Close();
            productmanager.Show();
        }

        private void cstbtnAddMan_Click(object sender, EventArgs e)
        {
            AddManagerFrm addManagerFrm = new AddManagerFrm(managerN);
            this.Close();
            addManagerFrm.Show();
        }
    }
}
