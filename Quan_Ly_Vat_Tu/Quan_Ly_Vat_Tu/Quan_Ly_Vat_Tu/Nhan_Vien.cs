using System;
using System.Collections.Generic;
using System.Text;

namespace Quan_Ly_Vat_Tu
{
    public class Nhan_Vien
    {
        private ds_NV ds_nv;
        public int ma_NV { get; set; }
        public string ho_NV { get; set; }
        public string ten_NV { get; set; }
        public string phai_NV { get; set; }
        //public Hoa_Don hoa_don { get; set; }

        //danh sách hóa đơn
        public ds_hd ds_HD { get; set; }
        
        //Nhân viên được lưu trữ dưới dạng cây nhị phân
        public Nhan_Vien pLeft;
        public Nhan_Vien pRight;

        public Nhan_Vien()
        {
            ds_HD = new ds_hd();
            ds_nv = new ds_NV();
            pLeft = null;
            pRight = null;
        }
        public void Input_Nhan_Vien()
        {
            Tao_ma_NV(ds_nv.ds_nv);
            Edit_Input_NV();

            //Console.WriteLine("Nhap hoa don: ");
            //hoa_don = new Hoa_Don();
            //hoa_don.Input_Hoa_Don();
        }
        public void Edit_Input_NV()
        {
            Console.Write("Nhap ho nhan vien: ");
            ho_NV = Console.ReadLine().FirstCharToUpper();
            Console.Write("Nhap ten nhan vien: ");
            ten_NV = Console.ReadLine().FirstCharToUpper();
            Console.Write("Nhap phai nhan vien: ");
            phai_NV = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine($"Ma: NV: {ma_NV} | Ho: {ho_NV} | Ten: {ten_NV} | Phai: {phai_NV}");
        }
        public int Tao_ma_NV(Nhan_Vien nv)
        {
            Random r = new Random();
            string a = "";
            do
            {
                for(int i=0;i<3;i++)
                {
                    a += r.Next(0, 9).ToString();
                }

                ma_NV = int.Parse(a);
            } while(Check_Ma_NV(nv, ma_NV)==true);
            return ma_NV;
        }
        public bool Check_Ma_NV(Nhan_Vien nv, int a)//Kiểm tra cây nhị phân xem có phần tử nào trùng với mã nhân viên hay không
        {
            if(nv==null)//Nêu danh sách rỗng thì cho tạo nhân viên mới
            {
                return false;
            } 
            else
            {
                if(nv.ma_NV==a)//Đã tìm thấy nhân viên trùng mã
                {
                    return true;
                }
                //else if(nv.ma_NV<a)//Tiếp tục duyệt đến hết cây
                //{
                //    Check_Ma_NV(nv.pRight, a);
                //}
                //else if(nv.ma_NV>a)//Tiếp tục duyệt đến hết cây
                //{
                //    Check_Ma_NV(nv.pLeft, a);
                //}
                Check_Ma_NV(nv.pRight, a);
                Check_Ma_NV(nv.pLeft, a);
            }
            return false;
        }

        public Nhan_Vien _Check_Ma_NV(Nhan_Vien nv, int a)//Kiểm tra cây nhị phân xem có phần tử nào trùng với mã nhân viên hay không
        {
            if (nv == null)//Nêu danh sách rỗng thì cho tạo nhân viên mới
            {
                return null;
            }
            else
            {
                if (nv.ma_NV == a)//Đã tìm thấy nhân viên trùng mã
                {
                    return nv;
                }
                else if (nv.ma_NV < a)//Tiếp tục duyệt đến hết cây
                {
                    _Check_Ma_NV(nv.pRight, a);
                }
                else if (nv.ma_NV > a)//Tiếp tục duyệt đến hết cây
                {
                    _Check_Ma_NV(nv.pLeft, a);
                }
            }
            return null;
        }
    }
    public class ds_NV
    {
        public Nhan_Vien ds_nv = null;
        public int so_luong = 0;
    }
}
