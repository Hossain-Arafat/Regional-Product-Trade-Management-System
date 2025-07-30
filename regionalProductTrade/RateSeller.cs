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
    public partial class RateSeller: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int buyerid;
        public RateSeller(int id)
        {
            buyerid = id;
            InitializeComponent();
            LoadBuyerName();
        }
        private void LoadBuyerName()
        {
            string query = "SELECT UserId, Name FROM Users WHERE UserId = @UserId";

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
        private void LoadSellerName()
        {
            string query = "SELECT UserId, Name FROM Users WHERE UserId = @UserId AND Role='Seller'";
            string id = selleridtextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        sellernametextBox.Text = reader["Name"].ToString();
                        sellernametextBox.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(selleridtextBox.Text.Trim(), out int sellerid))
            {
                MessageBox.Show("Seller ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ratingtextBox.Text.Trim(), out int rating))
            {
                MessageBox.Show("Rating must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be between 1 and 5.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string comment = commenttextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int buyerId = buyerid;

            string query = "INSERT INTO Rating (BuyerId, SellerId, Rating, Comment) OUTPUT INSERTED.RatingId VALUES (@BuyerId, @SellerId, @Rating, @Comment)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BuyerId", buyerId);
                    command.Parameters.AddWithValue("@SellerId", sellerid);
                    command.Parameters.AddWithValue("@Rating", rating);
                    command.Parameters.AddWithValue("@Comment", comment);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int newRatingId = Convert.ToInt32(result);
                            MessageBox.Show("Rating added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the rating. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while adding the rating:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void selectbutton_Click(object sender, EventArgs e)
        {
            LoadSellerName();
        }
    }
}
