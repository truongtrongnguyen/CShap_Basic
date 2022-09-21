using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_DesignPatten.CarParts
{
    internal class Windscreen
    {
        public Windscreen(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
