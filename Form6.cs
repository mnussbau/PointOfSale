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
    public partial class BalancesForm : Form
    {
        private Form form;
        private CUSTOMER cust;
        private DataClasses1DataContext db;
        public BalancesForm(Form form,CUSTOMER cust)
        {
            InitializeComponent();
            this.form = form;
            this.cust = cust;
            this.db = ConnectionClass.db;
            form.Hide();
            amtLbl.Text = db.CUSTOMERs.Where(c => c.cust_id.Equals(cust.cust_id)).Select(c => c.cust_balance).FirstOrDefault().ToString();
           
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            Decimal paymentAmount = Convert.ToDecimal(amtText.Text);
            cust.cust_balance -= paymentAmount;
            db.SubmitChanges();
            MessageBox.Show("Payment has been made!");
            amtLbl.Text = cust.cust_balance.ToString();
            amtText.Clear();
        }
    }
}
