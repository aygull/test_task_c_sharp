using System;
using System.Linq;

namespace Figures
{
    public class Triangle : Figure
    {
        public double Side1, Side2, Side3;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Сторона не может быть отрицательной");
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        private double GetSum(double numb1, double numb2) => Math.Sqrt(Math.Pow(numb1, 2) + Math.Pow(numb2, 2));
        public bool IsRectangular()
        {
            if (Side1 == GetSum(Side2, Side3) || Side2 == GetSum(Side1, Side3) || Side3 == GetSum(Side1, Side2))
            {
                return true;
            }
            return false;
        }
        public override double GetArea()
        {
            double max = new[] { Side1, Side2, Side3 }.Max();

            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

    }
}
