using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig1 = new Circle { Radius = 200, Name = "Круг" };
            fig1.About();
            double sl = fig1.getPerimetr();
            Console.WriteLine($"Периметр круга = {sl} см.");
            var fig2 = new Triangle { Name = "Круг", Width = 5 };
            fig2.About();
            double bb = fig2.getPerimetr();
            Console.WriteLine($"Периметр треугольника = {bb} см.");
        }
    }
}
