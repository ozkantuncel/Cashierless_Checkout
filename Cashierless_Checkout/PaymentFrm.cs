using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cashierless_Checkout.entity.old_sales;
using Cashierless_Checkout.firebase.dto;
using DevExpress.Utils.About;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using MessagingToolkit.QRCode.Codec;
using ZXing.QrCode.Internal;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Cashierless_Checkout
{
    public partial class PaymentFrm : Form
    {
        private FirestoreDb database;
        private CashierlessCheckoutOldSalesEntities db = new CashierlessCheckoutOldSalesEntities();
        private CashierlessCheckoutProductEntities db2 = new CashierlessCheckoutProductEntities();
        private int sec = 59;
        private PaymentJson paymenttoJson;

        public PaymentFrm(PaymentJson json)
        {
            this.paymenttoJson = json;
            InitializeComponent();
        }

        private void PaymentFrm_Load(object sender, EventArgs e)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonToString = JsonSerializer.Serialize(paymenttoJson, options);

            QRCodeEncoder deQr = new QRCodeEncoder();
            pictrboxQR.Image = deQr.Encode(jsonToString);
            lblTotalP.Text = paymenttoJson.TotalPrice.ToString()+ "₺";

            string path = AppDomain.CurrentDomain.BaseDirectory + @"cashierless-checkout.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            database = FirestoreDb.Create("cashierless-checkout");

            countDownT.Start();
            countDownT.Interval = 1000;
        }

        private void cBtnCancel_Click(object sender, EventArgs e)
        {
            GetData(paymenttoJson.Date.ToString());
        }

        async void GetData(string date)
        {
            DocumentReference docRef = database.Collection("ORDER").Document(date);
            DocumentSnapshot snap = await docRef.GetSnapshotAsync();
  

             if (snap.Exists)
             {
                countDownT.Stop();
                Check check = snap.ConvertTo<Check>();
                
                for(int i = 0; i < paymenttoJson.ProductNames.Length; i++)
                {
                    TBL_Sales_History old = new TBL_Sales_History();
                    old.productID = paymenttoJson.ProductId[i];
                    old.dateSales = paymenttoJson.Date;
                    db.TBL_Sales_History.Add(old);
                    db.SaveChanges();
                }                           
                MessageBox.Show("Ödeme başaralı bir şekilde tamalandı");               
                MainFrm frm = new MainFrm();
                this.Close();
                frm.Show();
            }
             
        }

        private void CountDownTick(object sender,EventArgs e)
        {
            int s = --sec;
            countDownLbl.Text = s.ToString();

            if (sec < 0)
            {
                countDownT.Stop();
            }

            if (sec % 5 == 0)
            {
                GetData(paymenttoJson.Date.ToString());
            }
        }
    }
}
