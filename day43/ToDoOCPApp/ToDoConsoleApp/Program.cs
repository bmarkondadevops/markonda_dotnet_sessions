using ToDoClassLibrary.Models;

namespace ToDoConsoleApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var dbConnectionProvider = new SqlServerDbConnectionProvider("Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;Trust Server Certificate=True");
            var toDoItemRepository = new SqlServerToDoItemRepository(dbConnectionProvider);

            SqlServerToDoItemRepository repository = new SqlServerToDoItemRepository(dbConnectionProvider);

            while (true)
            {
                Console.WriteLine("1. Create ToDo Item");
                Console.WriteLine("2. Read ToDo Items");
                Console.WriteLine("3. Update ToDo Item");
                Console.WriteLine("4. Delete ToDo Item");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                var option = Console.ReadLine();

               

              

                switch (option)
                {
                   
                    case "1":
                        Console.WriteLine("Enter title");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Description");
                        string description = Console.ReadLine();

                        repository.CreateToDoItem(description, "Automation");
                        break;
                    case "2":
                        repository.ReadToDoItems();
                        break;

                    case "3":
                        Console.WriteLine("Enter Id");
                        int Id = System.Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter title");
                        string title1 = Console.ReadLine();

                        Console.WriteLine("Enter Description");
                        string description1 = Console.ReadLine();

                        repository.UpdateToDoItem(Id, title1, description1);
                        break;

                    case "4":
                        Console.WriteLine("Enter Id");
                        int deleteId = System.Convert.ToInt32(Console.ReadLine());

                        repository.DeleteToDoItem(deleteId);
                        break;

                    case "5":                        
                        return;

                    default:
                        Console.WriteLine("Please enter only(1..5) only");
                        break;
                }

            }
        }
    }
}
