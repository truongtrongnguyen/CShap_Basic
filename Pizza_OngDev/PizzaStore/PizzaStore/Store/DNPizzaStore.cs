using System;
using System.Collections.Generic;
using System.Text;


namespace PizzaStore.Store
{
    using PizzaStore.Pizzas.Base;
    using PizzaStore.Store.Base;

    internal class DNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {

            switch (type)
            {
                case "greek":
                    return new DNGreekPizza();
                case "cheese":
                    return new DNCheesePizza();
                case "pepperoni":
                    return new DNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
