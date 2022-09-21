using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_ve_lap_trinh_huong_doi_tuong
{
    internal class Vukhi
    {   
        public Vukhi()//ĐÂY LÀ HÀM CONTRUCTOR KHÔNG CÓ THÔNG SỐ
        {
            Console.WriteLine("Day la ham Contructor");
        }
        
        public Vukhi(string tenloaivukhi)//HÀM CONTRUCTOR NHẬN THÔNG SỐ LÀ MỘT CHUỖI STRING
        {
            Console.WriteLine($"Ten loai vu khi la: {tenloaivukhi}");
        }
        private string tenvukhi="sung AK";
        private int dosatthuong=0;

        public void thietlapdosatthuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;
        }
        
        public  void tancong()
        {
            Console.WriteLine(tenvukhi);
            for(int i=0;i<dosatthuong;i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        public int satthuong        //THUOC TINH
        {
            set //ghi vao
            {   //các lệnh thi hành
                dosatthuong = value;
            }
            get //doc ra
            {   //truy cap
                return dosatthuong;
            }
        }
        public string Noisanxuat { set; get; }      //THUOC TINH

        public Vukhi(string tenvukhi, int dosatthuong)
        {
            this.tenvukhi = tenvukhi;
            this.dosatthuong = dosatthuong;

        }
    }
    
    class student : IDisposable
    {
        public string name;
        public student(string name)
        {
            this.name = name;
            Console.WriteLine($"Khoi tao: {name}");
        }

        ~student()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy + {0}", name);
            Console.ResetColor();
        }
        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy + {0}", name);
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void test()
        {
            using (student s = new student("sinhvien ")) ;
          
        }
        static void Main(string[] args)
        {
            Vukhi sungluc;//mang gia tri NULL
            sungluc = new Vukhi();

        
            Vukhi sungtruong = new Vukhi("sungtruong");
            // Console.WriteLine($"Ten vu khi: {Vukhi.tenvukhi}");
            
            //sungtruong.tenvukhi = "Sung AK";
            sungtruong.thietlapdosatthuong(5);
            sungtruong.tancong();
            Console.WriteLine($"sat thuong= {sungtruong.satthuong}");
            sungtruong.Noisanxuat = "My";
            Console.WriteLine($"Doc thuoc tinh Noisanxuat: {sungtruong.Noisanxuat}");

            Vukhi sungmay = new Vukhi("sungmay", 5);
            sungmay.tancong();

            test();
            
            Console.ReadKey();
        }
    }
}
