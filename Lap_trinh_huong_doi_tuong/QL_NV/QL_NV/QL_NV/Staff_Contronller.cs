using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class Staff_Contronller
    {
        private List<Staff> staffList;
        public List<Staff> StaffList
        {
            get { return staffList; }
            set { staffList = value; }
        }
        public Staff_Contronller()
        {
             StaffList = new List<Staff>();
        }
        public void Add_Staff(Staff staff)
        {
            StaffList.Add(staff);
        }
        public void Remove_Staff(Staff staff)
        {
            StaffList.Remove(staff);
        }
        public float Tinh_Luong(Staff staff)
        {
            float salary = staff.Salary * staff.Work_Time;
            return salary;
        }
        public void Pints(Staff staff)
        {
                Console.WriteLine("Ho ten NV: " + staff.Name);
                Console.WriteLine("Tuoi NV: " + staff.Age);
                Console.WriteLine("Dia chi: " + staff.Address);
                Console.WriteLine("Cong viec: " + staff.Job);
                Console.WriteLine("Luong : " + Tinh_Luong(staff));
        }
        public void Dem_NV()
        {
            Console.WriteLine("So luong: "+StaffList.Count());
        }
    }
}
