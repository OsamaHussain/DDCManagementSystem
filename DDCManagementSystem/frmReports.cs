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
    public partial class frmReports : Form
    {
        static string from;
        static string to;
        public frmReports()
        {
            InitializeComponent();
        }

        private void LoadReport(string from,string to)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
                return;

            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            var dataAdapter = new SqlDataAdapter($"select sum(o.unit_price * o.quantity) as 'Income',o.order_date as 'Date' from tblCustomer c join tblOrders o on c.id = o.customer_id join [Services] s on s.id = o.service_id group by o.order_date having o.order_date between '{from}' and '{to}'", con);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            grdReport.ReadOnly = true;
            grdReport.DataSource = ds.Tables[0];

            float totalIncome = 0;
            foreach (DataGridViewRow row in grdReport.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    float value;
                    if (cell.Value != null && float.TryParse(cell.Value.ToString(), out value))
                    {
                        totalIncome += value;
                    }
                }
            }
            txtTotalIncome.Text = "$"+totalIncome.ToString();


        }

        private void From_DateChanged(object sender, DateRangeEventArgs e)
        {
            from = e.Start.Date.ToString("dd/MM/yyyy");
            LoadReport(from, to);
        }

        private void To_DateChanged(object sender, DateRangeEventArgs e)
        {
            to = e.Start.Date.ToString("dd/MM/yyyy");
            LoadReport(from,to);
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDashboard().ShowDialog();
            this.Close();
        }

        private void btnServices_Click(object sender, EventArgs e)
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
