using bloodbankmngmt.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloodbankmngmt
{
    public partial class AddNewDonor : Form
    {
        

        public AddNewDonor()
        {
            InitializeComponent();
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Add add = new Add();
        private void btnsave_Click(object sender, EventArgs e)
        {
           
            string msg = validatefields();
            if(string.IsNullOrWhiteSpace(msg))
            {
                int i = add.CreateUser(txtName.Text, txtfather.Text, txtmother.Text, txtdob.Text, Convert.ToDouble(txtmobile.Text), txtgender.Text, txtemail.Text, txtblood.Text, txtcity.Text, txtaddress.Text);
                if (i > 0)
                {
                    MessageBox.Show("User Created");
                }
                else
                {
                    MessageBox.Show("Failed to create user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                MessageBox.Show(msg);
            }
        }
        public string validatefields()
        {
            string res = string.Empty;
            double convertedNumber;
            bool IsNumeric = double.TryParse(txtmobile.Text, out convertedNumber);
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                res = "Please enter Name";   
            }
            else if(string.IsNullOrWhiteSpace(txtfather.Text))
            {
                res = "Please enter Father's Name.";
            }
            else if(string.IsNullOrWhiteSpace(txtmother.Text))
            {
                res = "Please enter Mother's Name.";
            }
            else if(string.IsNullOrWhiteSpace(txtdob.Text))
            {
                res = "Please enter Date of Birth";
            }
            else if (!IsNumeric)
            {
                res = "Invalid Contact Number.";
            }
            else if (txtmobile.Text.Length != 10)
            {
                res = "Please enter valid Contact Number";
            }
            else if(string.IsNullOrWhiteSpace(txtgender.Text))
            {
                res = "Please enter Gender.";
            }
            else if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                res = "Please enter Email.";
            }
            else if(string.IsNullOrWhiteSpace(txtblood.Text))
            {
                res = "Please enter Blood Group";
            }
            else if (string.IsNullOrWhiteSpace(txtcity.Text))
            {
                res = "Please enter City.";
            }
            else if(string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                res = "Please enter Address.";
            }
            return res;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtfather.Clear();
            txtmother.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            txtcity.Clear();
            txtaddress.Clear();
            txtblood.SelectedIndex = 0;
            txtgender.SelectedIndex = 0;
            txtdob.ResetText();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtfather.Select();
            }
        }

        private void txtfather_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtmother.Select();
            }
        }

        private void txtmother_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtdob.Select();
            }
        }

        private void txtdob_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtmobile.Select();
            }
        }

        private void txtmobile_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtgender.Select();
            }
        }

        private void txtgender_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtemail.Select();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtblood.Select();
            }
        }

        private void txtblood_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtcity.Select();
            }
        }

        private void txtcity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtaddress.Select();
            }
        }
    }
}
