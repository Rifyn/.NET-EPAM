using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Circles : Figures
    {
        
        public Circles(double r)
        {
            radius = r;
        }
        
        public double GetArea() => Math.PI * radius * radius;
        public double GetCircumflex() => 2 * Math.PI * radius;

        public override string ToString() => $"Круг с площадью {GetArea()} и длинной описанной окружности {GetCircumflex()}";
    }
}
