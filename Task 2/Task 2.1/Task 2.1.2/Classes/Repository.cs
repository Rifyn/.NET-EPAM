using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Repository
    {
        public static List<Figures> figuresArray = new List<Figures>();
        public Dictionary<string,List<Figures>> users = new Dictionary<string,List<Figures>>();
    }
}
