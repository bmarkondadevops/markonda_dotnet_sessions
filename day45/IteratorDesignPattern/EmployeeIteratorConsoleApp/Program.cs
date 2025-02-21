
using EmployeeIteratorCommonLib.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeCollection collection = new EmployeeCollection();
        collection.AddEmployee(new Employee("Markonda", 22863));
        collection.AddEmployee(new Employee("Kannan", 22864));
        collection.AddEmployee(new Employee("Akhilesh", 105478));
        collection.AddEmployee(new Employee("Preethi", 67434));
        collection.AddEmployee(new Employee("Minu", 34525));

        Iterator iterator = collection.CreateIterator();

        Console.WriteLine("Iterating over collection:\n=========================\n");

        for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
        {
            Console.WriteLine($"Employee ID : {emp.ID} ==> Employee Name : {emp.Name}");
        }
    }
}