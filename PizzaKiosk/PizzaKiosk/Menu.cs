using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Menu
    {
        List<Pizza> menu = new List<Pizza>();


        public Menu()
        {
            Pizza Mafioso1 = new Pizza();
            Mafioso1.Oven(1, "Mafioso", "Cheese, tomato, salami, olives","thin", 5);

            Pizza Mafioso2 = new Pizza();
            Mafioso2.Oven(2, "Mafioso", "Cheese, tomato, salami, olives", "thick", 7);

            Pizza Hawaii1 = new Pizza();
            Hawaii1.Oven(3, "Hawaii", "Cheese, tomato, pineapple, chicken", "thin", 6);

            Pizza Hawaii2 = new Pizza();
            Hawaii2.Oven(4, "Hawaii", "Cheese, tomato, pineapple, chicken", "thick", 8);

            Pizza Bolognese1 = new Pizza();
            Bolognese1.Oven(5, "Bolognese", "Cheese, tex-mex sauce, jalapeno, minced meat", "thin", 6);

            Pizza Bolognese2 = new Pizza();
            Bolognese2.Oven(6, "Bolognese", "Cheese, tex-mex sauce, jalapeno, minced meat", "thick", 8);

            Pizza Francescana1 = new Pizza();
            Francescana1.Oven(7, "Francescana", "Cheese, tomato, mushrooms, ham", "thin", 7);

            Pizza Francescana2 = new Pizza();
            Francescana2.Oven(8, "Francescana", "Cheese, tomato, mushrooms, ham", "thick", 9);

            Pizza Pepperone1 = new Pizza();
            Pepperone1.Oven(9, "Pepperone", "Cheese, tomato, onions, pepperoni", "thin", 8);

            Pizza Pepperone2 = new Pizza();
            Pepperone2.Oven(10, "Pepperone", "Cheese, tomato, onions, pepperoni", "thick", 10);

            menu.Add(Mafioso1);
            menu.Add(Mafioso2);
            menu.Add(Hawaii1);
            menu.Add(Hawaii2);
            menu.Add(Bolognese1);
            menu.Add(Bolognese2);
            menu.Add(Francescana1);
            menu.Add(Francescana2);
            menu.Add(Pepperone1);
            menu.Add(Pepperone2);
        }

        public void PrintMenu()
        {
            foreach (Pizza pizza in menu)
            {
                Console.WriteLine($"ID: {pizza.id}");
                Console.WriteLine($"Name: {pizza.name}");
                Console.WriteLine($"Ingridients: {pizza.ingridients}");
                Console.WriteLine($"Crust: {pizza.crust}");
                Console.WriteLine($"Price: {pizza.price}");
                Console.WriteLine();

            }
        }
        public Pizza GetFromStock(int id)
        {
            return menu[id - 1];
        }
    }
}
