using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class A : IDisposable
    {
        bool resource = true;
        public void Dispose()
        {
            Console.WriteLine("Phương thức này gọi tự động khi hết using");
            resource = false; // giải phóng tài nguyên
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            //Person person = new Person("Trong Nguyen", "359/2b nvc", "Quan NK", "tp.CT", new DateTime(2001, 05, 19));
            //Person person1 = new Person("Trong Nguyen", "359/2b nvc", "Quan NK", "tp.CT", new DateTime(2001, 05, 19));
            //Address dc1 = new Address("359/2b nvc", "Quan NK", "tp.CT");
            //Address dc2 = new Address("359/2b nvc", "Quan NK", "tp.CT");

            //Console.WriteLine("Nguoi.tostring(): "+person.tostring());
            //Console.WriteLine($"Nguoi.operator(): {dc1 == dc2}");
            //Console.WriteLine("Nguoi.TaoEmail: " + person.tenEmail());
            //Console.WriteLine("So nguoi: "+Person.So_nguoi);

            using (var a = new A())
            {
                Console.WriteLine("Do something ...");
            }
            Console.ReadKey();
        }
    }
}
