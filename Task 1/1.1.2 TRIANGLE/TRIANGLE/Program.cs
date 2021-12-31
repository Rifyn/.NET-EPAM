using System;

namespace TRIANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) Console.WriteLine(new String('*',i));
            Console.ReadKey();
        }
    }
}
