using System;
using System.Collections.Generic;
using System.Text;

namespace Command_DesignPatten
{
    internal class Fan  //Receiver
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
}
