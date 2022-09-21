using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class Add_information
    {
        private string add_name;
        public string Add_Name()
        {
            Console.Write("Nhap ten nhan vien: ");
            add_name = Console.ReadLine();
            return add_name;
        }
        private int add_age;
        public int Add_Age()
        {
            Console.Write("Nhap tuoi nhan vien: ");
            add_age = Convert.ToInt32(Console.ReadLine());
            return add_age;
        }
        private string add_dia_chi;
        public string Add_Address()
        {
            Console.Write("Nhap dia chi nhan vien: ");
            add_dia_chi = Console.ReadLine();
            return add_dia_chi;
        }
        
 
    }
} 
