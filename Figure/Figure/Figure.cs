using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    abstract class Figure
    {
        public string Name { get; set; }
        public abstract double getSqare();
        public abstract double getPerimetr();
        public double getRatio(double s, double p)
        {
            return s / p;
        }
        public abstract void About();
    }
}
