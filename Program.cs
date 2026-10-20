using System;

namespace Pizzeria
{
    public class OrderCalculator
    {
        public int CalculateOrderTotal(int pizzaCount, bool isDelivery)
        {
            
            if (pizzaCount <= 0 || pizzaCount > 20)
            {
                return -1;
            }

            double pricePerPizza = 2500;
            double totalPrice = pizzaCount * pricePerPizza;

            
            if (pizzaCount >= 4)
            {
                totalPrice *= 0.9;
            }

            if (isDelivery)
            {
                totalPrice += 500;
            }

            return (int)Math.Round(totalPrice);
        }
    }
}