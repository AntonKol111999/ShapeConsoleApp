using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class ShapeCalculator
    {
        public static double CalculateArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }

        public static double CalculateArea(Triangle triangle)
        {            
            double s = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2;
            return Math.Sqrt(s * (s - triangle.Side1) * (s - triangle.Side2) * (s - triangle.Side3));
        }

        public static double CalculateArea(Shape shape)
        {
            if (shape is Circle circle)
            {
                return CalculateArea(circle);
            }
            else if (shape is Triangle triangle)
            {
                return CalculateArea(triangle);
            }
            else
            {
                throw new ArgumentException("Unsupported shape type.");
            }
        }

        public static bool IsRightTriangle(Triangle triangle)
        {            
            return Math.Pow(triangle.Side1, 2) == Math.Pow(triangle.Side2, 2) + Math.Pow(triangle.Side3, 2) ||
                   Math.Pow(triangle.Side2, 2) == Math.Pow(triangle.Side1, 2) + Math.Pow(triangle.Side3, 2) ||
                   Math.Pow(triangle.Side3, 2) == Math.Pow(triangle.Side1, 2) + Math.Pow(triangle.Side2, 2);
        }
    }

    
}
