using System;

namespace PizzaStore
{
    using PizzaStore.Store;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            HUEPizzaStore huepizzasotre = new HUEPizzaStore();
            huepizzasotre.OrderPizza("cheese");

            DNPizzaStore dnpizzasotre = new DNPizzaStore();
            dnpizzasotre.OrderPizza("greek");

            HCMPizzaStore hcmpizzasotre = new HCMPizzaStore();
            hcmpizzasotre.OrderPizza("greek");

            Console.ReadKey();
        }
    }
}
