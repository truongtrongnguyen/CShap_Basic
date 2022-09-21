using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Thong_Tin_Con_Vat
    {
        private string _name;
        private Thong_Tin_Thuc_An _thuc_an;
        private int _gia_tri;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Thong_Tin_Thuc_An Thuc_an
        {
            get { return _thuc_an; }
            set { _thuc_an = value; }
        }
        public int Gia_tri
        {
            get { return _gia_tri; }
            set { _gia_tri = value; }
            }
    }
}
