using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Pizzas.Base
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> topping = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough (nhàu bột)...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding topping: ");
            topping?.ForEach(topping => Console.WriteLine("\t" + topping));

        }
        public void Bake()//Nướng
        {
            Console.WriteLine("Baking " + name + " in 30 mins");
        }
        public void Cut()
        {
            Console.WriteLine("Cut " + name);
        }
        public void Boxing()
        {
            Console.WriteLine("Boxing " + name);
            Console.WriteLine();
        }
    }
}
