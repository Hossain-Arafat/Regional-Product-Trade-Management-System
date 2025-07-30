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
    public partial class BuyerViewProduct : Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int id;
        public BuyerViewProduct(int buyerId)
        {
            id = buyerId;
            InitializeComponent();
            string query = "SELECT ProductId, Name, Price, Quantity FROM Product";
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
        private void searchbutton_Click(object sender, EventArgs e)
        {
            string Search = searchtextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(Search))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"SELECT ProductId, Name, Price, Quantity FROM Product
                 WHERE CAST(ProductId AS NVARCHAR) LIKE @searchTerm
                 OR Name LIKE @searchTerm
                 OR CAST(Price AS NVARCHAR) LIKE @searchTerm
                 OR CAST(Quantity AS NVARCHAR) LIKE @searchTerm";



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

        private void showprofilebutton_Click(object sender, EventArgs e)
        {
            string productid = ShowProducttextBox.Text.Trim();
            ProductDetails f5 = new ProductDetails(int.Parse(productid),id);
            f5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowProducttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
