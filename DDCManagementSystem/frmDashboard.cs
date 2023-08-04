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
        //private int borderSize = 2;
        public frmDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            //this.Padding = new Padding(borderSize);
            //this.BackColor = Color.FromArgb(98, 102, 244);
        }

        /*[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        */

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            //labelDashboard.Location = new Point((this.Width - labelDashboard.Width) / 2, (this.Height - labelDashboard.Height) / 2);
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
    }
}
