using System;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Xunit;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
   
    class Demo
    {
        [Required(ErrorMessage = "Name phai thiet lap")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "sdc")]
        public string Name { get; set }
    }

}
