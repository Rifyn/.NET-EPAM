using System;

namespace TRIANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int n = Check(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            { 
                Console.WriteLine(new String('*', i));
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
