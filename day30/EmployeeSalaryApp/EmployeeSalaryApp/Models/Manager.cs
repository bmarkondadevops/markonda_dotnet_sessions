using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp.Models
{
    internal class Manager : Employee
    {
        private const double PercentageOfBasicForAllowances = 0.50;

        public Manager(string name, int employeeId, double basicSalary) : base(name, employeeId, basicSalary)
        {
        }
        public override double CalculateHRA()
        {
            return BasicSalary * 0.25;
        }

        public override double CalculateDA()
        {
            return BasicSalary * 0.18; 
        }

        public override double CalculatePerformanceAllowance()
        {
            return 50000; 
        }

        // Implementing the abstract method.

        public override double CalculateTotalSalary()
        {
            var hra = CalculateHRA();
            var da = CalculateDA();
            var performanceAllowance = CalculatePerformanceAllowance();

            return BasicSalary + hra + da + performanceAllowance;
        }
    }
}
