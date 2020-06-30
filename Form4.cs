using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace OOPFinalProject
{
    public partial class BrowseForm : Form
    {
        private Form form;
        public BrowseForm(Form form)
        {
            InitializeComponent();
            this.form = form;
            form.Hide();
        }

        private void BrowseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oOPSTOREDataSet.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter.Fill(this.oOPSTOREDataSet.ITEM);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }

}
