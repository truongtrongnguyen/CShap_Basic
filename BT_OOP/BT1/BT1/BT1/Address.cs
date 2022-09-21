using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    internal class Address
    {
        private string ten_duong;
        private string ten_quan;
        private string ten_tp;

        //public Address()
        //{
        //}
        //propre
        public  Address(string ten_duong, string ten_quan, string ten_tp)
        {
            this.ten_duong = ten_duong;
            this.ten_quan = ten_quan;
            this.ten_tp = ten_tp;
        }
        public string Ten_Duong
        {
            get { return ten_duong; }
            set { ten_duong = value; }
        }
        public string Ten_Quan
        {
            get { return ten_quan; }
            set { ten_quan = value; }
        }
        public string Ten_TP
        {
            get { return ten_tp;  }
            set { ten_tp = value; }
        }
        
        public string Tostring()
        {
            return $"Dia chi: {this.Ten_Duong}, {this.Ten_Quan}, {this.Ten_TP}\n";
        }
        public static bool operator ==(Address dc1, Address dc2)
        {
            return ((dc1.Ten_Duong.Equals(dc2.Ten_Duong))&&(dc1.Ten_Quan.Equals(dc2.Ten_Quan))&&(dc1.Ten_TP.Equals(dc2.Ten_TP)));
        }
        public static bool operator !=(Address dc1, Address dc2)
        {
            return !(dc1 == dc2);
        }
    }
}
