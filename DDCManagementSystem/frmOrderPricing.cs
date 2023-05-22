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
    public partial class frmOrderPricing : Form
    {
        public frmOrderPricing()
        {
            InitializeComponent();
        }

        private void frmOrderPricing_Load(object sender, EventArgs e)
        {
            LoadServicePrice();
        }

        private void LoadServicePrice()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter("select id as ID, service_name as Services, service_price as Price from [Services]", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grdServicePricing.ReadOnly = true;
            grdServicePricing.DataSource = ds.Tables[0];
        }

        private void grdServicePricing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection dtColletion = grdServicePricing.Rows[e.RowIndex].Cells;
            txtId.Text = dtColletion["ID"].Value.ToString().Trim();
            txtServiceName.Text = dtColletion["Services"].Value.ToString().Trim();
            txtServicePrice.Text = dtColletion["Price"].Value.ToString().Trim();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
                con.Open();
                SqlCommand cmd = new SqlCommand($"update [Services] set service_price = {txtServicePrice.Text} where id ={txtId.Text}", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadServicePrice();
                MessageBox.Show("service updated");
            }
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
    }
}
