using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Order1
    {
        Pizza pizza;
        int quantity;

        public Order1(Pizza _pizza, int _quantity)
        {
            pizza = _pizza;
            quantity = _quantity;
        }

        public void PrintOrder1()
        {
            Console.WriteLine();
            Console.WriteLine($"ID: {pizza.id}\n Name: {pizza.name} \n quantity: {quantity} \n Price: {pizza.price}\n" +
                $"Total: {CalculateOrder1Total()}"
                );
            Console.WriteLine();
        }

        public double CalculateOrder1Total()
        {
            return pizza.price * quantity;
        }
    }
}
