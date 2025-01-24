using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodApp.Models
{
    internal class Rectangle:Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height) { 
            this._width = width; 
            this._height = height;
         }

        // Implementing the abstract method
        public override double Area()
        {
           return _width * _height;
        }
    }
}
