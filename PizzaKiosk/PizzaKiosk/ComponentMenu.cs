using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class ComponentMenu
    {
        List<Component> selectionOfComponent;
        public ComponentMenu()
        {
            selectionOfComponent = new List<Component>();

            Component ExtraCheese = new Component();
            ExtraCheese.ComponentGenerator(1, "Extra Cheese", 1.5);

            Component Ham = new Component();
            Ham.ComponentGenerator(2, "Ham", 1.50);

            Component BlueCheese = new Component();
            BlueCheese.ComponentGenerator(3, "Blue Cheese", 1.5);

            Component Kebab = new Component();
            Kebab.ComponentGenerator(4, "Kebab", 1.50);

            Component TeryakiChicken = new Component();
            TeryakiChicken.ComponentGenerator(5, "Teryaki Chicken", 1.5);

            Component Pickles = new Component();
            Pickles.ComponentGenerator(6, "Pickles", 0.5);

            Component Olives = new Component();
            Olives.ComponentGenerator(7, "Olives", 0.5);

            Component Pineapple = new Component();
            Pineapple.ComponentGenerator(8, "Pineapple", 1.5);

            Component Corn = new Component();
            Corn.ComponentGenerator(9, "Corn", 0.5);

            Component Jalapeno = new Component();
            Jalapeno.ComponentGenerator(10, "Jalapeno", 0.5);

            Component TomatoPieces = new Component();
            TomatoPieces.ComponentGenerator(11, "Tomato Pieces", 0.5);

            Component Salami = new Component();
            Salami.ComponentGenerator(12, "Salami", 1.5);

            Component Chicken = new Component();
            Chicken.ComponentGenerator(13, "Chicken", 1.0);

            Component Texmex = new Component();
            Texmex.ComponentGenerator(14, "Texmex sauce", 0.5);

            Component Mincedmeat = new Component();
            Mincedmeat.ComponentGenerator(15, "Minced meat", 1.5);

            Component Mushrooms = new Component();
            Mushrooms.ComponentGenerator(16, "Mushrooms", 0.5);

            Component Onions = new Component();
            Onions.ComponentGenerator(17, "Onions", 0.5);

            Component Pepperoni = new Component();
            Pepperoni.ComponentGenerator(18, "Pepperoni", 1.5);




            selectionOfComponent.Add(ExtraCheese);
            selectionOfComponent.Add(Ham);
            selectionOfComponent.Add(BlueCheese);
            selectionOfComponent.Add(Kebab);
            selectionOfComponent.Add(TeryakiChicken);
            selectionOfComponent.Add(Pickles);
            selectionOfComponent.Add(Olives);
            selectionOfComponent.Add(Pineapple);
            selectionOfComponent.Add(Corn);
            selectionOfComponent.Add(Jalapeno);
            selectionOfComponent.Add(TomatoPieces);
            selectionOfComponent.Add(Salami);
            selectionOfComponent.Add(Chicken);
            selectionOfComponent.Add(Texmex);
            selectionOfComponent.Add(Mincedmeat);
            selectionOfComponent.Add(Mushrooms);
            selectionOfComponent.Add(Onions);
            selectionOfComponent.Add(Pepperoni);

        }


        public void PrintAvailableComponents()
        {
            foreach (Component component in selectionOfComponent)
            {
                Console.WriteLine($"ID: {component.id}");
                Console.WriteLine($"Name: {component.name}");
                Console.WriteLine($"Price: {component.price}");
            }
        }


       

        public Component GetFromStock(int id)
        {
            return selectionOfComponent[id - 1];
        }


    }
}
