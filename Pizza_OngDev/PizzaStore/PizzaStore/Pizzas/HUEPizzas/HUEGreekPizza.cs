using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HUEGreekPizza:Pizza
    {
        public HUEGreekPizza()
        {
            
            name = "HUE A good greek pizza";
            dough = "HUE Thin dough";
            sauce = "HUE Chilli sauce"; // sốt Ớt
            topping.Add("Tomato");
            topping.Add("Potato");  //Khoai tây
        }
    }
}
