using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    internal class Giao_dien
    {
        public Giao_dien()
        {
            farming_contronller = new Farming_contronller();
        }
        private Farming_contronller farming_contronller;
        internal Farming_contronller Farming_Contronller
        {
            get { return farming_contronller; }
            set { farming_contronller = value; }
        }


        public void Menu()
        {
            Console.WriteLine("---------Menu--------\n");
            Console.WriteLine("1. Xuat thong tin chi phi cac con vat");
            Console.WriteLine("2. Them so luong vat nuoi");
            Console.WriteLine("3. Xoa so luong vat nuoi");
            Console.WriteLine("4. Kiem tra so luong con vat trong trai");
            Console.WriteLine("---------End----------");
        }
        public void User()
        {
            Console.Write("Nhap lua chon cua ban: ");
            int Luachon = Convert.ToInt32(Console.ReadLine());
            switch (Luachon)
            {
                case 1:
                    {
                        Chon_con_vat_Xuat();
                        break;
                    }
                case 2:
                    {
                        Chon_con_vat_them();
                        break;
                    }
                case 3:
                    {
                        Chon_con_vat_can_xoa();
                        break;
                    }
                case 4:
                    {
                        farming_contronller.Kiem_Tra_So_Luong();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                    }
            }
        }
        public void Chon_con_vat_Xuat()
        {
            Console.WriteLine("Chon con vat can xuat: 1. Dog | 2. Pig | 3. Chicken | 4. Cow | 5. ALL\n");
            Console.Write("Nhap lua chon cua ban: ");
            string Luachon =Console.ReadLine();
            switch (Luachon)
            {
                case "Dog":
                case "Cow":
                case "Chicken":
                case "Pig":
                    {
                        Farming_Contronller.Total(Luachon);
                        break;
                    }
                case "ALL":
                    {
                        Farming_Contronller.Sum_TotalAmount();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                    }
            }
        }
        public void Chon_con_vat_them()
        {
            Console.WriteLine("Chon con vat can them: 1. Dog | 2. Pig | 3. Chicken | 4. Cow \n");

            Console.Write("Nhap lua chon cua ban: ");
            string luachon = Console.ReadLine();
            switch (luachon)
            {
                case "Dog":
                case "Cow":
                case "Chicken":
                case "Pig":
                    {
                        Console.Write("Nhap so luong can them: ");
                        int Count = Convert.ToInt32(Console.ReadLine());
                        
                        Farming_Contronller.AddAnimal(luachon, Count);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                    }
            }

        }
        public void Chon_con_vat_can_xoa()
        {
            Console.WriteLine("Chon con vat can xoa: 1. Dog | 2. Pig | 3. Chicken | 4. Cow \n");
            Console.Write("Nhap lua chon cua ban: ");
            string Luachon = Console.ReadLine();
            switch(Luachon)
            {
                case "Dog":
                case "Cow":
                case "Chicken":
                case "Pig":
                    {
                        Console.Write("Nhap so luong can xoa: ");
                        int Soluong = Convert.ToInt32(Console.ReadLine());
                        Farming_Contronller.RemoveAnimal(Luachon, Soluong);
                        break;
                    }
                case "ALl":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                    }
            }
        }
    }
}