using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public class Enemies : Characters
    {
        public Enemies(Point point)
        {
            position = point;
            visual = '@';
        }    
    }
}
