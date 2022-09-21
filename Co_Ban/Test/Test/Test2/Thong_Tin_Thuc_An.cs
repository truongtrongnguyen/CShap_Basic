using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Thong_Tin_Thuc_An
    {
        private string _name;
        private int _gia_thuc_an;
        private int _luong_thuc_an;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Gia_Thuc_An
        {
            get { return _gia_thuc_an; }
            set { _gia_thuc_an = value; }
        }
        public int Luong_Thuc_An
        {
            get { return _luong_thuc_an; }
            set { _luong_thuc_an = value; }
        }
    }
}
