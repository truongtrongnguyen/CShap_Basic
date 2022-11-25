using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP.Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Giao_dien e = new Giao_dien();
            while(true)
            {
                e.Menu();
                e.User();
                Console.ReadLine();
                Console.Clear();
                           
            }
            Console.ReadKey();
        }
    }
}
