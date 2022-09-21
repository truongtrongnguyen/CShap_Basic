using FatoryMethod_DesignPatten.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod_DesignPatten.AbstractFactory
{
    internal class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
                return new Duck();
            else
                return new Chicken();
        }
    }
}
