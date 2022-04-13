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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor dn = new AddNewDonor();
            dn.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updatedeatails up = new Updatedeatails();
            up.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alldetails ad = new Alldetails();
            ad.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonor sd = new SearchDonor();
            sd.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBlood sb = new SearchBlood();
            sb.Show();
        }

        //private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    increase i = new increase();
        //    i.Show();
        //}

        //private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Decrease d = new Decrease();
        //    d.Show();
        //}

        //private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Details dt = new Details();
        //    dt.Show();
        //}

        //private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Deletedonor dd = new Deletedonor();
        //    dd.Show();
        //}

        //private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           

        //}

        private void deleteDonorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Deletedonor dd = new Deletedonor();
            dd.Show();
        }
       
    }
}
