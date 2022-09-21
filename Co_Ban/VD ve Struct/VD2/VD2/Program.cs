using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2
{
    // Khai báo một enum “cây nhà lá vườn” 
    enum EmpType : byte // loại nhân viên 
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VP = 9
    }
    // Khai báo một struct sử dụng enum kể trên 
    struct EMPLOYEE
    { // Các vùng mục tin 
        public EmpType title; // chức vụ, kiểu enum 
        public string name; // tên nhân viên 
        public short deptID; // mã số phòng ban 
                             
        public EMPLOYEE(EmpType et, string n, short d)  // Hàm constructor của struct. 
        {
            title = et; // khởi gán 
            name = n; // … 
            deptID = d; // … 
        }
    }
    internal class Program
    {
        public static void DisplayEmpStats(EMPLOYEE e) // hiển thị tình trạng 
                                                // nhân viên 
        {
            Console.WriteLine("Đây là thông tin của {0}", e.name);
            Console.WriteLine("Mã số phòng ban: {0}", e.deptID);
            Console.WriteLine("Chức vụ: {0}", Enum.Format(typeof(EmpType), e.title, "G"));
        }
        public void UnboxThisEmployee(object o) // rã hộp nhân viên
        {
            EMPLOYEE temp = (EMPLOYEE)o;
            Console.WriteLine(temp.deptID + " còn sống!");
        }
        static int Main(string[] args)
        {
            // Tạo và định dạng Fred. 
            EMPLOYEE fred;
            fred.deptID = 40;
            fred.name = "Fred";
            fred.title = EmpType.Grunt;
            // Tạo và định dạng Mary dùng đến hàm constructor. 
            EMPLOYEE mary = new EMPLOYEE(EmpType.VP, "Mary", 10);
            // Để cho nhân viên kê khai lý lịch 
            Program t = new Program();
            DisplayEmpStats(mary);
            DisplayEmpStats(fred);
            // Tạo và đóng hộp một nhân viên 
            EMPLOYEE stan = new EMPLOYEE(EmpType.Grunt, "Stan", 10);
            object stanInBox = stan;

            // Chuyển object cho hàm rã hộp 
            t.UnboxThisEmployee(stanInBox);
            
            Console.ReadKey();
            return 0;
        }
    }
}
