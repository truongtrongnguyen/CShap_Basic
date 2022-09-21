using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_co_ban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Nhapchuoi();

            _300Code_Thieu_Nhi c = new _300Code_Thieu_Nhi();

            //Console.WriteLine(String.Join(" ", c.Demo1()));
            //Console.WriteLine(c.Demo7());
            c.Demo1().ToList().ForEach(x=>Console.WriteLine(x));
            
            _300Code_Thieu_Nhi.Demo3 demo3 = new _300Code_Thieu_Nhi.Demo3();
            demo3.Demo();
            Console.ReadKey();
        }
        #region - Viết chương trình tìm số lớn nhất và nhỏ nhất trong 3 số thực
        /// <summary>
        /// Tìm số lớn nhất giữa 2 số 
        /// </summary>
        /// <param name="x">thuộc kiểu float</param>
        /// <param name="y">thuộc kiểu float</param>
        /// <returns></returns>
        static float Max(float x, float y)
        {
            return x > y ? x : y;
        }
        /// <summary>
        /// Hàm tìm ra số lớn nhất trong 3 số
        /// </summary>
        static void Cau1()
        {
            float a, b, c;
            //Nhập vào 3 số 
            Console.WriteLine("Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            float max=Max(a, Max(b,c));
            Console.WriteLine($"So lon nhat giua 3 so {a} {b} {c} la: {max}");
        }

        #endregion

        #region - Viết chương trình tìm x^y
        static long Luythua(int x, int y)
        {
            #region Cách 1: Tính bằng tay
            long tong = 1;
            for(int i=0;i<y;i++)
            {
                tong *= x;
            }
            return tong;
            #endregion

            #region Cách 2: Dùng hàm có sẵn
             return (long)Math.Pow(x, y);
            #endregion
        }
        static void Cau2()
        {
            int x, y;
            Console.WriteLine("Nhap vao so x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Luy thua cua 2 so {x}^{y} la: {Luythua(x, y)}");
        }
        #endregion

        #region - Viết chương trình nhập vào điểm thi và xếp loại 
        /// <summary>
        /// Xuất ra học lực tương ứng nhập từ bàn phím
        /// Kém: 0-3
        /// Yếu: 3-5
        /// Trung bình: 5-7
        /// Khá: 7-8
        /// Giỏi: 8-10
        /// </summary>
        static void Cau3()
        {
            float diem;
            string hocluc = "";
            Console.WriteLine("Nhap vao so diem: ");
            diem = float.Parse(Console.ReadLine());
            hocluc = (diem >= 0 && diem < 3 ? "kem" 
                : (diem >= 3 && diem < 5 ? "Yeu" 
                : (diem >= 5 && diem < 7 ? "Trung binh" 
                : (diem >= 7 && diem < 8 ? "Kha" 
                : "Gioi"))));
            Console.WriteLine("Xep loai: "+ hocluc);
        }
        #endregion

        #region - Viết chương trình tạo menu cho các bài tập trên
        static void menu()
        {
            Console.WriteLine("-------MENU--------");
            Console.WriteLine("1. Viết chương trình tìm số lớn nhất và nhỏ nhất trong 3 số thực.");
            Console.WriteLine("2. Viết chương trình tìm x^y. ");
            Console.WriteLine("3. Viết chương trình nhập vào điểm thi và xếp loại. ");
            Console.WriteLine("-------END--------");
            string usecommand = "";
            bool isRightcommand = false;
            while(!isRightcommand)
            {
                Console.Write("Nhap vao lua chon cua ban: ");
                usecommand = Console.ReadLine();
                switch (usecommand)
                {
                   case"1":
                     {
                            isRightcommand = true;
                            Cau1();             
                     }break;
                    case"2":
                     {
                            isRightcommand = true;
                            Cau2();
                        }
                        break;
                    case "3":
                     {
                            isRightcommand = true;
                            Cau3();
                     }
                        break;

                    default:
                        {
                            Console.WriteLine("Lua chon khong hop le!");
                            break;
                        }
                }
            }

        }
        #endregion

        #region - Viết chương trình dung hàm để tìm số nguyên tố nhỏ hơn số N
        /// <summary>
        /// Hàm kiểm tra số nguyên tố
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool kt(int n)
        {
            if(n<2)
            { return false; }
            else
            {
                if(n==2)
                {
                    return true;
                }
                else
                {
                    for(int i=2;i<Math.Sqrt(n);i++)
                    {
                        if(n%i==0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
        }
        /// <summary>
        /// Kiểm tra nếu là số nguyên tố trong khoảng 0 đến n thì xuất ra
        /// </summary>
        static void kiem_tra_so_nguyen_to()
        {
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so nguyen to bao gom: ");
            for(int i=0;i<n;i++)
            {
                if (kt(i) == true)
                    Console.Write(i+" ");
            }
        }
        #endregion

        #region - Viết chương trình khởi tạo mảng có số từ 0-69
        /// <summary>
        /// Chương trình khởi tạo mảng với số bất kì từ 0-69
        /// </summary>
        /// <param name="a"></param>
     
        static void Khoitaomang(int[,]a)
        {
            Random random = new Random(); //Để Random ở đây để tạo ra các số khác nhau
            for(int i=0;i<a.GetLength(0);i++)//a.GetLength(0) -> Độ dài của dòng
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    a[i, j] =random.Next(0, 70);
                }
            }
        }
        /// <summary>
        /// Hàm xuất mảng 
        /// </summary>
        /// <param name="a"></param>
        static void Xuatmang(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write("{0, 4} ", a[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Taomang()
        {
            int[,] a = new int[20, 20];
            Khoitaomang(a);
            Xuatmang(a);
            Timmax(a);
        }
        #endregion

        #region - Tìm giá trị lớn nhất trong mảng của câu trên
        static void Timmax(int[,]a)
        {
            
            for(int i=0;i<a.GetLength(0);i++)
            {
                int max = a[i, 0];
                for (int j=0;j<a.GetLength(1);j++)
                {
                    max = max > a[i, j] ? max : a[i, j];
                }
                Console.WriteLine(($"Max cua dong {i+1} la {max}"));
            }
        }
        #endregion

        #region - Viết chương trình bỏ ký tự a trong 1 chuỗi
        static void delete(ref string a)//xóa kí tự a trong chuỗi
        {
            for(int i=0;i<a.Length;i++)
            {
                if (a[i]=='a')
                {
                    a = a.Remove(i,1);
                }
                
            }
        }
        static void Cau9()
        {
            string a = "";
            Console.Write("Nhap vao 1 chuoi: ");
            a = Console.ReadLine();
            delete(ref a);
            Console.WriteLine("Chuoi sao khi cat: "+a);
        }
        #endregion

        #region - Viết chương trình in các từ của chuỗi trên mỗi dòng
        static void enterstring(ref string a)
        {
            string[] s = a.Split(' ');
            a = "";
            foreach(var i in s)
            {
                a += i + '\n';
            }
          //  Console.WriteLine(a);
        }
        static void Catchuoi()
        {
            string s = "";
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();
            //s=s.Replace(' ','\n');
            //Console.WriteLine("Chuoi sao khi cat: \n" + s);
           enterstring(ref s);
            Console.WriteLine(s);
        }
        #endregion

        #region - Viết chương trình kiểm tra chuỗi có đối xứng hay không
        static bool doixung(string s)
        {
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length - i-1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Nhapchuoi()
        {
            string s = "";
            Console.Write("Nhap chuoi: ");
            s = Console.ReadLine();
            if(doixung(s))
            {
                Console.WriteLine("chuoi {0} la chuoi doi xung",s);
            }
            else
            {
                Console.WriteLine("Chuoi {0} khong phai la chuoi doi xung", s);
            }
        }
        #endregion
    }
}
