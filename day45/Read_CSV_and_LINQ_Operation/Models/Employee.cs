using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_CSV_and_GroupingOperation.Models
{
    internal class Employee
    {
       
        public int EmpNo { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeJob { get; set; }
        public string EmployeeMGRID {  get; set; }
        public string DateofJoining { get; set; }
        public string EmployeeSalary { get; set; }
        public string EmployeeCommision {  get; set; }
        public string EmployeeDepartmentNo { get; set; }

        public override int GetHashCode()
        {
            return EmpNo;
        }

        public override bool Equals(object obj)
        {
            Employee second = (Employee)obj;
            if (this.EmpNo == second.EmpNo)
            {
                return true;
            }
            return false;
        }


    }
}
