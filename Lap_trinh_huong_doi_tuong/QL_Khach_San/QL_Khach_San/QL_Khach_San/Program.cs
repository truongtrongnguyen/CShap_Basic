using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_Khach_San.Models;
using QL_Khach_San.Utils;
namespace QL_Khach_San
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User_Contronller1 User = new User_Contronller1();
            User.Giao_dien();
            //Utilly.Convert("sd");

            Console.ReadKey();
        }
    }
}
