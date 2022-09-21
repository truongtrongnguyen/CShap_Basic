using System;
using System.Collections.Generic;
using System.Text;

namespace QL_NV1
{
    public  class Staff
    {
        public string ma_nv { get; set; }
        public string hoten { get; set; }
        public string phongban { get; set; }
        public int luong_cb { get; set; }
        public int thuong { get; set; }
        public int thuc_lanh { get; set; }
        public Staff()
        {
           
        }
        public string Nhapthongtinchuoi(string thongtin, int length)
        {
            string _ma_nv = "";
            int sokytu = 0;
            do
            {
                Console.Write($"Nhap {thongtin} : ");
                _ma_nv = Console.ReadLine();
                sokytu = _ma_nv.Length;
                if (sokytu > length)
                {
                    Console.WriteLine($"{thongtin} khong hop le! {thongtin} phai co toi da la {length} ky tu, Vui long nhap lai: ");
                }
            } while (sokytu > length);
            return _ma_nv;
        }
        public int Nhapthongtinso(string thongtin)
        {
            int value = 0;
            do
            {
                Console.Write($"Nhap {thongtin} :");
                value = int.Parse(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine($"{thongtin} khong hop le! {thongtin} phai la mot so lon hon 0");
                }
            } while (value < 0);
            return value;
        }
        public void Input()
        {
            ma_nv = Nhapthongtinchuoi("ma nhan vien", 8);
            hoten = Nhapthongtinchuoi("ho ten nhan vien", 20);
            phongban = Nhapthongtinchuoi("phong ban nhan vien", 10);
            luong_cb = Nhapthongtinso("luong co ban cua nhan vien");
            thuong = Nhapthongtinso("thuong cua nhan vien");
            thuc_lanh = luong_cb + thuong;
        }
        public void Display()
        {
            Console.WriteLine($"Ma NV: {ma_nv} | Ho ten: {hoten} | Phong ban: {phongban} | Luong_CB: {luong_cb} | Thuong: {thuong} | Thuc lanh: {thuc_lanh}");
            
        }
    }
}
