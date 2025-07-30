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
    public partial class ProductDetails: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int productId;
        int buyerId;
        public ProductDetails(int id, int buyerid)
        {
            productId = id;
            buyerId = buyerid;
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
                    ProductNametextBox.ReadOnly = true;

                    ProductDescriptiontextBox.Text = reader["Description"].ToString();
                    ProductDescriptiontextBox.ReadOnly = true;

                    PricetextBox.Text = reader["Price"].ToString();
                    PricetextBox.ReadOnly = true;

                    QuantitytextBox.Text = reader["Quantity"].ToString();
                    QuantitytextBox.ReadOnly = true;


                    SellerNametextBox.Text = reader["SellerName"].ToString();
                    SellerNametextBox.ReadOnly = true;

                    DistrictextBox.Text = reader["DistrictName"].ToString();
                    DistrictextBox.ReadOnly = true;


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
                pictureBox1.Enabled = false;
            }
        }
        private void ProductDetails_Load(object sender, EventArgs e)
        {

        }

        private void ProductDescriptiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrderbutton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(purchasequantitytextBox.Text.Trim(), out int orderQuantity) || orderQuantity <= 0)
            {
                MessageBox.Show("Invalid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string getProductQuery = "SELECT Price, Quantity, SellerId FROM Product WHERE ProductId = @ProductId";
                    decimal unitPrice = 0;
                    int currentStock = 0;
                    int sellerId = 0;

                    using (SqlCommand cmd = new SqlCommand(getProductQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                unitPrice = Convert.ToDecimal(reader["Price"]);
                                currentStock = Convert.ToInt32(reader["Quantity"]);
                                sellerId = Convert.ToInt32(reader["SellerId"]);
                            }
                        }
                    }

                    if (orderQuantity > currentStock)
                    {
                        MessageBox.Show("Not enough stock available.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    
                    string insertOrderQuery = @"INSERT INTO Orders (BuyerId, SellerId, ProductId, OrderQuantity, UnitPrice, OrderDate, Status)
                                                VALUES (@BuyerId, @SellerId, @ProductId, @OrderQuantity, @UnitPrice, GETDATE(), 'Pending')";

                    using (SqlCommand cmd = new SqlCommand(insertOrderQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@BuyerId", buyerId);
                        cmd.Parameters.AddWithValue("@SellerId", sellerId);
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                        cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmd.ExecuteNonQuery();
                    }

                    
                    string updateStockQuery = @"UPDATE Product SET Quantity = Quantity - @OrderQuantity WHERE ProductId = @ProductId";
                    using (SqlCommand cmd = new SqlCommand(updateStockQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to place order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
