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
        private Pizzeria _pizzeria;
        private Order _order;
        public User(string name, Pizzeria pizzeria)
        {
            Name = name;
            _pizzeria = pizzeria;
        }

        public void MakeOrder(PizzaType.PizzaT pizzaType)
        {
            _order = new Order(pizzaType, _pizzeria, this);
            _order.TakeOrder += TakePizza;
            _order.MakeOrder(_order.ID, pizzaType);
        }

        public void TakePizza(PizzaType.PizzaT pizzaType)
        {
            ConsoleUI.PrintOrderReady(pizzaType, Name);
            _order.TakeOrder -= TakePizza;
        }
    }
}
