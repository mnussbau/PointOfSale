using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinalProject
{
    public partial class PurchaseForm : Form
    {
        private Form form;
        private CUSTOMER cust;
        private List<String> itemsInCart;
       private DataClasses1DataContext db;

        public PurchaseForm(Form form, CUSTOMER cust)
        {
            InitializeComponent();
            db = ConnectionClass.db;
            this.form = form;
            this.cust = cust;
            this.itemsInCart = new List<String>();
            form.Hide();
            this.Show();
            db.ITEMs.ToList().ForEach(item => productListView.Items.Add(item.item_desc + "-" + item.item_price));
            productListView.Columns.Add("Products", -2, HorizontalAlignment.Center);
          
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            string str;
            List<ITEM> itemList = new List<ITEM>();
            foreach (ListViewItem i in productListView.CheckedItems) {
                str = i.ToString().Remove(0, 15);
                var newStr = str.Remove(str.Length-1, 1);
                itemsInCart.Add(newStr);
            }
         
            PURCHASE purchase = new PURCHASE();
           
            foreach (string s in itemsInCart) {
              var strings = s.Split('-');
             
              
              var item = db.ITEMs.Where(i => i.item_desc==strings[0] && i.item_price.ToString() == strings[1]).First();
            
              itemList.Add(item);
            }
            var total = itemList.Sum(s => s.item_price);
            decimal totalPrice = Convert.ToDecimal(total);
            purchase.cust_id = db.CUSTOMERs.Where(c => c.cust_username.Equals(cust.cust_username)).Select(id => id.cust_id).First();
            purchase.total_price = totalPrice;
            purchase.purchase_date = DateTime.Now;
            db.PURCHASEs.InsertOnSubmit(purchase);
            db.SubmitChanges();
            foreach (ITEM item in itemList) {
                item_purchase ip = new item_purchase();
                ip.purchase_id=purchase.purchase_id;
                ip.upc = item.upc;
                db.item_purchases.InsertOnSubmit(ip);
                db.SubmitChanges();
            }
            cust.cust_balance += totalPrice;
            
            db.SubmitChanges();
            
            MessageBox.Show("Purchase was a success!");
            this.Close();
            Form f = new PurchaseForm(form, cust);
            f.Show();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
