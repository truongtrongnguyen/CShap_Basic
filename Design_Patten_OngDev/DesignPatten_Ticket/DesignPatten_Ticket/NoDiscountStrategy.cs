using System;
using System.Collections.Generic;
using System.Text;
using Ticket_StrategyDesignPatten.Base;

namespace DesignPatten_Ticket
{
    internal class NoDiscountStrategy:IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
