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
    public partial class LoginForm : Form
    {
        private Form form;
        private DataClasses1DataContext db;


        public LoginForm(Form form)
        {
            InitializeComponent();
            db = ConnectionClass.db;
            this.form = form;
            form.Hide();
            this.Show();
           
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
           // using (DataClasses1DataContext db = ConnectionClass.db)
            {
                bool valid = false;
                String username;
                String password;
                username = userText.Text;
                password = passwordText.Text;
                var customer = ValidationChecker(ref valid, username, password);
               try
                {
                    validateButton.Visible = false;
                    validLbl.Text = "This username and password is valid.";
                    validLbl.Show();
                   
                    form = new Form1(customer);
                    this.Close();
                    form.Show();
                }
                catch(NullReferenceException)
                {
                    createAccounctBtn.Visible = false;
                    InvalidLbl.Text = "Sorry that username and password combination is invalid. Please try again.";
                    InvalidLbl.Visible = true;
                    createAccounctBtn.Visible = true;

                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        public CUSTOMER ValidationChecker(ref bool valid, string userName, string password)
        {
            valid = (db.CUSTOMERs.Select(e => e.cust_username).Contains(userName) &&
             db.CUSTOMERs.Select(e => e.cust_pass).Contains(password));
            if (valid)
            {
                return db.CUSTOMERs.Where(e => e.cust_username == userName).First();
            }
            else
            {
                return null;
            }
        }

        private void createAccounctBtn_Click(object sender, EventArgs e)
        {
            Form f = new SignUpForm(this);
            f.Show();

        }
    }
}
