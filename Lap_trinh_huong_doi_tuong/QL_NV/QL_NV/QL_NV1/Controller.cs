using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_NV1
{
    public class Controller
    {
        private List<Staff> staffList;
        public Controller()
        {
            staffList = new List<Staff>();
        }
        public void Menu()
        {
            while(true)
            {
                Console.WriteLine("==========MENU==========");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. Xuat thong tin nhan vien");
                Console.WriteLine("3. Danh sach nhan vien co luong thap nhat");
                Console.WriteLine("4. Danh sach nhan vien co thuong 1200");
                Console.WriteLine("5. Sap xep nhan vien tang theo phong ban, neu trung thi giam dan theo ma nhan vien");
                Console.WriteLine("==========END==========");
                Console.Write("Nhap lua chon cua ban: ");
                int Option = int.Parse(Console.ReadLine());

                if (Option == 0) return;
                else if (Option == 1) ThemNV();
                else if (Option == 2) Xuatthongtinnhanvien();
                else if (Option == 3) XuatNhanVienCoLuongThapNhat();
                else if (Option == 4) XuatNhanVienCoThuong(1200);
                else if (Option == 5) Sapxep();
            }
            
        }
        public void ThemNV()
        {
            Console.Write("Nhap so luong nahn vien can them:  ");
            int soluong = int.Parse(Console.ReadLine());
            for(int i=0;i<soluong;i++)
            {
                Staff staff = new Staff();
                staff.Input();
                staffList.Add(staff);
            }
        }
        public void Xuatthongtinnhanvien()
        {
            for(int i=0;i<staffList.Count;i++)
            {
                staffList[i].Display();
            }
        }
        public void Tinhtongthuclanh()
        {
            int sum = 0;
            int count = staffList.Count;    //THực hiện dòng này để tối ưu hơn, nó không phải tính toán số lượng phần tử trong List
            for(int i=0;i< count; i++)
            {
                sum = staffList[i].thuc_lanh;
            }
            Console.WriteLine("Tong thuc lanh cua tac ca nhan vien la: " + sum);
        }
        public int Timluongthapnhat()
        {
            int luong_thapnhat = staffList[0].luong_cb;
            int count = staffList.Count;
            for(int i=1;i< count; i++)
            {
                if (staffList[i].luong_cb< luong_thapnhat)
                {
                    luong_thapnhat = staffList[i].luong_cb;
                }
            }
            return luong_thapnhat;
        }
        public void XuatNhanVienCoLuongThapNhat()
        {
            int count = staffList.Count;
            Console.WriteLine("Nhan vien co luong co ban thap nhat la: ");
            for(int i=0;i<count;i++)
            {
                if (staffList[i].luong_cb==Timluongthapnhat())
                {
                    staffList[i].Display();
                }
            }
        }
        public void XuatNhanVienCoThuong(int thuong)
        {
            Console.WriteLine("Danh sach nhan vien co thuong {0} la: ",thuong);
            int count = staffList.Count;
            for (int i = 0; i < count; i++)
            {
                if (staffList[i].thuong == thuong)
                {
                    staffList[i].Display();
                }
            }
        }
        public void Sapxep()
        {
            

            int count = staffList.Count;
            //staffList.Sort((x, y) => x.hoten.CompareTo(y.hoten));
            //staffList.Sort((x, y) => string.Compare(x.hoten, y.hoten));
            staffList.Sort(CompareCarSpecs);
            Xuatthongtinnhanvien();
        }
        public  int CompareCarSpecs(Staff x, Staff y)
        {
            return x.hoten.CompareTo(y.hoten);
        }
        //public void Sapxepten(string hoten)
        //{
        //    string[] temp = hoten.Split(' ');
        //    for(int i=0;i<temp.Length-1;i++)
        //    {
        //        for(int j=i+1;j<temp.Length;j++)
        //        {

        //        }
        //    }

        //}
        //public int Sosanh(string value1, string value2)
        //{
        //    int n = (value1.Length < value2.Length ? value1.Length : value2.Length);
        //    for(int i=0;i<n;i++)
        //    {
        //        if (value1[i] > value2[i])
        //        {
        //            return 1;
        //        }
        //        else if (value1[i] < value2[i]) return -1;
        //    }
        //    return 0;
        //}
    }
}
