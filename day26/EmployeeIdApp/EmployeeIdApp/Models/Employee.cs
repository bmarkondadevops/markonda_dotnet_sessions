using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIdApp.Models
{
    internal class Employee
    {

        private readonly int _employeeId;
        public string _name;

        public Employee(int employeeId,string name) {
            this._employeeId = employeeId;
            this._name = name;
        }

        public int EmployeeId
        {
            get { return _employeeId; }
        }
        public string Name {
            get { return _name; }
        }

        // Instance method to display employee ID
        public void DisplayEmployeeIdInstance()
        {
            Console.WriteLine($"Employee ID using Instance Method: {EmployeeId}");
        }

        // Static method to display employee ID
        public static void DisplayEmployeeIdStatic(Employee employee)
        {
            if (employee != null)
            {
                Console.WriteLine($"Employee ID using Static Method: {employee.EmployeeId}");
            }
            else
            {
                Console.WriteLine("Employee object is null.");
            }
        }
    }
}
