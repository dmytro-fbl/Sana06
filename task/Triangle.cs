using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Triangle : Shape
    {
        private string _name = "Трикутник";
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

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt((p * (p - _side1) * p * (p - _side2) * p * (p - _side3)));
        }

        public override double CalculatePerimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----{_name}----\nПлоща: {CalculateArea():N2}\nПериметр: {CalculatePerimeter():N2}\n");
        }
    }
}
