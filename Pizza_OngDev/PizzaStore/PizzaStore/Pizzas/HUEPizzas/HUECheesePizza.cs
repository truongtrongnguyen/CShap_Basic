using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HUECheesePizza:Pizza
    {
        public HUECheesePizza()
        {
            name = "HUE The best Cheese Pizza";
            dough = "HUE Very thin dough";
            sauce = "HUE Very spicy sauce";      //sốt siêu cay
            topping.Add("BLack olives");     //Dầu ô liu
            topping.Add("Cheese");          //Phô mai
        }
    }
}
