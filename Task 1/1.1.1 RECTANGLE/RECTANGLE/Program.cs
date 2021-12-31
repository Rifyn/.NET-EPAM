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
            Console.ReadKey();
        }

        public static int Check(string str)
        {
            try
            {
                int result = Int32.Parse(str);
                if(result > 0) return result;
                else throw new Exception(str);
            }
            catch 
            {
                Console.WriteLine("Некорректное значение, повторите попытку");
                return Check(Console.ReadLine());
            }  
        }
    }
}
