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

        private void Insert(string query)
        {
            SqlConnection con = new SqlConnection(Connection.CONNECTION_STRING);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private StringBuilder SetData(bool bUpdate)
        {
            int CustmerId = 0;
            StringBuilder sbMessage = new StringBuilder();

            if (bUpdate)
            {
                SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
                connection.Open();

                SqlCommand cmd = new SqlCommand("spAddCustomerData", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@phone", cmbCustomerPhone.Text);
                cmd.Parameters.AddWithValue("@email", txtCustomerEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtCustomerAddress.Text);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CustmerId = int.Parse(rdr["CustomerId"].ToString());
                }

                connection.Close();
            }

            string OrderNumber = DateTime.Now.ToLocalTime().Ticks.ToString();


            if (chkShalwar.Checked)
            {
                sbMessage.Append($"{chkShalwar.Text} \t Price: ${Connection.dictServicePrice["Shalwar"]} \t Qty: {qtyShalwar.Text} \t Sub-Total: ${3 * int.Parse(qtyShalwar.Text)}\n");
                if (bUpdate)
                {
                    Insert($"insert into tblOrders values('{OrderNumber}','{CustmerId}',{Connection.dictServicePrice["Shalwar"]},'{qtyShalwar.Value}',{1},'{DateTime.Now.ToString("dd/MM/yyyy")}')");
                }
            }

            if (chkKameez.Checked)
            {
                sbMessage.Append($"{chkKameez.Text} \t Price: ${Connection.dictServicePrice["Kameez"]} \t Qty: {qtyKameez.Text} \t Sub-Total: ${3 * int.Parse(qtyKameez.Text)}\n");
                if (bUpdate)
                {
                    Insert($"insert into tblOrders values('{OrderNumber}','{CustmerId}',{Connection.dictServicePrice["Kameez"]},'{qtyKameez.Value}',{2},'{DateTime.Now.ToString("dd/MM/yyyy")}')");
                }
            }

            if (chkPant.Checked)
            {
                sbMessage.Append($"{chkPant.Text} \t Price: ${Connection.dictServicePrice["Pant"]} \t Qty: {qtyPant.Text} \t Sub-Total: ${3 * int.Parse(qtyPant.Text)}\n");
                if (bUpdate)
                {
                    Insert($"insert into tblOrders values('{OrderNumber}','{CustmerId}',{Connection.dictServicePrice["Pant"]},'{qtyPant.Value}',{3},'{DateTime.Now.ToString("dd/MM/yyyy")}')");
                }
            }

            return sbMessage;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            StringBuilder sbMessage = SetData(false);

            DialogResult dialogResult = MessageBox.Show(
                    $"Order Summary:\n\n" +
                    $"Customer Name: {txtCustomerName.Text}\n" +
                    $"Customer Phone: {cmbCustomerPhone.Text}\n" +
                    $"\n********************** [ Details ] **********************\n" +
                    sbMessage.ToString(),
                    "Order Summary",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

            if(dialogResult == DialogResult.Yes)
            {
                SetData(true);
            }
        }

        private void cmbCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            string userTypedData = cmbCustomerPhone.Text;


            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
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


            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
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
                    if (cmbCustomerPhone.Items[i].ToString() == phone)
                    {
                        index = i;
                    }
                }
            }

            if (index != -1)
            {
                //cmbCustomerPhone.Items[index].se = cmbCustomerPhone.Items[index].ToString();
            }

            connection.Close();

        }

        private void chkShalwar_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkShalwar, txtShalwarPrice, qtyShalwar, "Shalwar");
        }

        private void chkKameez_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkKameez, txtKameezPrice, qtyKameez, "Kameez");
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkOther, txtOtherWashablesPrice, qtyOther, "Other Washables");
        }

        private void chkTowel_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkTowel, txtTowelPrice, qtyTowel, "Towel");
        }

        private void chkShoes_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkShoes, txtShoesPrice, qtyShoes, "Shoes");
        }

        private void chkSweater_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkSweater, txtSweaterPrice, qtySweater, "Sweater");
        }

        private void chkHoodie_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkHoodie, txtHoodiePrice, qtyHoodie, "Hoodie");
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from [Services]", connection);
            SqlDataReader rdr = cmd.ExecuteReader();

            Connection.dictServicePrice = new Dictionary<string, string>();

            while (rdr.Read())
            {
                if (rdr["service_name"].ToString() == "Shalwar")
                {
                    txtShalwarPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Shalwar", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Kameez")
                {
                    txtKameezPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Kameez", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Pant")
                {
                    txtPantPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Pant", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Shirt")
                {
                    txtShirtPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Shirt", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Undergarments")
                {
                    txtUndergarmentPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Undergarments", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "3 Piece Suit")
                {
                    txt3PieceSuitPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("3 Piece Suit", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "2 Piece Suit")
                {
                    txt2PieceSuitePrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("2 Piece Suit", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Jacket")
                {
                    txtJacketPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Jacket", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Coat")
                {
                    txtCoatPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Coat", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Socks")
                {
                    txtSocksPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Socks", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Hoodie")
                {
                    txtHoodiePrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Hoodie", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Sweater")
                {
                    txtSweaterPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Sweater", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Shoes")
                {
                    txtShoesPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Shoes", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Towel")
                {
                    txtTowelPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Towel", rdr["service_price"].ToString());
                }
                else if (rdr["service_name"].ToString() == "Other Washables")
                {
                    txtOtherWashablesPrice.Text = rdr["service_price"].ToString();
                    Connection.dictServicePrice.Add("Other Washables", rdr["service_price"].ToString());
                }
            }

            connection.Close();
        }

        private void qtyShalwar_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtShalwarPrice, qtyShalwar, "Shalwar");
        }

        private void SetPrice(TextBox txtPrice, NumericUpDown numericUpDown, string serviceName, bool bSetNumericUpDown = false)
        {
            txtPrice.Text = (numericUpDown.Value * decimal.Parse(Connection.dictServicePrice[serviceName])).ToString();
            if (bSetNumericUpDown)
            {
                numericUpDown.Value = 1;
            }
        }

        private void SetDefault(CheckBox chkBox, TextBox txtBox, NumericUpDown numericUpDown, string serviceName)
        {
            if (chkBox.Checked)
            {
                txtBox.Enabled = true;
                numericUpDown.Enabled = true;
            }
            else
            {
                txtBox.Enabled = false;
                numericUpDown.Enabled = false;
                SetPrice(txtBox, numericUpDown, serviceName, true);
            }
        }

        private void qtyKameez_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtKameezPrice, qtyKameez, "Kameez");
        }

        private void qtyPant_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtPantPrice, qtyPant, "Pant");
        }

        private void qtyShirt_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtShirtPrice, qtyShirt, "Shirt");
        }

        private void qtyUndergarments_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtUndergarmentPrice, qtyUndergarments, "Undergarments");
        }

        private void qty3Piece_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txt3PieceSuitPrice, qty3Piece, "3 Piece Suit");
        }

        private void qty2Piece_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txt2PieceSuitePrice, qty2Piece, "2 Piece Suit");
        }

        private void qtyJacket_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtJacketPrice, qtyJacket, "Jacket");
        }

        private void qtyCoat_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtCoatPrice, qtyCoat, "Coat");
        }

        private void qtySocks_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtSocksPrice, qtySocks, "Socks");
        }

        private void qtyHoodie_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtHoodiePrice, qtyHoodie, "Hoodie");
        }

        private void qtySweater_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtShalwarPrice, qtyShalwar, "Sweater");
        }

        private void qtyShoes_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtShoesPrice, qtyShoes, "Shoes");
        }

        private void qtyTowel_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtTowelPrice, qtyTowel, "Towel");
        }

        private void qtyOther_ValueChanged(object sender, EventArgs e)
        {
            SetPrice(txtOtherWashablesPrice, qtyOther, "Other Washables");
        }

        private void chkPant_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkPant, txtPantPrice, qtyPant, "Kameez");
        }

        private void chkShirt_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkShirt, txtShirtPrice, qtyShirt, "Shirt");
        }

        private void chkUndergarments_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkUndergarments, txtUndergarmentPrice, qtyUndergarments, "Undergarments");
        }

        private void chk3Piece_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chk3Piece, txt3PieceSuitPrice, qty3Piece, "3 Piece Suit");
        }

        private void chk2Piece_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chk2Piece, txt2PieceSuitePrice, qty2Piece, "2 Piece Suit");
        }

        private void chkJacket_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkJacket, txtJacketPrice, qtyJacket, "Jacket");
        }

        private void txtSocksPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkSocks_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkSocks, txtSocksPrice, qtySocks, "Socks");
        }

        private void txtSweaterPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkCoat_CheckedChanged(object sender, EventArgs e)
        {
            SetDefault(chkCoat, txtCoatPrice, qtyCoat, "Coat");
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
