using System;
using System.Collections.Generic;
using System.Text;

namespace Quan_Ly_Vat_Tu
{
    internal class Ngoai_Le
    {
        public string Xoa_khoang_trang_dau(ref string a)
        {
            while (a[0]==' ')
            {
                a=a.Remove(0, 1);
            }
            return a;
        }
        public string Xoa_khoang_trang_cuoi(ref string a)
        {
            while (a[a.Length - 1] == ' ')
            {
                a = a.Remove(a.Length-1,1);
            }
            return a;
        }
        public string Xoa_giua(ref string a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                if (a[i]==' ' && a[i+1]==' ')
                {
                    a = a.Remove(i+1, 1);
                    i--;
                }   
            }
            return a;
        }
        //public void Viet_hoa(string a)
        //{
        //    if (a[0] >= 97 && a[0]<=122)
        //    {
        //        a[0] -= 32;
        //    }
        //}
    }
}
