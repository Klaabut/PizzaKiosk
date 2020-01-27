using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Order3
    {
        Crust crust;
        public Order3(Crust _crust)
        {
            crust = _crust;
        }

        public void PrintOrder3()
        {
            Console.WriteLine($"ID: {crust.id} \n Name: {crust.name} \n Price: {crust.price}");
        }

        public double CalculateOrder3Total()
        {
            return crust.price;
        }
    }
}
