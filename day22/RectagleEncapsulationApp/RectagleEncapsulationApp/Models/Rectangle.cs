

using System.Diagnostics.Tracing;

namespace RectagleEncapsulationApp
{
    internal class Rectangle
    {
        private int width;
        private int height;


        public int CalculateArea()
        {
            return width * height;
        }

        public void CanYouSetWidth(int pwidth)
        {

            if (pwidth > 100)
            {
                width = 100;
            }
            else if (pwidth < 0)
            {
                width = 1;
            }

            else
            {
                width = pwidth;
            }
        }//writer


        public int CanYouGetWidth()//reader
        {
            return width;
        }

        public void CanYouSetHeight(int pheight)
        {
            if (pheight > 100)
            {
                height = 100;
            }
            else if (pheight < 1)
            {
                height = 1;
            }
            else
            {
                height = pheight;
            }
        }

        public int CanYouGetHeight()
        {
            return height;
        }

    }
}
