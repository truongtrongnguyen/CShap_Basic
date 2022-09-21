using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT_nhap_xuat_mang
{
    internal class Program
    {
        static void Nhapmang(int[] arry, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap gia tri mang a[{0}] = ", i);
                // int.TryParse(Console.ReadLine(), out arry[i]);
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Xuatmang(int[] arry, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arry[i]);
            }
        }
        static int Tinhtong(int[] arry, int n)
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
            {
                Tong = Tong + arry[i];
            }
            return Tong;
        }
        static bool Check(int n)
        {
            int tam = n;
            int daonguoc = 0;
            while (tam != 0)
            {
                int x = tam % 10;
                daonguoc = daonguoc * 10 + x;
                tam /= 10;
            }
            if (daonguoc == n)
            {
                Console.WriteLine("{0} chinh la so doi xung", n);
                return true;
            }
            else
            {
                Console.WriteLine("{0} khong phai la so doi xung", n);
                return false;
            }
        }
        static void Saochep(int[] arry1, int[] arry2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arry2[i] = arry1[i];
            }
            Console.WriteLine("\t\tMang sao khi sao chep la: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Gia tri mang arry2 [{0}]= {1}", i, arry2[i]);
            }
        }
        static void Timphantugiongnhau(int[] arry, int n)
        {
            int value;
            int dem = 0;
            Console.Write("Nhap phan tu can tim kiem: ");
            value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (value == arry[i])
                {
                    dem++;
                }
            }
            Console.WriteLine("Gia tri {0} xuat hien {1} lan trong mang ", value, dem);
        }
        static void Timcacphantukhacnhau(int[] arry, int n)
        {
            bool kt;
            for (int i = 0; i < n; i++)
            {
                kt = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (arry[i] != arry[j])
                    {
                        kt = false;
                    }
                }
                if (kt == true)
                {
                    Console.Write("{0} ", arry[i]);
                }
            }
        }
        static void Hoanvi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Sapxeptangdan(int[] arry, int n)
        {

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {

                    if (arry[i] < arry[j])
                    {
                        Hoanvi(ref arry[i], ref arry[j]);
                    }
                }
            }
        }
        public static bool Kiemtrachusochan(int n)
        {
            while(n>=10)
            {
                n /= 10;
            }
            if(n%2==0)
            {
                return true;
            }
            return false;
        }
        //HÀM LIỆT KÊ CÁC PHẦN TỬ CÓ CHỮ SỐ NGOÀI CÙNG BÊN TRÁI LÀ CHỮ SỐ CHĂN
        public static void Lietkecacphantulasochan(int[] arry, int n)
        {
            bool kt=false;
            for(int i=0;i<n;i++)
            {
                if(Kiemtrachusochan(arry[i]))
                {
                    Console.Write(arry[i]+ " ");
                    kt = true;
                }
            }
            if(kt==false)
            {
                Console.WriteLine("Mang khong ton tai so chan dau tien");
            }
        }
        //HÀM ĐẾM SỐ LẦN XUẤT HIỆN CỦA PHẦN TỬ X ĐƯỢC NHẬP TỪ BÀN PHÍM 
        static void Demsolanxuathiencuagiatrinhaptubanphim(int[] arry, int n)
        {
            int value;
            Console.Write("Nhap gia tri can tim: ");
            value = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if(value==arry[i])
                {
                    dem++;
                }
            }
            Console.WriteLine("Phan tu {0} xuat hien {1} lan trong mang",value,dem);
        }
        //HÀM KIỂM TRA SỐ NGUYÊN TỐ
        public static bool Kiemtrasonguyento(int n)
        {
            if(n<2)
            {
                return false;
            }
            else
            {
                if(n==2)
                {
                    return true;
                }
                else
                {
                    for(int i=2;i<n;i++)
                    {
                        if (n%i==0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public static void Kiemtramangcotontaisonguyento(int[] arry, int n)
        {
            bool kt = false;
            for(int i=0;i<n;i++)
            {
                if(Kiemtrasonguyento(arry[i]))
                {
                    Console.Write(arry[i] + " ");
                    kt = true;
                }
            }
            if(kt==false)
            {
                Console.WriteLine("Mang khong ton tai so nguyen to");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Kiemtrasonguyento(23));
            int n;
            int[] arry;
            int luachon;
            do
            {
                Console.Write("Nhap so luong mang: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.Clear();
                    Console.WriteLine("So luong phan tu khong hop le! ");
                }
            } while (n < 0);

            arry = new int[n];
            Console.WriteLine("\t\t\tNHAP MANG\t\t\t\n");
            Nhapmang(arry, n);
            Console.WriteLine("\t\t\tXUAT MANG\t\t\t\n");
            Xuatmang(arry, n);
            while (true)
            {
                Console.WriteLine("\n\t\t\tMENU\t\t\t\n");
                Console.WriteLine("0.Thoat chuong trinh");
                Console.WriteLine("1.Dem so lan xuat hien cua phan tu x duoc nha tu ban phim ");
                Console.WriteLine("2.Tinh tong cac phan tu trong mang");
                Console.WriteLine("3.Liet ke cac phan tu co chu so dau tien la chu so chan");
                Console.WriteLine("4.Xuat cac phan tu la so nguyen to trong mang");
                Console.WriteLine("\n\t\t\tEDN\t\t\t\n");
                do
                {

                    Console.Write("Nhap lua chon cua ban: ");
                    luachon = Convert.ToInt32(Console.ReadLine());
                    if (luachon < 0||luachon>5)
                    {
                        Console.WriteLine("Lua chon khong hop le! ");
                    }
                } while (luachon < 0||luachon>5);
                switch (luachon)
                {
                    case 0:
                        {
                            return;
                        }break;
                    case 1:
                        {
                            Console.WriteLine("\t\tDem so lan xuat hien cua phan tu X nhap tu ban phim : \n");
                            Demsolanxuathiencuagiatrinhaptubanphim(arry, n);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\tTong cac phan tu trong mang la: {0}", Tinhtong(arry, n));
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\tLiet ke cac phan tu co chu so dau tien la chu so chan: \n");
                            Lietkecacphantulasochan(arry, n);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\t\tKiem tra mang co ton tai so nguyen to hay khong\n");
                            Kiemtramangcotontaisonguyento(arry, n);
                        }
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}


//using System;

//namespace VietJackCsharp
//{
//    class TestCsharp
//    {
//        public static void Main()
//        {

//            int[] arr1 = new int[100];
//            int[] fr1 = new int[100];
//            int n, i, j, bien_dem;


//            Console.Write("\nDem so lan xuat hien cua tung phan tu trong mang trong C#:\n");
//            Console.Write("-----------------------------------------------------------\n");

//            Console.Write("Nhap so phan tu can luu giu trong mang: ");
//            n = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
//            for (i = 0; i < n; i++)
//            {
//                Console.Write("Phan tu - {0}: ", i);
//                arr1[i] = Convert.ToInt32(Console.ReadLine());
//                fr1[i] = -1;    //Gán -1 cho tất cả các phần tử trong mảng fr1
//            }
//            for (i = 0; i < n; i++)
//            {
//                bien_dem = 1;
//                for (j = i + 1; j < n; j++)
//                {
//                    if (arr1[i] == arr1[j])
//                    {
//                        bien_dem++;
//                        fr1[j] = 0;     //Nếu có giá trị nào bằng nhau thì gán =0 để nó không xuất giá trị trùng tiếp theo trong mảng
//                    }
//                }

//                if (fr1[i] != 0)    //Lúc này fr1 có giá trị là -1 nên nó khác 0
//                {
//                    fr1[i] = bien_dem;
//                }
//            }
//            Console.Write("\nTan suat xuat hien cua tung phan tu trong mang la: \n");
//            for (i = 0; i < n; i++)
//            {
//                if (fr1[i] != 0)    //chỉ giá trị khác 0 mới xuất ra màn hình
//                {
//                    Console.Write("Phan tu {0} xuat hien {1} lan\n", arr1[i], fr1[i]);
//                }
//            }

//            Console.ReadKey();
//        }
//    }
//}