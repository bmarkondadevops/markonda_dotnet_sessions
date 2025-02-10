using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeTClassLibrary.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }
}
