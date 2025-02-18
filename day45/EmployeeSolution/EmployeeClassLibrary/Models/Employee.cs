using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; } 
        public DateTime HireDate { get; set; }
        public decimal Sal { get; set; } 
        public decimal? Comm { get; set; } 
        public int DeptNo { get; set; }

        // Navigation property to Department (optional)
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"EmpNo: {EmpNo}, EName: {EName}, Job: {Job}, Mgr: {Mgr?.ToString() ?? "None"}, HireDate: {HireDate}, Sal: {Sal}, Comm: {Comm?.ToString() ?? "None"}, DeptNo: {DeptNo}";
        }
    }
}
