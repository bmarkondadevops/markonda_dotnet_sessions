using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
    internal class Man:Object
    {
        //can be orverriden 
        public virtual void Play() { //by default not ovrridable in C#

            Console.WriteLine("Man is  playing ");
        }

        public void Read() {


            Console.WriteLine("Man is reading books..");
        }
    }
}
