using System;
using System.Security.Principal;
using EmployeeSalaryApp.Models;

namespace EmployeeSalaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Manager("Lakshmi",234512,40000);
            PrintSalarySlip(emp);

            emp = new Developer("Markonda", 22863,35000);
            PrintSalarySlip(emp);            

        }

        static void PrintSalarySlip(Employee emp)
        {

            var totalSalary = emp.CalculateTotalSalary();
            var calculateHRA = emp.CalculateHRA();
            var calculateDA = emp.CalculateDA();


            Console.WriteLine($"Employee name::{emp.Name}" +
                $"\nEmployee ID::{emp.EmployeeId}" +
                $"\nBasic Salary::{emp.BasicSalary}" +
                $"\nBasic Salary::{calculateHRA}" +
                $"\nBasic Salary::{calculateDA}" +
                $"\nTotal Salary::{totalSalary}");              

            Console.WriteLine("");
        }
    }
}
