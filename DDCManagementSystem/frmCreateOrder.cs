using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Reflection;

namespace DDCManagementSystem
{
    public partial class frmCreateOrder : Form
    {
        public frmCreateOrder()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2GGTQSU\\SQLEXPRESS01;Initial Catalog=DDCManagementSystem;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand("spAddCustomerData", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", txtCustomerName.Text);
            cmd.Parameters.Add("@phone", cmbCustomerPhone.Text);
            cmd.Parameters.Add("@email", txtCustomerEmail.Text);
            cmd.Parameters.Add("@address", txtCustomerAddress.Text);
            SqlDataReader rdr = cmd.ExecuteReader();


            int CustmerId = 0;

            while (rdr.Read())
            {
                CustmerId = int.Parse(rdr["CustomerId"].ToString());
            }

            connection.Close();
            connection.Open();

            string OrderNumber = DateTime.Now.ToLocalTime().Ticks.ToString();


            StringBuilder sbMessage = new StringBuilder();

            if (chkShalwar.Checked)
            {
                sbMessage.Append($"{chkShalwar.Text} - Price: ${3} - Qty: {qtyShalwar.Text} \t Sub-Total: ${3 * int.Parse(qtyShalwar.Text)}\n");
                SqlCommand cmd2 = new SqlCommand($"insert into tblOrders values('{CustmerId}','3','{qtyShalwar.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')",connection);
                cmd2.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkKameez.Checked)
            {
                sbMessage.Append($"{chkKameez.Text} - Price: ${3} - Qty: {qtyKameez.Text} \t Sub-Total: ${3 * int.Parse(qtyKameez.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyKameez.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            MessageBox.Show(
                $"Order Summary:\n\n" +
                $"Customer Name: {txtCustomerName.Text}\n" +
                $"Customer Phone: {cmbCustomerPhone.Text}\n" +
                $"\n********************** [ Details ] **********************\n" +
                sbMessage.ToString(),
                "Order Summary",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None
            );
        }

        private void cmbCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            string userTypedData = cmbCustomerPhone.Text;


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2GGTQSU\\SQLEXPRESS01;Initial Catalog=DDCManagementSystem;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand($"SELECT top 10 * FROM tblCustomer WHERE phone like '{userTypedData}%'", connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            cmbCustomerPhone.Items.Clear();
            cmbCustomerPhone.Items.Add(userTypedData);

            while (rdr.Read())
            {
                cmbCustomerPhone.Items.Add(rdr["phone"].ToString());
            }


            this.cmbCustomerPhone.Focus();
            this.cmbCustomerPhone.SelectionStart = userTypedData.Length;
            this.cmbCustomerPhone.SelectionLength = 0;


            connection.Close();
        }

        private void cmbCustomerPhone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCustomerPhone_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            string userTypedData = cmbCustomerPhone.Text;


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2GGTQSU\\SQLEXPRESS01;Initial Catalog=DDCManagementSystem;Integrated Security=True");
            connection.Open();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM tblCustomer WHERE phone = '{userTypedData}'", connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            int index = -1;

            while (rdr.Read())
            {
                txtCustomerName.Text = rdr["name"].ToString();
                txtCustomerEmail.Text = rdr["email"].ToString();
                txtCustomerAddress.Text = rdr["address"].ToString();
                string phone = rdr["phone"].ToString();

                for (int i = 0; i < cmbCustomerPhone.Items.Count; i++)
                {
                    if(cmbCustomerPhone.Items[i].ToString() == phone)
                    {
                        index = i;
                    }
                }
            }

            if(index != -1)
            {
                //cmbCustomerPhone.Items[index].se = cmbCustomerPhone.Items[index].ToString();
            }

            connection.Close();

        }
    }
}
