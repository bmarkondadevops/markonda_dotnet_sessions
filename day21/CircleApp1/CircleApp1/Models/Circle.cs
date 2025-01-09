using System;


namespace CircleApp1.Models
{
    internal class Circle
    {
        private float radius;
        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public float CalculateArea()
        {
            return (float)Math.PI * (radius * radius);
        }
    }
}
