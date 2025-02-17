using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCommonLib.Models
{
    public class Manager : IManagement
    {
        public  string Name { get; set; }
        public  string Desigination { get; set; }

        public  double Salary { get; set; }
       
        public List<IManagement> _person = new List<IManagement>();
        //public List<Employee> _employees = new List<Employee>();
        public Manager(string name, string desigination, double salary, List<IManagement> person) 
        {
            Name = name;
            Desigination = desigination;
            Salary = salary;
            _person.AddRange(person);

        }


        public double CalculateCTCforTeam()=>_person.Sum(person => person.CalculateCTCforTeam());

        //public void ShowDetails()
        //{
        //    foreach (var employee in _employees)
        //    {
        //        Console.WriteLine(employee.Name);
        //    }
        //}
    }
}
