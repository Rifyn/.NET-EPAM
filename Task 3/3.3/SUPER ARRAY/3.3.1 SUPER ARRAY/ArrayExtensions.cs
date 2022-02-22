using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPER_ARRAY
{
    public static class ArrayExtensions
    {
        public static int Summ(this IEnumerable<int> mas)
        {
            int res = 0;
            foreach (int i in mas)
                res += i;
            return res;
        }
        public static float Summ(this IEnumerable<float> mas)
        {
            float res = 0f;
            foreach (int i in mas)
                res += i;
            return res;
        }
        public static double Summ(this IEnumerable<double> mas)
        {
            double res = 0.0;
            foreach (int i in mas)
                res += i;
            return res;
        }
        public static long Summ(this IEnumerable<long> mas)
        {
            long res = 0L;
            foreach (int i in mas)
                res += i;
            return res;
        }
        public static decimal Summ(this IEnumerable<decimal> mas)
        {
            decimal res = 0M;
            foreach (int i in mas)
                res += i;
            return res;
        }

        public static double Average(this IEnumerable<int> mas)
        {
            double sum = 0;
            int count = 0;
            foreach(int i in mas)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
        public static float Average(this IEnumerable<float> mas)
        {
            float sum = 0;
            int count = 0;
            foreach (int i in mas)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
        public static double Average(this IEnumerable<double> mas)
        {
            double sum = 0;
            int count = 0;
            foreach (int i in mas)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
        public static double Average(this IEnumerable<long> mas)
        {
            long sum = 0;
            int count = 0;
            foreach (int i in mas)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
        public static decimal Average(this IEnumerable<decimal> mas)
        {
            decimal sum = 0;
            int count = 0;
            foreach (int i in mas)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }

        public static T MostRepeatedElement<T>(this IEnumerable<T> mas)
        {
            Dictionary<T, int> repeatedElements = new Dictionary<T, int>();
            T maxElement = default(T);
            int count = 0;
            foreach (var element in mas)
            {
                if (repeatedElements.ContainsKey(element))
                {
                    repeatedElements[element]++;
                }
                else
                {
                    repeatedElements.Add(element, 1);
                }
            }
            foreach (var element in repeatedElements)
            {
                if(count < element.Value)
                {
                    count = element.Value;
                    maxElement = element.Key;
                }
            }
            return maxElement;
        }

        public static void ApplyToMass<T>(T[] mas, Func<T, T> func)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (func != null)
                {
                    mas[i] = func.Invoke(mas[i]);
                }
            }
        }
    }
}
