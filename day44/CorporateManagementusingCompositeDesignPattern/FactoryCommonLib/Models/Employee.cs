using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCommonLib.Models
{
    public class Employee : IManagement
    {
        public string Name { get; set; }

        public string Desigination { get; set; }

        public double Salary { get; set; }

        public Employee(string name,string desigination, double salary) 
        {
            Name = name;
            Desigination = desigination;
            Salary = salary;
        }
        public double CalculateCTCforTeam()
        {
            return Salary * 12;
        }
        //public void ShowDetails()
        //{
        //    Console.WriteLine($"Name : {Name}");
        //}

    }
}
