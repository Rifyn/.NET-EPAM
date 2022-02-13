using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    public class Pizzeria

    {
        static public event EventHandler<OrderArgs> EndOfCooking;
        static public void ConfirmOrder(int id, PizzaType pizzaType)
        {
            Cooking(id, pizzaType);
        }

        static private void Cooking(int id, PizzaType pizzaType)
        {
            Thread.Sleep(3000);
            GiveOrder(id, pizzaType);
        }

        static private void GiveOrder(int id, PizzaType pizzaType)
        {
            EndOfCooking?.Invoke(null, new OrderArgs(id, pizzaType));
        }
    }

    public class OrderArgs : EventArgs
    {
        public int ID { get; }
        public PizzaType TypePizza { get; }

        public OrderArgs(int ID, PizzaType pizzaType)
        {
            this.ID = ID;
            this.TypePizza = pizzaType;
        }
    }

    public enum PizzaType
    {
        Margherita,
        Marinara,
        Carbonara,
        Napoletana
    }
}
