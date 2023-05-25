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

namespace DDCManagementSystem
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().ShowDialog();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmReports().ShowDialog();
            this.Close();
        }

        private void btnPricing_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrderPricing().ShowDialog();
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomer().ShowDialog();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrders().ShowDialog();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"delete from tblUsers where id ={txtID.Text}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadUsers();
                MessageBox.Show("User Successfully Deleted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into tblUsers values ('{txtUsername.Text}', '{txtPassword.Text}', '{txtFullName.Text}', '{txtRole.Text}');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadUsers();
                MessageBox.Show("User Successfully Created");
        }

        private void LoadUsers()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter("select id as ID, full_name as 'Full Name',username as Username, password as 'Password', role as Role from tblUsers;", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grdUsers.ReadOnly = true;
            grdUsers.DataSource = ds.Tables[0];
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void grdUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"update tblUsers set full_name = '{txtFullName.Text.Trim()}', username ='{txtUsername.Text}', password ='{txtPassword.Text}', role='{txtRole.Text}' where id ={txtID.Text}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadUsers();
                MessageBox.Show("User Successfully Updated");
            }
        }

        private void grdUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection dtColletion = grdUsers.Rows[e.RowIndex].Cells;
            txtID.Text = dtColletion["ID"].Value.ToString().Trim();
            txtFullName.Text = dtColletion["Full Name"].Value.ToString().Trim();
            txtUsername.Text = dtColletion["Username"].Value.ToString().Trim();
            txtPassword.Text = dtColletion["Password"].Value.ToString().Trim();
            txtRole.Text = dtColletion["Role"].Value.ToString().Trim();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTracking().ShowDialog();
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
