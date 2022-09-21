using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Thao_tac_voi_Mang
{
    using System;
    using System.Collections;
    internal class Program
    {

        public struct diem_daucuoi
        {
            public string danhtu_chung, danhtu_rieng;
            public int giatri;
        }  
        //public void mangdong()
        //{
        //    List<diem_daucuoi> mang_dinhnghia = new List<diem_daucuoi>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        diem_daucuoi Diem = new diem_daucuoi();
        //        Diem.danhtu_chung = "chung" + i.ToString();
        //        Diem.danhtu_rieng = "rieng" + i.ToString();
        //        Diem.giatri = i + 1;
        //        //Add điểm
        //        mang_dinhnghia.Add(Diem);
        //    }
        //    //Sắp xếp mang_dinhnghia giảm dần theo giatri
        //    for (int i = 0; i < mang_dinhnghia.Count - 1; i++)
        //    {
        //        for (int j = i + 1; j < mang_dinhnghia.Count; j++)
        //        {
        //            if (mang_dinhnghia[j].giatri > mang_dinhnghia[i].giatri)
        //            {
        //                diem_daucuoi tg = mang_dinhnghia[j];
        //                mang_dinhnghia[j] = mang_dinhnghia[i];
        //                mang_dinhnghia[i] = tg;
        //            }

        //        }
        //    }
        //    String xau = "";
        //    for (int i = 0; i < mang_dinhnghia.Count; i++)
        //    {

        //        xau += mang_dinhnghia[i].giatri.ToString() + "\n";

        //    }
        //    //Console.Write(xau);
        //    MessageBox.Show(xau);//Hiển thị xau

        //    xau.RemoveRange(0, mang_dinhnghia.Count); //Xóa phần tử từ vị trí đầu đến hết

        //}
        static void Main(string[] args)
        {
            ArrayList ma = new ArrayList();
            ArrayList empArray = new ArrayList(); // bản dãy nhân viên 
            ArrayList intArray = new ArrayList(); // bản dãy số nguyên 
            for (int i = 0; i < 5; i++)
            {
                //empArray.Add(new Employee(i + 100));
                intArray.Add(i * 5);
            } // end for 
              // in ra nội dung của intArray 
            for (int i = 0; i < intArray.Count; i++)
            {
                Console.Write("{ 0} ", intArray[i].ToString());
            }
            
            Console.WriteLine();
            // in ra nội dung của empArray 
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.WriteLine();
                // Console.WriteLine("empArray.Capacity: { 0}", empArray.Capacity();
            }                            // cho điền dữ liệu vào bản dãy 

            /*
            int[] ds = { 1, 5, 3, 7, 9, 2 };
            Console.WriteLine($"So ohan tu trong mang la: {ds.Length}");
            Console.WriteLine($"Chieu { ds.Rank}");
            Console.WriteLine($"Max= {ds.Max()}");
            Console.WriteLine($"Min= {ds.Min()}");
            Console.WriteLine($"Tong gia tri cua cac phan tu la: {ds.Sum()}");

            Array.Sort(ds);     //Sắp xếp mảng theo chiều tăng dần
            foreach(var item in ds)
            {
                Console.WriteLine(item);
            }*/

            //MẢNG 2 CHIỀU
            double[,] data=new double[,] { { 2, 3,7 },{ 1, 2,7},{ 6, 8,7} };
             int n = 11;
             n = n%2;
             Console.WriteLine($"n%2= {n}");
             Console.WriteLine(data[1,1]);
             const int hang = 3;
             const int cot = 3;
            Console.WriteLine();
             for(int i=0;i<hang;i++)
             {
                 for(int j=0;j<cot;j++)
                 {
                     Console.Write(data[i,j]);
                     Console.Write(" ");
                 }
                 Console.WriteLine();
             }
             
            int[] mang = new int[] { 4, 1, 6, 3, 1, 7, 4, 9 };
            
            Console.WriteLine(Array.LastIndexOf(mang, 9));
            string[] mang3 = new string[12];
            
            Console.WriteLine(mang.Contains(5));
             Array.Sort(mang);
            //Array.Reverse(mang);
            string chuoi = "phai thanh cong";
          
            Console.WriteLine(chuoi.Remove(2));

            Console.WriteLine("Check vi tri xuat hien cua doi tuong "+Array.IndexOf(mang, 9));
            foreach(var item in mang)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(mang.Contains(7));


            Console.ReadKey();
        }

    }
}
