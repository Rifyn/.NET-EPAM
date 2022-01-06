using System;

namespace RECTANGLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника");
            int a = Check(Console.ReadLine());
            int b = Check(Console.ReadLine());
            Console.WriteLine(a*b);
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
