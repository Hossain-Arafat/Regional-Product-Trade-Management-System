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
    public partial class SellerOrder: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int sellerid;
        public SellerOrder(int id)
        {
            sellerid = id;
            InitializeComponent();
            LoadOrderHistory();
        }
        private void LoadOrderHistory()
        {
            string query = @"SELECT * FROM Orders WHERE SellerId = @SellerId ORDER BY OrderDate DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SellerId", sellerid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadOrderStatus()
        {
            string query = "SELECT OrderId, Status FROM Orders WHERE OrderId = @OrderId";
            string id = OrderidtextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        statustextBox.Text = reader["Status"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }
        private void LoadPaymentStatus()
        {
            string query = "SELECT OrderId, Status FROM Payment WHERE OrderId = @OrderId";
            string orderid = textBox1.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderid);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox2.Text = reader["Status"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }
        private void selectbutton_Click(object sender, EventArgs e)
        {
            LoadOrderStatus();
        }

        private void UpdateStatusbutton_Click(object sender, EventArgs e)
        {

            string status = statustextBox.Text.Trim();
            string id = OrderidtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Orders SET Status = @Status WHERE OrderId = @OrderId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", id);
                    command.Parameters.AddWithValue("@Status", status);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No record was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OrderidtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Paymen_Click(object sender, EventArgs e)
        {
            LoadPaymentStatus();
        }
    }
}
