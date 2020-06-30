using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFinalProject
{
    public partial class SignUpForm : Form
    {
        private Form form;
        public SignUpForm(Form form)
        {
            InitializeComponent();
            this.form = form;
            form.Hide();
            this.Show();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
           
            string fname = fNameText.Text;
            string lname = lnameText.Text;
            string street = streetText.Text;
            string city = cityText.Text;
            string state = stateComboBox.Text;
            string zip = zipText.Text;
            string phoneNumber = phoneNumberText.Text;
            string username = usernameText.Text;
            string pass;
            if (password1Text.Text == password2Text.Text)
            {
                pass = password1Text.Text;
            }
            else {
                pass = null;
            }
            if (fname == null || lname == null || street == null || city == null || state == null || zip == null || phoneNumber == null || pass == null) {
               // errorLbl.Text = "Error With your entry please try again.";
                this.Refresh();
            }
            else
            { 
                using (DataClasses1DataContext db = new DataClasses1DataContext()) {
                    CUSTOMER cust = new CUSTOMER();
                    cust.cust_username = username;
                    cust.cust_pass = pass;
                    cust.cust_fname = fname;
                    cust.cust_lname = lname;
                    cust.cust_street = street;
                    cust.cust_city = city;
                    cust.cust_state = state;
                    cust.cust_zip = zip;
                    cust.cust_phone = phoneNumber;
                    cust.cust_balance = new decimal(0.00);
                    
                    db.CUSTOMERs.InsertOnSubmit(cust);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Account has been created!");
                        this.Close();
                        form.Show();
                    }
                    catch(SqlException ) {
                        MessageBox.Show("Problem inserting Data");
                    }
                    
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
