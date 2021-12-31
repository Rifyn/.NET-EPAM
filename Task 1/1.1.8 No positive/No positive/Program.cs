using System;

namespace No_positive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = new int[3,3,3];
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int n = 0; n < mas.GetLength(2); n++)
                    {
                        mas[i,j,n] = rand.Next(-5,5);
                    }
                }
            }
            Print(mas);
            No_Positive(mas);
            Console.WriteLine();
            Print(mas);
            Console.ReadLine();
        }
        public static void Print(int[,,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.WriteLine(i +1 + "-й слой");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int n = 0; n < mas.GetLength(2); n++)
                    {
                        Console.Write(mas[i,j,n] + " ");
                    }
                    Console.WriteLine();
                }
            }  
        }
        public static void No_Positive(int[,,]mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    for (int n = 0; n < mas.GetLength(2); n++)
                    {
                        if (mas[i, j, n] > 0) mas[i, j, n] = 0;
                    }
                }
            }
        }
    }
}
