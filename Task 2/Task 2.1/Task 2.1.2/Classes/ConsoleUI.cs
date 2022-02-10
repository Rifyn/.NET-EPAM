using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ConsoleUI
    {
        public static void Start()
        {
            Repository figuresArray = new Repository();
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
                        AddFigure(figuresArray, figureType);
                        break;
                    case "2":
                        figuresArray.PrintAll();
                        break;
                    case "3":
                        figuresArray.Clear();
                        break;
                    case "4":
                        flag = false;
                        break;
                    default: goto case "4";
                }
            } while (flag);
        }

        public static void AddFigure(Repository mas, FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.circles:
                    Console.WriteLine("Введите радиус");
                    mas.AddToArray(new Circles(Check(Console.ReadLine())));
                    break;
                case FigureType.ring:
                    Console.WriteLine("Введите внутренний радиус");
                    int inner = Check(Console.ReadLine());
                    Console.WriteLine("Введите внешний радиус");
                    int outer = Check(Console.ReadLine());
                    mas.AddToArray(new Ring(inner, outer));
                    break;
                default:
                    Console.WriteLine("Неверно действие");
                    break;
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
