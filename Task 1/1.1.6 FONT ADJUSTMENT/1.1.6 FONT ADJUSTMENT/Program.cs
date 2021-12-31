using System;

namespace FONT_ADJUSTMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] {0,0,0};
            string[] param = new string[] { "Bold", "Italic", "Underline" };
            string str = "";
            bool flag = true;
            while (flag)
            {
                if (str == "") str = "None";
                Console.WriteLine("Параметры надписи: " + str);
                Console.WriteLine("Введите: \n\t1: Bold\n\t2: Italic\n\t3: Underline");
                switch (Console.ReadLine())
                {
                    case "1":
                        Indexcheck(mas, 0);
                        break;
                    case "2":
                        Indexcheck(mas, 1);
                        break;
                    case "3":
                        Indexcheck(mas, 2);
                        break;
                    default:
                        flag = false;
                        break;
                }
                Output(mas, param, out str);
            }            
        }
        public static void Indexcheck(int[] mas, int index)
        {
            if (mas[index] == 0) mas[index] = 1;
            else mas[index] = 0;
        }
        public static void Output(int[] mas, string[] param, out string str)
        {
            str = "";
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 1) 
                { 
                    if(str != "") str += ", ";
                    str += param[i];
                }
            }
        }
    }
}
