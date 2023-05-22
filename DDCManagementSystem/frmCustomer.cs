using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDCManagementSystem
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter("select id as ID, name as Name, phone as Phone, email as Email, address as Address from tblCustomer;", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection dtColletion = dataGridView1.Rows[e.RowIndex].Cells;
            txtCustomerId.Text = dtColletion["id"].Value.ToString().Trim();
            txtCustomerName.Text = dtColletion["name"].Value.ToString().Trim();
            txtPhone.Text = dtColletion["phone"].Value.ToString().Trim();
            txtEmail.Text = dtColletion["email"].Value.ToString().Trim();
            txtAddress.Text = dtColletion["address"].Value.ToString().Trim();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtCustomerId.Text != "")
            {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"delete from tblCustomer where id ={txtCustomerId.Text}",con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadCustomer();
                MessageBox.Show("customer deleted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"update tblCustomer set name = '{txtCustomerName.Text.Trim()}', phone ='{txtPhone.Text}', email ='{txtEmail.Text}', address='{txtAddress.Text}' where id ={txtCustomerId.Text}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadCustomer();
                MessageBox.Show("customer updated");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrders().ShowDialog();
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomer().ShowDialog();
            this.Close();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOrderPricing().ShowDialog();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmReports().ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
