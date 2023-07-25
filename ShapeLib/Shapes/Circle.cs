using System;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
