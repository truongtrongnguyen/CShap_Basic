using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_StrategyDesignPatten.Base
{
    internal class Ticket
    {
        private IPromoteStrategy _promoteStrategy;
        private double _price;
        private string _name;

        #region Get Set Properties
        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promoteStrategy;
        }
        public void SetPromoteStrategy(IPromoteStrategy value)
        {
            _promoteStrategy = value;
        }
        public double GetPrice()
        {
            return _price;
        }
        public void SetPrice(double value)
        {
            _price = value;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            _name = value;
        }
        #endregion
        public Ticket()
        { }
        public Ticket(IPromoteStrategy promoteStrategy)
        {
            _promoteStrategy = promoteStrategy;
        }
        public double GetPromotedPrice()    //Hàm này nó sẽ gọi hàm DoDiscount để lấy ra được giá tiền sau khi đã tính toán giảm giá
        {
            return _promoteStrategy.DoDiscount(_price);
        }
    }
}
