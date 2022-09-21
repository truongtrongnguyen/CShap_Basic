using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book_Contronller book = new Book_Contronller();
            while(true)
            {
                book.Giao_Tiep();
                 Console.ReadLine();
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
