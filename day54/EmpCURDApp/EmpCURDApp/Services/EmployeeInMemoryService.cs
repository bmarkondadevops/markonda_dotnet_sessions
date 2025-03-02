using System.Security.Cryptography.X509Certificates;
using EmpCURDApp.Domain;

namespace EmpCURDApp.Services
{
    public class EmployeeInMemoryService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeInMemoryService()
        {
            Console.WriteLine("Employee service created");
            _employees = new List<Employee>();
            _employees.Add(new Employee { Id = 1, Name = "Markonda", Salary = 1000 });
            _employees.Add(new Employee { Id = 2, Name = "Ram", Salary = 2000 });
            _employees.Add(new Employee { Id = 3, Name = "Kannan", Salary = 5000 });
            _employees.Add(new Employee { Id = 4, Name = "Preethi", Salary = 6000 });

        }
        public IEnumerable<Employee> Get()
        {

            return _employees;
        }
        public int HeadCount()
        {
            return _employees.Count();
        }

        public Employee GetById(int id)
        {
            return _employees.SingleOrDefault(e => e.Id == id);

        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Update(Employee employee)
        {
            var emp = GetById(employee.Id);
            if (emp != null)
            {
                emp.Salary = employee.Salary;
                emp.Name = employee.Name;
            }
            else
                throw new Exception("Employee Was not found");

        }

        public void Remove(int id)
        {
            var emp = GetById(id);
            if (emp != null)
                _employees.Remove(emp);
            else

                throw new Exception("Employee Was not found");


        }
    }

}
