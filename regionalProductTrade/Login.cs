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
    public partial class Login : Form
    {
        public static class SessionManager
        {
            public static int UserId { get; set; }
            public static string Role { get; set; }

            public static void ClearSession()
            {
                UserId = 0;
                Role = null;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string userId = idtextBox.Text;
            string userPassword = passwordtextBox.Text;


            if (string.IsNullOrEmpty(userId) && string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter both Id and Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter Id.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                string connectionString = DatabaseConnection.ConnectionString;

                string query = "SELECT Role FROM Users WHERE UserId = @UserId AND Password = @Password";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Password", userPassword);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            SessionManager.UserId = int.Parse(userId);
                            SessionManager.Role = role;


                            if (role == "Admin")
                            {
                                AdminDashboard adf = new AdminDashboard();
                                adf.Show();
                            }
                            else if (role == "Buyer")
                            {
                                buyerDashboard bdf = new buyerDashboard(SessionManager.UserId);
                                bdf.Show();
                            }
                            else if (role == "Seller")
                            {
                                SellerDashboard sdf = new SellerDashboard(SessionManager.UserId);
                                sdf.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unknown user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Id or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void createaccountbutton_Click(object sender, EventArgs e)
        {
            createaccount f2 = new createaccount();
            f2.Show();
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePass cp1 = new ChangePass();
            cp1.ShowDialog();
        }
    }
}
