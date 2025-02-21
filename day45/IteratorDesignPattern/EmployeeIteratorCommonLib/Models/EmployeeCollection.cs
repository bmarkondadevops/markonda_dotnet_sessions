using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIteratorCommonLib.Models
{
    public class EmployeeCollection : IAbstractCollection
    {
        private List<Employee> listEmployees = new List<Employee>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return listEmployees.Count; }
        }

        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }

        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}