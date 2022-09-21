using System;
using System.Collections.Generic;
using System.Text;

namespace Decorate_DesignPatten.Base
{
    internal class MilkTea : IMilkTea
    {
        public MilkTea()
        {

        }
        public double Cost()
        {
            return 5d; //Trả về kiểu double
        }
    }
}
