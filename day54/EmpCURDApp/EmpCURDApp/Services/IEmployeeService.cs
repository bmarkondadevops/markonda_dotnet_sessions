using EmpCURDApp.Domain;

namespace EmpCURDApp.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        IEnumerable<Employee> Get();
        Employee GetById(int id);
        int HeadCount();
        void Remove(int id);
        void Update(Employee employee);
    }
}