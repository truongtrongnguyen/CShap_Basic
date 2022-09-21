using System;
using System.Collections.Generic;
using System.Text;

namespace Command_DesignPatten.Base
{
    internal interface ICommand
    {
        void execute();
        void undo();
    }
}
