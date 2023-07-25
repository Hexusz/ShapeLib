using System;
using ShapeLib.Interfaces;
using ShapeLib.Shapes;
using Xunit;

namespace ShapeLibTests.Shapes
{
    public class CreateShapes
    {
        [Fact]
        public void CreateCircle_Success()
        {
            // Arrange
            IShape circle = new Circle(55.0);

            Circle circle2 = new Circle(55.0);

            // Act

            // Assert
            Assert.NotNull(circle);
            Assert.NotNull(circle2);
        }

        [Fact]
        public void CreateTriangle_Success()
        {
            // Arrange
            IShape triangle = new Triangle(3.0, 4.0, 5.0);

            Triangle triangle2 = new Triangle(3.0, 4.0, 5.0);

            // Act

            // Assert
            Assert.NotNull(triangle);
            Assert.NotNull(triangle2);
        }

        [Fact]
        public void CreateCircle_FailOnWrongInput()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => { IShape circle = new Circle(-55.0); });
            Assert.Throws<ArgumentException>(() => { Circle circle2 = new Circle(0); });
        }

        [Fact]
        public void CreateTriangle_FailOnWrongInput()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<ArgumentException>(() => { IShape triangle = new Triangle(-3.0, 4.0, 5.0); });
            Assert.Throws<ArgumentException>(() => { Triangle triangle = new Triangle(3.0, 455.0, 5.0); });
        }
    }
}
