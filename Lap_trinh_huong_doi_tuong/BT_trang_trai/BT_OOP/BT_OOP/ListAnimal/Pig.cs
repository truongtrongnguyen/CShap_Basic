using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class Pig:FarmingAnimal
    {
        public Pig()
        {
            Name = Constanst.C_Pig;
            EatFood = new Bran_Food();
        }
    }
}
