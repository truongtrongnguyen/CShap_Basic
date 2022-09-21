using FatoryMethod_DesignPatten.Animals;
using FatoryMethod_DesignPatten.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod_DesignPatten.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
