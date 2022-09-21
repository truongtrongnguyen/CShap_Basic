using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach_2
{
    internal class Author
    {
        //Tạo các thuộc tính chỉ đọc
        public string Name { get; private set; }
        public string Brithday { get; private set; }
        public string Nickname { get; private set; }
        public string Address { get; private set; }
        public Author()
        {

        }
        public Author(string name, string birthday, string nickname, string address)
        {
            this.Name = name;
            this.Brithday = birthday;
            this.Nickname = nickname;
            this.Address = address;
        }
        public Author(string nickname)
        {
            this.Nickname = nickname;
        }
        public void Input()
        {
            Console.Write("Nhap ten tac gia: ");
            Name = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            Brithday = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();
        }
        public void Input(List<Author> authors)
        {
            //Console.Write("Nhap ten tac gia: ");
            //Name = Console.ReadLine();
            //Console.Write("Nhap ngay sinh: ");
            //Brithday = Console.ReadLine();
            Input();
            Console.Write("Nhap but danh: ");
            while(true)
            {
                Nickname = Console.ReadLine();
                if (CheckNickName(authors, Nickname))
                {
                    Console.Write($"But danh {Nickname} da ton tai vui long nhap lai: ");
                }
                else
                {
                    break;  
                }
            }
            //Console.Write("Nhap dia chi: ");
            //Address = Console.ReadLine();
        }
        public bool CheckNickName(List<Author> authors, string Name)
        {
            for (int i = 0; i < authors.Count; i++)
            {
                if (authors[i].Nickname.Equals(Name))
                {
                    return true;
                }
            }
            return false;
        }
        public void Display()
        {
            Console.WriteLine($"Ten tac gia: {Name} | Ngay sinh: {Brithday} | But danh: {Nickname} | Dia chi: {Address}");
        }
    }
}
