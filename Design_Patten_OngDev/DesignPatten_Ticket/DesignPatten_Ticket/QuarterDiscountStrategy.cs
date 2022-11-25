using System;
using System.Collections.Generic;
using System.Text;
using Ticket_StrategyDesignPatten.Base;

namespace DesignPatten_Ticket
{
    internal class QuarterDiscountStrategy : IPromoteStrategy   // Giảm giá theo quý
    {
        public double DoDiscount(double price)
        {
            return price*0.75;
        }
    }
}
