using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Arrry_Trang_378_Giao_trinh
{
    internal class Program
    {
        public class ListBoxText
        {
            public ListBoxText(params string[] initialStrings)
            {
                myStrings = new string[256];//CẤP PHÁT SỐ LƯỢNG PHẦN TỬ CHUỖI
                // GÁN CÁC CHUỖI CHỮ QUA HÀM CONTRUCTOR
                foreach (string s in initialStrings)
                {
                    myStrings[myCtr++] = s;
                }
            }
            public void Add(string theString)
            {
                if (myCtr > myStrings.Length)
                {   //xử lí sai ở đây nếu myCtr mà lớn hơn 256 ô nhớ
                    throw new IndexOutOfRangeException("Vuot qua so luong phan tu chuoi");
                }
                else
                {
                    myStrings[myCtr] = theString;
                    myCtr++;
                }
            }
            //HÀM TRUY XUẤT PHẦN TỬ THEO SỐ NGUYÊN
            public string this[int index]
            {
                get
                {
                    if (index < 0 || index > myStrings.Length)
                    {
                        throw new IndexOutOfRangeException("Vuot qua gioi han");
                    }
                    return myStrings[index];
                }
                set
                {
                    if(index>myCtr)
                    {
                        throw new IndexOutOfRangeException("Vuot qua gioi han");
                    }
                    else
                        myStrings[index] = value;
                }
            }
            private int findString(string searchString)
            {
                for (int i = 0; i < myStrings.Length; i++)
                {
                    if (myStrings[i].StartsWith(searchString))
                        return i;
                }
                return -1;
            }
            public string this[string index]
            {
                get
                {
                    if(index.Length==0)
                    {
                        Console.WriteLine("Muc khong tim thay");
                    }
                    return this[findString(index)];
                }
                set
                {
                    myStrings[findString(index)] = value;
                }
            }
            //HÀM BÁO CHI BIẾT GIỮ BAO NHIÊU PHẦN TỬ
            public int GetNumEntries()
            {
                return myCtr;
            }

            private string[] myStrings;//TẠO MỘT MẢNG STRING
            private int myCtr = 0;//BIẾN GIỮ SỐ LƯỢNG PHẦN TỬ MẢNG
        }
        //HÀM THÊM MỘT PHẦN TỬ VÀO CUỐI MẢNG 
        
        static void Main(string[] args)
        {
            ListBoxText lbt = new ListBoxText("Hello","Work");
            //ICollection col = new System.Collections.Generic.ICollection();
            
            lbt.Add("khong");
            lbt.Add("Biet");
            lbt.Add("Vi");
            lbt.Add("Sao");
            lbt.Add("Ta");
            lbt.Add("Buon");
            string sub = "GooBye";
            lbt[1] = sub;
            lbt["V"] = "Goodbye";
            for(int i=0;i<lbt.GetNumEntries();i++)
            {
                Console.Write(lbt[i] + " ");
                
            }
            int[] Arry =  {1,3,6 ,54, 23,7 };
            Console.WriteLine($"So luong phan tu trong mang la: {Arry.Length}");
            int a = Arry.GetUpperBound(0);
            Console.WriteLine(a);
            Console.WriteLine($"Chieu phan tu la: {Arry.Rank}");
            Console.WriteLine($"Max= {Arry.Max()}");
            Console.WriteLine($"Min= {Arry.Min()}");
            int r = 5;
           // Arry.Add(r);
            Console.WriteLine(Arry.Contains(4));
            Console.ReadKey();
        }
    }
}
