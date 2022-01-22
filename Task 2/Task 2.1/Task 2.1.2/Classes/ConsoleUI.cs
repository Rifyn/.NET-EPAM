using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Classes
{
    public class ConsoleUI
    {
        public static void Start()
        {
            bool flag = true;           
            do
            {
                Console.WriteLine("1. Добавить фигуру\n" +
                                  "2. Вывести фигуры\n" +
                                  "3. Очистить холст\n" +
                                  "4. Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Выберите тип фигуры:\n" +
                                          "1. Круг\n" +
                                          "2. Кольцо");
                        FigureType figureType = (FigureType)Check(Console.ReadLine());
                        AddFigure(Repository.figuresArray, figureType);
                        break;
                    case "2":
                        PrintAll(Repository.figuresArray);
                        break;
                    case "3":
                        Clear();
                        break;
                    case "4":
                        flag = false;
                        break;
                    default: goto case "4";
                }
            } while (flag);
        }

        public static void AddFigure(List<Figures> mas, FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.circles:
                    Console.WriteLine("Введите радиус");
                    mas.Add(new Circles(Check(Console.ReadLine())));
                    break;
                case FigureType.ring:
                    Console.WriteLine("Введите внутренний радиус");
                    int inner = Check(Console.ReadLine());
                    Console.WriteLine("Введите внешний радиус");
                    int outer = Check(Console.ReadLine());
                    mas.Add(new Ring(inner, outer));
                    break;
                default:
                    Console.WriteLine("Неверно действие");
                    break;
            }
        }
        public static void Clear()
        {
            Repository.figuresArray.Clear();
            //Console.Clear();
        }
        public static void PrintAll(List<Figures> mas)
        {
            foreach (IPrintable f in mas)
            {
                Console.WriteLine(f.Print());          
            }
        }

        public static int Check(string value)
        {
            int result;
            if (Int32.TryParse(value,out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректное значение");
                return Check(Console.ReadLine());
            }
        }

        public enum FigureType
        {
            circles = 1,
            ring = 2
        }
    }

    
}
