using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLib.Shapes;
using Xunit;

namespace ShapeLibTests.Shapes
{
    public class TriangleTests
    {
        [Fact]
        public void IsRightAngled_ReturnsTrue()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightAngled_ReturnsFalse()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 6.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }
    }
}
