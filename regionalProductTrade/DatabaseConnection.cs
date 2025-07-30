using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regionalProductTrade
{
    class DatabaseConnection
    {
        public static readonly string ConnectionString = "data source=ARAFAT\\SQLEXPRESS; initial catalog=regionalProductTrade; user id=sa; password=@SerFC#Pj27@;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
