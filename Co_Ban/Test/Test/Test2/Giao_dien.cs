using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Giao_dien
    {
        public Giao_dien()
        {
            TrangTrai = new Trang_Trai();
        }
        private Trang_Trai _trangtrai;
        public Trang_Trai TrangTrai
        {
            get { return _trangtrai; }
            set { _trangtrai = value; }
        }
        private Chuong_Con_Vat _chuong_ga;
        public Chuong_Con_Vat Chuong_Ga
        {
            get { return _chuong_ga; }
            set { _chuong_ga = value; }
        }
        public void Menu()
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Them con vat");
            Console.WriteLine("2. Xoa con vat");
            Console.WriteLine("3. Tinh tong so luong kg");
            Console.WriteLine("4. Tinh chi phi trang trai");
            Console.WriteLine("5. Thong tin so luong con vat");
            Console.WriteLine("5. Thoat chuong trinh");
        }
        public void Chon_che_do()
        {

                Menu();
                Console.Write("Nhap lua chon cua ban: ");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        {
                            Console.Write("Nhap con vat can them: ");
                            string name = Console.ReadLine();
                            Console.Write("Nhap so luong: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            TrangTrai.Add(name, count);

                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhap con vat can xoa: ");
                            string name = Console.ReadLine();
                            Console.Write("Nhap so luong: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                            TrangTrai.Remove(name, count);
                            break;
                        }
                    case 3:
                        {
                            TrangTrai.Chi_phi_trang_trai(Chuong_Ga);
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            TrangTrai.Dem_So_Luong(Chuong_Ga);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hop le");
                            break;
                        }
                }
        }
    }
}
