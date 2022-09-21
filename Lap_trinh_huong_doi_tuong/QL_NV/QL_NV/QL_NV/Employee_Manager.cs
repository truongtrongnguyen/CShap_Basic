using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class Employee_Manager
    {
        public Employee_Manager()
        {
            NV_Ong_Nuoc = new Staff_Contronller();
        }
        private Staff_Contronller nv_ong_nuoc;
        public Staff_Contronller NV_Ong_Nuoc
        {
            get { return nv_ong_nuoc; }
            set { nv_ong_nuoc = value; }
        }
        public void _Add(Staff staff, string name, int count)
        {
            
        }
        public void Add_Staff()
        {
            Staff staff1 = null;
            Console.Write("Nhap ten nhan vien:");
            string name = Console.ReadLine();
            if (name.Equals(Constanst.C_NV_Sua_Ong_Nuoc))
            {
                staff1 = new NV_sua_ong_nuoc();
                Console.Write("Nhap so luong nhan vien can them: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap thong tin nhan vien thu: " + (i + 1));
                    NV_sua_ong_nuoc staff = new NV_sua_ong_nuoc();
                    NV_Ong_Nuoc.Add_Staff(staff);
                }
            }

        }
        public void Remove_staff()
        {
            Console.Write("Nhap ten nhan vien can xoa: ");
            string name = Console.ReadLine();
            for(int i=0;i< NV_Ong_Nuoc.StaffList.Count;i++)
            {
                if (NV_Ong_Nuoc.StaffList[i].Name.Equals(name))
                {
                    NV_Ong_Nuoc.Remove_Staff(NV_Ong_Nuoc.StaffList[i]);
                    return;
                }
            }
        }
        public void Prints_Staff()
        {
           for(int i=0;i<NV_Ong_Nuoc.StaffList.Count;i++)
            {
                NV_Ong_Nuoc.Pints(NV_Ong_Nuoc.StaffList[i]);
            }
        }
        public void Dem()
        {
            if (NV_Ong_Nuoc.StaffList.Count > 0)
            {
                NV_Ong_Nuoc.Dem_NV();
            }
            else
            {
                Console.WriteLine("Not thing show");
            }
        }
        
    }
}
