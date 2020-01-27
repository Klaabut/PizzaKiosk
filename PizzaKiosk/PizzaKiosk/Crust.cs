using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Crust
    {
        public int id;
        public string name;
        public double price;

        public void CrustGenerator(int _id, string _name, double _price)
        {
            id = _id;
            name = _name;
            price = _price;
        }
    }
}
