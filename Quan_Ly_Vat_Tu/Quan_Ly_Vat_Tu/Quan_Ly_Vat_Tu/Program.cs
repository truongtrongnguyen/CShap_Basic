using System;
using System.Collections.Generic;
using System.Linq;
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
            //c.Menu();
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
            //var rnd = new Random();
            //var randomNumbers = Enumerable.Range(0, 9).OrderBy(x => rnd.Next()).Take(6).ToList();
            //randomNumbers.ToList().ForEach(x =>
            //{
            //    Console.WriteLine(x);
            //});

            Random r = new Random();
            int rnd = r.Next(DateTime.UtcNow.Millisecond, DateTime.UtcNow.Minute);
            List<int> aux = new List<int>();
            //while (aux.Count < 3)
            //{
                
            //    aux.Add(rnd);
            //}
            
            aux.ToList().ForEach(x =>
            {
                Console.Write(x);
            });
            Console.Write(rnd);

            Console.ReadKey();
        }
    }
}
