using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DDCManagementSystem
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            InitialDashboardValues();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
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

        private void LoadDashboardData()
        {
            var series = new Series("Income");
            series.Points.DataBindXY(new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }, new[] { 100, 290, 90, 150, 100, 200, 90, 150, 100, 200, 90, 150 });
            chart1.Series.Add(series);
            int dataPointIndex = 0;
            series.Color = Color.FromArgb(63, 81, 181);
            series["PixelPointWidth"] = "20";
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
        }

        private void InitialDashboardValues()
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter("select count(distinct order_number) from tblOrders;", con);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0 || ds.Tables[0].Rows[0][0].ToString() == "")
            {
                label2.Text = "0";
            }
            else
            {
                label2.Text = ds.Tables[0].Rows[0][0].ToString();
            }

            var dataAdapter2 = new SqlDataAdapter("select sum(unit_price* quantity) as 'Total Income' from tblOrders;", con);
            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            if (ds2 == null || ds2.Tables.Count == 0 || ds2.Tables[0].Rows.Count == 0 || ds2.Tables[0].Rows[0][0].ToString() == "")
            {
                label3.Text = "0";
            }
            else
            {
                label3.Text = ds2.Tables[0].Rows[0][0].ToString();
            }

            var dataAdapter3 = new SqlDataAdapter("select sum(unit_price * quantity) from tblOrders where order_date = FORMAT (getdate(), 'dd/MM/yyyy');", con);
            var ds3 = new DataSet();
            dataAdapter3.Fill(ds3);
            if (ds3 == null || ds3.Tables.Count == 0 || ds3.Tables[0].Rows.Count == 0 || ds3.Tables[0].Rows[0][0].ToString() == "")
            {
                label8.Text = "0";
            }else
            {
                label8.Text = ds3.Tables[0].Rows[0][0].ToString();
            }

            var dataAdapter4 = new SqlDataAdapter("select count(id) from tblCustomer;", con);
            var ds4 = new DataSet();
            dataAdapter4.Fill(ds4);
            if (ds4 == null || ds4.Tables.Count == 0 || ds4.Tables[0].Rows.Count == 0 || ds4.Tables[0].Rows[0][0].ToString() == "")
            {
                label6.Text = "0";
            }
            else
            {
                label6.Text = ds4.Tables[0].Rows[0][0].ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
