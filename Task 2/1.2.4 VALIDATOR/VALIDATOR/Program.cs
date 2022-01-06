using System;
using System.Text;

namespace VALIDATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;//метка нового предложения
            Console.WriteLine("Введите строку");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < sb.Length; i++)
            {
                if (flag && sb[i] != ' ')
                {
                    sb[i] = char.ToUpper(sb[i]);
                    flag = false;
                }
                if(sb[i] == '.' || sb[i] == '!' || sb[i] == '?') flag = true;
            }
            Console.WriteLine(sb.ToString());
        } 
    }
}