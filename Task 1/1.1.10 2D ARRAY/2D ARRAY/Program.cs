using System;

namespace _2D_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Check(Console.ReadLine());
            int m = Check(Console.ReadLine());
            int[,] mas = new int[n,m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rand.Next(-10, 10);
                }
            }
            Print(mas);
            Console.WriteLine("Сумма элементов массива стоящих на чётных позициях " + PSum(mas));
        }

        public static void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,4}",mas[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int PSum(int[,] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if((i+j)%2 == 0) sum += mas[i,j];
                }
            }

            return sum;
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
