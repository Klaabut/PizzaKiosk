using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaKiosk
{
    class Program
    {
        /*Write a console app to allow your users to order pizza
     * 1.)Menu of five pizza types
     * 2.)User can choose from two types of pizza dough
     * 3.)User can add some additional ingridients to their order
     * 4.)User can choose a custom pizza with four ingridients
     * 5.)User can order more than one pizza
     * 6.)After the user confirms their order, the total is displayed.*/
        static void Main(string[] args)
        {
            Console.WriteLine("This is the third attempt of making this shit.");
            
            Menu menu = new Menu();
            ComponentMenu selectionOfComponents = new ComponentMenu();

            ShoppingCart shoppingCart1 = new ShoppingCart();
            ShoppingCart shoppingCart2 = new ShoppingCart();
            ShoppingCart shoppingCart3 = new ShoppingCart();
            ShoppingCart shoppingCart4 = new ShoppingCart();

            CrustStation selectionOfCrust = new CrustStation();









            bool needForList = true;
            bool needForExtraComponents = true;

            while(needForList == true)
            {
            Console.WriteLine("Would you like a custom or a menu pizza?(1=custom/2=menu)");
            int pizzaAnswer = int.Parse(Console.ReadLine());

               
                 if(pizzaAnswer== 1)
                 {
                    AddCrustToCustomPizza(selectionOfCrust, shoppingCart4);
                    bool customPizza = true;
                    //Custom pizza
                    
                    while(customPizza == true)
                    { 
                    Console.WriteLine("Would you like to add some ingridients?(1=yes/2=no)");
                        int userAnswer = int.Parse(Console.ReadLine());
                        if(userAnswer == 1)
                        {
                        AddComponentsToCustomPizza(selectionOfComponents, shoppingCart3);
                        }
                        else
                        {
                            customPizza = false;
                        }
                    }
                    shoppingCart3.PrintShoppingCart3();
                    
                    shoppingCart4.PrintShoppingCart4();
                    
                    Console.WriteLine($"The value of this custom pizza is {shoppingCart3.CalcShoppingCart3Total() + shoppingCart4.CalcShoppingCart4Total()} euros");
                    
                 }
                 //Menu pizza
                 else if(pizzaAnswer == 2)
                 {

                    AddPizzaToCart(menu, shoppingCart1);
                    

                    while(needForExtraComponents == true)
                    {
                        Console.WriteLine("Would you like to add some extra toppings?(1=yes/2=no)");
                        int componentAnswer = int.Parse(Console.ReadLine());
                        if(componentAnswer == 1)
                        {
                            AddToppingToCart(selectionOfComponents, shoppingCart2);
                            shoppingCart2.CalcShoppingCart2Total();
                        }
                        else if(componentAnswer == 2)
                        {
                            needForExtraComponents = false;
                            shoppingCart1.PrintShoppingCart1();
                            Console.WriteLine($"The pizzas all together add up to: {shoppingCart1.CalcShoppingCart1Total()} euros.");
                            shoppingCart2.PrintShoppingCart2();
                            Console.WriteLine($"The toppings all together add up to: {shoppingCart2.CalcShoppingCart2Total()} euros");
                        }
                        else
                        {
                            Console.WriteLine("Type 1 or 2!");
                        }
                    }

                    Console.WriteLine("Is that all or would you like to add another pizza?(1=That's all/2=Add)");
                    int endAnswer = int.Parse(Console.ReadLine());
                    if(endAnswer == 1)
                    {
                        needForList = false;
                    }
                    else
                    {
                        continue;
                    }
                    
                 }

                 else
                 {
                    Console.WriteLine("Type 1 or 2!");
                 }

            }

            PrintFinalOrder(shoppingCart1, shoppingCart2, shoppingCart3, shoppingCart4);
            Console.ReadLine();
           
        }
        static void PrintFinalOrder(ShoppingCart shoppingCart1, ShoppingCart shoppingCart2, ShoppingCart shoppingCart3, ShoppingCart shoppingCart4)
        {
            if(shoppingCart4 == null)
            {
                Console.WriteLine("---------------------------------------------------");
                shoppingCart1.PrintShoppingCart1();
                shoppingCart2.PrintShoppingCart2();

                Console.WriteLine($"Your order total is: {shoppingCart1.CalcShoppingCart1Total() + shoppingCart2.CalcShoppingCart2Total()}");
                Console.WriteLine("---------------------------------------------------");
            }
            else if(shoppingCart1 == null)
            {
                Console.WriteLine("---------------------------------------------------");
                shoppingCart4.PrintShoppingCart4();
                shoppingCart3.PrintShoppingCart3();
                Console.WriteLine($"Your order total is: {shoppingCart3.CalcShoppingCart3Total() + shoppingCart4.CalcShoppingCart4Total()}");
                Console.WriteLine("---------------------------------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                shoppingCart1.PrintShoppingCart1();
                shoppingCart2.PrintShoppingCart2();
                Console.WriteLine("---------------------------------------------------");
                shoppingCart4.PrintShoppingCart4();
                shoppingCart3.PrintShoppingCart3();

                Console.WriteLine($"Your order total is: {shoppingCart1.CalcShoppingCart1Total() + shoppingCart2.CalcShoppingCart2Total() + shoppingCart3.CalcShoppingCart3Total() + shoppingCart4.CalcShoppingCart4Total()}");
                Console.WriteLine("---------------------------------------------------");
            }
                
        }
        static void AddPizzaToCart(Menu menu, ShoppingCart shoppingCart1)
        {
            menu.PrintMenu();
            Console.WriteLine("Enter the id of the pizza you would like to add to cart:");
            int pizzaId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of pizzas you would like to add to cart:");
            int quantity = int.Parse(Console.ReadLine());
            Pizza pizzaToCart = menu.GetFromStock(pizzaId);
            shoppingCart1.AddToCart1(pizzaToCart, quantity);

            shoppingCart1.PrintShoppingCart1();
            Console.WriteLine($"The pizzas all together add up to: {shoppingCart1.CalcShoppingCart1Total()} euros.");
        }

        static void AddToppingToCart(ComponentMenu selectionOfComponents, ShoppingCart shoppingCart2)
        {
            selectionOfComponents.PrintAvailableComponents();
            Console.WriteLine("Enter the id of the component you would like to add:");
            int compId = int.Parse(Console.ReadLine());
            Component compToCart = selectionOfComponents.GetFromStock(compId);
            shoppingCart2.AddToCart2(compToCart);

            shoppingCart2.PrintShoppingCart2();


        }

        static void AddComponentsToCustomPizza(ComponentMenu selectionOfComponents, ShoppingCart shoppingCart3)
        {
            selectionOfComponents.PrintAvailableComponents();
            Console.WriteLine("Enter the id of the component you would like to add:");
            int compId = int.Parse(Console.ReadLine());
            Component compToCart = selectionOfComponents.GetFromStock(compId);
            shoppingCart3.AddToCart3(compToCart);

            shoppingCart3.PrintShoppingCart2();
        }

        static void AddCrustToCustomPizza(CrustStation selectionOfCrust, ShoppingCart shoppingCart4)
        {
            selectionOfCrust.PrintAvailableCrusts();

            Console.WriteLine("Enter the id of the crust you would like: ");
            int crustId = int.Parse(Console.ReadLine());
            Crust crustToCart = selectionOfCrust.GetFromStock(crustId);
            shoppingCart4.AddToCart4(crustToCart);

            shoppingCart4.PrintShoppingCart4();
        }

    }
}
