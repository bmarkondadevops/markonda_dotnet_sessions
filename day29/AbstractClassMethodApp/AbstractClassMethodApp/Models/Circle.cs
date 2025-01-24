using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    internal class Circle:Shape
    {

        private double _radius;
        public Circle(double radius)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

    }
}
