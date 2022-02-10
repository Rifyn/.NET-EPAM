using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class FiguresWithCoordinates:Figures
    {
        public Point Coordinates { get; private set; }
    }
}
