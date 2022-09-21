using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_thuc_truu_tuong_abstract
{
    abstract class Product      //tạo ra 1 lớp trừu tượng, không được dùng với lệnh NEW
    {
        protected double Price { set; get; }
        abstract public void ProductInfo(); //tạo ra phương thức trừu tượng chỉ có tên không có phần thân phương thức

        public void Test() => ProductInfo();
    }
    class Iphone:Product   
    {
        public Iphone() => Price = 500;

        public override void ProductInfo()      //nạp chồng lại phương thức do ở trên lớp cơ sở chưa được định nghĩa
        {
            Console.WriteLine("Dien thoai Iphone");
            Console.WriteLine($"Gia san pham {Price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Iphone IP = new Iphone();
            IP.Test();
          //  Product P = new Product();    Không được vì sai cú pháp của abstract 
            Console.ReadKey();
        }
    }
}
