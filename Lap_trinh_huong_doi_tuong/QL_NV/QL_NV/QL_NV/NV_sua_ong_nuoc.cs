using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NV
{
    internal class NV_sua_ong_nuoc:Staff
    {
        public NV_sua_ong_nuoc()
        {
            //add_information=new Add_information();   
            Add_nv_Staff();
            Job = Constanst.C_NV_Sua_Ong_Nuoc;
            Salary = Constanst.C_Salary_Sua_Ong_Nuoc;
            Work_Time = Constanst.C_Work_Time_Sua_Ong_Nuoc;
        }

    }
}
