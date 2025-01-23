using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityApp.Models
{
    internal class Employee
    {

        private readonly int _id;
        private readonly string _name;
        public readonly double _salary;

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
        }

        public int Id
        {
            get { return _id; }

        }

        public string Name
        {
            get { return _name; }

        }
        public double Salary
        {
            get { return _salary; }

        }

        public override string ToString()
        {
            return $" Id ==> {_id} , Name ==> {_name} , Salary {_salary} , base implement : {base.ToString()}";
        }

        public override bool Equals(object obj)
        {

            var second = (Employee)obj;
            return this._id == second._id
                && this._name == second._name
               ;
        }

    }
}
