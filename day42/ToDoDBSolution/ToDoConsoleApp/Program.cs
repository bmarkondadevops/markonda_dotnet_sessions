using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text.Json;
using ToDoClassLibrary.Models;

namespace ToDoConsoleApp
{
    internal class Program
    {
        //private static string connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;";

        [Obsolete]
        static void Main(string[] args)
        {

            //Create instance ToDoManager();
            var todoManager = new ToDoManager();

            while (true)
            {
                //Screen visibility options
                Console.WriteLine("TodoApp");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display ToDos");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddToDo(todoManager);
                        break;
                    case "2":
                        // DisplayToDos(todoManager);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }

                Console.WriteLine();

                static void AddToDo(ToDoManager todoManager)
                {
                    Console.Write("Enter ToDo Description: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("description:" + description);

                    Console.Write("Enter ToDoo Priority (High/Medium/Low): ");
                    string priority = Console.ReadLine();
                    Console.WriteLine("priority:" + priority);

                    string connectionString = "Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;";
                    var con = new SqlConnection(connectionString);
                    try
                    {
                        con.Open();
                        string query =$"INSERT INTO ToDo (Description, Priority) VALUES ('{description}','{priority}')";
                        // var cmd = new SqlCommand($"insert into ToDo (Description,Priority) values ('{description}','{priority}')", con);
                        var cmd = new SqlCommand(query, con);
                        Console.WriteLine("Connection open");
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Successfully inserted.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }


            }

        }
    }

}



