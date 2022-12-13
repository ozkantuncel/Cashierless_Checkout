using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using ZXing.QrCode.Internal;

namespace Cashierless_Checkout
{
    public partial class PaymentFrm : Form
    {
        private string jsonString;
        private double totalPrice;
        public PaymentFrm(string jsonString, double totalPrice)
        {
            this.jsonString = jsonString;
            this.totalPrice = totalPrice;   
            InitializeComponent();
        }

        private void PaymentFrm_Load(object sender, EventArgs e)
        {
            QRCodeEncoder deQr = new QRCodeEncoder();
            pictrboxQR.Image = deQr.Encode(jsonString);
            lblTotalP.Text = totalPrice.ToString()+ "₺";
            MessageBox.Show(jsonString);
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
