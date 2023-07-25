using System;
using System.Collections.Generic;
using ShapeLib.Interfaces;
using ShapeLib.Shapes;
using Xunit;

namespace ShapeLibTests.Shapes
{
    public class ShapesTests
    {
        [Theory]
        [InlineData(1.0, Math.PI)]
        [InlineData(0.4, 0.502654824574367)]
        [InlineData(5.0, 78.539816339744831)]
        public void CalculateArea_ValidCircle_ReturnsCorrectArea(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 15); // Точность до 15 знаков после запятой
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0, 6.0)]
        [InlineData(5.0, 12.0, 13.0, 30.0)]
        [InlineData(8.0, 15.0, 17.0, 60.0)]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            // Arrange
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, 15); // Точность до 15 знаков после запятой
        }
    }
}
