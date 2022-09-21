using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San.Models
{
    internal class Customer
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string CMTND { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer()
        {
        }
        public Customer(string cmtnd)
        {
            CMTND = cmtnd;
        }

        public Customer(string fullname, int age, string cmtnd, string gender, string address)
        {
            Fullname = fullname;
            Age = age;
            CMTND = cmtnd;
            Gender = gender;
            Address = address;
        }

        public void Input()//Dùng để thêm mới khách hàng
        {
            Console.WriteLine("Nhap CMTND: ");
            CMTND = Console.ReadLine();

            InputWithoutCMTND();
        }

        public void InputWithoutCMTND()//Khi đặt phòng mà CMND khách hàng chưa có trong ds thì thêm mới khách hàng vào List<Customer>
        {
            Console.WriteLine("Nhap ten: ");
            Fullname = Console.ReadLine();

            Console.WriteLine("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gioi tinh: ");
            Gender = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Ten: {0}, tuoi: {1}, cmtnd: {2}, gioi tinh: {3}, dia chi: {4}", Fullname, Age, CMTND, Gender, Address);
        }
    }
}
