using System;
using System.Collections.Generic;
using System.Text;

namespace Decorate_DesignPatten.Base
{
    internal abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        protected MilkTeaDecorator(IMilkTea inner)
        {
            _milkTea = inner;
        }
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}
