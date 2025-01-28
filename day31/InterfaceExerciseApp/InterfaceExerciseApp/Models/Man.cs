using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExerciseApp.Models
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Calling Depart() method from IMannerable Interface");
        }

        public void Wish()
        {
            Console.WriteLine("Calling Wish() method from IMannerable Interface");
        }
    }
}
