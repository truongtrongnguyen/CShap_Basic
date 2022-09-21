using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HUEPepperoniPizza:Pizza
    {
        public HUEPepperoniPizza()
        {
            name = "HUE The best pepperoni pizza";
            dough = "HUE Thick dough";
            sauce = "HUE Sweet sauce";
            topping.Add("Tomato");
        }
    }
}
