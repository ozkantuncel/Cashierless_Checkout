using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        FilterInfoCollection Cameras;
        VideoCaptureDevice camera;
        bool isSca = true;
        double totalPrice=0;
        double totalTax = 0;

        CashierlessCheckoutProductEntities db = new CashierlessCheckoutProductEntities();

        private void CheckoutFrm_Load(object sender, EventArgs e)
        {
            ScannerListMaker();
            Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            camera = new VideoCaptureDevice(Cameras[2].MonikerString);

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

                    string br, urnN, urterN, katN, fiyat, vergi;

                    foreach (var a in db.TBL_Barcode.Where(a => a.barcode.Contains(scn)))
                    {
                        br = a.barcode;
                        urnN = a.TBL_Product.productName;
                        urterN = a.TBL_Product.TBL_Producter.producterName;
                        katN = a.TBL_Product.TBL_Category.CategoryName;
                        fiyat = a.TBL_Product.price.ToString();
                        vergi = a.TBL_Product.tax.ToString();
                        string[] lst = { br, urnN, urterN, katN, fiyat, vergi };
                        ScannerListAdItem(lst);
                        totalPrice += double.Parse(fiyat);
                        totalTax += double.Parse(vergi);
                        totalLabels(totalPrice, totalTax);
                    }
                    isSca = false;
                    isAvabileScanner();

                }
            }    
            scannerBarcode.Image = ThatBarkod;
        }

        private void ScannerListMaker()
        {
            listScanner.Columns.Add("Barkod",125);
            listScanner.Columns.Add("Ürün adı", 125);
            listScanner.Columns.Add("Üretici", 125);
            listScanner.Columns.Add("Kategori", 75);
            listScanner.Columns.Add("Fiyat", 60);
            listScanner.Columns.Add("Vergi", 60);
        }

        private void ScannerListAdItem(string[] a)
        {
            
            ListViewItem lst = new ListViewItem(a);

            listScanner.Invoke(new MethodInvoker(delegate ()
            {

                listScanner.Items.Add(lst);
                 
            }));   
        }

        private void totalLabels(double priceT, double taxT)
        {
            totalPriceLabel.Invoke(new MethodInvoker(delegate ()
            {
                totalPriceLabel.Text = priceT.ToString();
            }));

            totalTaxLabel.Invoke(new MethodInvoker(delegate ()
            {
                totalTaxLabel.Text = taxT.ToString();
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
            MessageBox.Show(isSca.ToString());
        }

        private void urnEkleBtn_Click(object sender, EventArgs e)
        {
            isSca = true;
            isAvabileScanner();
        }
    }
}
