using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach
{
    internal class Book
    {
        public string _name;
        public string Author { get; set; }
        public string Producer { get; set; }
        public string YearPublish { get; set; }
        private float _price;
        public float Price
        {
            get { return _price; }
            set
            {
                if(value>0)
                {
                    _price = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Length>0&&value.Length<20)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Sai du lieu!");
                }
            }
        }
        public Book()
        {

        }
        public Book(string name, string author, string producer, string yearPublish, float price)
        {
            this.Name = name;
            this.Author = author;
            this.Producer = producer;
            this.YearPublish = yearPublish;
            this.Price = price;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ten sach: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap ten tac gia: ");
            Author = Console.ReadLine();
            Console.WriteLine("Nhap nam san xuat: ");
            Producer = Console.ReadLine();
            Console.WriteLine("Nhap nam xuat ban: ");
            YearPublish = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            Price = float.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine("----Thong tin sach----");
            Console.WriteLine("Ten sach: " + Name);
            Console.WriteLine("Ten tac gia: " + Author);
            Console.WriteLine("Nam san xuat: " + Producer);
            Console.WriteLine("Nam xuat ban: " + YearPublish);
            Console.WriteLine("Gia ban: " + Price);
        }
        /*Hoặc
         * public virtual tostring()
         * {
         * return "Ten sach: {0}"+"Ten tac gia: {1}" ....vv
         * }
         */
    }
}
