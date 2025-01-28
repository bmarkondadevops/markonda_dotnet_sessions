using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExerciseApp.Models
{
    public class Boy : IEmotionable, IMannerable
    {
        public void Cry()
        {
            Console.WriteLine("Calling Cry() method from IEmotionable Interface");
        }

        public void Depart()
        {
            Console.WriteLine("Calling Depart() method from IMannerable Interface");
        }

        public void Laugh()
        {
            Console.WriteLine("Calling Laugh() method from IEmotionable Interface");
        }

        public void Wish()
        {
            Console.WriteLine("Calling Wish() method from IMannerable Interface");
        }
    }
}

