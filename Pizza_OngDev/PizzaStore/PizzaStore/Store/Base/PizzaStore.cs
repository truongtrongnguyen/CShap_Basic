using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Store.Base
{
    using Pizzas.Base;
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Boxing();
        }
        protected abstract Pizza CreatePizza(string type);
    }
}
