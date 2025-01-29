using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterffaceApp.Models
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man departing..goodbye");
        }

        public void Wish()
        {
            Console.WriteLine("Man wishing..Hello");

        }

        public void Walk() {
            Console.WriteLine("Man walking");

        }
    }
}
