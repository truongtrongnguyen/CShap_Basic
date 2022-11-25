using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class Chicken:FarmingAnimal
    {
        public Chicken()
        {
            Name = Constanst.C_Chicken;
            EatFood = new Corn_Food();
        }
    }
}
