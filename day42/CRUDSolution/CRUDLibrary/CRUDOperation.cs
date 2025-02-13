using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace CRUDLibrary
{

    public class CRUDOperation : IProduct
    {
        private static string connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;Trust Server Certificate=True";
        private readonly object productId;



        public void InsertProduct(Products product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Products (ProductName, Price) VALUES (@ProductName, @Price)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);

                command.ExecuteNonQuery();

                Console.WriteLine("One product inserted successfully");


            }
        }
        public void DeleteProduct()

        {
            Console.WriteLine("Enter productID");
            int productId = System.Convert.ToInt32(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Products WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductID", productId);

                int b = command.ExecuteNonQuery();

                if (b > 0)
                    Console.WriteLine($"Given productID:{productId} deleted successfully");

                else
                    Console.WriteLine($"Given productId :{productId} not exist in the Products");

            }
        }


        public List<Products> GetAllProducts()
        {
            List<Products> products = new List<Products>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ProductID, ProductName, Price FROM Products";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Products product = new Products
                    {
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"])
                    };

                    products.Add(product);
                }

                reader.Close();
            }

            return products;

        }
        public void UpdateProduct(Products product)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Products SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ProductID", product.ProductID);
                command.Parameters.AddWithValue("@ProductName", product.ProductName);
                command.Parameters.AddWithValue("@Price", product.Price);

                command.ExecuteNonQuery();

                Console.WriteLine("product updated successfully");
            }
        }

        public void UpdateProduct(int product)
        {
            throw new NotImplementedException();
        }
    }
}
