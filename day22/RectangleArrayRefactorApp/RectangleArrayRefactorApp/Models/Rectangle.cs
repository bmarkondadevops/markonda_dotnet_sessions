using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArrayRefactorApp.Models
{

    public enum Color { Red, Blue, Green }
    internal class Rectangle
    {

        private int _width;
        private int _height;
        private const int MIN_DIMENSION = 10;
        private const int MAX_DIMENSION = 50;
       

        public Rectangle(int width, int height, Color _color)
        {
            _width = width;
            _height = height;
            
        }
        // Method to calculate the area of the rectangle
        public float CalculateArea()
        {
            return _width * _width;
        }


        //Setter and getter methods
        public void SetWidth(int pwidth)
        {
            _width = CorrectTheDimension(pwidth);
        }//writer


        public int GetWidth()//reader
        {
            return _width;
        }

        public void SetHeight(int pheight)
        {
            _height = CorrectTheDimension(pheight);
        }

        public int GetHeight()
        {
            return _height;
        }

        private Color Color { get; set; }

        private int CorrectTheDimension(int dimension)
        {
            if (dimension < MIN_DIMENSION)
            {
                return MIN_DIMENSION;
            }

            if (dimension > MAX_DIMENSION)
            {
                return MAX_DIMENSION;
            }

            return dimension;
        }

        // Override ToString for better output
        public override string ToString()
        {
            return $"Width: {_width}, Height: {_height}, Color: {Color}, Area: {CalculateArea()}";
        }
    }
}
