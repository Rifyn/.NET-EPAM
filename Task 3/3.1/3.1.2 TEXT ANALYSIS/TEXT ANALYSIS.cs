using System;
using System.Collections.Generic;
using System.Linq;

namespace TEXT_ANALYSIS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            char[] separators = new char[] { ' ', ',', '.', '!', '?', ':', ';', '\'', '"' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string,int> repeatedWords = new Dictionary<string,int>();
            foreach (string word in words)
            {
                if (CorrectWord(word))
                {
                    string wordToLower = word.ToLower();
                    if (repeatedWords.ContainsKey(wordToLower))
                    {
                        repeatedWords[wordToLower]++;
                    }
                    else
                    {
                        repeatedWords.Add(wordToLower, 1);
                    }
                }               
            }
            foreach (var word in repeatedWords)
            {
                Console.WriteLine("Word: {0,20} \tcount: {1}", word.Key, word.Value);
            }
            FavoriteWords(repeatedWords);
        }
        public static bool CorrectWord(string word)
        {
            if (word[0] == '-') return false;
            foreach (char c in word)
            {
                if (char.IsNumber(c)) return false;
            }
            return true;
        }

        public static void FavoriteWords(Dictionary<string, int> words)
        {
            var res = words.Where(x => x.Value > 5);
            if(res.Count() > 0)
            {
                Console.WriteLine("Favorite words");
                foreach (var word in res)
                {
                    Console.WriteLine(word.Key);
                }
            }
            else Console.WriteLine("No favorite words");
        }
    }
    
}
