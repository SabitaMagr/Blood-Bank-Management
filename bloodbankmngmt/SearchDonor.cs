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
    public partial class SearchDonor : Form
    {
        public SearchDonor()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Add ad = new Add();
        private void SearchDonor_Load(object sender, EventArgs e)
        {
            DataTable dt = ad.GetAllUser();
            dtbbyLocation.DataSource=dt;
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = ad.SearchByAddress(txtAddress.Text);
            if (dt.Rows.Count > 0)
            {
                dtbbyLocation.DataSource = dt;
            }
            else
            {
                MessageBox.Show("User not Found!!");
            }
            txtAddress.Clear();
        }
    }
}
