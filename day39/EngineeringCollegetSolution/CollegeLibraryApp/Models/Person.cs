using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLibraryApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

        public Person(int id, string address, DateTime dob)
        {
            this.Id = id;
            this.Address = address;
            this.DOB = dob;
        }
        public override string ToString()
        {

            return $"Id: {Id}, Address: {Address}, DOB: {DOB.ToString("yyyy-MM-dd")}";
        }
    }

}
