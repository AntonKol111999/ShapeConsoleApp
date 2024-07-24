using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using Xunit;

namespace UnitTestApp.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void AbstractCalculateArea_ShouldThrowException()
        {
            Shape shape = new Shape();

            Assert.Throws<NotImplementedException>(() => shape.CalculateArea());
        }
    }
}
