using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    internal class Chuong_Con_Vat
    {
        public Chuong_Con_Vat()
        {
            Con_Vat = new List<Thong_Tin_Con_Vat>();
        }
        private List<Thong_Tin_Con_Vat> _con_vat;
        public List<Thong_Tin_Con_Vat> Con_Vat
        {
            get { return _con_vat; }
            set { _con_vat = value; }
        }
        public void Them_Con_Vat(Thong_Tin_Con_Vat convat)
        {
            Con_Vat.Add(convat);
        }
        public void Xoa_Con_Vat(Thong_Tin_Con_Vat convat)
        {
            Con_Vat.Remove(convat);
        }
        public void Tong_So_Luong_KG_Con_Vat(Thong_Tin_Con_Vat convat)
        {
            
            //return Con_Vat.Count * convat.Gia_tri;
            
        }
        public void Amount(Thong_Tin_Con_Vat convat)
        {
            Console.WriteLine($"Luong thuc an ma con {convat.Name} tieu thu/ngay la: {convat.Thuc_an.Luong_Thuc_An}");
        }

    }
}
