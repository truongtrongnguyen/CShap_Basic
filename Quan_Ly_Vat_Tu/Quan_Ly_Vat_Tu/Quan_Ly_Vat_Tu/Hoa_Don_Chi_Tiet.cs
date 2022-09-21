using System;
using System.Collections.Generic;
using System.Text;

namespace Quan_Ly_Vat_Tu
{
    internal class Hoa_Don_Chi_Tiet
    {
        public int ma_VT_HDCT { get; set; }
        public int soluong_HDCT { get; set; }
        public float price_HDCT { get; set; }
        public float thue_VAT_HDCT { get; set; }
        public bool trang_thai_HDCT { get; set; }
        public Hoa_Don_Chi_Tiet(int ma_VT_HDCT, int soluong_HDCT, float price_HDCT, float thue_VAT_HDCT, bool trang_thai_HDCT)
        {
            this.ma_VT_HDCT = ma_VT_HDCT;
            this.soluong_HDCT = soluong_HDCT;
            this.price_HDCT = price_HDCT;
            this.thue_VAT_HDCT = thue_VAT_HDCT;
            this.trang_thai_HDCT = trang_thai_HDCT;
        }
        public Hoa_Don_Chi_Tiet()
        { }
        public void Input_Hoa_Don_Chi_Tiet()
        {
            Console.Write("Nhap ma vat tu: ");
            ma_VT_HDCT=int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong vat tu: ");
            soluong_HDCT = int.Parse(Console.ReadLine());
            Console.Write("Nhap thue vat tu: ");
            thue_VAT_HDCT = int.Parse(Console.ReadLine());
            Console.Write("Nhap trang thai vat tu: ");
            trang_thai_HDCT=bool.Parse(Console.ReadLine());
        }
    }
    public class ds_hoadonchitiet
    {
        Hoa_Don_Chi_Tiet[] ds_hdct=new Hoa_Don_Chi_Tiet[20];
        int soluong;
    }
}
