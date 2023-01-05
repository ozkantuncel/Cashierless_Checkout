using Cashierless_Checkout.entity;
using Cashierless_Checkout.entity.old_sales;
using Cashierless_Checkout.entity.product;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace Cashierless_Checkout
{
    public partial class OldSales : UserControl
    {

        private static OldSales _instance;
        public static OldSales Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OldSales();
                }
                return _instance;
            }
        }

        public OldSales()
        {
            InitializeComponent();
        }
       
        private CashierlessCheckoutProductDBEntities dbProduct = new CashierlessCheckoutProductDBEntities();
        private CashierlessCheckoutOldSalesDBEntities dbOldSales = new CashierlessCheckoutOldSalesDBEntities();

        private int OldSalesID;
        private string productName, producerName, producCategory, barcode, tax, price, dateSales;

        private void CstbtnReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog exc = new SaveFileDialog() {Filter = "Satıs listesi|*..xlsx",ValidateNames = true })
            {
                if(exc.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Barkod";
                    ws.Cells[1, 2] = "Ürün";
                    ws.Cells[1, 3] = "Üretici";
                    ws.Cells[1, 4] = "Kategori";
                    ws.Cells[1, 5] = "Fiyat";
                    ws.Cells[1, 6] = "Vergi";
                    ws.Cells[1, 7] = "Satış Zamanı";
                    int i = 2;
                    foreach(ListViewItem item in ListOldSales.Items)
                    {
                        ws.Cells[i, 1] =Convert.ToInt64(item.SubItems[0].Text);
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        i++;
                    }

                    wb.SaveAs(exc.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();

                }
            }
        }

        private void CstbtnChangeP_Click(object sender, EventArgs e)
        {

        }

        private void OldSales_Load(object sender, EventArgs e)
        {
            ListOldSales.Items.Clear();
            AddListProduct();
        }

        private void AddListProduct()
        {
            try
            {

                foreach (var a in dbOldSales.TBL_Sales_History)
                {


                    OldSalesID = a.id;
                    dateSales = a.dateSales;

                    foreach (var tblProduct in dbProduct.TBL_Barcode.Where(tblProduct => tblProduct.id.Equals(a.productID)))
                    {
                        barcode = tblProduct.barcode;
                        productName = tblProduct.TBL_Product.productName;
                        producerName = tblProduct.TBL_Product.TBL_Producter.producterName;
                        producCategory = tblProduct.TBL_Product.TBL_Category.CategoryName;
                        price = tblProduct.TBL_Product.price.ToString();
                        tax = tblProduct.TBL_Product.tax.ToString();
                    }
                    string[] ls = { barcode, productName, producerName, producCategory, price, tax, dateSales };
                    OldSalesListAdItem(ls);
                    //var tblProduct = dbProduct.TBL_Barcode.Find(a.productID);

                }

                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OldSalesListAdItem(string[] a)
        {
            ListViewItem lst = new ListViewItem(a);

            ListOldSales.Invoke(new MethodInvoker(delegate ()
            {
                ListOldSales.Items.Add(lst);
            }));
        }
    }
}
