using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_Manager manager = new Employee_Manager();
            manager.Dem();

            manager.Add_Staff();
            manager.Dem();
            manager.Prints_Staff();
            Console.Write("Nhap ten nhan vien can xoa: ");
            //string name1 = Console.ReadLine();
            manager.Remove_staff();
            manager.Prints_Staff();
            manager.Dem();
            Console.ReadLine();
        }
    }
}
