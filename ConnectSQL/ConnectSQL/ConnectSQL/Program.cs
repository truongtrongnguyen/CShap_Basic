using System;
using System.Data.Common;
using System.Data.SqlClient;
using ConnectSQL.Utils;
using ConnectSQL.Configuration;
using ConnectSQL.Module;
using System.Data;
namespace ConnectSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataset = new DataSet();
            dataset.Tables

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            GiaoDien();
        }



        public static void GiaoDien()
        {
            int chose;
            do
            {
                ShowMenu();
                Console.Write("Nhap lua chon cua ban: ");
                chose = Utility.ReadInt();
                switch(chose)
                {
                    case 1:
                        Display_SV();
                        break;
                    case 2:
                        Add_SV();
                        break;
                    case 3:
                        Delete_SV();
                        break;
                    case 4:
                        Update_SV();
                        break;
                    case 5:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Nhap lai!!!");
                        break;
                }   
            } while (true);
        }
        public static void Display_SV()
        {
            SinhVienDAO.GetSinhVien();
            Console.WriteLine("Danh sach Sinh Vien ");
            foreach(var i in SinhVienDAO.GetSinhVien())
            {
                i.Display();
            }
        }
        public static void Add_SV()
        {
            Console.WriteLine("Nhap thong tin sinh vien can them");
            SinhVien sv = new SinhVien();
            sv.Input();
            SinhVienDAO.InsertInto_SV(sv);
            Console.WriteLine("Them sinh vien thanh cong");
            sv.Display();
        }
        public static void Delete_SV()
        {
            SinhVienDAO.Delete_SV();
        }
        public static void Update_SV()
        {
            SinhVienDAO.Update_SV();
        }
        public static void ShowMenu()
        {
            Console.WriteLine("1. Hien thi danh sach sinh vien");
            Console.WriteLine("2. Them sinh vien");
            Console.WriteLine("3. Xoa sinh vien");
            Console.WriteLine("4. Sua thong tin sinh vien");
            Console.WriteLine("5. Thoat");
        }
    }
}
