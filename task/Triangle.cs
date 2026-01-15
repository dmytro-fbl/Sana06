using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Triangle : Shape
    {
        public string Name = "Трикутник";
        private double _side1;
        private double _side2;
        private double _side3;

        public (double s1, double s2, double s3) Sides
        {
            get {  return (_side1, _side2, _side3); }
            set
            {
                if (value.s1 < 0 || value.s2 < 0|| value.s3 < 0)
                    throw new ArgumentOutOfRangeException("Сторона не може бути від'ємною");
                if (value.s1 + value.s2 < value.s3 || value.s3 + value.s2 < value.s1 || value.s1 + value.s3 < value.s2)
                    throw new ArgumentOutOfRangeException("неправильне співвідношення сторін");
                _side1 = value.s1;
                _side2 = value.s2;
                _side3 = value.s3;
            }
        }
        public Triangle(double side1, double side2, double side3)
        {
            Sides = (side1, side2, side3);
        }

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            double res = p * (p - _side1) * (p - _side2) * (p - _side3);
            Console.WriteLine(res);
            return Math.Sqrt(res);
        }

        public override double CalculatePerimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----{Name}----\nПлоща: {CalculateArea():N2}\nПериметр: {CalculatePerimeter():N2}\n");
        }
        public override string GetName()
        {
            return Name;
        }
    }
}
