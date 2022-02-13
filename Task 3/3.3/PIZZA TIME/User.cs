using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    public class User
    {
        public string Name { get; init; }

        public User(string name)
        {
            Name = name;
        }

        public void MakeOrder(PizzaType pizzaType)
        {
            Order.TakeOrder += TakePizza;
            Order.MakeOrder(Name, pizzaType);

        }

        private void TakePizza(PizzaType pizzaType)
        {
            Console.WriteLine("{0} забрал заказ {1}", Name, pizzaType);
            Order.TakeOrder -= TakePizza;
        }

    }
}
