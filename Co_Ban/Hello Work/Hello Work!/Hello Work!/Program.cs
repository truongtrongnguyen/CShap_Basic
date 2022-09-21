//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using <tên thư viện>;  --> chỉ cho trình biên dịch biết rằng mình đang sử dụng thư viện nào
////có thể sử dụng thư viện có sẵn hoặc tự tạo
//namespace Hello_Work_
////namespace <tên namespace>  -->ý nghĩa là báo cho trình biên dịch biết rằng
////các thành phần bên trong dấu {} đều thuộc namespace
//{
//    class Program
//    //class <Tên của class>
//    {
//        static int n;
//        static void Main(string[] args)//đây là hàm chính của chương trình
//        {
//            /*
//            string year = "Hello Work!";
//            //có 5 lệnh nhập xuất trong C#
//            Console.Write("Hello Work /n");//sử dụng kí tự đặc biệt
//            Console.WriteLine();//có chữ line nên nó tự xuống dòng
//           // Console.Write(Enviroment.NewLine);-->sử dụng lệnh xuống dòng
//            Console.Read();
//            Console.ReadKey();//lệnh dừng màn hình 
//            Console.ReadLine();//lệnh dừng màn hình 
//            */
//            /*
//            Console.Write("{0} {1} {2} {3}" , 1, 2, 3, 4);//xuất dữ liệu lần lượt
//            Console.ReadKey();*/


//            //Đọc kí tự từ bàn phím và xuất kí tự đó ra màn hình
//            // Console.WriteLine(Console.Read());    -->chỉ đọc được 1 kí tự
//            // Console.Write("Nhap ten cua ban: ");
//            //Console.WriteLine("Ten cua ban la: "+Console.ReadLine());  //Giá trị đọc luôn là 1 chuỗi
//            //Console.ReadKey();

//            /*
//            Console.ReadKey();//không truyền tham số mặc định là false
//            Console.ReadKey(false);//hiển thị phím nhấn lên màn hình
//            Console.ReadKey(true);//không hiển thị phím nhấn lên mà hình
//            */

//            //VÍ DỤ VỀ ÉP KIỂU DỮ LIỆU 
//            /* int a;
//             bool kt;
//             string b = "10e", d = "20";
//             kt = int.TryParse(b, out a);
//             Console.WriteLine(kt==true?"Success":"Failed");
//             Console.WriteLine("a=" + a);


//             int value = Convert.ToInt32("9");
//             Console.WriteLine("value= "+value);
//             Console.ReadKey();*/




//            /*  Console.WriteLine("   Chuong trinh tinh tong hieu tich thuong     ");
//              string date1, date2;
//              int a, b;
//              bool kta;
//              bool ktb;
//              int tong, hieu, tich;
//              double thuong;
//              Console.Write("Nhap so a= ");
//              kta = int.TryParse(Console.ReadLine(), out a);
//              Console.WriteLine("Nhap so b= ");
//              ktb=int.TryParse(Console.ReadLine(), out b);
//              //  kta= int.TryParse(date1, out a);
//              Console.Write("Ep kieu bien a ");
//               Console.WriteLine(kta==true?"Success":"Failed");

//              //ktb =int.TryParse(date2, out b);
//              Console.Write("Ep kieu bien b ");
//               Console.WriteLine(ktb==true?"Success":"Flaied");
//              Console.WriteLine("a= " + a);
//              Console.WriteLine("b= "+b);
//              tong = a + b;
//              hieu = a - b;
//              tich = a * b;
//              thuong = a / b;
//              Console.WriteLine("Tong = " + tong);
//              Console.WriteLine("Tich ="+tich);
//              Console.WriteLine("Hieu ="+hieu);
//              Console.WriteLine("THuong ="+thuong);
//              Console.ReadKey();
//            */

//            /*
//            Console.Write("Nhap gia tri value: ");
//            int value = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(value+5);
//            Console.ReadKey();*/


//            /*
//            // Ve hinh chu nhat rong trong C#
//            Console.Write("Moi ban nhap vao chieu dai: ");
//            int cd = int.Parse(Console.ReadLine());
//            Console.Write("Moi ban nhap vao chieu rong: ");
//            int cr = int.Parse(Console.ReadLine());
//            // In canh ngan
//            for (int stt_cr = 1; stt_cr <= cr; stt_cr++)
//            {
//                // In canh dai
//                for (int stt_cd = 1; stt_cd <= cd; stt_cd++)
//                {
//                    if ((stt_cd == 1) || (stt_cd == cd) || (stt_cr == 1) || (stt_cr == cr))
//                    {
//                        Console.Write('*');
//                    }
//                    else
//                    {
//                        Console.Write(' ');
//                    }
//                }
//                Console.WriteLine();
//            }*/

//            Console.ReadKey();
//        }
//    }
//}


using System;
namespace AppDomainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Environment.Exit(0);
            MyClass1 obj1 = new MyClass1();
            MyClass2 obj2 = new MyClass2();
            Console.Read();
        }
    }
    public class MyClass1
    {
    }
    public class MyClass2
    {
    }
}
