using System;
namespace ANOTHER_TRIANGLE 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Введите кол-во треугольников");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(new String(' ', n-j-1));
                    Console.WriteLine(new String('*', 2 * j + 1));
                }
            }
            Console.ReadKey();
        }
    } 
}