using System;
namespace ANOTHER_TRIANGLE 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.WriteLine("Введите кол-во треугольников");
            int n = Check(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(new String(' ', n-j-1));
                    Console.WriteLine(new String('*', 2 * j + 1));
                }
            }
        }
        public static int Check(string str)
        {
            if (Int32.TryParse(str, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректное значение, повторите попытку");
                return Check(Console.ReadLine());
            }
        }
    } 
}