 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_ve_struct
{
    public struct Location
    {
        private int xvalue;
        private int yvalue;
        //public Location(int Ix, int Iy)
        //{
        //    xvalue = Ix;
        //    yvalue = Iy;
        //}
        public int x
        {
           get
            {
                return xvalue;
            }
            set
            {
                xvalue = value;
            }
        }
        public int y
        {
            set
            {
                yvalue = value;
            }
            get
            {
                return yvalue;
            }
        }
        public override string ToString()
        {
            return String.Format($"{xvalue},{yvalue}");
        }
    }
    internal class Program
    {   
        public static void Funtion(Location Lo)
        {
            Lo.x = 50;
            Lo.y = 100;
            Console.WriteLine("In my Funtion: {0}", Lo);
        }
        static void Main(string[] args)
        {
            Location l = new Location();
            
            Console.WriteLine($"Location= {l}");
            Program p = new Program();
            Funtion(l);
            Console.WriteLine($"Location= {l}");
            
            Console.ReadKey();
        }
    }
}
