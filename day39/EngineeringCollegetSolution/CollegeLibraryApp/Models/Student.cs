using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLibraryApp.Models
{
    public class Student : Person
    {
        public string Branch { get; set; }

        public Student(int id, string address, DateTime dob, string branch) : base(id, address, dob)
        {
            Branch = branch;
        }

        public override string ToString()
        {
            return base.ToString() + $", Branch: {Branch}";
        }
    }
}
