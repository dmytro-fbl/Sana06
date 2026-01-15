using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Circle : Shape
    {
        private double _radius;
        private string _name = "Коло";

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Радіус не може бути від'ємним");
                _radius = value;
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"----{_name}----\nПлоща: {CalculateArea():N2}\nПериметр: {CalculatePerimeter():N2}\n");
        }
    }
}
