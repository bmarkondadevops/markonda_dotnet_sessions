using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    public abstract class Shape
    {

        //Abstract method
        public abstract double Area();

        //// Non-abstract method (optional)
        public void DisplayShape() {
            Console.WriteLine("This is a shape.");
        }

    }
}
