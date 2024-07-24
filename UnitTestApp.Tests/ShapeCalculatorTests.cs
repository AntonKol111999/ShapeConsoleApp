using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using Xunit;

namespace UnitTestApp.Tests
{
    public class ShapeCalculatorTests
    {
        [Fact]
        public void CalculateArea_Circle_ShouldReturnCorrectArea()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;

            double actualArea = ShapeCalculator.CalculateArea(circle);

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CalculateArea_Triangle_ShouldReturnCorrectArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            double actualArea = ShapeCalculator.CalculateArea(triangle);

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CalculateArea_UnsupportedShape_ShouldThrowException()
        {
            Shape invalidShape = new Shape();

            Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateArea(invalidShape));
        }
    }
}
