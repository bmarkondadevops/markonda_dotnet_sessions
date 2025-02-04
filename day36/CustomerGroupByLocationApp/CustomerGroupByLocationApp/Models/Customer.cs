using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerGroupByLocationApp.Models
{
    public class Customer
    {
        public string _name { get; set; }
        public string _location { get; set; }

        public Customer(string name, string location)
        {
            _name = name;
            _location = location;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Location: {_location}";
        }
    }
}
