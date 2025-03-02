using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankpplication.Models;
using Microsoft.Data.SqlClient;

namespace Bankpplication.Models
{
    public class SqlServerDbConnectionProvider : IDbConnectionProvider
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
