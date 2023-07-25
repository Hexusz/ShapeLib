using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib.Interfaces;

namespace ShapeLib.Shapes
{
    public class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double GetArea()
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Не все стороны треугольника положительны");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("Такого треугольника не может существовать");

            // Формула Герона
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public bool IsRightAngled()
        {
            double maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            double sumSquares = 0;

            if (maxSide == sideA)
            {
                sumSquares = sideB * sideB + sideC * sideC;
            }
            else if (maxSide == sideB)
            {
                sumSquares = sideA * sideA + sideC * sideC;
            }
            else
            {
                sumSquares = sideA * sideA + sideB * sideB;
            }

            return Math.Abs(maxSide * maxSide - sumSquares) < double.Epsilon;
        }
    }
}
