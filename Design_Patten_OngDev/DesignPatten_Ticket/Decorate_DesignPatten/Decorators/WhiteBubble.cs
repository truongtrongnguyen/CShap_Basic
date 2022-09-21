using Decorate_DesignPatten.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPatten.Decorators
{
    internal class WhiteBubble:MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea inner):base(inner)
        {

        }
        public override double Cost()
        {
            return 1.5d+base.Cost();
        }
    }
}
