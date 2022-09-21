using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bieu_thuc_Lamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cách 1: 
             *  (Tham số) => Biểu thức
             *Cách 2:
             *  (Tham số) =>{
             *  Các biểu thức
             *  return ...}
             */
            Action<string> Thong_bao;
            Thong_bao=(string s) => Console.WriteLine(s);  //tương đương với delegate void Kieu(string s) hoặc Action<string>
            Thong_bao?.Invoke("Xin chao");//Nếu biến thông báo khác null thì nó sẽ xuất ra màn hình 
            //Hoặc
            Action Thong_bao1;  //Tạo 1 delegate không có kiểu trả về và không có tham số 
            Thong_bao1 = () => Console.WriteLine("Xin chao cac ban");//Tạo một biểu thức lamda không có kiểu trả về và không có tham số
            Thong_bao1?.Invoke();
            //Hoặc
            Action<string, string> Thong_bao2;
            Thong_bao2 = (s, e) => Console.WriteLine(s+e); // Do ở trên ta khai báo kiểu delegate có tham số là 2 chuỗi thì ta chỉ cần truyền
            Thong_bao2?.Invoke("Xin chao ", "Trong Nguyen");// vào tên chuỗi ở biểu thức lamda mà thôi cũng được
            //Hoặc
            Action<string, string> Thong_bao3;
            Thong_bao3 = (s, e) =>
            {         // Do ở trên ta khai báo kiểu delegate có tham số là 2 chuỗi thì ta chỉ cần truyền
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(s + e);
                Console.ResetColor();
            };
            Thong_bao3?.Invoke("Xin chao ", "Trong Nguyen");
            //Hoặc
            Func<int, int, int> TinhTong; //Tạo biến delegate có kiểu int và 2 tham số là kiểu int
            TinhTong = (a, b) =>
            {
                int kq = a + b;
                return kq;
            };
            Console.WriteLine("Tinh tong: " + TinhTong?.Invoke(5, 6));
            //Hoặc
            int[] array = { 2, 3, 9, 5, 66, 77, 88, 99 };
            var kq1 = array.Select((int x) =>   //phương thức select trả về từng phần tử đi qua biểu thức delegate (hoặc lamda)  
            {                              // Tại những phương thức mà nhận tham số là delegate thì ta có thể truyền vào biểu thức lamda
                return Math.Sqrt(x);
            });
            foreach(var result in kq1)
            {
                Console.WriteLine(result);
            }
            //Hoặc
            Console.WriteLine("Su dung phuong thuc ForEach");
            int[] array1 = { 2, 3, 9, 5, 66, 77, 88, 99 };
            array1.ToList().ForEach((x) =>  //ForEach nhận delegate không có kiểu trả về nên ta cho nó duyệt qua từng phần tử theo 
            {                                    // theo biểu thức lamda
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            });
            //Hoặc
            Console.WriteLine("Su dung phuong thuc Where");
            int[] array2 = { 2, 3, 9, 5, 14, 20, 66, 77, 88, 99 };
            var w = array2.Where((y) =>  
            {                                   
                return y >= 2 && y <= 30;
            });
            foreach(var i in w)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
