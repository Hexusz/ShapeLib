using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            return Math.PI * radius * radius;
        }
    }
}
