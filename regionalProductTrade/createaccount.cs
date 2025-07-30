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
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();

            string connectionString = DatabaseConnection.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DistrictId, DistrictName FROM District";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                districtidcomboBox.DataSource = dt;
                districtidcomboBox.DisplayMember = "DistrictName";
                districtidcomboBox.ValueMember = "DistrictId";
            }

            String[] r = new String[2];
            r[0] = "Buyer";
            r[1] = "Seller";
            rolecomboBox.DataSource = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DatabaseConnection.ConnectionString;
            string name = nametextBox.Text.Trim();
            string email = emailtextBox.Text;
            string role = rolecomboBox.SelectedItem.ToString();
            int districtId = int.Parse(districtidcomboBox.SelectedValue.ToString());
            string password = passwordtextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "INSERT INTO Users (Name, Email, Role, DistrictId, Password) OUTPUT INSERTED.UserId VALUES (@Name, @Email, @Role, @DistrictId, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@DistrictId", districtId);
                    command.Parameters.AddWithValue("@Password", password);


                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int newUserId = int.Parse(result.ToString());
                        MessageBox.Show("Profile created successfully! Your User ID is: "+newUserId+"\nPlease note this ID for login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void createaccount_Load(object sender, EventArgs e)
        {

        }
    }
}
