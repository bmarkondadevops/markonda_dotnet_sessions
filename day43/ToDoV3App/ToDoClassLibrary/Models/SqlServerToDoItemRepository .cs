using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ToDoClassLibrary.Models
{
    public class SqlServerToDoItemRepository : IToDoItemRepository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public SqlServerToDoItemRepository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }
        public void CreateToDoItem(string title, string description)
        {
            try
            {
                using (var connection = _connectionProvider.GetConnection())
                {
                    connection.Open();

                    var command = new SqlCommand("INSERT INTO ToDoItems (Title, Description) VALUES (@Title, @Description)", connection);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    command.ExecuteNonQuery();

                    Console.WriteLine("ToDo item created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteToDoItem(int id)
        {
            try
            {
                using (var connection = _connectionProvider.GetConnection())
                {
                    connection.Open();

                    var command = new SqlCommand("DELETE FROM ToDoItems WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("ToDo item deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No such ToDo item found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ReadToDoItems()
        {
            try
            {
                using (var connection = _connectionProvider.GetConnection())
                {
                    connection.Open();

                    var command = new SqlCommand("SELECT * FROM ToDoItems", connection);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Title: {reader["Title"]}, Description: {reader["Description"]}, IsCompleted: {reader["IsCompleted"]}");
                        }
                    }

                    Console.WriteLine("ToDo items read successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateToDoItem(int id, string title, string description)
        {
            try
            {
                using (var connection = _connectionProvider.GetConnection())
                {
                    connection.Open();

                    var command = new SqlCommand("UPDATE ToDoItems SET Title = COALESCE(@Title, Title), Description = COALESCE(@Description, Description) WHERE Id = @Id", connection);
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Title", string.IsNullOrEmpty(title) ? DBNull.Value : title);
                    command.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? DBNull.Value : description);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        Console.WriteLine("ToDo item updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No such ToDo item found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
