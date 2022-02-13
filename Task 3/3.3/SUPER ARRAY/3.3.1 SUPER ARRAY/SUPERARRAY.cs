using System;

namespace SUPER_ARRAY
{
    internal class SUPERARRAY
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 1, 2, 2, 2};
            Console.WriteLine("Сумма элементов массива: " + ArrayExtensions.Summ(mas));
            Console.WriteLine("Среднее значение массива: " + ArrayExtensions.Average(mas));
            Console.WriteLine("Самый повторяемый элемент массива: " + ArrayExtensions.MostRepeatedElement<int>(mas));
        }

    }
}
