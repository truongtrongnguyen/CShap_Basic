using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
namespace Doc_Ghi_File_SV
{
    internal class Doc_File
    {
        public Doc_File()
        {
            listsv = new List<Sinh_Vien>();//Sử dụng hàm List<T>
            controller = new Controller();
            l = new List();
        }
        public List<Sinh_Vien> listsv;//Sử dụng hàm List<T>
        public Controller controller;//Sử dụng thuật toán
        public List l;//Sử dụng thuật toán
        public void ReadFile(FileStream fs, string path)
        {
            using (fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string temp = sr.ReadToEnd();//Cho biến temp giữ chuỗi tạm thời
                string[] s = temp.Split('\n');//Tiến hành cắt chuỗi theo dấu enter

                Regex e = new Regex(@"(?<name>[a-z A-Z]+)\W+(?<id>[A-Z0-9]+)\W+(?<time>\d{2}\/\d{2}\/\d{4})\W+(?<diem>[\d]\.\d)");
                MatchCollection matches;
                foreach (var i in s)
                {
                    matches = e.Matches(i);
                    foreach (Match m in matches)
                    {

                        string name = m.Groups["name"].ToString();
                        string id = m.Groups["id"].ToString();
                        string datetime = m.Groups["time"].ToString();
                        float diem = float.Parse(m.Groups["diem"].ToString());

                        Sinh_Vien sv = new Sinh_Vien(name, id, datetime, diem);//Sử dụng thuật toán
                        Node p=controller.KhoiTaoNode(sv);
                        controller.Themvaocuoi(l, p);

                        //listsv.Add(sv);//Sử dụng hàm List<T>
                    }
                }
                sr.Close();
            }
        }
        public void Xoa_SV_Cuoi()
        {
            controller.Xoa_Cuoi(l);
        }
        public void Xoa_SV_Dau()
        {
            controller.Xoa_Dau(l);
        }
        public void Them_SV()
        {
            Console.Write("Nhap so sinh vien can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu: " + (i + 1));
                Sinh_Vien sv = new Sinh_Vien();
                sv.Input();
                Node p=controller.KhoiTaoNode(sv);
                controller.Themvaocuoi(l,p);
            }
        }
        public void Tim_Kiem()
        {
            Console.Write("Nhap ten can tim: ");
            string name = Console.ReadLine();
            controller.Tim_Kiem(l, name);
        }
        public void Sap_sep_tang_dan()
        {
            controller.Sap_Sep(l);
        }
        public void XuatThongTin()//Sử dụng thuật toán
        {
            
            Console.WriteLine("\tDANH SACH SINH VIEN: ");
            controller.Xuatthongtinsinhvien(l);
        }
        public void DisplayList()//Sử dụng hàm List<T>
        {
            int n = 1;
            Console.WriteLine("\tDANH SACH SINH VIEN");
            foreach (Sinh_Vien i in listsv)
            {
                Console.WriteLine("Thong tin sinh vien thu " + n);
                i.Display();
                n++;
            }
        }
        public void WriteFile(FileStream fs, string path)
        {
            using (fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {

                StreamWriter sw = new StreamWriter(fs);
                //foreach (Sinh_Vien i in listsv)
                //{
                //    sw.Write(i.Name);
                //    sw.Write(", ");
                //    sw.Write(i.Id);
                //    sw.Write(", ");
                //    sw.Write(i.Time);
                //    sw.Write(", ");
                //    sw.WriteLine(i.Diem);
                //}


                for(Node k=l.pHead;k!=null;k=k.pNext)
                {
                    sw.Write(k.sinvien.Name);
                    sw.Write(", ");
                    sw.Write(k.sinvien.Id);
                    sw.Write(", ");
                    sw.Write(k.sinvien.Time);
                    sw.Write(", ");
                    sw.WriteLine(k.sinvien.Diem);
                }
                sw.Flush();
                sw.Close();
            }
              
        }
    }
}
