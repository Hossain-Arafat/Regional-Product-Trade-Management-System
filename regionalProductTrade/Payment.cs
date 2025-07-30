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

namespace regionalProductTrade
{
    public partial class Payment: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        public Payment()
        {
            InitializeComponent();
            String[] r = new String[6];
            r[0] = "bKash";
            r[1] = "Nagad";
            r[2] = "Rocket";
            r[3] = "Visa";
            r[4] = "Mastercard";
            r[5] = "SSLCommerz";
            rolecomboBox.DataSource = r;
        }
        private void LoadAmount()
        {
            string query = "SELECT OrderId, TotalAmount FROM Orders WHERE OrderId = @OrderId";
            string id = orderidtextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        amounttextBox.Text = reader["TotalAmount"].ToString();
                        amounttextBox.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            int orderid;
            if (!int.TryParse(orderidtextBox.Text.Trim(), out orderid))
            {
                MessageBox.Show("Please enter a valid OrderID.");
                return;
            }

            double amount;
            if (!double.TryParse(amounttextBox.Text.Trim(), out amount))
            {
                MessageBox.Show("Please enter a valid number for amount.");
                return;
            }
            string method = rolecomboBox.SelectedItem.ToString();

            string query = "INSERT INTO Payment (OrderId, PaymentMethod, Amount) OUTPUT INSERTED.PaymentId VALUES (@OrderId, @PaymentMethod, @Amount)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderid);
                    command.Parameters.AddWithValue("@PaymentMethod", method);
                    command.Parameters.AddWithValue("@Amount", amount);
                    
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Your Payment is Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Your payment is failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void selectbutton_Click(object sender, EventArgs e)
        {
            LoadAmount();
        }
    }
}
