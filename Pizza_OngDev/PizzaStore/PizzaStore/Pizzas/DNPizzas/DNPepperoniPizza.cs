using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class DNPepperoniPizza:Pizza
    {
        public DNPepperoniPizza()
        {
            name = "DN The best pepperoni pizza";
            dough = "DN Thick dough";
            sauce = "DN Sweet sauce";
            topping.Add("Tomato");
        }
    }
}
