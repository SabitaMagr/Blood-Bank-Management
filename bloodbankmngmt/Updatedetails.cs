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
    public partial class Updatedeatails : Form
    {
        public Updatedeatails()
        {
            InitializeComponent();
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfather.Clear();
            txtmother.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            txtcity.Clear();
            txtaddress.Clear();
            txtblood.ResetText();
            txtgender.ResetText();
            txtdob.ResetText();
        }
        Add ad = new Add();
        public int New_Donor_Id = 0;

        private void Updatedeatails_Load(object sender, EventArgs e)
        {
            DataTable dt=ad.GetById(New_Donor_Id);
            txtname.Text = dt.Rows[0]["Name"].ToString();
            txtfather.Text = dt.Rows[0]["Father_Name"].ToString();
            txtmother.Text = dt.Rows[0]["Mother_Name"].ToString();
            txtdob.Text = dt.Rows[0]["Date_of_Birth"].ToString();
            txtmobile.Text = dt.Rows[0]["Mobile_No"].ToString();
            txtgender.Text = dt.Rows[0]["Gender"].ToString();
            txtemail.Text = dt.Rows[0]["Email"].ToString();
            txtblood.Text = dt.Rows[0]["Blood_group"].ToString();
            txtcity.Text = dt.Rows[0]["City"].ToString();
            txtaddress.Text = dt.Rows[0]["Address"].ToString();

        }
        Alldetails add = new Alldetails();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int i = ad.UpdateUser(txtname.Text, txtfather.Text, txtmother.Text, txtdob.Text, Convert.ToDouble(txtmobile.Text), txtgender.Text, txtemail.Text, txtblood.Text, txtcity.Text, txtaddress.Text,New_Donor_Id);
            if(i>0)
            {
                MessageBox.Show("User updated Successfully!!");
            }
        }
    }
}
