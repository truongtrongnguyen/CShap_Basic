using Decorate_DesignPatten.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPatten.Decorators
{
    internal class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea inner) : base(inner)     //Truyền thông số inner và gán cho inner cho class MilkTeadDecorator
        {

        }
        public override double Cost()
        {
            return 1d+base.Cost();
        }
    }
}
