using System;

namespace PIZZA_TIME
{
    public class PIZZATIME
    {
        static void Main(string[] args)
        {
            User user1 = new User("12345");
            user1.MakeOrder(PizzaType.Napoletana);
        }
    }
}
