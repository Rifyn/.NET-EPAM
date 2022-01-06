using System;
using System.Collections.Generic;

namespace FONT_ADJUSTMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            string str = string.Empty;
            bool flag = true;
            while (flag)
            {
                if (str == "") str = "None";
                Console.WriteLine("Параметры надписи: " + str);
                Console.WriteLine("Введите: \n\t1: Bold\n\t2: Italic\n\t3: Underline");
                switch (Console.ReadLine())
                {
                    case "1":
                        IndexCheck(keyValuePairs, 0, "Bold");
                        break;
                    case "2":
                        IndexCheck(keyValuePairs, 1, "Italic");
                        break;
                    case "3":
                        IndexCheck(keyValuePairs, 2, "Underline");
                        break;
                    default:
                        flag = false;
                        break;
                }
                Output(keyValuePairs, out str);
            }
        }
        public static void IndexCheck(Dictionary<int, string> keyValuePairs, int index, string value)
        {
            if (keyValuePairs.ContainsKey(index))
            {
                keyValuePairs.Remove(index);
            }
            else
            {
                keyValuePairs.Add(index, value);
            }
        }
        public static void Output(Dictionary<int, string> keyValuePairs, out string str)
        {
            str = "";
            foreach (var item in keyValuePairs)
            {
                if (str != "") str += ", ";
                str += item.Value;
            }
        }
    }
}
