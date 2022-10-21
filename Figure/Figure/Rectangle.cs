using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public override double getPerimetr() => Width * 2 + Height * 2;
        public override double getSqare() => Width * Height;
        public override double getRatio() => (Width * Height) / (Width * 2 + Height * 2);
        public override void About()
        {
            string inf = $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::\n---Прямоугольник---\nНаименование: {Name}" +
                         $"\nДлина: {Width} см" +
                         $"\nЩирина: {Height} см" +
                         $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::";
            Console.WriteLine(inf);
        }
    }
}
