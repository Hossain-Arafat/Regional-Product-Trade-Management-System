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
    public partial class RequestProduct: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int buyerid;
        public RequestProduct(int id)
        {
            buyerid = id;
            InitializeComponent();
            LoadBuyerDetails();
        }
        private void LoadBuyerDetails()
        {
            string query = "SELECT UserId FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", buyerid);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        buyeridtextBox.Text = reader["UserId"].ToString();
                        buyeridtextBox.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.Trim();
            string description = descriptiontextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name)|| string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO ProductRequest (BuyerId, ProductName, Description) OUTPUT INSERTED.RequestId VALUES (@BuyerId, @ProductName, @Description)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuyerId", buyerid);
                    command.Parameters.AddWithValue("@ProductName", name);
                    command.Parameters.AddWithValue("@Description", description);

                    
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                       MessageBox.Show("Product request sended successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.Hide();
                    }
                    else
                    {
                       MessageBox.Show("Failed to add the rating. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
    }
}
