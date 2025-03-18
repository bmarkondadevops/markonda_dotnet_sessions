using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFProject.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; } = "";

        public string City { get; set; } = "";

        public ICollection<Order> Orders { get; set; }=new List<Order>();

    }
}
