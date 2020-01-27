using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaKiosk
{
    class Pizza
    {
        public int id;
        public string name;
        public string ingridients;
        public string crust;
        public int price;

        public void Oven(int _id, string _name, string _ingridients,string _crust, int _price)
        {
            id = _id;
            name = _name;
            ingridients = _ingridients;
            crust = _crust;
            price = _price;
        }
    }
}
