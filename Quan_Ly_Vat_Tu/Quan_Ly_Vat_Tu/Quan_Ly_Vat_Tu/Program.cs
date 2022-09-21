using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Quan_Ly_Vat_Tu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            c.Menu();
            //string a = "VT0900,Vat Tu 1,Cai,17";
            //Regex re = new Regex(@"(?<ten1>(^VT\d+))\,(?<ten2>([\w|\s|\w]*))\,(?<dv>(\w+))\,(?<sl>\d+)");
            //MatchCollection m = re.Matches(a);
            //foreach(Match i in m)
            //{
            //    Console.WriteLine("ten: "+i.Groups["ten1"].ToString());
            //    Console.WriteLine(i.Groups["ten2"]);
            //    Console.WriteLine(i.Groups["dv"]);
            //    Console.WriteLine(i.Groups["sl"]);
            //}


            Console.ReadKey();
        }
    }
}
