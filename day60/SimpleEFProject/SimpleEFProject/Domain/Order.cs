using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFProject.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Customer Customer { get; set; }

    }
}
