using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArrayApp.Models
{
    // Enum for colors
    public enum Color { Red, Blue, Green }

    internal class Rectangle
    {

        private float Width { get; set; }
        private float Height { get; set; }
        private Color Color { get; set; }

        // Constructor to initialize a Rectangle
        public Rectangle(float width, float height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        // Method to calculate the area of the rectangle
        public float CalculateArea()
        {
            return Width * Height;
        }

        // Override ToString for better output
        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}, Color: {Color}, Area: {CalculateArea()}";
        }


    }
}
