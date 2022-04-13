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
    public partial class SearchBlood : Form
    {
        public SearchBlood()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Add ad = new Add();
        private void SearchBlood_Load(object sender, EventArgs e)
        {
             DataTable dt=ad.GetAllUser();
            dtbbyBlood.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = ad.SearchbyBlood(txtBlood.Text);
            if(dt.Rows.Count>0)
            {
                dtbbyBlood.DataSource = dt;
            }
            else
            {
                MessageBox.Show("User not Found!!!");
            }
            txtBlood.SelectedIndex=0;
        }
    }
}
