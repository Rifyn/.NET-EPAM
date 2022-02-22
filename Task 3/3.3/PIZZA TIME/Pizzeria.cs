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
        //public event EventHandler<OrderArgs> EndOfCooking;
        public delegate void EventHandler(int id, PizzaType.PizzaT pizzaType);
        public event EventHandler EndOfCooking;
        public void ConfirmOrder(int id, PizzaType.PizzaT pizzaType)
        {
            Cooking(id, pizzaType);
        }

        private async void Cooking(int id, PizzaType.PizzaT pizzaType)
        {
            var task = new Task(() => GiveOrder(id, pizzaType));
            task.Wait(TimeSpan.FromSeconds(3));
            task.Start();
            await task;

        }

        private void GiveOrder(int id, PizzaType.PizzaT pizzaType)
        {
            EndOfCooking?.Invoke(id, pizzaType);
        }
    }
}
