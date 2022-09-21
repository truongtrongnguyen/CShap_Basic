using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Test
{
    internal class Customer
    {
        public string CMND { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Customer()
        { }
        public Customer(string cmnd)
        {
            this.CMND = cmnd;
        }
        public void InputWithCMND()
        {
            Console.Write("Nhap cmnd: ");
            CMND = Console.ReadLine();
            Input();
        }
        public void Input()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap gioi tinh: ");
            Gender = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"Ten: {Name} | CMND: {CMND} | Tuoi: {Age} | Gioi tinh: {Gender} | Dia chi: {Address}");
        }
    }
}
