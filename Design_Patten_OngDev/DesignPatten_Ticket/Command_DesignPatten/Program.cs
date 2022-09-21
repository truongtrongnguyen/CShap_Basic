using Command_DesignPatten.Base;
using System;

namespace Command_DesignPatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  https://gpcoder.com/4686-huong-dan-java-design-pattern-command/
             * - encapsulate a request as an object, thereby letting you parametrize client with different request, 
             *      queue or log request, and support undoable opertions. 
             * - promote invocation of a method on an ojbect to full object status
             */
            Fan fan = new Fan();

            //Nó sẽ đóng gói những yêu cầu vào trong interface ICommand
            ICommand turnOnCommand = new TurnOnCommand(fan); 
            ICommand turnOffCommand = new TurnOffCommand(fan);

            Remote remote = new Remote(turnOnCommand, turnOffCommand);
            remote.TurnOnButtonClick();
            remote.TurnOffButtonClick();

        }
    }
}
