using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien_Doc_Ghi_File
{
    [Serializable]//Giao thức chuyển đổi dùng để lưu file
    public class Student
    {
        public string Fullname { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Student()
        {
        }
        public Student(string fullname, string birthday, string email, string gender, string address)
        {
            this.Fullname = fullname;
            this.Birthday = birthday;
            this.Email = email;
            this.Gender = gender;
            this.Address = address;
        }
        public void Input()
        {
            Console.WriteLine("Nhap ten: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh(dd-mm-yyyy): ");
            Birthday = Console.ReadLine();
            Console.WriteLine("Nhap email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            Gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Ten: {0}, Ngay sinh: {1}, Gioi tinh: {2}, Email: {3}, " +
                              "Dia chi: {4}", Fullname, Birthday, Gender, Email, Address);
        }
    }
}
