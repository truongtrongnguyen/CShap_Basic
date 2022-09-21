using System;

namespace QL_NV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Controller c = new Controller();
            c.Menu();
            Console.ReadKey();
        }
    }
}
