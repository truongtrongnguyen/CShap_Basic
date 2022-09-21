using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_dien_Interface
{

    interface Hinhhoc
    {
         double Tinhchuvi();      //triển khai giao diện

         double Tinhdientich();    //triển khai giao diện
        string Giatri();

    }
    class Hinhchunhat: Hinhhoc          //MỖI LỚP KẾ THỪA PHẢI ĐỊNH NGHĨA LẠI LỚP CƠ SỞ
    {
        public Hinhchunhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double a { set; get; }    //khai báo cạnh a
        public double b { set; get; }   //khai báo cạnh b

        public double Tinhchuvi()       //khai báo định nghĩa phương thức cần phải triển khai
        {
            return 2 * (a + b);
        }

        public double Tinhdientich()
        {
            return a * b;
        }
        public string Giatri()
        {
            return "Chu vi: "+ Tinhchuvi()+" | Dien tich: "+Tinhdientich();
        }
        public string Hinhhoc
        {
            set;get;
        }
    }
    class Hinhtron: Hinhhoc
    {
        public double r { set; get; }      //khai báo bán kính

        public Hinhtron(double _r) => r = _r;   //khai báo hàm Constructor

        public double Tinhchuvi()
        {
            return 2 * r * Math.PI;
        }

        public double Tinhdientich()
        {
            return Math.PI * r * r;
        }
        public string Giatri()
        {
            return "Da tinh xong";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Hinhchunhat h = new Hinhchunhat(4, 5);
            Console.WriteLine($"Dien tich = { h.Tinhdientich()}, chu vi = {h.Tinhchuvi()}");
            h.Giatri();
            Hinhtron htron = new Hinhtron(1);
            Console.WriteLine($"Dien tich hinh tron: {htron.Tinhdientich()}, Chu vi hinh tron: {htron.Tinhchuvi()}");
            Hinhhoc hinh= htron as Hinhhoc;
            if(hinh==null)
            {
                Console.WriteLine("hinh khong duoc ho tro! ");
            }
            else
                Console.WriteLine(hinh.Giatri());
            Console.ReadKey();
        }
    }
}
