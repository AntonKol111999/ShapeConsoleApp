using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using Xunit;

namespace UnitTestApp.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;

            double actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, 0.001); 
        }
    }
}
