using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
namespace Doc_Ghi_File_SV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DELL\Desktop\456.txt";
            Doc_File d = new Doc_File();
            Controller controller = new Controller();
            FileStream fs = null;
            d.ReadFile(fs, path);
            //d.Them_SV();

            d.Sap_sep_tang_dan();
            d.XuatThongTin();//Sử dụng thuật toán
            Console.WriteLine("Sau khi xoa: ");
            //d.Xoa_SV_Dau();
            d.Xoa_SV_Cuoi();
            d.XuatThongTin();//Sử dụng thuật toán
                             //d.Tim_Kiem();

            //d.WriteFile(fs, path);
            ////sắp xếp tăng dần
            //d.listsv.Sort(delegate (Sinh_Vien c1, Sinh_Vien c2)
            //{
            //    return c1.Diem.CompareTo(c2.Diem); 
            //});

            //d.DisplayList();
            // d.WriteFile(fs, path);

            Console.ReadKey();
        }
    }
    

}
