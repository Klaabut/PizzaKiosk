using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class CrustStation
    {
        List<Crust> selectionOfCrust;

        public CrustStation()
        {
            selectionOfCrust = new List<Crust>();

            Crust thin = new Crust();
            thin.CrustGenerator(1, "thin", 1.50);
            Crust thick = new Crust();
            thick.CrustGenerator(2, "thick", 3);

            selectionOfCrust.Add(thin);
            selectionOfCrust.Add(thick);

        }

        public void PrintAvailableCrusts()
        {
            foreach(Crust crust in selectionOfCrust)
            {
                Console.WriteLine($"Id: {crust.id} \n Name: {crust.name} \n Price: {crust.price}");
            }
        }

        public Crust GetFromStock(int id)
        {
            return selectionOfCrust[id - 1];
        }
      
    }
}
