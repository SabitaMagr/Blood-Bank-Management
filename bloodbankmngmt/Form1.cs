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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhideshow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(btnhideshow.Text=="Show")
            {
                btnhideshow.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                btnhideshow.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox.Checked==true)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="blood" && txtPassword.Text=="pass")
            {
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtPassword.Select();
            }
        }
    }
}
