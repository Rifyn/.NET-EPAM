using System;
using System.Collections.Generic;

namespace WEAKEST_LINK
{
    public class WEAKEST_LINK
    {
        class Person
        {
            public int Id { get; set; }
            public override string ToString()
            {
                return Id.ToString();
            }
        }
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Console.WriteLine("Введите N");
            int n = Check(Console.ReadLine());
            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:");
            int dropOutNumber = Check(Console.ReadLine());
            int turn = 1;
            int id;
            int round = 1;
            for (int i = 1; i <= n; i++)
            {
                persons.Add(new Person { Id = i });
            }
            
            for (int i = 1; ;i++)
            {
                if (persons.Count < dropOutNumber)
                {
                    Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
                    break;
                }
                else 
                {
                    if (turn == dropOutNumber)
                    {
                        foreach (Person p in persons)
                        {
                            Console.WriteLine(p);
                        }
                        id = persons[i - 1].Id;
                        persons.RemoveAt(i - 1);
                        Console.WriteLine("Раунд {0}. Вычеркнут человек №{1}. Людей осталось: {2}", round++, id, persons.Count);
                        turn = 1;
                        i--;
                    }
                    else
                    {
                        turn++;
                    }     
                }
                if (persons.Count <= i) i = 0;
            }
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }
        public static int Check(string str)
        {
            if (Int32.TryParse(str, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректное значение, повторите попытку");
                return Check(Console.ReadLine());
            }
        }
    }
}
