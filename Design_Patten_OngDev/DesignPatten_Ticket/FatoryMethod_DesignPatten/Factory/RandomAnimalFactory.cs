using FatoryMethod_DesignPatten.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace FatoryMethod_DesignPatten.Factory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Console.WriteLine("\t RandomAnimalFactory");
            Random random = new Random();
            switch (random.Next(0, 3))
            {
                case 0: return new Dog();
                case 1: return new Cat();
                default : return new Duck();
            }
        }
    }
}
