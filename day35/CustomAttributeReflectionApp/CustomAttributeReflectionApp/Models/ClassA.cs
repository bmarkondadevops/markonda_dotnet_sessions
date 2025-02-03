using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeReflectionApp.Models
{
    public class ClassA
    {

        [NeedsAttention("Method M1 needs urgent attention")]
        public void M1()
        {
            Console.WriteLine("Method M1");
        }

        [NeedsAttention("Method M2 needs urgent attention")]
        public void M2()
        {
            Console.WriteLine("Method M2");
        }

        public void M3()
        {
            Console.WriteLine("Method M3");
        }

        [NeedsAttention("Method M4 needs urgent attention")]
        public void M4()
        {
            Console.WriteLine("Method M4");
        }
    }
}
