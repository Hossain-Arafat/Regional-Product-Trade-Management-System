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
    public partial class AdminViewOrder: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        public AdminViewOrder()
        {
            InitializeComponent();
            string query = "SELECT * FROM Orders";
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

            string query = @"SELECT * FROM Orders
                           WHERE CAST(OrderId AS NVARCHAR) LIKE @searchTerm
                           OR CAST(BuyerId AS NVARCHAR) LIKE @searchTerm
                           OR CAST(SellerId AS NVARCHAR) LIKE @searchTerm
                           OR CAST(OrderQuantity AS NVARCHAR) LIKE @searchTerm
                           OR CAST(UnitPrice AS NVARCHAR) LIKE @searchTerm
                           OR CAST(TotalAmount AS NVARCHAR) LIKE @searchTerm
                           OR Status LIKE @searchTerm";


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
    }
}
