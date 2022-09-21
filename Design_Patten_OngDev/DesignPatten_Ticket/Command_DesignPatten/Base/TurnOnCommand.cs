using System;
using System.Collections.Generic;
using System.Text;

namespace Command_DesignPatten.Base
{
    internal class TurnOnCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOnCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void execute()
        {
            fan.TurnOn();
        }

        public void undo()
        {
            fan.TurnOff();
        }
    }
}
