using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class Circles : Figures, IPrintable
    {
        public Point Coordinates { get; private set; }
        public Circles(double r)
        {
            radius = r;
        }
        
        public double GetArea() => Math.PI * radius * radius;
        public double GetCircumflex() => 2 * Math.PI * radius;

        public void Print() 
        {
            Console.WriteLine("круг");
        }
    }
}
