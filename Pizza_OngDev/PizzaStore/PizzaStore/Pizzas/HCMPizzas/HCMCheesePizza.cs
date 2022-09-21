using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HCMCheesePizza:Pizza
    {
        public HCMCheesePizza()
        {
            name = "HCM The best Cheese Pizza";
            dough = "HCM Very thin dough";
            sauce = "HCM Very spicy sauce";      //sốt siêu cay
            topping.Add("BLack olives");     //Dầu ô liu
            topping.Add("Cheese");          //Phô mai
        }
    }
}
