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
    public partial class Alldetails : Form
    {
        public Alldetails()
        {
            InitializeComponent();
        }
        Add ad = new Add();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alldetails_Load(object sender, EventArgs e)
        {
            DataTable dt = ad.GetAllUser();
            dtbAllDonor.DataSource = dt;

        }

        private void dtbAllDonor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int New_Donor_Id = Convert.ToInt32(dtbAllDonor.CurrentRow.Cells[0].Value.ToString());
            Updatedeatails ud = new Updatedeatails();
            ud.New_Donor_Id=Convert.ToInt32(dtbAllDonor.CurrentRow.Cells[0].Value.ToString());
            ud.Show();
            this.Hide();
        }

        //private void dtbAllDonor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
           
        //}

        //private void dtbAllDonor_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int New_Donor_Id = Convert.ToInt32(dtbAllDonor.CurrentRow.Cells[0].Value.ToString());
        //    Deletedonor dd = new Deletedonor();
        //    dd.New_Donor_Id = Convert.ToInt32(dtbAllDonor.CurrentRow.Cells[0].Value.ToString());
        //    dd.Show();
        //    this.Hide();
        //}
    }
}

