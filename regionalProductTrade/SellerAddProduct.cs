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
    public partial class SellerAddProduct : Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int Id;
        
        public SellerAddProduct(int id)
        {
            Id = id;
            InitializeComponent();
            LoadSellerDetails();
        }
        private void LoadSellerDetails()
        {
            string query = "SELECT UserId, DistrictId FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", Id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        selleridtextBox.Text = reader["UserId"].ToString();
                        selleridtextBox.ReadOnly = true;

                        districtidtextBox.Text = reader["DistrictId"].ToString();
                        districtidtextBox.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }

        private void SellerAddProduct_Load(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void addproudctbutton_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConnection.ConnectionString;

            string name = nametextBox.Text.Trim();
            string description = descriptiontextBox.Text;


             int quantity;
             if (!int.TryParse(quantitytextBox.Text.Trim(), out quantity))
             {
                 MessageBox.Show("Please enter a valid number for quantity.");
                 return;
             }

             double price;
             if (!double.TryParse(pricetextBox.Text.Trim(), out price))
             {
                 MessageBox.Show("Please enter a valid number for price.");
                 return;
             }

             int sellerid;
             if (!int.TryParse(selleridtextBox.Text.Trim(), out sellerid))
             {
                 MessageBox.Show("Please enter a valid number for seller ID.");
                 return;
             }

             int districtid;
             if (!int.TryParse(districtidtextBox.Text.Trim(), out districtid)) // 👈 Use a proper textbox
             {
                 MessageBox.Show("Please enter a valid number for district ID.");
                 return;
             }
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string selectedImagePath = imagePathtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(selectedImagePath) || !System.IO.File.Exists(selectedImagePath))
            {
                MessageBox.Show("Please select a valid image file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string imageFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            
            string fileName = Path.GetFileName(selectedImagePath);
            string destImagePath = Path.Combine(imageFolder, fileName);

            
            try
            {
                File.Copy(selectedImagePath, destImagePath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying image: " + ex.Message);
                return;
            }

            
            string relativeImagePath = Path.Combine("Images", fileName);

            
            string query = "INSERT INTO Product (Name, Description, Price, Quantity, SellerId, DistrictId, ImagePath) " +
               "OUTPUT INSERTED.ProductId " +
               "VALUES (@Name, @Description, @Price, @Quantity, @SellerId, @DistrictId, @ImagePath)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@SellerId", sellerid);
                    command.Parameters.AddWithValue("@DistrictId", districtid);
                    command.Parameters.AddWithValue("@ImagePath", relativeImagePath);


                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int newUserId = int.Parse(result.ToString());
                        MessageBox.Show("Product added successfully! Your Product ID is: " + newUserId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BrowseImagebutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePathtextBox.Text = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void imagePathtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
