using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDCManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin")
            {
                if (txtPassword.Text == "admin")
                {
                    this.Hide();
                    new frmDashboard().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Wrong Username", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
