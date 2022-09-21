using Command_DesignPatten.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command_DesignPatten
{
    internal class Remote   //Commander
    {
        private readonly ICommand turnOnCommand;
        private readonly ICommand turnOffCommand;

        public Remote(ICommand turnOnCommand, ICommand turnOffCommand)
        {
            this.turnOnCommand = turnOnCommand;
            this.turnOffCommand = turnOffCommand;
        }
        public void TurnOnButtonClick()
        {
            turnOnCommand.execute();
            //turnOnCommand.undo();
        }
        public void TurnOffButtonClick()
        {
            turnOffCommand.execute();
            //turnOffCommand.undo();
            
        }
    }
}
