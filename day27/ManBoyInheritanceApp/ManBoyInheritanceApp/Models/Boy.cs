using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Models
{
    internal class Boy : Man
    {

        public override void Play() {

            Console.WriteLine("Boy plays ");
        }

        public void Eat() {

            Console.WriteLine("Boy eats burger..");

        }
    }
}
