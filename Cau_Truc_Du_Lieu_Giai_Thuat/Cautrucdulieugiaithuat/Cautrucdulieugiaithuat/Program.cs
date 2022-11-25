using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cautrucdulieugiaithuat
{
    //
    internal class Program
    {
        static void Main(string[] args)
        {
            //List l = new List();
            //while(true)
            //{
            //    Console.Clear();
            //    Menu(l);
            //    Console.ReadKey();
            //}



        }
        static void Menu(List l)
        {
            Console.WriteLine("-------MENU-------");
            Console.WriteLine("1. Them vao dau danh sach");
            Console.WriteLine("2. Them vao cuoi danh sach");
            Console.WriteLine("3. Xuat thong tin");
            Console.WriteLine("4. Tim Max");
            Console.WriteLine("6.Them node p sau node q");
            Console.WriteLine("7. Xoa dau");
            Console.WriteLine("8.Xoa cuoi");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.WriteLine("-------END-------");
            Console.Write("Nhap lua chon cua ban: ");
            int Option = int.Parse(Console.ReadLine());
            if(Option==0)
            {
                Environment.Exit(0);
            }
            if(Option==1)
            {
                Console.Write($"Nhap gia tri so nguyen ");
                int x = int.Parse(Console.ReadLine());
                Node p = KhoiTaoNode(x);//Cho vô hàm khởi tạo node để kiểm tra
                Themvaodau(l, p);
                n++;//Mỗi lần thêm thì biến số lượng phần tử trong danh sách sẽ tăng lên 1 đơn vị
            }
            else if(Option==2)
            {
                Console.Write($"Nhap gia tri so nguyen ");
                int x = int.Parse(Console.ReadLine());
                Node p = KhoiTaoNode(x);//Cho vô hàm khởi tạo node để kiểm tra
                Themvaocuoi(l, p);
                n++;

                //Xoa_Cuoi(l);
            }
            else if(Option==3)
            {
                Display(l);
            }
            else if(Option==4)
            {
                Giai_Phong(l);
            }
            else if(Option==5)
            {
                Console.Write($"Nhap gia can them: ");
                int x = int.Parse(Console.ReadLine());
                Node p = KhoiTaoNode(x);//Cho vô hàm khởi tạo node để kiểm tra
                int vt = 0;
                while(true)
                {
                    Console.Write("Nhap vi tri can them: ");
                    vt = int.Parse(Console.ReadLine());
                    if(vt>=1&&vt<=n+1)
                    {
                        break;
                    }
                    Console.WriteLine("Vi tri can them phai nam trong doan [2-n+1]");
                }
                Them_Node_vaovitribatki(l,p, vt);
                n++;
                Display(l);
            }
            else if(Option==6)
            {
                ThemNode_q_truoc_Node_p(l);
            }
            else if (Option == 7)
            {
                Xoa_Dau(l);
            }
            else if (Option == 8)
            {
                Xoa_Cuoi(l);
            }

            else
            {
                Console.WriteLine("Lua chon khong hop le!");
            }
        }

        static void Giai_Phong(List l)
        {
            Node k = null;
            while(l.pHead!=null)
            {
                k = l.pHead;
                l.pHead = l.pHead.PNext;
                k = null;
            }
        }

        //  CHƯƠNG TRÌNH XÓA
        static void Xoa_vitribatki(List l)
        {
            Console.Write("Nhap vi tri can xoa: ");
            int vt = int.Parse(Console.ReadLine());
           
            if(vt==1)
            {
                Xoa_Dau(l);
                return;
            }
            else
            {
                int count = 0;
                Node g = new Node();
                for(Node k=l.pHead;k!=null;k=k.PNext)
                {
                    count++;
                    if(count==vt)
                    {
                        g.PNext = k.PNext;
                        k = null;
                        return;
                    }
                    g = k;
                }
            }
        }
        static void Xoa_node_p_sauNode_q(List l)
        {
            Console.Write("Nhap node can xoa: ");
            int x = int.Parse(Console.ReadLine());
            Node p = KhoiTaoNode(x);
            for(Node k=l.pHead;k!=null;k=k.PNext)
            {
                if(p.Data==k.Data)
                {
                    Node g = k.PNext;
                    k.PNext = g.PNext;
                    g = null;
                }
            }
        }
        static void Xoa_Dau(List l)
        {
           if(l.pHead==null)
           {
                return;
           }
           else
           {
                Node h = l.pHead;
                l.pHead = h.PNext;
                //l.pHead = l.pHead.PNext;
                h = null;
           }
        }
        static void Xoa_Cuoi(List l)
        {
           if(l.pHead==null)
            {
                return;
            }
            if (l.pHead.PNext==null)//đối với danh sách có 1 phần tử
            {
                Xoa_Dau(l);
            }
            else
            {
                for(Node k=l.pHead;k!=null;k=k.PNext)
                {
                    if(k.PNext==l.pTail)
                    {
                        l.pTail = null;//xóa đi phần tử cuối
                        k.PNext = null;//cập nhật lại node trước đó là phần tử cuối
                        l.pTail = k;
                    }
                }
            }
        }

        //CHƯƠNG TRÌNH THÊM NODE

        static int n = 0;//lhai báo biến toàn cục để lưu số lượng phần tử trong hàm thêm vào vị trí bất kì
        static void Them_Node_vaovitribatki(List l, Node p, int vt)
        {      
            if(l.pHead==null||vt==1)//danh sách đang rỗng
            {
                Themvaodau(l, p);
            }

            else if(vt==n+1)
            {
                Themvaocuoi(l, p);
            }

            else//vị trí nằm trong đoạn 2->n+1
            {
                int dem = 0;//xác định vị trí cần thêm
                Node g = new Node();
                for(Node k=l.pHead;k!= null;k=k.PNext)
                {
                    dem++;
                    if(dem==vt)
                    {
                        Node h =KhoiTaoNode(p.Data);
                        h.PNext = k;
                        g.PNext = h;
                        break;
                    }
                    g = k;
                }
            }
        }

        static void ThemNode_q_truoc_Node_p(List l)
        {
            Console.Write("Nhap mot so nguyen: ");
            int x = int.Parse(Console.ReadLine());
            Node p = KhoiTaoNode(x);
            Console.Write("Nhap vi tri can them truoc: ");
            int a = int.Parse(Console.ReadLine());
            if (a == l.pHead.Data && l.pHead.PNext == null)
            {
                Themvaodau(l, p);
            }
            else
            {
                Node g = new Node();
               
                for (Node k=l.pHead;k!=null;k=k.PNext)
                {
                    if (l.pHead.Data == a)
                    {
                        Themvaodau(l, p);
                    }
                    if (k.Data==a)
                    {
                        //Thực hện thêm node p sau node g <=> thêm node p trước node q
                        Node h = KhoiTaoNode(p.Data);//Khởi tạo node h để tạo một địa chỉ thêm vào sau node q
                        h.PNext = k;
                        g.PNext = h;

                        //Node h = KhoiTaoNode(p.Data);
                        //k = h.PNext;
                        //g.PNext = h;

                    }
                    g = k;
                }
            }
           
        }

        static void ThemNode_q_sau_Node_p(List l)
        {
            Console.Write("Nhap node can them: ");
            int x = int.Parse(Console.ReadLine());
            Node p = KhoiTaoNode(x);
            Console.Write("Them sau Node:");
            int q = int.Parse(Console.ReadLine());

            if(l.pHead.Data==q&&l.pHead.PNext==null)
            {
                Themvaocuoi(l, p);
            }
            else
            {
                for(Node k=l.pHead;k!=null;k=k.PNext)
                {
                    if(k.Data==q)
                    {
                        //Node h = KhoiTaoNode(p.Data);//Khởi tạo node h để tạo một địa chỉ thêm vào sau node q
                        //Node g = k.PNext;//Cho node k trỏ đến node nằm sau node q
                        //h.PNext = g; //B1: Tạo mối LK từ node p đến node h, cũng chính là tạo mối liên kết từ node h đến node nằm sau node q
                        //k.PNext = h;//B2: Tạo mối LK từ node q đến node h, chính là node k đến node h

                        Node h = KhoiTaoNode(p.Data);
                        h.PNext = k.PNext;
                        k.PNext=h;
                    }
                }
            }
        }

        static int TimMax(List l)
        {
            int max = l.pHead.Data;
            for(Node k=l.pHead;k!=null;k=k.PNext)
            {
                if(max<k.Data)
                {
                    max = k.Data;
                }
            }
            return max;
        }

        static void Display(List l)
        {
            Console.WriteLine("Danh sach cac node ");
           for(Node k=l.pHead; k!=null;k=k.PNext)
            {
                Console.Write(k.Data + " ");
            }
        }

        static void Themvaodau(List l,Node p)
        {
            if(l.pHead==null)//Nếu danh sách đang rỗng thì con trỏ đang là null thì node dầu cũng như node cuối = null
            {
                l.pHead = l.pTail=p;
            }
            else
            {
                p.PNext = l.pHead;//lấy node p.next của node cần thêm trỏ đến đầu của danh sách
                l.pHead = p;//Sau đó cập nhật lại đầu danh sách là node p
            }
        }

        static void Themvaocuoi(List l, Node p)
        {
            if (l.pHead == null)//Nếu danh sách đang rỗng thì con trỏ đang là null thì node dầu cũng như node cuối = null
            {
                l.pHead = l.pTail = p;
            }
            else
            {
                l.pTail.PNext = p;//cho con trỏ cua node pTail trỏ đến node cần thêm
                l.pTail = p;//Cập nhật lại node p là node cuối
            }
        }

        static Node KhoiTaoNode(int x)
        {
            Node p = new Node();//Khai báo một đối tượng 
            if(p==null)
            {
                Console.WriteLine("Khong du bo nho de cap phat!");
                return null;
            }
            p.Data = x;//gán giá trị x cho dữ liệu trong đối tượng p
            p.PNext = null;//đầu tiên khai báo một node thì node đó chưa có liên kết đến node nào hết -> con trỏ của node đó sẽ trỏ đến node
            return p;
        }

        static void Khoitao(List l)//khởi tạo một danh sách liên kết đơn chứa các phần tử là số nguyên
        {
            //Cho 2 con trỏ đến Null - Vì DSLK đơn chưa có phần tử
            l.pHead = null;
            l.pTail = null;
        }
    }
}
