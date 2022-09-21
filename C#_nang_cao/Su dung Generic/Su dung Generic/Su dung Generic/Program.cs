using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_dung_Generic
{
    internal partial class Program
    {
        //public static void Swap(ref int a, ref int b)//xây dựng hàm hoán vị kiểu int
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //public static void Swap(ref float a, ref float b)//xây dựng hàm hoán vị kiểu float
        //{
        //    float temp = a;
        //    a = b;
        //    b = temp;
        //}
        public static void Swap<T>(ref T a, ref T b)//xây dựng hàm Generic 
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //Sử dụng Generic với class
        public class MyGeneric<T>
        {
            private T[] item; //tạo 1 mảng kiểu dữ liệu T có tên là item
            public T[] Item
            {
                get { return item; }
            }
            public MyGeneric(int size)
            {
                item = new T[size];//khởi tạo mảng với size mình sử dụng                                                                                                                                                                                    
            }
            public T GetIndex(int Index) //trả về vị trí của phần tử thông qua index
            {
                if (Index < 0 || Index > item.Length)
                    throw new IndexOutOfRangeException();
                else
                    return Item[Index];
            }
            public void Setitemvalue(int index, T value)//Gán 1 giá trị cho 1 phần tử tại vị trí được chỉ định
            {
                if (index < 0 || index > item.Length)
                    throw new IndexOutOfRangeException();
                else
                    item[index] = value;
            }
        }
        

        #region//VD Sử dụng generic của Xuanlap
        class Product<T>
        {
            private T item;
            public void SetID(T item)
            {
                this.item = item;
            }
            public void PrintsID()
            {
                Console.WriteLine("ID cua san pham la: " + item);
            }
        }
        #endregion

        #region//Sử dụng kiểu dữ liệu vô danh
        //  https://xuanthulab.net/kieu-vo-danh-va-kieu-dong-dynamic-trong-c-c-sharp.html
        static void Su_dung_kieu_du_lieu_vo_danh()
        {
            //Khai báo kiểu dữ liệu vô danh có thuộc tính chỉ đọc
            var sanpham = new
            {
                Ten = "Iphone8",
                Gia = 1000,
                NamSX = 2018
            };
            Console.WriteLine("Ten san pham: " + sanpham.Ten);
            Console.WriteLine("Gia san pham: " + sanpham.Gia);
        }
        #endregion


        #region //Sử dụng tạo đối tượng vô danh truy vấn linq
       public  class Sinhvien
       {
            public string HoTen { set; get; }
            public int Namsinh { get; set; }
            public string Noisinh { get; set; }
       }
        #endregion

        static void Main(string[] args)
        {
            
            Stack<int> mf = new Stack<int>();
            int a = 5;
            int b = 2;
            Swap<int>(ref a, ref b);
            //Hoặc
            Swap(ref a, ref b);
            Console.WriteLine($"a: {a} b: {b}");
            MyGeneric<int> MyG = new MyGeneric<int>(5);//Khởi tạo 1 mảng số nguyên có 5 phần tử
            MyG.Setitemvalue(0, 10);//gán 10 vào vị trí 0
            MyG.Setitemvalue(1, 11);
            MyG.Setitemvalue(2, 12);
            Console.WriteLine(MyG.GetIndex(2));
            Console.WriteLine();

            Product<int> SanPham = new Product<int>();//Tạo 1 class có kiểu dữ liệu là int
            SanPham.SetID(12345);
            SanPham.PrintsID();
            Product<string> SanPham2 = new Product<string>();//Tạo 1 class có kiểu dữ liệu là string
            SanPham2.SetID("abc");
            SanPham2.PrintsID();

            Console.WriteLine();
            Console.WriteLine("Su dung kieu du lieu vo danh");
            Su_dung_kieu_du_lieu_vo_danh();
            Console.WriteLine();

            #region//SỬ DỤNG TRUY VẤN Linq
            Console.WriteLine("Su dung truy van linq");
            List<Sinhvien> cacsinhvien = new List<Sinhvien>()//Tạo 1 cllection có kiêu dữ liệu là sinh viên
            {
                new Sinhvien(){HoTen="Nam", Namsinh=2000, Noisinh="CM"},
                new Sinhvien(){HoTen="Vy",  Namsinh=2002, Noisinh="CT"},
                new Sinhvien(){HoTen="Thu", Namsinh=2003, Noisinh="ST"},
                new Sinhvien(){HoTen="Nhi", Namsinh=2001, Noisinh="BL"}

            };
            var kq = from sv in cacsinhvien//Truy vấn các sinh viên từ danh sách các sinh viên
                     where sv.Namsinh <= 2003//phải thỏa dk Namsinh <=2003
                     //tại đây có thể lấy DK là HoTen hoặc Namsinh hoặc Noisinh
                     select new//Tạo những đối tượng kiểu vô danh để lưu những dữ liệu trả về
                     {
                         Ten = sv.HoTen,
                         Namsinh=sv.Namsinh,
                         Noisinh = sv.Noisinh
                     };
            foreach (var sinhvien in kq)
            {
                Console.WriteLine(sinhvien.Ten + " - " + sinhvien.Noisinh);
            }
            #endregion

            int? av=null;//khai báo biến kiểu trị có giá trị là null
            //av = null;
            if (av == null)
                Console.WriteLine("Bien av la null");
            Console.ReadKey();
        }
    }
}
