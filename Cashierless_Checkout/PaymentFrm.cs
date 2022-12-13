using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cashierless_Checkout.firebase.dto;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using MessagingToolkit.QRCode.Codec;
using ZXing.QrCode.Internal;

namespace Cashierless_Checkout
{
    public partial class PaymentFrm : Form
    {
        private string jsonString;
        private double totalPrice;
        private string dateL;
        private FirestoreDb database;

        private int sec = 60;

        public PaymentFrm(string jsonString, double totalPrice,string dateL)
        {
            this.jsonString = jsonString;
            this.totalPrice = totalPrice;
            this.dateL = dateL;
            InitializeComponent();
        }

        private void PaymentFrm_Load(object sender, EventArgs e)
        {
            QRCodeEncoder deQr = new QRCodeEncoder();
            pictrboxQR.Image = deQr.Encode(jsonString);
            lblTotalP.Text = totalPrice.ToString()+ "₺";

            string path = AppDomain.CurrentDomain.BaseDirectory + @"cashierless-checkout.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("cashierless-checkout");

            countDownT.Start();
            countDownT.Interval = 1000;
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            GetData(dateL);
        }

        async void GetData(string date)
        {
            DocumentReference docRef = database.Collection("ORDER").Document(date);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
  

             if (snap.Exists)
             {
                Check check = snap.ConvertTo<Check>();
                MessageBox.Show("Ödeme başaralı bir şekilde tamalandı");
                countDownT.Stop();
                CheckoutFrm frm = new CheckoutFrm();
                this.Close();
            }
             
        }

        private void CountDownTick(object sender,EventArgs e)
        {
            
            countDownLbl.Text = sec--.ToString();

            if (sec < 0)
            {
                countDownT.Stop();
            }

            if (sec % 5 == 0)
            {
                GetData(dateL);
            }
        }
    }
}
