using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    abstract class Figure
    {
        string name;
        public string Name { get { return name; } }
        public abstract double getSqare();
        public abstract double getPerimetr();
        public abstract double getRatio();
        public abstract void About();
    }
}
