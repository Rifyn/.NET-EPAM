using System;

namespace LOWERCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            bool flag = true;
            int words = 0;
            foreach (char s in str)
            {
                if (char.IsSeparator(s) || char.IsPunctuation(s))
                { 
                    flag = true;
                }
                else
                {
                    if (char.IsLower(s) && flag) words++;

                    flag = false;
                }             
            }
            Console.WriteLine(words);
        }
    }
}
