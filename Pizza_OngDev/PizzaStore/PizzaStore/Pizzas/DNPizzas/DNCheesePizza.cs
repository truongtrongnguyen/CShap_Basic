using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class DNCheesePizza:Pizza
    {
        public DNCheesePizza()
        {
            name = "DN The best Cheese Pizza";
            dough = "DN Very thin dough";
            sauce = "DN Very spicy sauce";      //sốt siêu cay
            topping.Add("BLack olives");     //Dầu ô liu
            topping.Add("Cheese");          //Phô mai
        }
    }
}
