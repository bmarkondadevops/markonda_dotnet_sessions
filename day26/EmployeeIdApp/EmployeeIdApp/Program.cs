using System;
using EmployeeIdApp.Models;

namespace EmployeeIdApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee emp = new Employee(22863,"markonda");           

            // Using instance method
            emp.DisplayEmployeeIdInstance();

            // Using static method
            Employee.DisplayEmployeeIdStatic(emp);

           
        }
    }
}
