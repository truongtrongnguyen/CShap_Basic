using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Co_Ban_GaLaiLapTrinh
{
    internal class Program
    {
        static void Tach_So_Va_TInh_Tong()
        {
            //Link Youtube: https://www.youtube.com/watch?v=MrvkLl-ZHr0&list=PLPt6-BtUI22owYNbmZMv76VIfyqBDv0-D&index=32
            string s = "English = 78 Science = 83 Math = 68 History = 65";
            string str = "";
            string[] ds = s.Split(' ');
            foreach(var i in ds)
            {
                foreach(var item in i)
                {
                    if(char.IsDigit(item))//Nếu nó gặp kí tự số đầu tiên thì cho nó cộng nguyên chuỗi i vì mình đã tách nó ra trước rồi
                    {
                        str += i + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(str);
            str = str.Trim();//Xóa kí tự khoảng trắng ở cuối do lúc tách số có cộng kí tự khoảng trắng
            string [] so = str.Split(' ');
            int tong = 0;
            foreach(var i in so)
            {
                tong += Convert.ToInt32(i);
            }
            Console.WriteLine("Tong cac so trong chuoi \"{0}\" la: {1}",s,tong);
            Console.WriteLine("Trung binh cong la: " + (float)tong / so.Length);
        }
         static void Kiem_Tra_Mat_Khau()
         {
            /*
             * Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
             *  mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
             *chứa ít nhất 1 chữ số 
             */
            Console.Write("Thiet lap mat khau dang nhap: ");
            string login = Console.ReadLine();
            string mk;
            int demso = 0;
            int demkitu = 0;
            for(int e=0;e<5;e++)
            {
                Console.Write("Nhap mat khau dang nhap: ");
                mk = Console.ReadLine();
                foreach (var i in mk)
                {
                    if(char.IsDigit(i))
                    {
                        demso++;
                    }
                    else if(char.IsLetter(i))
                    {
                        demkitu++;
                    }    
                }
                if(demso>0&&demkitu>0&&mk.Length>=6)
                {

                    if(mk.Equals(login))
                    {
                        Console.WriteLine("Dang nhap thanh cong");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ban da nhap sai {0}/5 lan", (e + 1));
                    Console.WriteLine("Mat khau phai lon hon 6 ki tu va co it nhat mot ki tu chu va mot ki tu so");
                }
            }


        }
        static void Main(string[] args)
        {
            Tach_So_Va_TInh_Tong();
            Kiem_Tra_Mat_Khau();
            int dem = 0;
            string a = @"tôi chăm học 
                         tôi chịu khó
                        tôi đẹp zai";
            string[] b = a.Split(' ');
            foreach(var i in b)
            {
                if("tôi".Equals(i))
                {
                    dem++;
                }
            }
            Console.WriteLine(dem);
            Console.ReadLine();
        }
    }
}
