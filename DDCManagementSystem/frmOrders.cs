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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
            this.Close();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            new frmCreateOrder().Show();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadOrders();
        }

        private void LoadOrders()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter("select id as ID, order_number as 'Order #', customer_id as 'Customer ID', unit_price as 'Unit Price', quantity as Qantity, service_id as 'Service ID', order_date as 'Order Date' from tblOrders", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            gvOrder.ReadOnly = true;
            gvOrder.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomer().ShowDialog();
            this.Close();
        }

        private void btnPricing_Click(object sender, EventArgs e)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSettings().ShowDialog();
            this.Close();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmTracking().ShowDialog();
            this.Close();
        }
    }
}
