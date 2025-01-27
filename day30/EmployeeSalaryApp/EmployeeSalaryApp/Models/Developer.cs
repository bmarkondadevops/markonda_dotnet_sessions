using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp.Models
{
    internal class Developer : Employee
    {
        private const double PercentageOfBasicForAllowances = 0.40;

        public Developer(string name, int employeeId, double basicSalary) : base(name, employeeId, basicSalary)
        {
        }
        //Override methods if needed for Developer specific rates or allowances.

        public override double CalculateHRA()
        {
            return BasicSalary * 0.20;
        }

        public override double CalculateDA()

        {
            return BasicSalary * 0.15;
        }

        public override double CalculatePerformanceAllowance()

        {
            return 30000;
        }

        //Implementingtheabstractmethod.

        public override double CalculateTotalSalary()

        {
            var hra = CalculateHRA();
            var da = CalculateDA();
            var performanceallowance = CalculatePerformanceAllowance();
            return BasicSalary + hra + da + performanceallowance;

        }


    }
}
