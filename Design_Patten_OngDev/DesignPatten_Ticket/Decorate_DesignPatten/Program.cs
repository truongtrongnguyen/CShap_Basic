using Decorate_DesignPatten.Base;
using Decorator_DesignPatten.Decorators;
using System;

namespace Decorate_DesignPatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Decorator cho phép thêm hành vi bằng cách đặt object vào trong một object khác, objec khác đó gọi là Decorator
             *  Quy định của Decorator là phải có một interface, core object và decor object
             */

            // Create: EggPuddingBlackSugarFruitPuddingBubbleMikTea
            var firstMilkTea = new EggPudding(
                                new BlackSugar(
                                    new FruitPudding(
                                        new Bubble(
                                            new MilkTea()))));
            Console.WriteLine("EggPuddingBlackSugarFruitPuddingBubbleMikTea: " + firstMilkTea.Cost());

            //Create: EggPuddingBlackSugarWhiteBubbleMilkTea
            var sercondMilkTea = new EggPudding(
                                    new BlackSugar(
                                        new WhiteBubble(
                                            new MilkTea())));
            Console.WriteLine("EggPuddingBlackSugarWhiteBubbleMilkTea " + sercondMilkTea.Cost());

            Console.ReadKey();
        }
    }
}
