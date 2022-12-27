using AForge.Video.DirectShow;
using Cashierless_Checkout.entity.product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Cashierless_Checkout
{
     
    public partial class CheckoutFrm : Form
    {


        public CheckoutFrm()
        {
            InitializeComponent();
        }
        
        private FilterInfoCollection Cameras;
        private VideoCaptureDevice camera;
        private byte seleCmbCameras =0;

        private bool isSca = true;
        private double totalPrice=0;
        private double totalTax = 0;
        private double totalPriceWTax = 0;
        private List<short> barcodeId = new List<short>(); 
        private List<String> productNames = new List<String>();
        private List<String> producterNames = new List<String>();
        private List<int> productPrice = new List<int>();
        private List<int> productTax = new List<int>();

        private CashierlessCheckoutProductDBEntities db = new CashierlessCheckoutProductDBEntities();

        private void CheckoutFrm_Load(object sender, EventArgs e)
        { 
            ScannerListMaker();
            Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);


            foreach (FilterInfo i in Cameras)
            {
                CmbCameres.Items.Add(i.Name);
            }
            CmbCameres.SelectedIndex = seleCmbCameras;

            camera = new VideoCaptureDevice(Cameras[CmbCameres.SelectedIndex].MonikerString);//0 Phone 2 PC

            camera.NewFrame += VideoCaptureDevice_NewFrame;
            camera.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {            
            Bitmap ThatBarkod = (Bitmap)eventArgs.Frame.Clone();

            if (isSca)
            {
                BarcodeReader scanner = new BarcodeReader();

                var result = scanner.Decode(ThatBarkod);

                if (result != null)
                {                    
                    string scn = result.ToString();
                    AddListBarcodeScanner(scn);
                    isSca = false;
                    isAvabileScanner();
                }
            }    
            scannerBarcode.Image = ThatBarkod;
        }

        private void ScannerListMaker()
        {
            listScanner.Columns.Add("Barkod",125);
            listScanner.Columns.Add("Ürün adı", 250);
            listScanner.Columns.Add("Üretici", 150);
            listScanner.Columns.Add("Kategori", 75);
            listScanner.Columns.Add("Fiyat", 70);
            listScanner.Columns.Add("Vergi", 70);
        }

        private void AddListBarcodeScanner(string scn)
        {
            string br, urnN, urterN, katN, fiyat, vergi;

            foreach (var a in db.TBL_Barcode.Where(a => a.barcode.Contains(scn)))
            {

                br = a.barcode;
                urnN = a.TBL_Product.productName;
                urterN = a.TBL_Product.TBL_Producter.producterName;
                katN = a.TBL_Product.TBL_Category.CategoryName;
                fiyat = a.TBL_Product.price.ToString();
                vergi = a.TBL_Product.tax.ToString();

                barcodeId.Add(a.id);

                productNames.Add(urnN);
                producterNames.Add(urterN);
                productPrice.Add(Convert.ToInt32(fiyat));
                productTax.Add(Convert.ToInt32(vergi));
                string[] lst = { br, urnN, urterN, katN, fiyat, vergi };
                ScannerListAdItem(lst);
                totalPrice += double.Parse(fiyat);
                totalTax += double.Parse(vergi);
                totalPriceWTax = totalPrice - totalTax;
                totalLabels(totalPrice, totalTax, totalPriceWTax);
            }
        }

        private void ScannerListAdItem(string[] a)
        {            
            ListViewItem lst = new ListViewItem(a);

            listScanner.Invoke(new MethodInvoker(delegate ()
            {
                listScanner.Items.Add(lst);                 
            }));   
        }
       
        private void totalLabels(double priceT, double taxT, double priceWtax)
        {
            totalPriceWTaxLabel.Invoke(new MethodInvoker(delegate ()
            {
                totalPriceWTaxLabel.Text = priceT.ToString();
            }));

            totalTaxLabel.Invoke(new MethodInvoker(delegate ()
            {
                totalTaxLabel.Text = taxT.ToString();
            }));

            totalPLabel.Invoke(new MethodInvoker(delegate ()
            {
                totalPLabel.Text = priceWtax.ToString();
            }));
        }

        private void isAvabileScanner()
        {
            isAvLabel.ForeColor = isSca ? Color.Green : Color.Red;
        }

        private void CheckoutFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (camera != null)
            {
                if (camera.IsRunning)
                {
                    camera.Stop();
                }
            }
        }

        private void odmButton_Click(object sender, EventArgs e)
        {
            if(totalPrice != 0)
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm").Replace(" ", "");
                var paymenttoJson = new PaymentJson()
                {
                    Date = date,
                    ProductId = barcodeId.ToArray(),
                    ProductNames = productNames.ToArray(),
                    ProducerNames = producterNames.ToArray(),
                    ProductTotalPrice = productPrice.ToArray(),
                    ProductTax = productTax.ToArray(),
                    TotalPrice = Convert.ToInt32(totalPriceWTaxLabel.Text)
                };
                PaymentFrm paymentFrm = new PaymentFrm(paymenttoJson);
                paymentFrm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen barkodu okutun");
            }
            
        }

        private void urnEkleBtn_Click(object sender, EventArgs e)
        {
            isSca = true;
            isAvabileScanner();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            if(textBoxBarcode.Text != "")
            {
                string scr = textBoxBarcode.Text;
                AddListBarcodeScanner(scr);
                textBoxBarcode.Text = "";
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            listScanner.Items.Clear();
            totalPriceWTax = 0;totalPrice = 0;totalTax = 0;
            totalLabels(totalPrice, totalTax, totalPriceWTax);

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem selectedInfo in listScanner.CheckedItems)
            {
                int pr, tax, prWTaxx;
                pr = Int32.Parse(selectedInfo.SubItems[4].Text);
                tax = Int32.Parse(selectedInfo.SubItems[5].Text);
                prWTaxx = pr - tax;
                totalPrice -= pr;
                totalTax -= tax;
                totalPriceWTax-= prWTaxx;
                totalLabels(totalPrice, totalTax, totalPriceWTax);
                selectedInfo.Remove();
            }
        }

        private void listScanner_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NO OP
        }

         

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainFrm main = new MainFrm();           
            main.Show();
            Close();
        }

        

        private void BtnCameras_Click(object sender, EventArgs e)
        {
            if (camera != null)
            {
                if (camera.IsRunning)
                {
                    camera.Stop();
                }
            }
            camera = new VideoCaptureDevice(Cameras[CmbCameres.SelectedIndex].MonikerString);//0 Phone 2 PC

            camera.NewFrame += VideoCaptureDevice_NewFrame;
            camera.Start();
        }
    }
}
