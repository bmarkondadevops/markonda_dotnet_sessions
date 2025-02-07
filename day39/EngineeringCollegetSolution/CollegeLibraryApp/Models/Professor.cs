using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLibraryApp.Models
{
    public class Professor:Person
    {
        public double BaseSalary { get; set; }
        public double Allowance { get; set; }
        public double Deduction { get; set; }

        public Professor(int id, string address, DateTime dob, double baseSalary, double allowance, double deduction)
            : base(id, address, dob)
        {
            BaseSalary = baseSalary;
            Allowance = allowance;
            Deduction = deduction;
        }

        public double CalculateSalary()
        {
            return BaseSalary + Allowance - Deduction;
        }

        public override string ToString()
        {
            return base.ToString() + $", Base Salary: {BaseSalary}, Allowance: {Allowance}, Deduction: {Deduction}, Total Salary: {CalculateSalary()}";
        }
    }
}
