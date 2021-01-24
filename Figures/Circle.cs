using System;

namespace Figures
{
    public class Circle : Figure
    {
        public double Radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }
            Radius = radius;
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}