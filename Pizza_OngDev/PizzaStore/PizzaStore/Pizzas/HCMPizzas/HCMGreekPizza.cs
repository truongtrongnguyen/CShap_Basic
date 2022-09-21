using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class HCMGreekPizza:Pizza
    {
        public HCMGreekPizza()
        {
            
            name = "HCM A good greek pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chilli sauce"; // sốt Ớt
            topping.Add("Tomato");
            topping.Add("Potato");  //Khoai tây
        }
    }
}
