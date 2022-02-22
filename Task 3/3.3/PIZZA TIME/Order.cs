using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    public class Order
    {
        private static int _id = 0;
        public event Action<PizzaType.PizzaT> TakeOrder = (pizzaType) => { };
        private Pizzeria _pizzeria;
        private string _name;
        public int ID { get; }
        public PizzaType.PizzaT PizzaTypes { get; init; }

        public Order(PizzaType.PizzaT pizzaTypes, Pizzeria pizzeria, User user)
        {
            ID = _id++;
            PizzaTypes = pizzaTypes;
            _pizzeria = pizzeria;
            _name = user.Name;
        }

        public void MakeOrder(int id, PizzaType.PizzaT typePizza)
        {
            _pizzeria.EndOfCooking += OrderIsReady;
            _pizzeria.ConfirmOrder(id, typePizza);
            ConsoleUI.PrintOrder(id, _name);
        }

        public void OrderIsReady(int id, PizzaType.PizzaT typePizza)
        {
            _pizzeria.EndOfCooking -= OrderIsReady;
            ConsoleUI.PrintOrderReady(id, _name);
            TakeOrder?.Invoke(typePizza);
            
        }

    }
}
