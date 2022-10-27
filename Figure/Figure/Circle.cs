using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override double getPerimetr() => Radius * 2 * 3.14;
        public override double getSqare() => Radius * Radius * 3.14;
        public override void About()
        {
            string inf = $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::\n---Круг---\nНаименование: {Name}" +
                         $"\nРадиус: {Radius} см" +
                         $"\nСоотношение: {getRatio(getSqare(), getPerimetr())} см" +
                         $"\n::::::::::::::::::::::::::::::::::::::::::::::::::::::";
            Console.WriteLine(inf);
        }
    }
}
