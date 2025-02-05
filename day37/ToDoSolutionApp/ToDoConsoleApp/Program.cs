using ToDoClassLibrary.BusinessLayer;

namespace ToDoConsoleApp
{
    internal class Program
    {
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
                        DisplayToDos(todoManager);
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
            }
        }
    }
}
