using System;
using System.Text;

namespace DOUBLER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            string firststr = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string secondstr = Console.ReadLine();
            StringBuilder thirdstr = new StringBuilder();
            foreach (char arg in firststr)
            {
                if (secondstr.Contains(arg))
                {
                    thirdstr.Append(arg, 2);
                }
                else 
                {
                    thirdstr.Append(arg);
                }
            }
            Console.WriteLine(thirdstr);
        }
    }
}
