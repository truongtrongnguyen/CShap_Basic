using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach_2
{
    internal class Contronller
    {
        public Contronller()
        {
            Authors = new List<Author>();
            Books = new List<Book>();
        }
        public List<Author> Authors;
        public List<Book> Books;

        public void Giaodien()
        {
            int Option;
            do
            {
                ShowMenu();
                Console.Write("Nhap lua chon cua ban: ");
                Option = int.Parse(Console.ReadLine());
                switch(Option)
                {
                    case 1:
                        {
                            Nhapthongtinsach(Books, Authors);
                            break; 
                        }
                    case 2:
                        {
                            Display_ListBook(Books);
                            break;
                        }
                    case 3:
                        {
                            Nhapthongtintacgia(Authors);
                            break;
                        }
                    case 4:
                        {
                            Display_ListAuthor(Authors);
                            break;
                        }
                    case 5:
                        {
                            Seach(Books);
                            break;
                        }
                    case 6:
                        {
                            SeachWithAuthor(Authors, Books);
                           // Environment.ExitCode = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Lua chon khong hop le");
                            break;
                        }
                }
            } while (Option != 6);
        }
        public void Nhapthongtinsach(List<Book> books, List<Author> authors)
        {
            Console.Write("Nhap so luong sach can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap thong tin sach thu: " + (i + 1));
                Book book = new Book();
                book.Input(authors);
                books.Add(book);
            }

        }
        public void Display_ListBook(List<Book>books)
        {
            for(int i=0;i<books.Count;i++)
            {
                Console.WriteLine("Thong tin sach thu: "+(i + 1));
                books[i].Display();
            }
        }
        public void Display_ListAuthor(List<Author> authors)
        {
            for (int i = 0; i < authors.Count; i++)
            {
                Console.WriteLine("Thong tin tac gia thu: " + (i + 1));
                authors[i].Display();
            }
        }
        public void Nhapthongtintacgia(List<Author> authors)
        {
            Console.Write("Nhap so luong tac gia can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap thong tin tac gia thu: " + (i + 1));
                Author author = new Author();
                author.Input(authors);
                authors.Add(author);
            }
        }
        public void Seach(List<Book> books)
        {
            Console.Write("Nhap but danh can tim: ");
            string name = Console.ReadLine();
            Console.WriteLine("THONG TIN SACH CAN TIM:");
            for(int i=0;i<books.Count;i++)
            {
                if (books[i].Nickname.Equals(name))
                {
                    books[i].Display();
                }
            }
        }
        public void SeachWithNickName(List<Book> books, string nickname)
        {
            foreach(Book i in books)
            {
                if (i.Nickname.Equals(nickname))
                {
                    i.Display();
                }
            }
        }
        public void SeachWithAuthor(List<Author> authors, List<Book> books)
        {
            Console.WriteLine("Nhap ten tac gia can tim: ");
            string name = Console.ReadLine();
            Console.WriteLine("Thong tin lien qua toi tac gia:");
            foreach(Author author in authors)
            {
                if(author.Name.Equals(name))
                {
                    author.Display();
                    SeachWithNickName(books, author.Nickname);
                    return;
                }
            }

        }
        public void ShowMenu()
        {
            Console.WriteLine("\t-----NENU-----");
            Console.WriteLine("1. Nhap thong tin sach");
            Console.WriteLine("2. Hien thi tat ca sach");
            Console.WriteLine("3. Nhap thong tin tac gia");
            Console.WriteLine("4. Xuat thong tin tac gia");
            Console.WriteLine("5. Tim kiem");
            Console.WriteLine("6.Thoat chuong trinh");
            Console.WriteLine("\t-----END-----");

        }

    }
}
