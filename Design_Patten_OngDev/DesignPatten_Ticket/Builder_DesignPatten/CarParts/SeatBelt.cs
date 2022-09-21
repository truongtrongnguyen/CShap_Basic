using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_DesignPatten.CarParts
{
    internal class SeatBelt
    {
        public SeatBelt(string brand)
        {
            Brand = brand;
        }
        public string Brand { get; set; }
    }
}
