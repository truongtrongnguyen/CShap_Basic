using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store
{
    using PizzaStore.Pizzas.Base;
    using PizzaStore.Store.Base;
    internal class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "greek":
                    return new HCMGreekPizza();
                case "cheese":
                    return new HCMCheesePizza();
                case "pepperoni":
                    return new HCMPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
