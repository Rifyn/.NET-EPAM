using System;

namespace NON_NEGATIVE_SUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Int32.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rand = new Random();    
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(-10,10);
            }
            Print(mas);
            Console.WriteLine("Сумма неотрицательных элементов " +  NSum(mas));
            Console.ReadKey();
        }
        public static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        
        public static int NSum(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] >= 0) sum += mas[i];
            }
            return sum;
        }
    }
}
