using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Triangle : Figure
    {
        public float Width { get; set; }
        public override double getPerimetr() => Width * 3;
        public override double getSqare() => (Math.Pow(Width, 2) * Math.Sqrt(3)) / 4;
        public override double getRatio() => ((Math.Pow(Width, 2) * Math.Sqrt(3)) / 4) / (Width * 3);
        public override void About()
        {
            string inf = $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::\n---Треуголник---\nНаименование: {Name}" +
                         $"\nДлина: {Width} см" +
                         $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::";
            Console.WriteLine(inf);
        }
    }
}
