using Decorate_DesignPatten.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPatten.Decorators
{
    internal class FruitPudding:MilkTeaDecorator
    {
        public FruitPudding(IMilkTea inner):base(inner)     //Truyền thông số inner và gán cho inner cho class MilkTeadDecorator
        {

        }
        public override double Cost()
        {
            return 3d+base.Cost();
        }
    }
}
