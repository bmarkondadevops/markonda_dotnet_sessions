using System;
using System.Security.Cryptography;

namespace RectangelEncapsulationREfacotred.Models
{
    class Rectangle
    {

        private int _width;
        private int _height;
        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;
       


        public int CalculateArea()
        {
            return _width * _height;
        }

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
           _height =  CorrectTheDimension( pheight);
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


        public int GetHeight()
        {
            return _height;
        }
    }
}
