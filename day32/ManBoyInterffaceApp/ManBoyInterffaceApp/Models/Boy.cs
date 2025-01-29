using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterffaceApp.Models
{
    internal class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy crying..");
        }

    

        public void Laugh()
        {
            Console.WriteLine("Boy Loaughs..:-)..");
        }

        public void Wish()
        {
            Console.WriteLine("Boy wishing..hello");
        }
        public void Depart()
        {
            Console.WriteLine("Boy deparing..goodbye");
        }

        public void Eat() {
            Console.WriteLine("Boy is eating..");
        }
    }
}
