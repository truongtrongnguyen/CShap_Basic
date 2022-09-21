

namespace Test2
{
    using System;
    class Student
    {
        public readonly string name;
        public Student(string name)
        {
            this.name = name;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student hs = new Student("trong nguyen");
            Console.WriteLine(hs.name);
            //Giao_dien e = new Giao_dien();
            //while (true)
            //{
               
            //    e.Chon_che_do();
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            Console.ReadKey();
        }
    }
}