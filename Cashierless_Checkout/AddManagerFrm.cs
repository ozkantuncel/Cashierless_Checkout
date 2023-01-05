using Cashierless_Checkout.entity.admin;
using Cashierless_Checkout.entity.old_sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashierless_Checkout
{
    public partial class AddManagerFrm : Form
    {
        private string managerA;
        public AddManagerFrm(string managerA)
        {
            this.managerA = managerA;
            InitializeComponent();
        }

        private CashierlessCheckoutAdminsDBEntities db = new CashierlessCheckoutAdminsDBEntities();
        

        private void AddManagerFrm_Load(object sender, EventArgs e)
        {
            try
            {
                ManagerListMaker();
                AddListManager();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
     
        }


        private void AddListManager()
        {
            byte ID;
            string name,pass;

            foreach (var a in db.TBL_Admin)
            {
                ID = a.id;
                name = a.admin_nick;
                pass = a.admin_password.Substring(0,4)+"********";


                string[] lst = { ID.ToString(),name, pass};
                ManagerListAddItem(lst);
            }
        }

        private void ManagerListAddItem(string[] a)
        {
            ListViewItem lst = new ListViewItem(a);

            listAdmin.Invoke(new MethodInvoker(delegate ()
            {
                listAdmin.Items.Add(lst);
            }));
        }

        private void ManagerListMaker()
        {
            listAdmin.Columns.Add("Yönetici İD", 85);
            listAdmin.Columns.Add("Yönetici İsmi", 150);
            listAdmin.Columns.Add("Yönetici Şifre", 100);
        }

        private static string CreateRandomPassword()
        {
            string charsAll = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

               
            int size = random.Next(8, 12);

             
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = charsAll[random.Next(0, charsAll.Length)];
            }
            return new string(chars);
        }

        private void BtnGnrcPass_Click(object sender, EventArgs e)
        {
            string passGnrc = CreateRandomPassword();
            txtPass.Text = passGnrc;
            txtPass2.Text = passGnrc;
        }

        private void CstbtnDelManager_Click(object sender, EventArgs e)
        {
            if(listAdmin.Items.Count > 1)
            {
                foreach (ListViewItem selectedInfo in listAdmin.CheckedItems)
                {
                    byte temp = Convert.ToByte(selectedInfo.SubItems[0].Text);
                    try
                    {
                        var tbc = db.TBL_Admin.Find(temp);
                        db.TBL_Admin.Remove(tbc);
                        db.SaveChanges();
                       

                        listAdmin.Items.Clear();
                        AddListManager();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    selectedInfo.Remove();
                }
            }
            else
            {
                 
                MessageBox.Show("Tüm yöneticiler silinemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void CstBtnAddManager_Click(object sender, EventArgs e)
        {
            string nick = txtNick.Text;
            string pass1 = txtPass.Text;
            string pass2 = txtPass2.Text;

            if (nick != ""&& pass1 != "" && pass2 != "")
            {
                if(pass1 == pass2)
                {
                    try 
                    {
                        TBL_Admin tbl = new TBL_Admin();
                        tbl.admin_nick = nick;
                        tbl.admin_password = pass1;
                        db.TBL_Admin.Add(tbl);
                        db.SaveChanges();
                        listAdmin.Items.Clear();
                        AddListManager();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanlarını doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }

        private void CstPboxEx_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ManagerFrm manager = new ManagerFrm(managerA);
            this.Hide();
            manager.Show();
        }
    }
}
