using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HCMPepperoniPizza:Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "HCM The best pepperoni pizza";
            dough = "HCM Thick dough";
            sauce = "HCM Sweet sauce";
            topping.Add("Tomato");
        }
    }
}
