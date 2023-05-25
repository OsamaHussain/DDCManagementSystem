using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DDCManagementSystem
{
    public partial class frmTracking : Form
    {
        public frmTracking()
        {
            InitializeComponent();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadTrack()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            //var dataAdapter = new SqlDataAdapter($"select distinct order_number, customer_id, order_date, tblCustomer.name, tblCustomer.email, tblCustomer.phone, tblCustomer.address from tblOrders inner join tblCustomer on tblOrders.customer_id = tblCustomer.id where order_number like {txtTrack};", con);
            var dataAdapter = new SqlDataAdapter($"select tblOrders.id,tblOrders.order_date, tblOrders.order_number, tblOrders.customer_id, tblCustomer.name, tblCustomer.email, tblCustomer.phone, tblCustomer.address from tblOrders inner join tblCustomer on tblOrders.customer_id = tblCustomer.id;", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            gvTrack.ReadOnly = true;
            gvTrack.DataSource = ds.Tables[0];
        }

        private void txtTrack_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter($"select order_number, customer_id, order_date, tblCustomer.name, tblCustomer.email, tblCustomer.phone, tblCustomer.address from tblOrders inner join tblCustomer on tblOrders.customer_id = tblCustomer.id where order_number like {txtTrack.Text};", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            gvTrack.ReadOnly = true;
            gvTrack.DataSource = ds.Tables[0];



        }

        private void frmTracking_Load(object sender, EventArgs e)
        {
            LoadTrack();
        }

        private void gvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection dtColletion = gvTrack.Rows[e.RowIndex].Cells;
            txtOrderID.Text = dtColletion["order_number"].Value.ToString().Trim();
            txtName.Text = dtColletion["name"].Value.ToString().Trim();
            txtEmail.Text = dtColletion["email"].Value.ToString().Trim();
            txtPhone.Text = dtColletion["phone"].Value.ToString().Trim();
            txtAddress.Text = dtColletion["address"].Value.ToString().Trim();
            txtDate.Text = dtColletion["order_date"].Value.ToString().Trim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmCustomer().ShowDialog();
            this.Close();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
