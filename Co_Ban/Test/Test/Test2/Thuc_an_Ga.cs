using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Thuc_an_Ga:Thong_Tin_Thuc_An
    {
        public Thuc_an_Ga()
        {
            Name = Thong_Tin_Chung.C_Name_Thuc_An_Ga;
            Gia_Thuc_An = Thong_Tin_Chung.C_Gia_Thuc_An_Ga;
            Luong_Thuc_An = Thong_Tin_Chung.C_Luong_Thuc_An_Ga;
        }
    }
}
