using Read_CSV_and_GroupingOperation.Models;
using System.Collections.Generic;

namespace Read_CSV_and_GroupingOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\emp_duplicate.csv";
            EmployeeMaster checkEmployeemaster = new EmployeeMaster();
            var uniqueEmployeeList= checkEmployeemaster.ReadFromCSVFile(filePath);

            SelectWhereEmployeeJobType(uniqueEmployeeList);

            SelectWhereEmployeeDeptNo(uniqueEmployeeList);

            FindWithEmployeeName(uniqueEmployeeList);


        }

        private static void FindWithEmployeeName(HashSet<Employee> uniqueEmployeeList)
        {
            var employee = uniqueEmployeeList.Single(x => x.EmployeeName == "KING");
            Console.WriteLine("select employee Name is King");
            Console.WriteLine($"{employee.EmpNo} | {employee.EmployeeName} | {employee.EmployeeMGRID} | {employee.EmployeeSalary} |{employee.EmployeeJob} |{employee.EmployeeDepartmentNo}");
        }

        private static void SelectWhereEmployeeDeptNo(HashSet<Employee> uniqueEmployeeList)
        {
            var DeptList = uniqueEmployeeList.Where(e => e.EmployeeDepartmentNo.Contains("10")).AsEnumerable();
            var enumerator = DeptList.GetEnumerator();
            Console.WriteLine("Select Dept where dept Id=10");
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                Console.WriteLine($"{employee.EmpNo} | {employee.EmployeeName} | {employee.EmployeeMGRID} | {employee.EmployeeSalary} |{employee.EmployeeJob} |{employee.EmployeeDepartmentNo}");
            }
        }

        private static void SelectWhereEmployeeJobType(HashSet<Employee> uniqueEmployeeList)
        {
            Console.WriteLine("Select Manager from list");
            var ManagerIdList = uniqueEmployeeList.Where(e => e.EmployeeJob.Contains("MANAGER")).AsEnumerable();
            var enumerator = ManagerIdList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                Console.WriteLine($"{employee.EmpNo} | {employee.EmployeeName} | {employee.EmployeeMGRID} | {employee.EmployeeSalary} |{employee.EmployeeJob}");
            }

        }

       
    }
}
