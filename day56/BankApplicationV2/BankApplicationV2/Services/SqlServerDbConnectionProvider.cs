

using Microsoft.Data.SqlClient;

namespace BankApplicationV2.Models
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
