using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Doc_Ghi_File_SV
{
        public class Overrride_Sort : IComparer
        {
            public int Compare(object x, object y)
            {
                Sinh_Vien p1 = x as Sinh_Vien;
                Sinh_Vien p2 = x as Sinh_Vien;
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (p1.Diem < p2.Diem)
                    {
                        return -1;
                    }
                    else if (p1.Diem == p2.Diem)
                        return 0;
                    else
                        return 1;
                }
            }
        }
}
