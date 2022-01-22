using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class Ring:Figures, IPrintable
    {
        public Circles inner;
        public Circles outer;

        public Ring(double inR, double outR)
        {
            inner = new Circles(inR);
            outer = new Circles(outR);
        }
        public double GetArea() => outer.GetArea() - inner.GetArea();

        public string Print() => $"Кольцо с площадью {GetArea()}";
        
    }
}
