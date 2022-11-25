using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class Dog:FarmingAnimal
    {
        public Dog()
        {
            Name = Constanst.C_Dog;
            EatFood = new Meat_Food();
        }
    }
}
