using System;

namespace Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig = new Circle { Radius = 200 };
            fig.About();
            double sl = fig.getPerimetr();

        }
    }
}
