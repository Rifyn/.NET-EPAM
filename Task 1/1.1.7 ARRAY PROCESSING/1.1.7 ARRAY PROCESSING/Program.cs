using System;

namespace ARRAY_PROCESSING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Check(Console.ReadLine());
            int[] mas = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(100);
            }
            Print(mas);
            Console.WriteLine("Максимальное число " + MaxValue(mas));
            Console.WriteLine("Минимальное число " + MinValue(mas));
            Sort(mas);
            Print(mas);
        }
        public static int MaxValue(int[]mas)
        {
            int max = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > max) max = mas[i];

            }
            return max;
        }
        public static int MinValue(int[] mas)
        {
            int min = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < min) min = mas[i];

            }
            return min;
        }
        public static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        public static void Sort(int[] mas)
        {
            int tmp;
            for (int i = 0; i < mas.Length-1; i++)
            {
                for (int j = i; j < mas.Length; j++)
                {
                    if (mas[i] < mas[j])
                    {
                        tmp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = tmp;
                    }
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
