using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store
{
    using PizzaStore.Pizzas.Base;
    using PizzaStore.Store.Base;
    internal class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "greek":
                    return new HUEGreekPizza();
                case "cheese":
                    return new HUECheesePizza();
                case "pepperoni":
                    return new HUEPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
