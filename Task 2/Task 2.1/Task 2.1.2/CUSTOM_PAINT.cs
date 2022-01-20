using Classes;
using System;
using System.Text;
using Interfaces;

namespace CUSTOM_PAINT
{
    public class CUSTOM_PAINT
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            List<Figures> figuresArray = new List<Figures>();
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
                        AddFigure(figuresArray, Int32.Parse(Console.ReadLine()));
                        break;
                    case "2":PrintAll(figuresArray);
                        break;
                    case "3":
                        break;
                    case "4":
                        flag = false;
                        break;
                    default: goto case "4";
                }
            } while (flag);

        }
        public static void AddFigure(List<Figures>mas, int figureType)
        {
            switch (figureType)
            {
                case 1: mas.Add(new Circles(2));
                    break;
                case 2: mas.Add(new Ring(2,3));
                    break;
                    default:
                    break;
            }
        }
        public static void Clear()
        {

        }
        public static void PrintAll(List<Figures> mas)
        {
            foreach (IPrintable f in mas)
            {
                f.Print();
            }
        }
    }
}