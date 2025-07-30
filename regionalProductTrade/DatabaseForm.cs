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
    public partial class DatabaseForm : Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        
        public DatabaseForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM Users";
            FillDataGridView(query);

        }

        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string Search = searchtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Search))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT * FROM Users
                     WHERE UserID LIKE @searchTerm
                     OR Name LIKE @searchTerm
                     OR Role LIKE @searchTerm
                     OR DistrictId LIKE @searchTerm
                     OR Email LIKE @searchTerm";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + Search + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching rows found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showprofilebutton_Click(object sender, EventArgs e)
        {

            string id = showProfiletextBox.Text.Trim();
            UpdateProfile f4 = new UpdateProfile(int.Parse(id));
            f4.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
