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
    public partial class ChangePass: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            int userid;
            if (!int.TryParse(useridtextBox.Text.Trim(), out userid))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }
            string newpass = newpasstextBox.Text.Trim();
            string confirmpass = confirmtextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(newpass) || string.IsNullOrWhiteSpace(confirmpass))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newpass != confirmpass)
            {
                MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Users SET Password=@Password WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userid);
                    command.Parameters.AddWithValue("@Password", newpass);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No password was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
