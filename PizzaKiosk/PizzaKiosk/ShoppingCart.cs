using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class ShoppingCart
    {
        List<Order1> shoppingCart1;//Menu pizzas
        List<Order2> shoppingCart2;//Components
        List<Order2> shoppingCart3;//Custom Pizza Components
        List<Order3> shoppingCart4;//Custom Pizza Crust
        double total1;
        double total2;
        double total3;
        double total4;

        public ShoppingCart()
        {
            shoppingCart1 = new List<Order1>();
            shoppingCart2 = new List<Order2>();
            shoppingCart3 = new List<Order2>();
            shoppingCart4 = new List<Order3>();
            total1 = 0;
            total2 = 0;
            total3 = 0;
            total4 = 0;

        }


        public void AddToCart1(Pizza pizza, int quantity)
        {
            Order1 newOrder = new Order1(pizza, quantity);
            shoppingCart1.Add(newOrder);

        }
        public void PrintShoppingCart1()
        {
            if (shoppingCart1.Count == 0)
            {
                Console.WriteLine("The cart empty");

            }
            else
            {
                foreach (Order1 order in shoppingCart1)
                {

                    order.PrintOrder1();


                }

            }
        }
        
        public void AddToCart2(Component component)
        {
            Order2 newComp = new Order2(component);
            shoppingCart2.Add(newComp);
        }
        public void PrintShoppingCart2()
        {
                foreach(Order2 order in shoppingCart2)
                {
                    order.PrintOrder2();
                }
            
        }

        public void AddToCart3(Component component)
        {
            Order2 newComp = new Order2(component);
            shoppingCart3.Add(newComp);
        }
        public void PrintShoppingCart3()
        {
            foreach (Order2 order in shoppingCart3)
            {
                order.PrintOrder2();
            }

        }

       public void AddToCart4(Crust crust)
        {
            Order3 newCrust = new Order3(crust);
            shoppingCart4.Add(newCrust);
        }

        public void PrintShoppingCart4()
        {
            foreach(Order3 order in shoppingCart4)
            {
                order.PrintOrder3();
            }
        }
        public double CalcShoppingCart1Total()
        {
            total1 = 0;
            foreach(Order1 pizza in shoppingCart1)
            {
                total1 += pizza.CalculateOrder1Total();
            }
            return total1;
        }
        public double CalcShoppingCart2Total()
        {
            total2 = 0;
            foreach (Order2 component in shoppingCart2)
            {
                total2 += component.CalculateOrder2Total();
            }
            return total2;
        }
        public double CalcShoppingCart3Total()
        {
            total3 = 0;
            foreach(Order2 component in shoppingCart3)
            {
                total3 += component.CalculateOrder2Total();
            }
            return total3;
        }
        public double CalcShoppingCart4Total()
        {
            total4 = 0;
            foreach(Order3 crust in shoppingCart4)
            {
                total4 += crust.CalculateOrder3Total();
            }
            return total4;
        }
    }
}
