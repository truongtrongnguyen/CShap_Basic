using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Ga:Thong_Tin_Con_Vat
    {
        public Ga()
        {
            Name = Thong_Tin_Chung.C_Ga;
            Thuc_an = new Thuc_an_Ga();
            Gia_tri = Thong_Tin_Chung.C_Gia_Ga;
        }
    }
}
