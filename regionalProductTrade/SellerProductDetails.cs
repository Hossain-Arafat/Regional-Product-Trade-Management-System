using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regionalProductTrade
{
    public partial class SellerProductDetails: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int productId;
        public SellerProductDetails(int id)
        {
            productId = id;
            InitializeComponent();
            LoadProductDetails();
        }
        private void LoadProductDetails()
        {
            string query = @"SELECT P.Name AS ProductName, P.Description, P.Price, P.Quantity, P.ImagePath, U.Name AS SellerName, D.DistrictName FROM Product P
             JOIN Users U ON P.SellerId = U.UserId
             JOIN District D ON U.DistrictId = D.DistrictId
             WHERE P.ProductId = @ProductId;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ProductNametextBox.Text = reader["ProductName"].ToString();
                    ProductDescriptiontextBox.Text = reader["Description"].ToString();
                    PricetextBox.Text = reader["Price"].ToString();
                    QuantitytextBox.Text = reader["Quantity"].ToString();
                    
                    SellerNametextBox.Text = reader["SellerName"].ToString();
                    SellerNametextBox.ReadOnly = true;

                    DistrictextBox.Text = reader["DistrictName"].ToString();
                    DistrictextBox.ReadOnly = true;


                    ImagepathtextBox.Text = reader["ImagePath"].ToString();

                    string relativeImagePath = reader["ImagePath"].ToString();
                    string fullImagePath = Path.Combine(Application.StartupPath, relativeImagePath);
                    if (File.Exists(fullImagePath))
                    {
                        pictureBox1.Image = Image.FromFile(fullImagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBox1.Image = null; 
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Product WHERE ProductId = @ProductId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close(); // Close the form after successful deletion
                        }
                        else
                        {
                            MessageBox.Show("No profile was found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            string name = ProductNametextBox.Text.Trim();
            string description = ProductDescriptiontextBox.Text.Trim();
            string priceText = PricetextBox.Text.Trim();
            string quantityText = QuantitytextBox.Text.Trim();
            string imagePath = ImagepathtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(quantityText))
            {
                MessageBox.Show("Please fill in all product details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price) || price < 0 ||
                !int.TryParse(quantityText, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Invalid price or quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE Product 
                     SET Name = @Name, Description = @Description, Price = @Price, Quantity = @Quantity, ImagePath = @ImagePath 
                     WHERE ProductId = @ProductId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ImagePath", imagePath);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BrowseImagebutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = ofd.FileName;
                    string productImagesFolder = Path.Combine(Application.StartupPath, "ProductImages");

                    string relativePath = selectedFilePath.Substring(Application.StartupPath.Length + 1); 
                    ImagepathtextBox.Text = relativePath;
                   

                    pictureBox1.Image = Image.FromFile(selectedFilePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
