using System;

namespace LOWERCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            int lowercaseWords = 0;
            string[] words = str.Split(' ',':',',',';');
            foreach (string word in words)
            {
                if (word != "" && char.IsLower(word[0]))
                {
                    lowercaseWords++;
                }
            }
            Console.WriteLine(lowercaseWords);
        }
    }
}
