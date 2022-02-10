using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Ring:Figures
    {
        public Circles inner;
        public Circles outer;

        public Ring(double inR, double outR)
        {
            inner = new Circles(inR);
            outer = new Circles(outR);
        }
        public double GetArea() => outer.GetArea() - inner.GetArea();

        public override string ToString() => $"Кольцо с площадью {GetArea()}";
        
    }
}
