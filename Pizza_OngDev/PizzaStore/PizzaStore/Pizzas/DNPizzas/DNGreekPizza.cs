using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    using PizzaStore.Pizzas.Base;
    internal class DNGreekPizza:Pizza
    {
        public DNGreekPizza()
        {
            
            name = "DN A good greek pizza";
            dough = "DN Thin dough";
            sauce = "DN Chilli sauce"; // sốt Ớt
            topping.Add("Tomato");
            topping.Add("Potato");  //Khoai tây
        }
    }
}
