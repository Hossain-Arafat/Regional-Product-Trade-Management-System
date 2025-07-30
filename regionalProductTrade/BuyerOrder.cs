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
    public partial class BuyerOrder: Form
    {
        string connectionString = DatabaseConnection.ConnectionString;
        int buyerid;
        public BuyerOrder(int id)
        {
            buyerid = id;
            InitializeComponent();
            LoadOrderHistory();
        }
        private void LoadOrderHistory()
        {
            string query = @"SELECT * FROM Orders WHERE BuyerId = @BuyerId ORDER BY OrderDate DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@BuyerId", buyerid);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p1 = new Payment();
            p1.ShowDialog();
        }
    }
}
