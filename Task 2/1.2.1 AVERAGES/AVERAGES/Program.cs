using System;

namespace AVERAGES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            int words = 0;
            int letters = 0;
            str = str.Replace(",", " ").Replace("."," ");
            string [] arr = str.Split(' ');
            foreach (string s in arr)
            {
                if(s != "")
                {
                    letters += s.Length;
                    words++;
                }
            }
            if(words > 0)
            {
                double averageWordsLenght = (double)letters / words;//выводит дробный результат
                Console.WriteLine("Средняя длина слова " + averageWordsLenght);
            }
            else
            {
                Console.WriteLine("Нет слов");               
            }
        }
    }
}
