using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SQLInjectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // caseStudy1();

            caseStudy2();
        }

        private static void caseStudy2()
        {
            var connectionString = "Data Source = CHLAPDMARKOND\\SQLEXPRESS; Initial Catalog = rrd_db1; Integrated Security = True";
            var con = new SqlConnection(connectionString);

            Console.WriteLine("Enter a product id :");
            var productId = Console.ReadLine();

            var cmd = new SqlCommand("select * from product where id = @paramProductId", con);//step1 create a parameter
            cmd.Parameters.AddWithValue("@paramProductId", productId);//step 2;
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
            }
            con.Close();
        }

        

        private static void caseStudy1()
        {
            var connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;";
            var con = new SqlConnection(connectionString);
            var cmd = new SqlCommand("select * from" +
                " product", con);
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"]);
                Console.WriteLine(reader["quantity"]);
                Console.WriteLine(reader["price"]);

            }
            con.Close();
        }
    }
}
