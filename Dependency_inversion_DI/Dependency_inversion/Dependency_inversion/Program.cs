using System;
using System.Reflection;
namespace Dependency_inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo1 k = new Demo1();
            //k.Demo();
            var a = Assembly.GetExecutingAssembly();
            Console.WriteLine(a.FullName);
            Console.ReadKey();
        }
    }
  

}
