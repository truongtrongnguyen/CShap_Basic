using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Base
{
    internal abstract class Observer
    {
        protected Subject subject;
        public abstract void Notify(Subject subject, object arg);

        // Class này đã được generic, không thay đổi gì nữa cả và nó đã được đóng gói
    }
}
