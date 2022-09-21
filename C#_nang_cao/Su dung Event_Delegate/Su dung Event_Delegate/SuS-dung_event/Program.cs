using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuS_dung_event
{
    static class abc
    {
        public static float BinhPhuong(this int a)
        {
            return a * a;
        }
    }
    
    internal class Program
    {
        //public delegate void Sukiennhapso(int x);
        public class Dulieunhap : EventArgs //Do lớp EventArgs chưa có dữ liệu gì nên ta cần xây dựng dữ liệu cho nó
        {
            public int data { set; get; }
            public Dulieunhap(int x)
            {
                data = x;
            }
        }
        public class ae:EventArgs
        {

        }
        class UserInput
        {
           // public event Sukiennhapso sukiennhapso;
            public event EventHandler sukiennhapso; //tương đương delegate void KIEU ( object? sender, EventArgs args)
                                                    //Kiểu object có thể nhận tham số là null
            public void Input()
            {
               
                for(int i=0;i<10;i++)
                {
                    Console.Write("Nhap vao so nguyen: ");
                    string s = Console.ReadLine();
                    int x = Convert.ToInt32(s);
                    //phát đi sự kiện

                    sukiennhapso?.Invoke(this,new Dulieunhap(x));
                    //if(sukiennhapso!=null)
                    //{
                    //    sukiennhapso(this, new ae());
                    //}
                }
            }
        }
        class TinhCan
        {
            public void Sub(UserInput userinput)//Phương thức này dùng để đăng kí sự kiện nhập số
            {
                userinput.sukiennhapso += Tinh;
            }
            //tương đương delegate void KIEU ( object? sender, EventArgs args)
            public void Tinh(object sender, EventArgs e)    //Phải khai báo cùng kiểu với event mới có thể thực hiện += được
            {
                //Do mỗi lần phát đi sự kiện thì nó sẽ new Dulieunhap(i) nên ta cần convert lại cái EventArgs truyền vào
                Dulieunhap dulieunhap = (Dulieunhap)e;
                int i = dulieunhap.data;
                Console.WriteLine($"Can bac hai cua so {i} la {Math.Sqrt(i)}"); 
            }
        }
        class TinhBinhPhuong
        {
            public void Sub(UserInput userinput)//Phương thức này dùng để đăng kí sự kiện nhập số
            {
                userinput.sukiennhapso += BinhPhuong;
            }
            public void BinhPhuong(object sender, EventArgs e)
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                int i = dulieunhap.data;
                Console.WriteLine($"Binh phuong cua {i} la {i * i}");
            }
        }
        
        static void Main(string[] args)
        {
            int a = 2;
            a.BinhPhuong();
            Console.WriteLine(a.BinhPhuong());
            // Lớp UserInput là lớp phát đi sự kiện nên được gọi là publisher
            UserInput input = new UserInput();
            //Do sự kiện nhập số là một delegate nên ta có thể thay thế là một biểu thức lamda 
            // nhưng phải phù hợp với kiểu delegate
            // input.sukiennhapso += (x) => Console.WriteLine("Ban vua nhap so: " + x);

            input.sukiennhapso += (sender, e) =>
            {
                Dulieunhap dulieunhap = (Dulieunhap)e;
                Console.WriteLine("Ban vua nhap: " + dulieunhap.data);
            };
            // Lớp nhận sự kiện khi có publisher phát đi sự kiện là subsriver
            TinhCan tinh = new TinhCan();
            tinh.Sub(input);

            TinhBinhPhuong binhphuong = new TinhBinhPhuong();
            binhphuong.Sub(input);
            input.Input();
            Console.ReadKey();
        }      
    }
}
