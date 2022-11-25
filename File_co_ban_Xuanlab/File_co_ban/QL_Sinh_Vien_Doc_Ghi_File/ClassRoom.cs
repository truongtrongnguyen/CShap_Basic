using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien_Doc_Ghi_File
{
    [Serializable]//Giao thức chuyển đổi dùng để lưu file
    public class ClassRoom
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Student> StudentList;

        public ClassRoom()
        {
            StudentList = new List<Student>();
        }

        public void Input()
        {
    
            Console.WriteLine("Nhap ten lop: ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();

            
            Console.WriteLine("Nhap so sinh vien: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu: " + i + 1);
                Student std = new Student();
                std.Input();

                StudentList.Add(std);
            }
        }

        public void Display()
        {
            Console.WriteLine("THONG TIN LOP HOC: ");
            Console.WriteLine("Ten lop hoc: {0} | Dia chi: {1}", Name, Address);
            Console.WriteLine("DANH SACH SINH VIEN: ");
            foreach (Student std in StudentList)
            {
                std.Display();
            }
            Console.WriteLine();
        }
    }
}
