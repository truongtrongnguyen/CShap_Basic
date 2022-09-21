using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Doc_Ghi_File_SV
{
    public class Controller
    {
        public void Xoa_Cuoi(List l)
        {
            if(l.pHead==null)
            {
                return;
            }
            if(l.pHead.pNext==null)//Nếu danh sách tồn tại một phần tử
            {
                Node p = l.pHead;
                l.pHead = l.pHead.pNext;
                p = null;
                return;

            }
            else
            {
                for(Node k=l.pHead;k!=null;k=k.pNext)
                {
                    if(k.pNext.pNext==null)
                    {
                        k.pNext = null;
                        k.pNext = null;
                        return;
                    }
                }
            }
        }
        public void Xoa_Dau(List l)
        {
            if(l.pHead==null)
            {
                return;
            }
            Node p = l.pHead;
            l.pHead = l.pHead.pNext;
        }
        public void Xuatthongtinsinhvien(List l)//Sử dụng thuật toán
        {
            for(Node k=l.pHead;k!=null;k=k.pNext)
            {
                k.sinvien.Display();
            }
        }
        public void Themvaocuoi(List l, Node p)//Sử dụng thuật toán
        {
            if (l.pHead == null)//Nếu danh sách đang rỗng thì con trỏ đang là null thì node dầu cũng như node cuối = null
            {
                l.pHead = l.pTail = p;
            }
            else
            {
                l.pTail.pNext = p;//cho con trỏ cua node pTail trỏ đến node cần thêm
                l.pTail = p;//Cập nhật lại node p là node cuối
            }
        }
        public Node KhoiTaoNode(Sinh_Vien x)
        {
            Node p = new Node();//Khai báo một đối tượng 
            if (p == null)
            {
                Console.WriteLine("Khong du bo nho de cap phat!");
                return null;
            }
            p.sinvien = x;//gán giá trị x cho dữ liệu trong đối tượng p
            p.pNext = null;//đầu tiên khai báo một node thì node đó chưa có liên kết đến node nào hết -> con trỏ của node đó sẽ trỏ đến node
            return p;
        }
        public void Giaiphongvungnho(List l)
        {
            Node k = null;
            while(true)
            {
                k = l.pHead;    
                l.pHead = l.pHead.pNext;
                k = null;
            }
        }
        public void Hoanvi(Sinh_Vien x, Sinh_Vien y)
        {
           
        }
        public void Sap_Sep(List l)
        {
            for(Node k=l.pHead;k!=null; k = k.pNext)
            {
                for(Node j=k.pNext;j!=null;j=j.pNext)
                {
                    if(k.sinvien.Diem>j.sinvien.Diem)
                    {
                        Sinh_Vien temp = k.sinvien;
                        k.sinvien = j.sinvien;
                        j.sinvien = temp;
                    }
                }
            }
        }
        public void Tim_Kiem(List l, string name)
        {
            Regex e = new Regex(@"(\w+$)");
            Match m;

            for (Node k = l.pHead; k != null; k = k.pNext)
            {
                m = e.Match(k.sinvien.Name);
                if (name.ToUpper().Equals(m.ToString().ToUpper()))
                {
                    k.sinvien.Display();
                }
            }
        }
    }
}
