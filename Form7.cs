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
    public partial class CheckPurchaseForm : Form
    {
        private Form form;
        private CUSTOMER cust;
        private DataClasses1DataContext db;


        public CheckPurchaseForm(Form form, CUSTOMER cust)
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
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            dateTimePicker1.Refresh();
            dateTimePicker2.Refresh();
            if (startDate > endDate || endDate > DateTime.Now)
            {
                MessageBox.Show("Problem with your dates please re-enter.");
                dateTimePicker1.Refresh();
                dateTimePicker2.Refresh();
            }
            else {
                var purchases = db.PURCHASEs.Where(p => p.purchase_date >= startDate && p.purchase_date <= endDate && p.cust_id==cust.cust_id);
              
                foreach(PURCHASE purch in purchases) {
                    var listViewItem =purchasesListView.Items.Add($"{purch.purchase_id} {purch.purchase_date} ${purch.total_price}");
                    var items = db.ITEMs.Where(item => (db.item_purchases.Where(p => purchases.
                    Select(i => i.purchase_id).
                    Contains(p.purchase_id)).
                    Where(po => po.purchase_id.Equals(purch.purchase_id)).
                    Select(purchase => purchase.upc).Contains(item.upc))).ToList();
                   
                    foreach (ITEM i in items) {
                        listViewItem.SubItems.Add($"{i.item_desc}");
                    }
                }
              
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
