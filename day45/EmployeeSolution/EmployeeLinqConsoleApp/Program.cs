using EmployeeClassLibrary.Models;

namespace EmployeeLinqConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpNo = 1, EName = "Smith", Job = "CLERK", Mgr = null, HireDate = DateTime.Parse("1980-12-17"), Sal = 800, Comm = null, DeptNo = 20 },
            new Employee { EmpNo = 2, EName = "Allen", Job = "SALESMAN", Mgr = 1, HireDate = DateTime.Parse("1981-02-20"), Sal = 1600, Comm = 300, DeptNo = 30 },
            new Employee { EmpNo = 3, EName = "Ward", Job = "SALESMAN", Mgr = 1, HireDate = DateTime.Parse("1981-02-22"), Sal = 1250, Comm = 500, DeptNo = 30 },
            new Employee { EmpNo = 4, EName = "Jones", Job = "MANAGER", Mgr = null, HireDate = DateTime.Parse("1981-04-02"), Sal = 2975, Comm = null, DeptNo = 20 },
            new Employee { EmpNo = 5, EName = "King", Job = "PRESIDENT", Mgr = null,HireDate=DateTime.Parse("1981-11-17"),Sal=5000 ,Comm=null ,DeptNo=10},
            // Add more employees here...
        };

            // LINQ Queries

            // 1. Employees in deptno 10
            Console.WriteLine("Employees in deptno 10:");
            var empInDept10 = employees.Where(e => e.DeptNo == 10);

            foreach (var emp in empInDept10)
            {
                Console.WriteLine(emp.ToString());
            }

            // 2. Employee whose name is "King"
            Console.WriteLine("\nEmployee whose name is 'King':");
            var kingEmployee = employees.FirstOrDefault(e => e.EName == "King");
            if (kingEmployee != null)
            {
                Console.WriteLine(kingEmployee.ToString());
            }

            // 3. Display all employees who are managers
            Console.WriteLine("\nEmployees who are managers:");
            var managerEmployees = employees.Where(e => e.Job == "MANAGER");
            foreach (var managerEmp in managerEmployees)
            {
                Console.WriteLine(managerEmp.ToString());
            }


            // Convert SQL queries to LINQ queries:

            // SQL Query: SELECT * FROM EMP WHERE DEPTNO=10;
            // LINQ Query:
            //var sqlQuery1 = employees.Where(e => e.DeptNo == 10);

            // SQL Query: SELECT * FROM EMP WHERE ENAME='King';
            // LINQ Query:
           // var sqlQuery2 = employees.FirstOrDefault(e => e.EName == "King");


        }
    }
}
