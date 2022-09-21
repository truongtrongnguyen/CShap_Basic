using System;
using System.Collections.Generic;
using System.Text;

namespace Quan_Ly_Vat_Tu
{
    public class Hoa_Don
    {
        private ds_hd ds;
        public string so_HD { get; set; }
        public string ngaylap_HD { get; set; }
        public string loai_HD { get; set; }
        public int ID { get; set; } //trùng với mã nhân viên

        //public Hoa_Don_Chi_Tiet hoadon_chitiet { get; set; }

        //danh sách hóa đơn chi tiết là một danh sách liên kết đơn
        public ds_hoadonchitiet ds_hdct;
        public Hoa_Don pNext { get; set; }//Hóa đơn được lưu trữ dưới dạng danh sách liên kết

        public Hoa_Don()
        {
            ds = new ds_hd();
            ds.soluong = 0;
            pNext = null;
        }
        public void Input_Hoa_Don()
        {
            Tao_ma_hd();
            Console.Write("Nhap ngay lap hoa don(yyyy-MM-dd): ");
            ngaylap_HD = Console.ReadLine();
            //ConvertStringToDate(date);
            while(true)
            {
                Console.Write("Nhap loai hoa don (N/X): ");
                loai_HD = Console.ReadLine();
                if(loai_HD=="N"||loai_HD=="X")
                {
                    break;
                }
                Console.WriteLine("Yeu cau nhap dung dinh dang");
            }
        }
        public void Tao_ma_hd()
        {
            so_HD = "HD";
            Random r = new Random();
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    so_HD += r.Next(0, 9).ToString();
                }
            } while (Check_ma_HD(so_HD));
        }
        public bool Check_ma_HD(string value)
        {
            Hoa_Don temp = ds.pHead;
            while(temp != null)
            {
                if (temp.so_HD.Equals(value))
                {
                    return true;
                }
                temp = temp.pNext;
            }
            return false;
        }
        public DateTime ConvertStringToDate(string date)
        {
            DateTime myDate = DateTime.ParseExact(date, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            return myDate;
        }
        public void Display()
        {
            Console.WriteLine($"Ma HD: {so_HD} | Ngay nhap: {ngaylap_HD} | Loai: {loai_HD}");
        }
    }
    public class ds_hd
    {
        public Hoa_Don data;
        public Hoa_Don pTail =null;
        public Hoa_Don pHead = null;
        public int soluong { get; set; }   
    }
}
