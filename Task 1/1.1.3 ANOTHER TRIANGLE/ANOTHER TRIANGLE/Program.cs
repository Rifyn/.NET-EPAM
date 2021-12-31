using System;

namespace ANOTHER_TRIANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new String(' ', n-i-1));
                Console.WriteLine(new String('*', 2*i+1));
            }
            Console.ReadKey();
        }
    }
}
