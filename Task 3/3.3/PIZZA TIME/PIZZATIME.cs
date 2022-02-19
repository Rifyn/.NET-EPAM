using System;

namespace PIZZA_TIME
{
    public class PIZZATIME
    {
        static void Main(string[] args)
        {
            
            Pizzeria pizzeria = new Pizzeria();
            User user2 = new User("4124", pizzeria);
            User user1 = new User("12345", pizzeria);
            user1.MakeOrder(PizzaType.PizzaT.Carbonara);
            user2.MakeOrder(PizzaType.PizzaT.Margherita);
            
        }
    }
}
