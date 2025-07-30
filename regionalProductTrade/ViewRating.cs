using System;
using System.Collections;
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
    public partial class ViewRating: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int sellerid;
        public ViewRating(int id)
        {
            sellerid = id;
            InitializeComponent();
            string query = "SELECT * FROM Rating WHERE SellerId = @SellerId";
            FillDataGridView(query);
            LoadRating();
        }
        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@SellerId", sellerid);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }
        private void LoadRating()
        {
            string query = "SELECT SellerId, Rating FROM Rating WHERE SellerId = @SellerId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SellerId", sellerid);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    int totalRating = 0;
                    int count = 0;

                    while (reader.Read())
                    {
                        totalRating += Convert.ToInt32(reader["Rating"]);
                        count++;
                    }

                    if (count > 0)
                    {
                        double average = (double)totalRating / count;
                        textBox1.Text = average.ToString("0.00");
                    }
                    else
                    {
                        textBox1.Text = "No Ratings Yet";
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
