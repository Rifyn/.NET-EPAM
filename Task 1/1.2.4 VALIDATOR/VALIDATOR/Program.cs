using System;
using System.Text;

namespace VALIDATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isSentenceStart = true;
            Console.WriteLine("Введите строку");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < sb.Length; i++)
            {
                if (isSentenceStart && sb[i] != ' ')
                {
                    sb[i] = char.ToUpper(sb[i]);
                    isSentenceStart = false;
                }
                if(sb[i] == '.' || sb[i] == '!' || sb[i] == '?') isSentenceStart = true;
            }
            Console.WriteLine(sb.ToString());
        } 
    }
}