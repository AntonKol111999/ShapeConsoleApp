using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using Xunit;

namespace UnitTestApp.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectAreaForRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5); 
            double expectedArea = 6;

            double actualArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 0.001);
        }

        [Fact]
        public void CalculateArea_ShouldReturnCorrectAreaForGeneralTriangle()
        {
            Triangle triangle = new Triangle(7, 2, 8);
            double expectedArea = 6.4934; 

            double actualArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 0.001);
        }
    }
}
