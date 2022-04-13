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
    public partial class Deletedonor : Form
    {
        public Deletedonor()
        {
            InitializeComponent();
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtblood.ResetText();
            txtgender.ResetText();
            txtdob.ResetText();
            txtdonorId.Clear();
        }
        public  int New_Donor_Id = 0;
        Add ad = new Add();
        private void Deletedonor_Load(object sender, EventArgs e)
        {
         
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
          

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           int i=ad.DeleteUser(New_Donor_Id);
            if(i>0)
            {
                MessageBox.Show("User Deleted Successfully!!!");
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            New_Donor_Id = Convert.ToInt32(txtdonorId.Text.ToString());
            DataTable dt=ad.GetById(New_Donor_Id);
            if(dt.Rows.Count!=0)
            {
                txtName.Text = dt.Rows[0]["Name"].ToString();
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
          else
            {
                MessageBox.Show("Invalid Donor Id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
