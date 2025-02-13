using Microsoft.Data.SqlClient;

namespace SQLInjectionUserApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;Trust Server Certificate=True";

            string username = "user1";
            string password = "password1";

            // Safe way using parameters
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"UserId: {reader["UserId"]}, Username: {reader["Username"]}, Password: {reader["Password"]}");
                }

                reader.Close();
            }




            //var con = new SqlConnection(connectionString);
            //con.Open();
            //Console.WriteLine("connection opened connected to ");
            //Console.WriteLine(con.Database);
            //Console.WriteLine("conneciton state is ");
            //Console.WriteLine(con.State);
            //con.Close();
        }
    }
}
