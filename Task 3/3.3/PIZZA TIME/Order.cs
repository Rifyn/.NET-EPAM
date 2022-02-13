using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    public class Order
    {
        static private int _id = 0;
        static public event Action<PizzaType> TakeOrder = (pizzaType) => { };
        public int ID { get; }
        public PizzaType PizzaTypes { get; init; }

        public Order(PizzaType pizzaTypes)
        {
            ID = _id++;
            PizzaTypes = pizzaTypes;
        }

        public static void MakeOrder(string name, PizzaType typePizza)
        {
            Pizzeria.EndOfCooking += OrderIsReady;
            Console.WriteLine("Заказ номер:{0} на имя {1} принят ", _id, name);
            Pizzeria.ConfirmOrder(_id, typePizza);
            _id++;
        }

        public static void OrderIsReady(Object sender, OrderArgs orderArgs)
        {
            Pizzeria.EndOfCooking -= OrderIsReady;
            Console.WriteLine("Заказ номер:{0} готов", orderArgs.ID);
            TakeOrder?.Invoke(orderArgs.TypePizza);
        }

    }
}
