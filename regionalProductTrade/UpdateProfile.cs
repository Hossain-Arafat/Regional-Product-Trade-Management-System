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
    public partial class UpdateProfile : Form
    {

        int userId;
        string connectionString = DatabaseConnection.ConnectionString;
        public UpdateProfile(int i)
        {
            userId = i;
            InitializeComponent();    
            LoadDetails();
        }
       

        private void LoadDetails()
        {
            string query = "SELECT UserId, Name, Email, Role, DistrictId, Password FROM Users WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        idtextBox.Text = reader["UserId"].ToString();
                        idtextBox.ReadOnly = true;

                        nametextBox.Text = reader["Name"].ToString();
                        emailtextBox.Text = reader["Email"].ToString();
                        passwordtextBox.Text = reader["Password"].ToString();


                        roletextBox.Text = reader["Role"].ToString();
                        roletextBox.ReadOnly = true;
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

        private void updateprofilebutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.Trim();
            string email = emailtextBox.Text.Trim();
           string password = passwordtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Users SET Name = @Name, Email = @Email,Password=@Password WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteprofilebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this profile?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Users WHERE UserId= @UserId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close(); 
                        }
                        else
                        {
                            MessageBox.Show("No profile was found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void districtidcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rolecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roletextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
