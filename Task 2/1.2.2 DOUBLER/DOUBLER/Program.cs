using System;

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
            string thirdstr = string.Empty;
            foreach (char arg in firststr)
            {
                if (secondstr.Contains(arg))
                {
                    thirdstr += new string(arg, 2);
                }
                else 
                {
                    thirdstr += arg;
                }
            }
            Console.WriteLine(thirdstr);
        }
    }
}
