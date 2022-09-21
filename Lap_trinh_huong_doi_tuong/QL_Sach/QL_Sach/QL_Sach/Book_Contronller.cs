using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach
{
    internal class Book_Contronller
    {
        public Book_Contronller()
        {
            AptechBook = new List<AptechBook>();
        }
        private List<AptechBook> aptechBook;
        public List<AptechBook> AptechBook
        {
            get { return aptechBook; }
            set { aptechBook = value; }
        }
        public void Add_Book(List<AptechBook> aptechbook)
        {
            Console.WriteLine("Nhap so luong sach can them: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Them thong tin sach thu " + (i+1));
                AptechBook aptech = new AptechBook();
                aptech.Input();
                aptechbook.Add(aptech);
            }
        }
        public void Displays(List<AptechBook> aptechbook)
        {
            for(int i=0;i<aptechbook.Count;i++)
            {
                aptechbook[i].Display();
            }
        }
        public void Sort(List<AptechBook> aptechbook1)
        {
            //aptechbook1.Sort((AptechBook ap1, AptechBook ap2) =>
            //{
            //    return string.Compare(ap1.YearPublish, ap2.YearPublish, StringComparison.Ordinal);
            //});
            //aptechBook.Sort(delegate (AptechBook ap1, AptechBook ap2)
            //{
            //    return ap1.Name.CompareTo(ap2.Name);
            //});
            aptechbook1.Sort(
    delegate (AptechBook p1, AptechBook p2)
    {
        int compareDate = p1.Name.CompareTo(p2.Name);
        if (compareDate == 0)
        {
            return p2.Name.CompareTo(p1.Name);
        }
        return compareDate;
    });
        }
        public void SeachingByBookName(List<AptechBook> aptechbook1)
        {
            Console.WriteLine("Nhap ten sach can tim: ");
            string name = Console.ReadLine();
            bool kt = true;
            if(kt==true)
            {
                for (int i = 0; i < aptechbook1.Count; i++)
                {
                    if (aptechbook1[i].Name.Equals(name))
                    {
                        aptechbook1[i].Display();
                        kt = false;
                    }
                }
            }
            if(kt==true)
            {
                Console.WriteLine("Khong tim thay!");
            }
        }
        public void SeachingByBookAuthor(List<AptechBook> aptechbook1)
        {
            Console.WriteLine("Nhap ten tac gia can tim: ");
            string author = Console.ReadLine();
            bool kt = true;
            if(kt==true)
            {
                for (int i = 0; i < aptechbook1.Count; i++)
                {
                    if (aptechBook[i].Author.Equals(author))
                    {
                        aptechBook[i].Display();
                        kt = false;
                    }
                }
            }
            if(kt==true)
            {
                Console.WriteLine("khong tim thay!");
            }
            
        }
        public void Show_Menu()
        {
            Console.WriteLine("1. Nhap thong tin n cuon sach cua AptechBook");
            Console.WriteLine("2. Hien thi thong tin vua nhap");
            Console.WriteLine("3. Sap xep thong tin giam dan theo nam xuat ban va hien thi");
            Console.WriteLine("4. Tim kiem theo ten sach");
            Console.WriteLine("5. Tim kiem theo ten tac gia");
            Console.WriteLine("6. Thoat");
        }
        public void Giao_Tiep()
        {
            int Luachon;
            do
            {
                Show_Menu();
                Console.WriteLine("Nhap lua chon cua ban: ");
                Luachon = Convert.ToInt32(Console.ReadLine());
                switch (Luachon)
                {
                    case 1:
                        {
                            Add_Book(AptechBook);
                            
                            break;
                        }
                    case 2:
                        {
                            Displays(AptechBook);
                            break;
                        }
                    case 3:
                        {
                            Sort(AptechBook);
                            Displays(AptechBook);
                            break;
                        }
                    case 4:
                        {
                            SeachingByBookName(AptechBook);
                            break;
                        }
                    case 5:
                        {
                            SeachingByBookAuthor(AptechBook);
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }while (Luachon<0||Luachon>6);
            
            
        }
    }
}
