using Decorate_DesignPatten.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_DesignPatten.Decorators
{
    internal class BlackSugar:MilkTeaDecorator
    {
        public BlackSugar(IMilkTea inner):base(inner)   //Truyền thông số inner và gán cho inner cho class MilkTeadDecorator
        {

        }
        public override double Cost()
        {
            return 2d+base.Cost();
        }
    }
}
