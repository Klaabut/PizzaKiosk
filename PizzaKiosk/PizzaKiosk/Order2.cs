using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Order2
    {
        Component component;
        public Order2(Component _component)
        {
            component = _component;
        }

        public void PrintOrder2()
        {
            Console.WriteLine($"ID: {component.id} \n Name: {component.name} \n Price: {component.price}");
        }

        public double CalculateOrder2Total()
        {
            return component.price;
        }
    }
}
