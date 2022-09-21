using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace Cay_Nhi_Phan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node t = new Node();
            t = null;
            Menu(t);
            Console.ReadKey();
        }


        static void Them_Node_vaocay(ref Node t, int x)
        {
            if(t==null)//cây chưa có phần tử nào
            {
                Node p = new Node();//Tạo một Node gốc trong cây
                p.data = x;//thêm dữ liệu vào
                p.pLeft = null;
                p.pRight = null;
                t = p;//node p chính là node gốc
            }
            else//cây có tồn tại phần tử
            {
                //Nếu phần tử thêm (x)  vào mà nhỏ hơn node gốc thì thêm nó vào bên trái
                if(t.data>x)
                {
                    //Gọi lại hàm đệ quy để duyệt cây bên trái
                    Them_Node_vaocay(ref t.pLeft, x);
                }    
                else if(t.data<x)//Do bản chất của cây nhị phân là không chứa phần tử trùng nhau
                {
                    Them_Node_vaocay(ref t.pRight, x);
                }    
            }
        }
        static void Duyet_NRL(Node t)
        {
            if(t!=null)
            {
                Console.Write(t.data + " ");//đầu tiên xuất dữ liệu trong node ra
                Duyet_NRL(t.pRight);//tiếp theo là duyệt qua trái
                Duyet_NRL(t.pLeft);//tiếp theo là duyệt qua phải
            }
        }
        static void Duyet_NLR(Node t)
        {
            if (t != null)//Nếu cây còn phần tử thì duyệt tiếp
            {
                Console.Write(t.data + " ");//đầu tiên xuất dữ liệu trong node ra
                Duyet_NLR(t.pLeft);//tiếp theo là duyệt qua trái
                Duyet_NLR(t.pRight);//tiếp theo là duyệt qua phải
            }
        }

        static void Duyet_LNR(Node t)//Xuất ra các phần tử từ nhỏ đến lớn 
        {
            if (t != null)//Nếu cây còn phần tử thì duyệt tiếp
            {
                Duyet_LNR(t.pLeft);//duyệt qua trái
                Console.Write(t.data + " ");// xuất dữ liệu trong node ra
                Duyet_LNR(t.pRight);//tiếp theo là duyệt qua phải
            }
        }
        static void Duyet_RNL(Node t)//Xuất ra các phần tử từ lớn đến nhỏ 
        {
            if (t != null)//Nếu cây còn phần tử thì duyệt tiếp
            {
                Duyet_RNL(t.pRight);//duyệt qua trái
                Console.Write(t.data + " ");// xuất dữ liệu trong node ra
                Duyet_RNL(t.pLeft);//tiếp theo là duyệt qua phải
            }
        }
        static void Duyet_RLN(Node t)
        {
            if (t != null)//Nếu cây còn phần tử thì duyệt tiếp
            {
                Duyet_RLN(t.pRight);//duyệt qua trái
                Duyet_RLN(t.pLeft);//tiếp theo là duyệt qua phải
                Console.Write(t.data + " ");// xuất dữ liệu trong node ra
            }
        }
        static void Duyet_LRN(Node t)
        {
            if (t != null)//Nếu cây còn phần tử thì duyệt tiếp
            {
                Duyet_LRN(t.pLeft);//tiếp theo là duyệt qua phải
                Duyet_LRN(t.pRight);//duyệt qua trái
                Console.Write(t.data + " ");// xuất dữ liệu trong node ra
            }
        }
        static bool kt(int x)//Hàm kiểm tra số nguyên tố
        {
            if(x<2)
            {
                return false;
            }
            else
            {
                if(x==2)
                {
                    return true;
                }
                else
                {
                    if(x%2==0)
                    {
                        return false;
                    }
                    else
                    {
                        for(int i=2;i<x;i++)
                        {
                            if(x%i==0)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
        }
        static void Dem_So_Nguyen_To(Node t,ref int dem)
        {
            if (t != null)
            {
                if (kt(t.data))
                {
                    dem++;
                }
                //2 dòng này có tác dụng duyệt qua từng node trong cây
                Dem_So_Nguyen_To(t.pRight, ref dem);//tiếp theo là duyệt qua trái
                Dem_So_Nguyen_To(t.pLeft, ref dem);//tiếp theo là duyệt qua phải
            }
        }
        //Hàm tìm kiếm nếu node có tồn tại thì trả về node ngược lại thì trả về null
        static Node TimKiem(Node t, int x)
        {
            if(t==null)
            {
                return null;
            }
            else
            {
                if(x==t.data)// tương đương x=t.data
                {
                    return t;
                }
                else if (x<t.data)//Nếu phần tử cần tìm kiếm mà nhỏ hơn node gốc thì (đệ quy) duyệt sang bên trái
                {
                    TimKiem(t.pLeft, x);
                }
                else if(x>t.data)//duyệt qua bên phải
                {
                    TimKiem(t.pRight, x);
                }
               
                return null;
            }
        }
        static void Node_Co_2_Con(Node t)
        {
            if(t!=null)
            {
                if(t.pLeft!=null&&t.pRight!=null)
                {
                    Console.Write(t.data + " ");
                }
                Node_Co_2_Con(t.pLeft);
                Node_Co_2_Con(t.pRight);
            }
        }
        static void Node_Co_1_Con(Node t)
        {
            if (t != null)
            {
                if (t.pLeft == null && t.pRight != null|| t.pLeft != null && t.pRight == null)
                {
                    Console.Write(t.data + " ");
                }
                Node_Co_1_Con(t.pLeft);
                Node_Co_1_Con(t.pRight);
            }
        }
        static void Node_La(Node t)
        {
            if (t != null)
            {
                if (t.pLeft == null && t.pRight == null)
                {
                    Console.Write(t.data + " ");
                }
                Node_La(t.pLeft);
                Node_La(t.pRight);
            }   
        }


        //  TÌM MAX CÁCH 1
        //static int max = int.MinValue;
        //static void Tim_Max(Node t)
        //{
        //    if (t != null)
        //    {
        //        if (t.data>=max)
        //        {
        //            max=t.data;
        //        }
        //        Tim_Max(t.pLeft);
        //        Tim_Max(t.pRight);
        //    }
        //}

        //  TÌM MAX CÁCH 2
        static int Tim_Max(Node t)
        {
            //Nếu node không tồn tại cây con phải thì node cha là node ngoài cùng của cây con phải
            if (t.pRight == null)
            {
                return t.data;
            }

            int max = t.data;//Gán giá trị max là node cha

            // Do đa số phần tử nhỏ thì nằm bên trái node cha và phần tử lớn thì nằm bên phải vì vậy ta không cần duyệt cây con trái
            //if (t.pLeft!=null)//Nếu node cha có tồn tại cây con trái
            //{
            //    int left = Tim_Max(t.pLeft);
            //    if(max<left)
            //    {
            //        max = left;
            //    }
            //}

            //if(t.pRight!=null)
            //{
            //    int right = Tim_Max(t.pRight);
            //    if(max<right)
            //    {
            //        max = right;
            //    }
            //}
            //return max;

            //Do phần tử lớn nhất là nằm bên phải ngoài cùng nên ta không cần so sánh nữa chỉ cần duyệt đến cây con phải cuối cùng
            return Tim_Max(t.pRight);
        }
        static int Tim_Min(Node t)
        {
            if(t.pLeft==null)//nếu node không còn tồn  tại cây con trái nữa thì trả về node cha
            {
                return t.data;
            }
            return Tim_Min(t.pLeft);//Tiếp tục đệ quy để tìm phần tử nhỏ ở ngoài cùng bên trái
        }


        static void Tim_Node_The_Mang(ref Node X,ref Node Y)
        {
            #region Cách 1 - Duyệt qua bên trái nhất của cây con phải
            //if (Y.pLeft != null)
            //{
            //    Tim_Node_The_Mang(ref X, ref Y.pLeft);//Tiếp tục duyệt 
            //}

            //else//khi đã duyệt đến cuối 
            //{
            //    X.data = Y.data;//lấy dữ liệu của thằng cuối cùng đó gán cho cái node cần xóa đồng thời cập nhật Node cần xóa lúc này là Node Y cho Node X để xóa Node X
            //    X = Y;// Cập nhật cho Node X trỏ đến Node thế mạng -> Ra khỏi hàm sẽ xóa Node X
            //    Y = Y.pRight;//Cập nhật lại Node cha và Node con của cái Node thế mạng
            //}
            #endregion


            #region Cách 2 - Duyệt qua bên phải nhất của cây con trái
            //duyệt qua bên phải nhất của cây con trái
            if (Y.pRight != null)
            {
                Tim_Node_The_Mang(ref X, ref Y.pRight);//Tiếp tục duyệt 
            }
            else
            {
                X.data = Y.data;
                X = Y;
                Y = Y.pLeft;// Do nó đang là Node phải nhất của cây con trái
                //nên ta cần cập nhật lại Node cha và Node con của cái Node thế mạng, Nghĩa là bên trái nó vẫn còn phần tử
            }
            #endregion
        }


        static void XoaNode(ref Node t, int x)
        {
            if(t==null)
            {
                return;//Kết thúc việc xóa nếu cây đang rỗng
            }
            else
            {
                if(t.data==x)//Khi đã duyệt thấy
                {
                    Node X = t;//tạo một node thế mạng để nữa xóa nó

                    //Case Node một con
                    if (t.pLeft == null)//tức là t.pRight != null, đây là cây con phải
                    {
                        t = t.pRight;//cập nhật mối liên kết giữa Node cha và Node con của Node cần xóa
                    }
                    //Case Node một con
                    else if (t.pRight == null)//tức là t.pLeft != null, đây là cây con trái Node một con
                    {
                        t = t.pLeft;//cập nhật mối liên kết giữa Node cha và Node con của Node cần xóa
                    }

                    //Case Node có 2 con    
                    else
                    {
                        //Cách 1: Tìm node trái nhất của cây con phải (Cây con phải của cái node cần xóa)
                        //Tim_Node_The_Mang(ref X, ref t.pRight);//Node Y là node thế mạng cho node cần xóa

                        //Cách 2:Tìm node phải nhất của cây con trái (Cây con trái của cái node cần xóa)
                        Tim_Node_The_Mang(ref X,ref t.pLeft);//Node Y là node thế mạng cho node cần xóa
                    }
                    X = null;
                }
                else if(x<t.data)
                {
                    XoaNode(ref t.pLeft, x);//nếu duyệt chưa thấy phần tử thì cứ cho nó tiếp tục duyệt qua trái
                }
                else if(x>t.data)
                {
                    XoaNode(ref t.pRight, x);//nếu duyệt chưa thấy phần tử thì cứ cho nó tiếp tục duyệt qua phải
                }
               
            }
        }
        static void Menu(Node t)
        {

          
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t-----MENU-----");
                Console.WriteLine("1. Nhap du lieu");
                Console.WriteLine("2. Duyet NLR");
                Console.WriteLine("3. Duyet NRL");
                Console.WriteLine("4. Duyet LNR");
                Console.WriteLine("5. Duyet RNL");
                Console.WriteLine("6. Duyet RLN");
                Console.WriteLine("7. Duyet LRN");
                Console.WriteLine("8. Dem so nguyen to");
                Console.WriteLine("9. Tim kiem");
                Console.WriteLine("10. Node co 2 con");
                Console.WriteLine("11. Node co 1 con");
                Console.WriteLine("12. Node la");
                Console.WriteLine("13. Tim Max");
                Console.WriteLine("14. Tim Min");
                Console.WriteLine("15. Xoa Node");
                Console.WriteLine("\t-----END-----");
                Console.Write("Nhap lua chon cua ban: ");
                int luachon = int.Parse(Console.ReadLine());
                if(luachon==0)
                {
                    return;
                }
                if(luachon==1)
                {
                   
                    Console.Write("Nhap so nguyen x: ");
                    int x = int.Parse(Console.ReadLine());
                    Them_Node_vaocay(ref t, x);
                }
                else if(luachon==2)
                {
                    Console.WriteLine("DUYET CAY THEO NLR");
                    Duyet_NLR(t);
                }
                else if(luachon==3)
                {
                    Duyet_NRL(t);
                }
                else if (luachon == 4)
                {
                    Duyet_LNR(t);
                }
                else if (luachon == 5)
                {
                    Duyet_RNL(t);
                }
                else if (luachon == 6)
                {
                    Duyet_RLN (t);
                }
                else if (luachon == 7)
                {
                    Duyet_LRN(t);
                }
                else if (luachon == 8)
                {
                    int dem = 0;

                    Dem_So_Nguyen_To(t, ref dem);
                    Console.WriteLine("So luong so nguyen to la: "+dem);
                }
                else if (luachon == 9)
                {
                    Console.Write("Nhap phan tu can tim kiem: ");
                    int x = int.Parse(Console.ReadLine());
                    Node p = TimKiem(t, x);
                    if(p!=null)
                    {
                        Console.WriteLine("Phan tu x co ton tai: " + p.data);
                    }
                    else if (p==null)
                    {
                        Console.WriteLine("Phan tu {0} khong ton tai ", x);
                    }
                }
                else if (luachon == 10)
                {
                    Console.WriteLine("Node co 2 con la: ");
                    Node_Co_2_Con(t);
                }
                else if (luachon == 11)
                {
                    Console.WriteLine("Node co 1 con la: ");
                    Node_Co_1_Con(t);   

                }
                else if (luachon == 12)
                {
                    Console.WriteLine("Node la: ");
                    Node_La(t);
                }
                else if (luachon == 13)
                {
                    Console.Write("Max la: "+ Tim_Max(t));
                    //Console.Write("Max la: "+max);
                }
                else if (luachon == 14)
                {
                    Console.Write("Max la: " + Tim_Min(t));
                    //Console.Write("Max la: "+max);
                }
                else if(luachon==15)
                {
                    Console.Write("Nhap gia tri can xoa: ");
                    int x = int.Parse(Console.ReadLine());
                    XoaNode(ref t, x);
                    Duyet_NLR(t);

                }
                else {
                    Console.WriteLine("Lua chon khong hop le");
                }
                Console.ReadLine();
            }
        }
    }
  
}
