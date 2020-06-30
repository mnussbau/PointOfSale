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
    public partial class Form1 : Form
    {
        private CUSTOMER customer;
        private DataClasses1DataContext db; 
       
            public Form1()
            {
               InitializeComponent();
               db = ConnectionClass.db;
               
            }
            public Form1(CUSTOMER customer)
             {
                InitializeComponent();
                this.customer = customer;
             }

            private void loginToolStripMenuItem_Click(object sender, EventArgs e)
            {
                
                Form f  = new LoginForm(this);
            
                f.Show();
            }

            private void browseToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Form f = new BrowseForm(this);
            f.Show();
            }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (customer.cust_balance.HasValue && customer.cust_balance > (Decimal)1000.00)
                {
                    MessageBox.Show("Cannot make a purchase today because your balance is too high.");
                    
                }
                Form f = new PurchaseForm(this, customer);
                f.Show();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");
                
            }
           catch(NullReferenceException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");

            }


            }

        private void payBalncesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new BalancesForm(this, customer);
                f.Show();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");

            }

        }

        private void byMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new CheckPurchaseForm(this, customer);
                f.Show();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot purchase items.");

            }


        }

        private void byPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form f = new CheckPurchaseByPriceForm(this, customer);
                f.Show();
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot view purchases.");

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Sorry you have not created an account with us \ntherefore you cannot view purchases.");

            }



        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (db != null) {
                db.Dispose();
            }
            Close();
        }
    }

    
}
