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

            MessageBox.Show(chkShalwar.Text);

            if (chkShalwar.Checked)
            {
                sbMessage.Append($"{chkShalwar.Text} \t Price: ${3} \t Qty: {qtyShalwar.Text} \t Sub-Total: ${3 * int.Parse(qtyShalwar.Text)}\n");
                SqlCommand cmd2 = new SqlCommand($"insert into tblOrders values('{CustmerId}','3','{qtyShalwar.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')",connection);
                cmd2.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkKameez.Checked)
            {
                sbMessage.Append($"{chkKameez.Text} \t Price: ${3} \t Qty: {qtyKameez.Text} \t Sub-Total: ${3 * int.Parse(qtyKameez.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyKameez.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkPant.Checked)
            {
                sbMessage.Append($"{chkPant.Text} \t Price: ${3} \t Qty: {qtyPant.Text} \t Sub-Total: ${3 * int.Parse(qtyPant.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyPant.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkShirt.Checked)
            {
                sbMessage.Append($"{chkShirt.Text} \t Price: ${3} \t Qty: {qtyShirt.Text} \t Sub-Total: ${3 * int.Parse(qtyShirt.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyShirt.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkUndergarments.Checked)
            {
                sbMessage.Append($"{chkUndergarments.Text} \t Price: ${3} \t Qty: {qtyUndergarments.Text} \t Sub-Total: ${3 * int.Parse(qtyUndergarments.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyUndergarments.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chk3Piece.Checked)
            {
                sbMessage.Append($"{chk3Piece.Text} \t Price: ${3} \t Qty: {qty3Piece.Text} \t Sub-Total: ${3 * int.Parse(qty3Piece.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qty3Piece.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chk2Piece.Checked)
            {
                sbMessage.Append($"{chk2Piece.Text} \t Price: ${3} \t Qty: {qty2Piece.Text} \t Sub-Total: ${3 * int.Parse(qty2Piece.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qty2Piece.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkJacket.Checked)
            {
                sbMessage.Append($"{chkJacket.Text} \t Price: ${3} \t Qty: {qtyJacket.Text} \t Sub-Total: ${3 * int.Parse(qtyJacket.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyJacket.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkCoat.Checked)
            {
                sbMessage.Append($"{chkJacket.Text} \t Price: ${3} \t Qty: {qtyJacket.Text} \t Sub-Total: ${3 * int.Parse(qtyJacket.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyJacket.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkSocks.Checked)
            {
                sbMessage.Append($"{chkSocks.Text} \t Price: ${3} \t Qty: {qtySocks.Text} \t Sub-Total: ${3 * int.Parse(qtySocks.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtySocks.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkHoodie.Checked)
            {
                sbMessage.Append($"{chkHoodie.Text} \t Price: ${3} \t Qty: {qtyHoodie.Text} \t Sub-Total: ${3 * int.Parse(qtyHoodie.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyHoodie.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkSweater.Checked)
            {
                sbMessage.Append($"{chkSweater.Text} \t Price: ${3} \t Qty: {qtySweater.Text} \t Sub-Total: ${3 * int.Parse(qtySweater.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtySweater.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkShoes.Checked)
            {
                sbMessage.Append($"{chkShoes.Text} \t Price: ${3} \t Qty: {qtyShoes.Text} \t Sub-Total: ${3 * int.Parse(qtyShoes.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyShoes.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkTowel.Checked)
            {
                sbMessage.Append($"{chkTowel.Text} \t Price: ${3} \t Qty: {qtyTowel.Text} \t Sub-Total: ${3 * int.Parse(qtyTowel.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyTowel.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
                cmd1.ExecuteNonQuery();
            }

            connection.Close();

            connection.Open();

            if (chkOther.Checked)
            {
                sbMessage.Append($"{chkOther.Text} \t Price: ${3} \t Qty: {qtyOther.Text} \t Sub-Total: ${3 * int.Parse(qtyOther.Text)} \n");
                SqlCommand cmd1 = new SqlCommand($"insert into tblOrders values('{CustmerId}','2','{qtyOther.Value}','{OrderNumber}','{DateTime.Now.ToString("dd/MM/yyyy")}')", connection);
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

        private void chkShalwar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShalwar.Checked)
            {
                qtyShalwar.Value = 1;
            }else
            {
                qtyShalwar.Value = 0;
            }
        }

        private void chkKameez_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKameez.Checked)
            {
                qtyKameez.Value = 1;
            }
            else
            {
                qtyKameez.Value = 0;
            }
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkTowel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkShoes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSweater_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkHoodie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
