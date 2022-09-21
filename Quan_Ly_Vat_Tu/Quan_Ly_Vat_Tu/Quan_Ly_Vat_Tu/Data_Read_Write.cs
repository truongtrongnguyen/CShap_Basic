using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Quan_Ly_Vat_Tu
{
    internal class Data_Read_Write
    {
        private FileStream stream;
        public string path;
        public ds_Vat_Tu ds_vat_tu;
        public Data_Read_Write(string path, ds_Vat_Tu ds_vat_tu)
        {
            this.path = path;
            this.ds_vat_tu = ds_vat_tu;
            stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            
        }
        public void Read_Data()
        {
            StreamReader sr = new StreamReader(stream);
            string a= sr.ReadToEnd();
            Xu_li(a);
            sr.Close();
        }
        public void Xu_li(string a)
        {
            Regex re = new Regex(@"(?<ma_vt>(VT\d+))\,(?<ten_vt>([\w|\s|\w]*))\,(?<dv>(\w+))\,(?<sl>\d+)\,(?<kt>(\w+))");
            

            string[] temp = a.Split('\n');
            
            for(int i=0;i<temp.Length-1;i++)
            {
                Vat_Tu vt = new Vat_Tu();
                MatchCollection m = re.Matches(temp[i]);
                foreach (Match j in m)
                {
                    
                    vt.ma_vt = j.Groups["ma_vt"].ToString();
                    vt.ten_vt = j.Groups["ten_vt"].ToString();
                    vt.don_vi = j.Groups["dv"].ToString();
                    vt.so_luong_ton = Convert.ToInt32((j.Groups["sl"]).ToString());
                    vt.kt = j.Groups["kt"].ToString().Equals("True") ? true : false;
                }
                ds_vat_tu.ds_vat_tu[ds_vat_tu.soluong] = vt;
                ds_vat_tu.soluong++;
            }
        }
        public void Write_Data(ds_Vat_Tu ds_vat_tu)
        {
            StreamWriter sw = new StreamWriter(stream);
            for(int i=0;i<ds_vat_tu.soluong;i++)
            {
                sw.Write(ds_vat_tu.ds_vat_tu[i].ma_vt);
                sw.Write(',');
                sw.Write(ds_vat_tu.ds_vat_tu[i].ten_vt);
                sw.Write(',');
                sw.Write(ds_vat_tu.ds_vat_tu[i].don_vi);
                sw.Write(',');
                sw.Write(ds_vat_tu.ds_vat_tu[i].so_luong_ton);
                sw.Write(',');
                sw.WriteLine(ds_vat_tu.ds_vat_tu[i].kt);
            }
            sw.Flush();
            sw.Close();
        }
    }
}
