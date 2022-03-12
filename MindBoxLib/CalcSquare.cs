using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    public abstract class Shape
    {
        public string FigureName { get; private set; }

        public Shape(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double CalcSquare();
    }

    public static class ShapePrototype
    {
        public static double CalcSquare(Shape shape) => shape.CalcSquare();
    }

    public class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }

    public class Triangle : Shape
    {
        public double ab { get; private set; }
        public double bc { get; private set; }
        public double ac { get; private set; }

        public Triangle(string FigureName, double ab, double bc, double ac) : base(FigureName)
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values");
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException($"Error: Your side greater than summary of two another sides\nCheck your input values");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }

        public override double CalcSquare()
        {
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2))
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check;
        }
    }
}
