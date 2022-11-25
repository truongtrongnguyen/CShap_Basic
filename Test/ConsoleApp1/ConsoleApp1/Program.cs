using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Docghifile();
            Console.ReadKey();
        }
        public void Docghifile()
        {
            string path=@"C:\Users\DELL\Desktop/456.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            //sw.WriteLine(Console.ReadLine());
            //sw.Flush();
            string s="" ;
            s = sw.ReadToEnd();
            Console.WriteLine(s);
        }
    }
}
