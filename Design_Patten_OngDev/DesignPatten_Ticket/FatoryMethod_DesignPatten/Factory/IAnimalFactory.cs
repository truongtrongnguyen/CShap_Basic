using FatoryMethod_DesignPatten.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod_DesignPatten.Factory
{
    internal interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }
}
