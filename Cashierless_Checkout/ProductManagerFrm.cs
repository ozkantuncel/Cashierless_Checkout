using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashierless_Checkout.entity
{
    public partial class ProductManagerFrm : Form
    {
        private string managerName;
        public ProductManagerFrm(string managerName)
        {
            InitializeComponent();
            this.managerName = managerName;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            pictureB.Visible = false;
            if (!pnlUser.Controls.Contains(AddProduct.Instance))
            {
                pnlUser.Controls.Add(AddProduct.Instance);
                AddProduct.Instance.Dock = DockStyle.Fill;
                AddProduct.Instance.BringToFront();
            }
            else
            {
                AddProduct.Instance.BringToFront();
            }

            if(btnUrunEkle.Focused == true)
            {
                btnUrunEkle.BackColor = Color.PaleGreen;
                btnOldSales.BackColor = panel1.BackColor;
            }
             
        }

        private void btnOldSales_Click(object sender, EventArgs e)
        {
            pictureB.Visible = false;
            if (!pnlUser.Controls.Contains(OldSales.Instance))
            {
                pnlUser.Controls.Add(OldSales.Instance);
                OldSales.Instance.Dock = DockStyle.Fill;
                OldSales.Instance.BringToFront();
            }
            else
            {
                OldSales.Instance.BringToFront();
            }

            if (btnOldSales.Focused == true)
            {
                btnOldSales.BackColor = Color.PaleGreen;
                btnUrunEkle.BackColor = panel1.BackColor;
            }
        }

        private void ProductManagerFrm_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ManagerFrm manager = new ManagerFrm("dd");
            this.Close();
            manager.Show();
        }
    }
}
