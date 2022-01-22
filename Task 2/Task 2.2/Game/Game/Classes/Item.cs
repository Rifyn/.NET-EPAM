using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Item:Coordinates
    {
        public Item(Point point)
        {
            position = point;
            visual = '$';
        }
    }
}
