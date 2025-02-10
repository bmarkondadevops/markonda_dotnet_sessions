using NodeTClassLibrary.Models;

namespace NodeTConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employee instances
            var emp1 = new Employee("Markonda", 30, "IT");
            var emp2 = new Employee("Udhay", 25, "Marketing");
            var emp3 = new Employee("Subbu", 40, "Sales");

            // Create nodes of type Employee
            var first = new Node<Employee>(emp1);
            first.next = new Node<Employee>(emp2);
            first.next.next = new Node<Employee>(emp3);

            // Print details of all employees in the linked list
            PrintEmployeeDetails(first);
        }

        private static void PrintEmployeeDetails(Node<Employee> head)
        {
            while (head != null)
            {
                head.Data.PrintDetails();
                head = head.next;
            }
        }
    }
}
