using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach_2
{
    internal class Book
    {
        public string Name { get; set; }
        public string RelesasedDate { get; set; }
        public string Nickname { get; set; }
        public Author author;
        public Book() 
        {
            author = new Author();
        }
        public Book(string name, string relesaseddate, string nickname)
        {
            this.Name = name;
            this.RelesasedDate = relesaseddate;
            this.Nickname = nickname;
        }
        public void Input(List<Author> authors)
        {
            Console.Write("Nhap ten sach: ");
            Name = Console.ReadLine();
            Console.Write("Nhap ngay phat hanh: ");
            RelesasedDate = Console.ReadLine();
            Console.Write("Nhap but danh: ");
            Nickname = Console.ReadLine();
            if (!author.CheckNickName(authors, Nickname))
            {
                Console.WriteLine("But danh tac gia chua ton tai vui long them tac gia: ");
                Author author = new Author(Nickname);
                author.Input();
                authors.Add(author);
            }
        }
        public void Display()
        {
            Console.WriteLine($"Ten sach: {Name} | Ngay phat hanh: {RelesasedDate} | But danh: {Nickname}");
        }
    }
}
