using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    public static class ConsoleUI
    {
        public static void PrintOrder(int id, string name)
        {
            Console.WriteLine($"Заказ номер:{id} на имя {name} принят ");
        }
        public static void PrintOrderReady(int id, string name)
        {
            Console.WriteLine($"Заказ номер:{id} готов");
        }
        public static void PrintOrderReady(PizzaType.PizzaT pizzaType, string Name)
        {
            Console.WriteLine("{0} забрал заказ {1}", Name, pizzaType);
        }

    }
}
