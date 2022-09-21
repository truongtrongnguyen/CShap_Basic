using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Color { get; set; }
        public int Bran { get; set; }   //ID nhãn hiệu
        public Product(int id, string name, double price, string[] color, int bran)
        {
            Id = id;
            Name = name;
            Price = price;
            Color = color;
            Bran = bran;
        }
        public override string ToString()
        {
            return $"{Id, 3} {Name, 12} {Price, 5} {Bran, 5} {string.Join(",", Color)}";
        }
    }
}
