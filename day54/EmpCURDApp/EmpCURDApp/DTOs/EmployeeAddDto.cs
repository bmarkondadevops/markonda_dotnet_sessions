using System.ComponentModel.DataAnnotations;
using EmpCURDApp.Domain;

namespace EmpCURDApp.DTOs
{
    public class EmployeeAddDto
    {
        public int Count { get; set; }
        public string HeaderTitle { get; set; }
        public string Message { get; set; } = "";
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public double Salary { get; set; }
    }
}
