using System;
using System.Collections.Generic;
using System.Text;

namespace Command_DesignPatten.Base
{
    internal class TurnOffCommand : ICommand
    {
        private readonly Fan fan;

        public TurnOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public void execute()
        {
            fan.TurnOff();
        }

        public void undo()
        {
            fan.TurnOn();
        }
    }
}
