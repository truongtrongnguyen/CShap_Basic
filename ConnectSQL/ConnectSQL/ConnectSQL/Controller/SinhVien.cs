
using System;
using System.Collections.Generic;
using System.Text;
using ConnectSQL.Utils;

namespace ConnectSQL.Module
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string Ho_TenSV { get; set; }
        public int Nam_Sinh { get; set; }
        public string Dan_Toc { get; set; }
        public string Ma_Lop { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string maSV, string ho_TenSV, int nam_Sinh, string dan_Toc, string ma_Lop)
        {
            MaSV = maSV;
            Ho_TenSV = ho_TenSV;
            Nam_Sinh = nam_Sinh;
            Dan_Toc = dan_Toc;
            Ma_Lop = ma_Lop;
        }
        public void Input()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten SV: ");
            Ho_TenSV = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            Nam_Sinh = Utility.ReadInt();
            Console.Write("Nhap dan toc: ");
            Dan_Toc = Console.ReadLine();
            Console.Write("Nhap ma lop: ");
            Ma_Lop = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine($" MaSV: {MaSV} | TenSV: {Ho_TenSV} | NamSinh: {Nam_Sinh} | Dantoc: {Dan_Toc} | MaLop: {Ma_Lop}");
        }
    }
}
