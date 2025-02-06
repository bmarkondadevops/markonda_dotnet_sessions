using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using ToDoSerializationLib.Models;

namespace ToDoSerializationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoManager toDoManager = new ToDoManager();

            while (true)
            {
                Console.WriteLine("TodoApp");
                Console.WriteLine("1. Add Todo");
                Console.WriteLine("2. Display ToDos");
                Console.WriteLine("3. Serialize ToDos");
                Console.WriteLine("4. Deserialize ToDos");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                Console.WriteLine(option);

                switch (option)
                {
                    case "1":
                        AddToDo(toDoManager);
                        break;
                    case "2":
                        DisplayToDos(toDoManager);
                        break;
                    case "3":
                        SerializeToDos(toDoManager);
                        break;
                    case "4":
                        if (File.Exists(@"C:\temp\todos.json"))
                        {
                            toDoManager = DeserializeToDos();
                            Console.WriteLine("ToDos deserialized successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No serialized data found.");
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }
    
    static void AddToDo(ToDoManager todoManager)
        {
            Console.Write("Enter ToDo Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter ToDoo Priority (High/Medium/Low): ");
            string priority = Console.ReadLine();

            var todo = new ToDo(0, description, priority);
            todoManager.AddToDo(todo);

            Console.WriteLine("Todo added successfully.");
        }

        static void DisplayToDos(ToDoManager todoManager)
        {
            var todos = todoManager.GetToDos();

            if (todos.Count == 0)
            {
                Console.WriteLine("No todos available.");
            }
            else
            {
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo.ToString());
                }
            }
        }

        static void SerializeToDos(ToDoManager todoManager)
        {            
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(todoManager.GetToDos(), options);

            using (StreamWriter writer = new StreamWriter(@"C:\temp\todos.json"))
            {
                writer.Write(json);
            }

            Console.WriteLine("ToDos serialized successfully."); 

            /*
            var jsonString = JsonSerializer.Serialize(todoManager.GetToDos());
            Console.WriteLine(jsonString);
            var sw = new StreamWriter(@"C:\temp\cust1.json");
            sw.WriteLine(jsonString);
            sw.Close();
            Console.WriteLine("written to file"); */
        }

        static ToDoManager DeserializeToDos()
        {

            string json;
            using (StreamReader reader = new StreamReader(@"C:\temp\todos.json"))
            {
                json = reader.ReadToEnd();
                Console.WriteLine(json);
            }

            var todos = JsonSerializer.Deserialize<List<ToDo>>(json);

            var todoManager = new ToDoManager();
            foreach (var todo in todos)
            {
                // Adjust IDs if necessary
                //todo._id = 0; // Reset ID for re-assignment during AddToDo
                todoManager.AddToDo(todo);
            }

            /*
            var sw = new StringReader(@"C:\temp\todos.json");
            var jsonString = sw.ReadLine();

            Console.WriteLine($"{jsonString}");

            var todoManager=JsonSerializer.Deserialize<ToDoManager>(jsonString);
            */

            return todoManager;
        }
    }

}
