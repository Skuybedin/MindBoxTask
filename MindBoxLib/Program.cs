using System;

namespace MindBoxLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Круг", 12);
            Triangle triangle = new Triangle("Треугольник", 4, 4, 5);

            Console.WriteLine(circle.CalcSquare());
            Console.WriteLine(triangle.CalcSquare());
        }
    }
}
