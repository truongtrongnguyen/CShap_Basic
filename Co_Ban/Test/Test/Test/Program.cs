using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prog_CSharp
{
    using System;
    using System.Threading;
    class Student
    {
        public readonly string name;
        public Student()
        {
            name = "trong nguyen";
        }
    }
    public class Tester
    {
        static void Main()
        {
            Student hs = new Student();
            Console.WriteLine(hs.name);
            Console.ReadKey();
        } // end Main 
    } // end Tester 
} // end Prog_CSharp