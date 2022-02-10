using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Food:Coordinates
    {
        public Food(Point point)
        {
            position = point;
            visual = '+';
        }
    }
}
