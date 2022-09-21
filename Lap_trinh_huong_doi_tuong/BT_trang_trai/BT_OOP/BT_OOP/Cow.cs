using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    internal class Cow:FarmingAnimal
    {
        public Cow()
        {
            Name = Constanst.C_Cow;
            EatFood = new Grass_Food();
        }
    }
}
