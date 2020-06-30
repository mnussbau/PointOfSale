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
    public partial class CheckPurchaseByPriceForm : Form
    {
        private Form form;
        private CUSTOMER cust;
        private DataClasses1DataContext db;

        public CheckPurchaseByPriceForm(Form form, CUSTOMER cust)
        {
            InitializeComponent();
            this.form = form;
            this.cust = cust;
            this.db = ConnectionClass.db;
            form.Hide();
            purchasesListView.Columns.Add("Purchases", -2, HorizontalAlignment.Center);
            purchasesListView.Columns.Add("Items", -2, HorizontalAlignment.Center);
            purchasesListView.Columns.Add("Items", -2, HorizontalAlignment.Center);
            purchasesListView.Columns.Add("Items", -2, HorizontalAlignment.Center);
            purchasesListView.Columns.Add("Items", -2, HorizontalAlignment.Center);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (highestPriceText.Text == null || lowestPriceText.Text == null) {
                MessageBox.Show("Please fill in the info.");
                highestPriceText.Clear();
                lowestPriceText.Clear();
            }
            else
            {
                decimal high = Convert.ToDecimal(highestPriceText.Text);
                decimal low = Convert.ToDecimal(lowestPriceText.Text);
                var purchases = db.PURCHASEs.Where(p => p.total_price >= low && p.total_price <= high && p.cust_id == cust.cust_id);
                // var items = db.ITEMs.Where(item => (db.item_purchases.Where(p => purchases.Select(i => i.purchase_id).Contains(p.purchase_id)).Where(po => po.purchase_id.Equals(purch.purchase_id)).Select(purchase=> purchase.upc).Contains(item.upc)));
                foreach (PURCHASE purch in purchases)
                {
                    var listViewItem = purchasesListView.Items.Add($"{purch.purchase_id} {purch.purchase_date} ${purch.total_price}");
                    var items = db.ITEMs.Where(item => (db.item_purchases.Where(p => purchases.
                    Select(i => i.purchase_id).
                    Contains(p.purchase_id)).
                    Where(po => po.purchase_id.Equals(purch.purchase_id)).
                    Select(purchase => purchase.upc).Contains(item.upc))).ToList();
                    Console.WriteLine(items);
                    foreach (ITEM i in items)
                    {
                        listViewItem.SubItems.Add($"{i.item_desc}");
                    }
                }

            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}