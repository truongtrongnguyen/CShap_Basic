using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Quan_Ly_Vat_Tu
{
    internal class Controller
    {
        private ds_Vat_Tu ds_vt;
        private ds_NV ds_nv;
        private ds_hd ds_hd;
        public Controller()
        {
            ds_vt = new ds_Vat_Tu();
            ds_nv = new ds_NV();
            ds_hd = new ds_hd();
            Doc_Data(ds_vt);
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("=======MENU=========");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Them vat tu");
                Console.WriteLine("2. Xuat vat tu");
                Console.WriteLine("3. Them nhan vien");
                Console.WriteLine("4. Ghi file");
                Console.WriteLine("5. Xoa");
                Console.WriteLine("6. Chinh sua thong tin vat tu");
                Console.WriteLine("7. Xuat thong tin nhan vien");
                Console.WriteLine("8. Xoa thong tin nhan vien");
                Console.WriteLine("9. Chinh sua thong tin nhan vien");
                Console.WriteLine("10. Them HD vao danh sach");
                Console.WriteLine("11. Xuat thong tin hoa don");
                Console.WriteLine("=======END=========");
                Console.Write("Nhap lua chon cua ban: ");
                int Option = int.Parse(Console.ReadLine());
                if (Option == 0)
                { return; }
                else if (Option == 1)
                {
                    Them_VT(ds_vt);
                }
                else if (Option == 2)
                {
                    Console.WriteLine("Xuat danh sach vat tu: ");
                    Xuat_Ds_Vat_Tu(ds_vt);
                }
                else if (Option == 3)
                {
                    Khoitao(ref ds_nv);
                }
                else if (Option == 4)
                {
                    Write_Data(ds_vt);
                }
                else if (Option == 5)
                {
                    Xoa_Ds_Vat_Tu(ds_vt);
                }
                else if (Option == 6)
                {
                    Hieu_Chinh(ds_vt);
                }
                else if (Option == 7)
                {
                    Nhan_Vien[] ds = new Nhan_Vien[100];
                    int n = 0;
                    Chuyen_cay_sang_mang(ref ds_nv.ds_nv, ref ds, ref n);
                    Sap_Xep_NV(ref ds, n);
                    Xuat_Nhan_Vien(ref ds, ref n, ds_hd);
                    //GiaiPhong(ds, n);
                }
                else if(Option==8)
                {
                    Xoa_NV(ref ds_nv);
                }
                else if(Option==9)
                {
                    Hieu_Chinh_NV(ds_nv);
                }
                else if (Option == 10)
                {
                    Nhan_Vien nv = new Nhan_Vien();
                    Them_HD(ref ds_nv, nv);
                }
                else if (Option == 11)
                {
                    Console.Write("Nhap ma nhan vien: ");
                    int m = int.Parse(Console.ReadLine());
                    Xuat_tt_HD(ds_hd,m);
                }
            }
        }
        public void Them_VT(ds_Vat_Tu ds_vt)
        {
            Vat_Tu vt = new Vat_Tu();
            vt.Input();
            ds_vt.ds_vat_tu[ds_vt.soluong] = vt;
            ds_vt.soluong++;
        }
        public void Xuat_Ds_Vat_Tu(ds_Vat_Tu ds)
        {
            if (ds.soluong == 0)
            {
                Console.WriteLine("Danh sach rong");
            }
            else
            {
                for (int i = 0; i < ds.soluong; i++)
                {
                    ds.ds_vat_tu[i].Display();
                }
            }
        }
        public void Doc_Data(ds_Vat_Tu ds)
        {
            Data_Read_Write data = new Data_Read_Write(@"D:\Code C#\Quan_Ly_Vat_Tu\Quan_Ly_Vat_Tu\Quan_Ly_Vat_Tu\456.txt", ds);
            data.Read_Data();
        }
        public void Write_Data(ds_Vat_Tu ds)
        {
            Data_Read_Write data = new Data_Read_Write(@"D:\Code C#\Quan_Ly_Vat_Tu\Quan_Ly_Vat_Tu\Quan_Ly_Vat_Tu\456.txt", ds);
            data.Write_Data(ds);
        }
        public void Xoa_Ds_Vat_Tu(ds_Vat_Tu ds)
        {

            Console.Write("Nhap ma vat tu can xoa(VTxxxx): ");
            string a = Console.ReadLine().Trim();
            int value = Check_HD_Vat_Tu(ds, a);
            if (ds.soluong == 0)
            {
                Console.WriteLine("Danh sach rong");
            }
            else if (value == -1)
            {
                Console.WriteLine("Ma vat tu khong ton tai");
            }
            else
            {
                for (int i = value; i < ds.soluong - 1; i++)
                {
                    ds.ds_vat_tu[i].ma_vt = ds.ds_vat_tu[i + 1].ma_vt;
                    ds.ds_vat_tu[i].ten_vt = ds.ds_vat_tu[i + 1].ten_vt;
                    ds.ds_vat_tu[i].don_vi = ds.ds_vat_tu[i + 1].don_vi;
                    ds.ds_vat_tu[i].so_luong_ton = ds.ds_vat_tu[i + 1].so_luong_ton;
                    ds.ds_vat_tu[i].kt = ds.ds_vat_tu[i + 1].kt;
                }
                ds.ds_vat_tu[ds.soluong - 1] = null;
                ds.soluong--;
                Console.WriteLine("Xoa thanh cong");
            }
        }
        public void Hieu_Chinh(ds_Vat_Tu ds)
        {
            Console.Write("Nhap ma vat tu can xoa(VTxxxx): ");
            string a = Console.ReadLine().Trim();
            int value = Check_HD_Vat_Tu(ds, a);
            if (ds.soluong == 0)
            {
                Console.WriteLine("Danh sach rong");
            }
            else if (value == -1)
            {
                Console.WriteLine("Ma vat tu khong ton tai");
            }
            else
            {
                Console.WriteLine("Chinh sua thong tin(Ma vat tu va so luong khong the chinh sua): ");
                ds.ds_vat_tu[value].Edit_Input();
                Console.WriteLine("Chinh sua thong tin thanh cong");
            }
        }
        public int Check_HD_Vat_Tu(ds_Vat_Tu ds, string ma_vt)
        {
            for (int i = 0; i < ds.soluong; i++)
            {
                if (ma_vt.Equals(ds.ds_vat_tu[i].ma_vt))
                {
                    return i;
                }
            }
            return -1;
        }
        //================================= THÊM NHÂN VIÊN==================    
        private void Khoitao(ref ds_NV ds)
        {
            Nhan_Vien nv = new Nhan_Vien();
            nv.Input_Nhan_Vien();
            Them_NV(ref ds.ds_nv, ref nv);
            ds.so_luong++;
        }
        public void Them_NV(ref Nhan_Vien ds, ref Nhan_Vien nv)
        {
            if (ds == null)
            {
                ds = nv;//Thêm nhân viên vào đầu cây nhị phân
            }
            else
            {
                if (ds.ma_NV > nv.ma_NV)
                {
                    Them_NV(ref ds.pLeft, ref nv);
                }
                else if (ds.ma_NV < nv.ma_NV)
                {
                    Them_NV(ref ds.pRight, ref nv);
                }
            }
        }
        //========================XUẤT THÔNG TIN NHÂN VIÊN====================
        public void Chuyen_cay_sang_mang(ref Nhan_Vien t, ref Nhan_Vien[] ds, ref int n)
        {
            if (t != null)
            {
                ds[n] = new Nhan_Vien();//KHởi tạo ra một đối tượng nhân viên để tiến hành thêm vào mảng danh sách
                //data tiến hành thêm dữ liệu vào mảng để dễ xử lí
                ds[n].ma_NV = t.ma_NV;
                ds[n].ho_NV = t.ho_NV;
                ds[n].ten_NV = t.ten_NV;
                ds[n].phai_NV = t.phai_NV;
                //ds[n].ds_HD = t.ds_HD;
                n++;

                Chuyen_cay_sang_mang(ref t.pLeft, ref ds, ref n);
                Chuyen_cay_sang_mang(ref t.pRight, ref ds, ref n);
            }
        }
        public void Xuat_Nhan_Vien(ref Nhan_Vien[] ds, ref int n, ds_hd hd)
        {
            Console.WriteLine("So luong nhan vien la: " + n);
            for (int i = 0; i < n; i++)
            {
                ds[i].Display();
                if (hd.soluong > 0 && ds[i].ds_HD.soluong>0)
                {
                    Hoa_Don current = hd.pHead;
                    while (current != null)
                    {
                        if (current.ID == ds[i].ma_NV)
                        {
                            current.Display();
                            current = current.pNext;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                // Xuat_tt_HD(ds_hd, ds[i].ma_NV);
            }
        }
        //========================XẮP XẾP DANH SÁCH NHÂN VIÊN====================
        public bool Sosanh(string a, string b)
        {
            int n = (a.Length >= b.Length ? b.Length : a.Length);
            if (n == 0) n = 1;
            for(int i=0;i<n;i++)
            {
                if (a[i] > b[i])
                    return true;
            }
            return false;
        }
        public void Hoanvi(ref Nhan_Vien a,ref Nhan_Vien b)
        {
            Nhan_Vien temp = a;
            a = b;b = temp;
        }
        public void Sap_Xep_NV(ref Nhan_Vien[] ds, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (Sosanh(ds[i].ten_NV, ds[j].ten_NV))
                    {
                        Hoanvi(ref ds[i], ref ds[j]);
                    }
                }
            }
        }
        public void GiaiPhong(Nhan_Vien[] ds, int n)
        {
            for(int i=0;i<n;i++)
            {
                ds[i] = null;
            }
        }
        //========================= XÓA NHÂN VIÊN====================
        public void Xoa_NV(ref ds_NV ds)
        {
            Console.Write("Nhap ma nhan vien can xoa: ");
            int value = int.Parse(Console.ReadLine());
            Tim_NV_Xoa(ref ds.ds_nv, value);
            ds.so_luong--;
            Console.WriteLine("Xoa thanh cong, So luong nhan vien con lai la: "+ds.so_luong);
        }
        public void Tim_NV_Xoa(ref Nhan_Vien t, int a)
        {
            if(t==null)
            {
                Console.WriteLine("Danh sach rong");
            }
            else
            {
                if(t.ma_NV==a)
                {
                    Nhan_Vien temp = t;
                    if(t.pLeft==null)
                    {
                        t = t.pRight;
                    }
                    else if(t.pRight==null)
                    {
                        t = t.pLeft;
                    }
                    else
                    {
                        Tim_Node_The_Mang(ref temp,ref temp.pRight);
                    }
                    temp = null;
                }
                else if(t.ma_NV<a)
                {
                    Tim_NV_Xoa(ref t.pRight, a);
                }
                else if(t.ma_NV>a)
                {
                    Tim_NV_Xoa(ref t.pLeft, a);
                }
            }
           
        }
        public void Tim_Node_The_Mang(ref Nhan_Vien x,ref Nhan_Vien y)
        {
            if(x.pLeft!=null)
            {
                Tim_Node_The_Mang(ref x,ref y.pLeft);
            }
            else
            {
                y = x;
                y = y.pRight;

            }
        }
        //=======================CHỈNH SỬA THÔNG TIN NHÂN VIÊN
        public void Hieu_Chinh_NV(ds_NV ds)
        {
            if (ds.so_luong == 0) Console.WriteLine("Danh sach rong");
            else
            {
                Console.Write("Nhap ma so nhan vien can chinh sua: ");
                int value = int.Parse(Console.ReadLine());

                if (ds.ds_nv.Check_Ma_NV(ds.ds_nv, value)==null) Console.WriteLine("Ma nhan vien khong ton tai");
                else
                {
                    Console.WriteLine("Chinh sua thong tin nhan vien");
                    Tim_NV_hieu_Chinh(ds.ds_nv, value);
                }
            }
        }
        public void Tim_NV_hieu_Chinh(Nhan_Vien t, int value)
        {
            if(t.ma_NV==value)
            {
                t.Edit_Input_NV();
            }
            else if(t.ma_NV<value)
            {
                Tim_NV_hieu_Chinh(t.pRight, value);
            }
            else if(t.ma_NV>value)
            {
                Tim_NV_hieu_Chinh(t.pLeft, value);
            }
        }
        ///////////////////////TẠO HÓA ĐƠN////////////////////////

        public void Them_HD(ref ds_NV ds, Nhan_Vien nv)
        {
            Console.Write("Nhap ma nhan vien: ");
            int value = int.Parse(Console.ReadLine());
            if (ds.ds_nv.Check_Ma_NV(nv, value) == true)
            {
                //Them_HD_Vao_DSLK(ref ds_hd, ds.ds_nv.Check_Ma_NV(, value));
                Console.WriteLine("Co nhan vien");
            }
            else
            {
                Console.WriteLine("Khong tim thay nhan vien");
            }
            
        }
        //public void Them_HD_Vao_DSLK(ref Nhan_Vien ds, int value)
        //{
        //    if (ds.ma_NV==value)
        //    {
        //        Hoa_Don hd = new Hoa_Don();
        //        hd.Input_Hoa_Don();
        //        hd.ID = value;
        //        if (ds.ds_HD.pHead== null && ds.ds_HD.pTail == null)
        //        {
        //            ds.ds_HD.pHead = ds.ds_HD.pTail = hd;
        //        }
        //        else
        //        {
        //            ds.ds_HD.pTail.pNext = hd;
        //        }
        //        ds.ds_HD.soluong++;
        //    }
        //    else if (ds.ma_NV>value)
        //    {
        //        Them_HD_Vao_DSLK(ref ds.pLeft, value);
        //    }
        //    else if(ds.ma_NV<value)
        //    {
        //        Them_HD_Vao_DSLK(ref ds.pRight, value);
        //    }

        //}
        public void Them_HD_Vao_DSLK(ref ds_hd ds, Nhan_Vien nv)
        {
            Hoa_Don hd = new Hoa_Don();
            hd.Input_Hoa_Don();
            hd.ID = nv.ma_NV;
            if (ds.pHead == null)
            {
                nv.ds_HD = new ds_hd();
                ds.pHead = ds.pTail = hd;
            }
            else
            {
                ds.pTail.pNext=hd;
                ds.pTail=hd;
            }
            ds.soluong++;
        }
        public void Xuat_tt_HD(ds_hd hd, int value)
        {
            //Nhan_Vien temp = nv.ds_nv.Check_Ma_NV(nv.ds_nv, value);
            //if(temp==null|| temp.ds_HD.soluong == 0)
            //{
            //    Console.WriteLine("Nhan vien chua lap hoa don nao");
            //    return;
            //}
            //Console.WriteLine("So luong HD la: "+temp.ds_HD.soluong);

            if(hd.pHead==null)
            {
                return;
            }
            else
            {
                Hoa_Don current = hd.pHead;
                while(current!=null)
                {
                    if(current.ID==value)
                    {
                        current.Display();
                        current = current.pNext;
                    }
                }
            }
        }
    }
}