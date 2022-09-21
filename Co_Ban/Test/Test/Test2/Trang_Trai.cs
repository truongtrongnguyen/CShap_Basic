using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Trang_Trai
    {
        public Trang_Trai()
        {
            Chuong_Ga = new Chuong_Con_Vat();
           
        }
        private Chuong_Con_Vat _chuong_ga;
        public Chuong_Con_Vat Chuong_Ga
        {
            get { return _chuong_ga; }
            set { _chuong_ga = value; }
        }
        private void Add_(Chuong_Con_Vat chuong, string name, int count)
        {
            Thong_Tin_Con_Vat tt_convat = null;
            if (name.Equals(Thong_Tin_Chung.C_Ga))
            {
                tt_convat = new Ga();
            }
            for(int i=0;i<count;i++)
            {
                chuong.Them_Con_Vat(tt_convat);
            }
        }
        public void Add(string name, int count)
        {
            if (name.Equals(Thong_Tin_Chung.C_Ga))
            {
                Add_(Chuong_Ga, Thong_Tin_Chung.C_Ga, count);
            }
        }
        private void _Remove(Chuong_Con_Vat chuong, string name, int count)
        {
            Thong_Tin_Con_Vat tt_con_vat = null;
            if(name.Equals(Thong_Tin_Chung.C_Ga))
            {
                tt_con_vat = new Ga();
            }
            for(int i=0;i<count;i++)
            {
                chuong.Xoa_Con_Vat(tt_con_vat);
            }
        }
        public void Remove(string name, int count)
        {
            if(name.Equals(Thong_Tin_Chung.C_Ga))
            {
                _Remove(Chuong_Ga, Thong_Tin_Chung.C_Ga, count);
            }
        }
        public void Chi_phi_trang_trai(Chuong_Con_Vat chuong)
        {
                Console.WriteLine("Tong chi phi trang trai la: " + chuong.Con_Vat[0].Thuc_an.Gia_Thuc_An*chuong.Con_Vat.Count);
        }
        public void Dem_So_Luong(Chuong_Con_Vat chuong)
        {
            Console.WriteLine($"So luong con {chuong.Con_Vat[0].Name} hien co trong trai la: {chuong.Con_Vat.Count}");
        }
    }
}
