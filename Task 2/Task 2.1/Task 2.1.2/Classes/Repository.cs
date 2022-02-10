using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Repository
    {
        private List<Figures> figuresArray = new List<Figures>();
        public Dictionary<string,List<Figures>> users = new Dictionary<string,List<Figures>>();

        public void AddToArray(Figures figures)
        {
            figuresArray.Add(figures);
        }
        public void Clear()
        {
            figuresArray.Clear();
        }
        public void PrintAll()
        {
            foreach (var f in figuresArray)
            {
                Console.WriteLine(f);
            }
        }
    }
}
