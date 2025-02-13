using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BankClassLibrary.Models
{
    public class SqlServerDbConnectionProvider :IDbConnectionProvider
    {
        private readonly string _connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;Trust Server Certificate=True";

        public SqlServerDbConnectionProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

       
    }
}
