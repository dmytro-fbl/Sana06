using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Rectangle : Shape
    {
        public string Name = "Прямокутник";
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Відстань ширини не може бути від'ємною");
                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Відстань довжини не може бути від'ємною");
                _height = value;
            }
        }

        public Rectangle(double  width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return (Width + Height) * 2;
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
