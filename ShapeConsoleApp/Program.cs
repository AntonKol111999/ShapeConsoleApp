using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;
using Xunit;


namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);

            double circleArea = ShapeCalculator.CalculateArea(circle);
            double triangleArea = ShapeCalculator.CalculateArea(triangle);

            Console.WriteLine("Площадь круга: " + circleArea);
            Console.WriteLine("Площадь треугольника: " + triangleArea);

            bool isRightTriangle = ShapeCalculator.IsRightTriangle(triangle);
            Console.WriteLine("Является ли треугольник прямоугольным: " + isRightTriangle);

            Console.ReadLine();
        }
    }
}
