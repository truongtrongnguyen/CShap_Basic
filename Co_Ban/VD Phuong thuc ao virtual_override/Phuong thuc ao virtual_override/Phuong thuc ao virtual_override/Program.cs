using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_thuc_ao_virtual_override
{
    class Product
    {
        public double Price { set; get; }        //khai báo 1 giá trị Price
        //tại đây phải cho biết những phương thức nào có thể bị ghi đè, định nghĩa lại thì đó gọi là phương thức ảo
        //sau khi định nghĩa phương thức, xác định phạm vi truy cập, ta thêm vào từ virtual
        public virtual void ProductInfo()       //có thể bị định nghĩa lại, bị thay đổi
        {
            Console.WriteLine($"Gia san pham {Price}");
        }
        public void Test()  // Hoặc => Product();
        {
            ProductInfo();
        }
    }
    class Iphone : Product      //lớp Iphone kế thừa và sử dụng được các hàm trên lớp Product 
    {
        public Iphone()
        {
            Price = 500;
        }//DÙNG DẤU MŨI TÊN ĐỂ THAY THẾ CẶP DẤU NGOẶC {}, chỉ áp dụng trả về 1 đối tượng
        public override void ProductInfo() // lúc này thì giá trị của ProductInfo() đã bị ghi đè tại lớp kế thừa ở đây
        {
            Console.WriteLine("Dien thoai Iphone");
            base.ProductInfo();     //dùng từ khóa này để gọi lại giá trị khi chưa bị ghi đè ở lớp cơ sở
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Iphone IP = new Iphone();
            IP.Test(); ;
            Product P = new Product();
            P.Price = 100;
            P.Test();
            Console.ReadKey();
        }
    }
}
