using System;
using System.Security.Cryptography;

namespace RectangleWithPropertiesApp.Models
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private BorderOptions _borderStyle;

        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;

        //properties
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = CorrectTheDimension(value);

            }

        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = CorrectTheDimension(value);
            }

        }

        public int Area
        {

            get
            {
                return _width * _height;
            }
        }


        public BorderOptions BorderStyle
        {
            get
            {
                return _borderStyle;
            }
            set
            {
                _borderStyle = value;
            }
        }


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

    }
}
