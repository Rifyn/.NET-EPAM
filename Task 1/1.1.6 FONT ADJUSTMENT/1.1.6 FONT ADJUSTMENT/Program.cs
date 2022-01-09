using System;
using System.Collections.Generic;

namespace FONT_ADJUSTMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> fontStateMap = new Dictionary<string, bool>() 
            {
                {"Bold",false },
                {"Italic",false },
                {"Underline",false }
            };
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
                        IndexCheck(fontStateMap, "Bold");
                        break;
                    case "2":
                        IndexCheck(fontStateMap, "Italic");
                        break;
                    case "3":
                        IndexCheck(fontStateMap, "Underline");
                        break;
                    default:
                        flag = false;
                        break;
                }
                Output(fontStateMap, out str);
            }
        }
        public static void IndexCheck(Dictionary<string,bool> keyValuePairs, string key)
        {
            keyValuePairs[key] = !keyValuePairs[key];
        }
        public static void Output(Dictionary<string,bool> keyValuePairs, out string str)
        {
            str = "";
            foreach (var item in keyValuePairs)
            {
                if (item.Value)
                {
                    if (str != "") str += ", ";
                    str += item.Key;
                }
            }
        }
    }
}
