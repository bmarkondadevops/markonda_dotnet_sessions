using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp.Models
{
    internal abstract class Employee
    {

        private string _name;
        private int _employeeId;
        private double _basicSalary;

        public Employee(string name, int employeeId, double basicSalary) { 
            this._name = name;
            this._employeeId = employeeId;
            this._basicSalary = basicSalary;
        }   
        public string Name { get { return _name; } }

        public int EmployeeId { get { return _employeeId; } }

        public double BasicSalary { get { return _basicSalary; } }

        
        public virtual double CalculateHRA()
        {
            return BasicSalary * 0.20; 
        }

        //calculate DA
        public virtual double CalculateDA()
        {
            return BasicSalary * 0.15; 
        }

        // Calculate Performance Allowance
        public virtual double CalculatePerformanceAllowance()
        {
            return 20000; 
        }

        // Abstract Method to calculate total salary
        public abstract double CalculateTotalSalary();

    }
}
