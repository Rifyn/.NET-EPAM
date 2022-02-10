using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public struct Point
    {
        public double X { get; }
        public double Y { get; }
        public Point() : this(1, 1)
        {

        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public abstract class Figures
    {
        public double radius { get; set; }
    }
}
