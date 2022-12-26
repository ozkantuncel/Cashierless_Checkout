using Cashierless_Checkout.entity.product;
using System;
using System.Collections;
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
    public partial class AddProduct : UserControl
    {

        private static AddProduct _instance;
        public static AddProduct Instance
        {
            get
            {
                if( _instance == null)
                {
                    _instance = new AddProduct();
                }
                return _instance;
            }
        }

        public AddProduct()
        {
            InitializeComponent();
           
        }
        
        private byte catId;
        private short productId, producerId, barcodeID;
        private string productName, producerName,producCategory,barcode, tax,price;
       
        private CashierlessCheckoutProductDBEntities db = new CashierlessCheckoutProductDBEntities();
        private void CstbtnDellP_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem selectedInfo in listProduct.CheckedItems)
            {
                short temp = Convert.ToByte(selectedInfo.SubItems[0].Text.ToString());
                try
                {
                    var tbl = db.TBL_Barcode.Find(temp);
                    db.TBL_Barcode.Remove(tbl);
                    db.SaveChanges();

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }

                 
            }

            listProduct.Items.Clear();
            AddListProduct();



        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
 
            AddListProduct();
        }

        private void CstbtnLst_Click(object sender, EventArgs e)
        {
            listProduct.Items.Clear();
            AddListProduct();
        }

        private void CstBtnAddP_Click(object sender, EventArgs e)
        {
            byte a = 0;
            short b = 0;
            short c = 0;
            string bar = txtBarcode.Text;
            string prd = txtPName.Text;
            string prder = txtProducer.Text;
            string prCat = txtPCat.Text;
            string totalP = txtTotalP.Text;
            string taxP = txtPTax.Text;
            
            if(!bar.Equals("") && !prd.Equals("") && !totalP.Equals("") && !taxP.Equals(""))
            {
                try
                {
                    TBL_Product productTBL = new TBL_Product();
                    TBL_Barcode barcodeTBL = new TBL_Barcode();
                    if (!prder.Equals("")) 
                    {
                        TBL_Producter producterTBL = new TBL_Producter();
                        producterTBL.producterName = prder;
                        db.TBL_Producter.Add(producterTBL);
                        db.SaveChanges();
                        

                        foreach (var i in db.TBL_Producter)
                        {
                            b = i.id;
                        }
                    }
                    else
                    {

                        b = Convert.ToInt16(cmbProducer.SelectedValue);
                    }

                    if (!prCat.Equals(""))
                    {
                        TBL_Category categortTBL = new TBL_Category();
                        categortTBL.CategoryName = prCat;
                        db.TBL_Category.Add(categortTBL);
                        db.SaveChanges();

                        foreach (var i in db.TBL_Category)
                        {
                            a = i.id;
                        }

                    }
                    else
                    {
                        a = Convert.ToByte(cmbCat.SelectedValue);
                    }

                    productTBL.productName = prd;
                    productTBL.price = Convert.ToInt32(totalP);
                    productTBL.tax = Convert.ToInt32(taxP);
                    productTBL.categoryID = a;
                    productTBL.producerID = b;
                    db.TBL_Product.Add(productTBL);
                    db.SaveChanges();

                    foreach (var i in db.TBL_Product)
                    {
                        c = i.id;
                    }
                    barcodeTBL.barcode = bar;
                    barcodeTBL.produceID = c;
                    db.TBL_Barcode.Add(barcodeTBL);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ClearTextView();
                }
            }
            else
            {
                MessageBox.Show("Eksik değerleri giriniz");
            }                    
        }

        private void listProduct_DoubleClick(object sender, EventArgs e)
        {
            barcodeID = Convert.ToInt16(listProduct.SelectedItems[0].SubItems[0].Text);
            txtBarcode.Text = listProduct.SelectedItems[0].SubItems[1].Text;
            txtPName.Text = listProduct.SelectedItems[0].SubItems[2].Text;           
            txtTotalP.Text = listProduct.SelectedItems[0].SubItems[5].Text;
            txtPTax.Text = listProduct.SelectedItems[0].SubItems[6].Text;           

        }

        private void CstbtnChangeP_Click(object sender, EventArgs e)
        {

            try
            {
                var barcodeP = db.TBL_Barcode.Find(barcodeID);
                barcodeP.barcode = txtBarcode.Text;
                barcodeP.TBL_Product.productName = txtPName.Text;
                barcodeP.TBL_Product.price = Convert.ToInt32(txtTotalP.Text);
                barcodeP.TBL_Product.tax = Convert.ToInt32(txtPTax.Text);
                db.SaveChanges();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearTextView();
            }

        }

        private void AddListProduct()
        {
            try
            {

                foreach (var a in db.TBL_Barcode)
                {

                    barcodeID= a.id;
                    barcode = a.barcode;

                    productId = a.TBL_Product.id;
                    producerId = a.TBL_Product.TBL_Producter.id;
                    catId = a.TBL_Product.TBL_Category.id;

                    productName = a.TBL_Product.productName;
                    producerName = a.TBL_Product.TBL_Producter.producterName;
                    producCategory = a.TBL_Product.TBL_Category.CategoryName;
                    price = a.TBL_Product.price.ToString();
                    tax = a.TBL_Product.tax.ToString();
                    string[] ls = {barcodeID.ToString(),barcode, productName, producerName, producCategory, price, tax };
                    ProductListAdItem(ls);
                    

                }

                comboboxS();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboboxS()
        {
            var cat = (from x in db.TBL_Category
                       select new
                       {
                           x.id,
                           x.CategoryName
                       }).ToList();
            cmbCat.ValueMember = "id";
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.DataSource = cat;

            var prod = (from x in db.TBL_Producter
                        select new
                        {
                            x.id,
                            x.producterName
                        }).ToList();
            cmbProducer.ValueMember = "id";
            cmbProducer.DisplayMember = "producterName";
            cmbProducer.DataSource = prod;
        }

        private void ProductListAdItem(string[] a)
        {
            ListViewItem lst = new ListViewItem(a);

            listProduct.Invoke(new MethodInvoker(delegate ()
            {
                listProduct.Items.Add(lst);
            }));
        }

        private void ClearTextView()
        {
            txtBarcode.Text = "";
            txtPName.Text= "";
            txtProducer.Text= "";
            txtPCat.Text= "";
            txtTotalP.Text= "";
            txtPTax.Text= "";
        }

        private void BtnGnrcBrcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = GnrBarcode().ToString();
        }

        private long GnrBarcode()
        {
            Random rnd = new Random();
            return rnd.Next(100000000,1000000000);
        }


    }
}
