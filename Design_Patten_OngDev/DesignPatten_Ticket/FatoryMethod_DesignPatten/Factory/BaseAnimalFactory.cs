using FatoryMethod_DesignPatten.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod_DesignPatten.Factory
{
    internal class BaseAnimalFactory : IAnimalFactory
    {
        private int index=0;
        public IAnimal CreateAnimal()
        {
            Console.WriteLine("\t BaseAnimalFactory");
            if(index==0)
            {
                index++;
                return new Dog();
            }
            if (index == 1)
            {
                index++;
                return new Cat();
            }
            if (index == 2)
            {
                index=0;
                return new Duck();
            }
            return null;
        }
    }
}
