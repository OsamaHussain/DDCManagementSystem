using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2GGTQSU\\SQLEXPRESS01;Initial Catalog=DDCManagementSystem;Integrated Security=True");
            connection.Open();
            string query = $"SELECT * FROM tblUsers where username='{txtUsername.Text}' OR password='{txtPassword.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string username = reader["username"].ToString();
                string password = reader["password"].ToString();
                string role = reader["role"].ToString();
                
                if (username == txtUsername.Text)
                {
                    if (password == txtPassword.Text)
                    {
                        this.Hide();
                        new frmDashboard().ShowDialog();
                        this.Close();
                    }else
                    {
                        MessageBox.Show("Wrong Password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Wrong Username", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!reader.HasRows)
            {
                MessageBox.Show("[ No User Found ] - Wrong Username Or Password", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
