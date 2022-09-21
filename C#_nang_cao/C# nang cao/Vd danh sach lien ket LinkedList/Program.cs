using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Vd_danh_sach_lien_ket_LinkedList
{
    using System.Runtime;
    using System.Timers;
    using System.Collections;

    internal class Program
    {
        public static object DataTime { get; private set; }

        static void su_dung_LinkedList()
        {

            LinkedList<string> cacbaihoc = new LinkedList<string>();
            var bh1 = cacbaihoc.AddFirst("baihoc1");//thêm vào đầu danh sách
            var bh4 = cacbaihoc.AddBefore(bh1, "baihoc4");//thêm vào sau một danh sách nào đó
            var bh3 = cacbaihoc.AddLast("baihoc3");//Thêm vào cuối danh sách
            LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1, "baihoc2");//Thêm một phần tử vào trước đó
            cacbaihoc.AddLast("baihoc4");
            cacbaihoc.AddLast("baihoc5");
            Console.WriteLine("\tKieu du lieu la: " + bh1.GetType().ToString());
            foreach (var i in cacbaihoc)
            {
                Console.WriteLine(i);
            }
            var data = bh2;     //khai báo biến để giữ giá trị của danh sách liên kết 
            Console.WriteLine("Gia tri cua bai hoc 2 la: " + bh2.Value);
            data = data.Next;
            Console.WriteLine("Su dung data.Net de xuat gia tri tiep theo: " + data.Value);  //Chấm tới Value nó mới xuất được giá trị 
            data = data.Previous;//tham chiếu đến nút phía trước nó hoặc có thể data.Next.Value;
            Console.WriteLine("Su dung data.Net de xuat gia tri tiep theo: " + data.Value);
            Console.WriteLine("\tcach 2: ");
            //var a = cacbaihoc.Last;
            var a = cacbaihoc.First;
            while (a != null)
            {
                Console.WriteLine(a.Value);
                //a = a.Previous;//Xuất ra các node trước a được đi chung với  cacbaihoc.Last
                a = a.Next;//Xuất ra các node sau a được đi chung với cacbaihoc.First

            }

        }//thuộc video Xuan_La
        static void su_dung_Hashtable()
        {
            //https://www.youtube.com/watch?v=h2teAwDUOfg&list=PL33lvabfss1y5jmklzilr2W2LZiltk6bU&index=3
            Hashtable H1 = new Hashtable();
            H1.Add("K", "Kteam");
            H1.Add("H", "How");
            H1.Add("FE", "Free Education");

            Console.WriteLine("So luong phan tu torng Hashtable la: {0}", H1.Count);
            foreach (DictionaryEntry item in H1)
            {
                Console.WriteLine($"key: {item.Key} - value: {item.Value}");
            }
            //cách 2: truy xuất qua giá trị Key của nó
            //  LƯU Ý: 
            // Nếu ta thực hiện truy xuất giá trị thông qua Key mà trong Hashtable không
            // tồn tại thì nó sẽ không báo lỗi và không xuất gì ra màn hình
            // Nếu ta thực hiện gán giá trị thông qua Key mà Key không tồn tại thì nó sẽ
            // tự động thêm giá trị đó vô Hashtable
            Console.WriteLine($"Truy cao thong qua Keys[\"K\"]: " + H1["K"]);
            Console.WriteLine("Thuc hien gan gia tri khong ton tai: ");
            H1["ab"] = "abcd";
            Console.WriteLine("So luong phan tu trong Hashtable la: {0}", H1.Count);
            foreach (DictionaryEntry item in H1)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }

        static void Su_Dung_HashSet()
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7 };
            HashSet<int> set2 = new HashSet<int>() { 8, 9, 2, 3, 4, 13, 14, };
            set1.Add(11);
            set1.Remove(7);
            //set1.UnionWith(set2);//lấy các phần tử của set1 hợp với set2
            set1.Intersect(set2);//thực hiện phép giao giữa 2 tập hợp
            foreach (var i in set1)
            {
                Console.WriteLine(i);
            }
        }


        #region//SỬ DỤNG SORTEDLIST()
        static void su_dung_SortedList()
        {
            //https://www.youtube.com/watch?v=ORjz4SUg_Ws&list=PL33lvabfss1y5jmklzilr2W2LZiltk6bU&index=4
            // SortedList là sự kế thừa của ArrayList và Hastable, có thể truy xuất thông qua 
            // chỉ số hoặc từ khóa Key, nhưng các phần tử được sắp xếp theo Key
            SortedList S1 = new SortedList();   //khởi tạo một SortedList rỗng
            SortedList S2 = new SortedList(5);  //Khởi tạo SortedLlist có capacity là 5 phần tử
            SortedList S3 = new SortedList(new PersonCompare_chu());
            S3.Add(new Section("Nguyen A", 1995), 12);
            S3.Add(new Section("Nguyen B", 2000), 10);
            S3.Add(new Section("Nguyen C", 1994), 11);
            S3.Add(new Section("Nguyen D", 2002), 5);
            //Console.WriteLine($"Key: {S3["S3"]} | Value:");//chỉ có thể truy cập được value thông qua Keys
            Console.WriteLine("Su dung lop Section");
            Console.WriteLine("So luong phan tu trong Section la: {0}", S3.Count);
            foreach (DictionaryEntry item in S3)
            {
                Console.WriteLine("Key: " + item.Key + " + Value: " + item.Value);
            }

            /* 
            * Mình dinh nghĩa 1 PersonCompaer có kế thừ từ 1 interface ICompare 
            * Sao đó override lại phương thức Compare theo ý muốn
            * Sử dụng lớp trên để truyền vào contructor của SortedList
            */
            SortedList S4 = new SortedList(new PersonICompare());
            S4.Add(new Person("one", 1), 10);
            S4.Add(new Person("two", 2), 20);
            S4.Add(new Person("six", 6), 60);
            Console.WriteLine("Su dung lop Person ");
            //Console.WriteLine("Truy cap phan tu thong qua chi so: " + S4["one"]);

            foreach (DictionaryEntry item in S4)
            {
                Console.WriteLine("Key: " + item.Key + "|  value: " + item.Value);
            }
        }
        public class Person     //Thuộc bài SortedList
        {
            private string name;
            private int age;
            public Person(string name, int age)//tạo hàm contructor
            {
                this.name = name;
                this.age = age;
            }
            public string Name  //Tạo hàm để đọc và trả về giá trị 
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public override string ToString()
            {   //Nếu không xây lại thì nó sẽ không biết xuất ra cái gì
                return "name: " + name + " age: " + age;
            }
        }
        public class PersonICompare : IComparer  //thuộc bài SortedList
        {      //Tạo 1 class kế thừa lại ICompare để override lại nó
            public int Compare(object x, object y)  //xây dựng lại hàm so sánh Comare
            {
                Person p1 = x as Person;//nếu obect truyền vào là 1 Person thì gán cho nó thành Person thực sự
                Person p2 = y as Person;// còn không thì chuyển cho nó thành giá trị NULL
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException("Loi khong hop le!");
                }
                else
                {
                    if (p1.Age < p2.Age)
                        return -1;
                    else if (p1.Age == p2.Age)
                        return 0;
                    else
                        return 1;
                }
            }
        }
        public class PersonCompare_chu : IComparer
        {
            public int Compare(object x, object y)
            {
                Section p1 = x as Section;
                Section p2 = y as Section;
                if (p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if (p1.Namsinh < p2.Namsinh)
                        return -1;
                    else if (p1.Namsinh == p2.Namsinh)
                        return 0;
                    else
                        return 1;
                }
            }
        }
        public class Section
        {
            private string name;
            private int namsinh;
            public Section(string name, int namsinh)
            {
                this.name = name;
                this.namsinh = namsinh;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Namsinh
            {
                get { return namsinh; }
                set { namsinh = value; }
            }
            public override string ToString()
            {
                return "Ho va ten: " + name + " | Nam sinh: " + namsinh;
            }
        }   //Thuộc bài SortedList 
        #endregion

        static void su_dung_Stack()
        {
            Stack Stack1 = new Stack();//Khởi tạo stack rỗng
            Stack1.Push(1);
            var a = Stack1.Peek();
            Stack Stack2 = new Stack(5);//Khởi tạo stack có capacity có 5 phần tử

            ArrayList arr = new ArrayList(10);//Khởi tạo 1 mảng bất kì
            arr.Add(4);
            arr.Add(5);
            arr.Add(1);
            Stack Stack3 = new Stack(10);
            Stack3.Push("Education");
            Stack3.Push(9); //Thêm giá trị vào stack3
            for (int i = 0; i < 10; i++)
            {
                Stack3.Push(i);
            }
            Console.WriteLine("So phan tu trong Stack: {0}", Stack3.Count);
            //Do số 9 được thêm vào cuối cùng nên nó sẽ được lấy ra đầu tiên
            Console.WriteLine("Phan tu dau trong Stack la: {0}", Stack3.Peek());

            Console.WriteLine("\tCac phan tu trong Stack3 la: ");
            foreach (var item in Stack3)
            {
                Console.WriteLine("Value: {0}", item);
            }
        }
        public static void BT_Stack()
        {
            //Bai tap chuyen doi co so
            Console.WriteLine("Chuyen doi co so: ");
            Stack<int> stack4 = new Stack<int>();
            Console.Write("Nhap so can chuyen doi: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap co so can chuyen doi: ");
            int c = int.Parse(Console.ReadLine());
            int w;
            while (b != 0)
            {
                w = b % c;
                stack4.Push(w);
                b = b / c;
            }
            foreach (var i in stack4)
            {
                if (i < 10)
                {
                    Console.WriteLine(i);
                }
                else if (i == 10)
                {
                    Console.WriteLine("A");
                }
                else if (i == 11)
                {
                    Console.WriteLine("B");
                }
                else if (i == 12)
                {
                    Console.WriteLine("C");
                }
                else if (i == 13)
                {
                    Console.WriteLine("D");
                }
                else if (i == 14)
                {
                    Console.WriteLine("E");
                }
                else if (i == 15)
                {
                    Console.WriteLine("F");
                }
            }
        }
        public static void May_tinh_casio()
        {
            Stack stack = new Stack();
            Queue queue = new Queue();

            string s = "(((2*3)+5)*5+5)";
            for (int i = 0; i < s.Length; i++)
            {
                //nếu là số thì cho thêm vào queue
                if (char.IsDigit(s[i]))
                {
                    queue.Enqueue(s[i]);
                }
                //nếu là dấu mở ngoặc thì thêm vào stack
                if (s[i].Equals('('))
                {
                    stack.Push(s[i]);
                }
                if (s[i].Equals(')'))//nếu gặp ( thì lấy các phần tử trong stack vào queue cho đến khi gặp kí tự ( thì dừng và xóa kí tự ( khỏi stack
                {
                    bool kt = true;
                    for (int j = 0; j < stack.Count; j++)//cho vòng lặp ngoài để stack nó cập nhật dữ liệu khi nó chạy xong vòng lặp ở trong
                    {
                        foreach (var item in stack)
                        {
                            if (item.Equals('('))//nếu gặp kí tự ( thì dừng và xóa kí tự đó khỏi stack
                            {
                                stack.Pop();
                                kt = false;
                                break;
                            }
                            else
                            {
                                queue.Enqueue(stack.Pop());
                                break;
                            }
                        }
                        if (kt == false)
                        {
                            break;
                        }
                    }
                }
                //Nếu gặp kí tự toán tử
                if (s[i].Equals('+') || s[i].Equals('-') || s[i].Equals('*') || s[i].Equals('/') || s[i].Equals('^') || s[i].Equals('v'))
                {
                    if (stack.Count == 0)//Nếu stack đang rỗng thì thêm nó vào
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        //Nếu phần tử đầu satck không phải là toán tử thì thêm s[i] vào 
                        if (!stack.Peek().Equals('+') && !stack.Peek().Equals('-') && !stack.Peek().Equals('*') && !stack.Peek().Equals('/') && !stack.Peek().Equals('^') && !stack.Peek().Equals('v'))
                        {
                            stack.Push(s[i]);
                        }
                        else
                        {
                            //Kiểm tra độ ưu tiên nếu s[i] lớn hơn phần tử đầu stack
                            if (s[i].Equals('*') || s[i].Equals('/') || s[i].Equals('^') || s[i].Equals('v') && stack.Peek().Equals('+') || stack.Peek().Equals('-'))
                            {
                                stack.Push(s[i]);
                            }
                            //Kiểm tra độ ưu tiên nếu s[i] >= phần tử đầu stack
                            else if (stack.Peek().Equals('+') || stack.Peek().Equals('-') || stack.Peek().Equals('*') || stack.Peek().Equals('/') || stack.Peek().Equals('^') || stack.Peek().Equals('v'))
                            {
                                bool kt = true;
                                for (int f = 0; f <= stack.Count; f++)//Cho vòng lặp duyệt để cập nhật dữ liệu
                                {
                                    foreach (var item in stack)
                                    {
                                        //Nếu kí tự dầu stack là toán tử thì thêm nó vào queue đến khi stack rỗng hoặc các phần tử trong stack không phải là toán tử nữa thì dừng
                                        if (stack.Peek().Equals('+') || stack.Peek().Equals('-') || stack.Peek().Equals('*') || stack.Peek().Equals('/') || stack.Peek().Equals('^') || stack.Peek().Equals('v'))
                                        {
                                            queue.Enqueue(stack.Pop());
                                            //stack.Push(s[i]);
                                            break;
                                        }

                                        if (!item.Equals('+') && !item.Equals('-') && !item.Equals('*') && !item.Equals('/') && !item.Equals('^') && !item.Equals('v') || stack == null)
                                        {
                                            stack.Push(s[i]);
                                            kt = false;
                                            break;
                                        }
                                    }
                                    if (!kt)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var item in stack)
            {
                queue.Enqueue(item);
            }
            double a1 = 0;
            double a2 = 0;
            double kq = 0;
            Stack<double> stack_value = new Stack<double>();
            foreach (char item in queue)
            {
                //Nếu phần tử đầu stack là số thì thêm vào queue
                if (char.IsDigit(item))
                {
                    stack_value.Push(Convert.ToDouble(item.ToString()));
                }
                else if (item.Equals('+'))
                {
                    a1 = stack_value.Pop();
                    a2 = stack_value.Pop();
                    kq = a2 + a1;
                    stack_value.Push(kq);
                }
                else if (item.Equals('-'))
                {
                    a1 = stack_value.Pop();
                    a2 = stack_value.Pop();
                    kq = a2 - a1;
                    stack_value.Push(kq);
                }
                else if (item.Equals('*'))
                {

                    a1 = stack_value.Pop();
                    a2 = stack_value.Pop();
                    kq = a2 * a1;
                    stack_value.Push(kq);
                }
                else if (item.Equals('/'))
                {
                    a1 = stack_value.Pop();
                    a2 = stack_value.Pop();
                    kq = a2 / a1;
                    stack_value.Push(kq);
                }
                else if (item.Equals('^'))
                {
                    a1 = stack_value.Pop();
                    a2 = stack_value.Pop();
                    kq = a2 * a1;
                    stack_value.Push(kq);
                }
                else if (item.Equals('v'))
                {
                    a1 = stack_value.Pop();
                    //a2 = stack_value.Pop();
                    kq = Math.Sqrt(a1);
                    stack_value.Push(kq);
                }
            }
            Console.WriteLine("Ket qua la: " + stack_value.Pop());
        }

        static void su_dung_Queue()
        {
            Queue Q1 = new Queue();//tạo 1 Queue rỗng
            Queue Q2 = new Queue(4);//tạo 1 Queue có capacity là 5
                                    //tạo Queue tương tự như tạo Stack
            Q1.Enqueue("1");
            Q1.Enqueue("2");
            Q1.Enqueue("3");
            Console.WriteLine("So luong phan tu trong Q1 la: {0}", Q1.Count);
            foreach (var item in Q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("lay ra phan tu dau tien trong Q1: {0}", Q1.Peek());
            Console.WriteLine("Lay va xoa gia tri khoi Q1: {0}", Q1.Dequeue());
            Console.WriteLine("So luong phan tu trong Q1 la: {0}", Q1.Count);
        }

        static void su_dung_ArrayList()
        {
            ArrayList arr = new ArrayList();
            arr.Add(0);
            arr.Add(1);

        }

        static void su_dung_BitArray()
        {
            //Khởi tạo 1 BitArray có 10 phần tử , mỗi phần tử có giá trị mặc định là 0 (false)
            BitArray myBit = new BitArray(10);

            //Khởi tạo và gán cho nó thành giá trị các phần tử là 1 (true)
            BitArray myBit2 = new BitArray(10, true);

            //Khởi tạo 1 BitArray từ 1 mảng Bool có sẵn
            bool[] kt = new bool[4] { true, false, true, false };
            BitArray myBit3 = new BitArray(kt);

            //Khởi tạo 1 BitArray từ 1 mảng byte có sẵn
            byte[] byte1 = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray myBit4 = new BitArray(byte1);
            Console.WriteLine("Su dung BitArray dung byte: ");
            Console.WriteLine("So bit cua BitArray la: " + myBit4.Length);
            Prints(myBit4, 8);  //Do đây 1 byte là 8bit

            //Khởi tạo 1 BitArray từ 1 mảng int có sẵn
            int[] int1 = new int[5] { 1, 2, 3, 4, 5 };
            BitArray myBit5 = new BitArray(int1);
            Console.WriteLine("Su dung BitArray dung int: ");
            Console.WriteLine("So bit cua BitArray la: " + myBit5.Length);
            Prints(myBit5, 32); //Do kiểu int= 4 byte nên 8*4 =32

            Console.WriteLine("**Mot so vi du su dung BitArray** ");
            bool[] myB = new bool[5] { true, false, true, true, false };//nó sẽ xuất ra 0 hoặc 1 
            BitArray MyBA6 = new BitArray(myB);

            bool[] myC = new bool[] { false, true, true, false, false };
            BitArray MyBA7 = new BitArray(myC);
            Console.WriteLine("Gia tri cua MyBA6: ");
            Prints(MyBA6, 5);
            Console.WriteLine("Gia tri cua MyBA7: ");
            Prints(MyBA7, 5);
            Console.WriteLine("Thuc hien cac phep toan AND, OR, NOT, XOR tren MyBA6 va MyBA7: ");
            // thực hiện sao chép giá trị của MyBA6 ra để không làm thay đổi nó
            BitArray AndBit = MyBA6.Clone() as BitArray;
            AndBit.And(MyBA7);
            Console.Write(" Ket qua cua phep toan AND: ");
            Prints(AndBit, 5);

            BitArray OrBit = MyBA6.Clone() as BitArray;
            OrBit.Or(MyBA7);
            Console.Write(" Ket qua cua phep toan OR: ");
            Prints(OrBit, 5);

            BitArray XorBit = MyBA6.Clone() as BitArray;
            XorBit.Xor(MyBA7);
            Console.Write(" Ket qua cua phep toan XOR: ");
            Prints(XorBit, 5);

            BitArray NotBit = MyBA6.Clone() as BitArray;
            NotBit.Not();
            Console.Write(" Ket qua cua phep toan NOT tren MyBA6: ");
            Prints(NotBit, 5);
        }

        static void Prints(BitArray myBit, int With)//Thuộc hàm BitArray
        {
            int i = With;
            foreach (bool item in myBit)
            {
                if (i < 1)
                {
                    i = With;
                    Console.WriteLine();
                }
                i--;
                Console.Write(item.GetHashCode());//in ra 0 1 thay vì true false    
            }
            Console.WriteLine();
        }

        static void su_dung_List()
        {
            List<int> myList1 = new List<int>(); // Khởi tạo 1 List các số nguyên rỗng

            List<int> myList2 = new List<int>(5); // khởi tạo 1 list có 5 phần tử

            List<int> myList3 = new List<int>(myList2); //Khởi tạo 1 List số nguyên có số phần tử bằng mylist2
                                                        // và sao chép toàn bộ phần tử của myList2

            List<string> myList4 = new List<string>();
            myList4.Add("How");
            myList4.Add("Kteam");
            Console.WriteLine("So phan tu la: " + myList4.Count);
            foreach (var item in myList4)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine("\nSau khi them phan tu: ");
            myList4.Insert(0, "Education");
            foreach (var i in myList4)
                Console.Write(i + " ");
            //Kiểm tra xem phần tử có tồn tại hay không
            bool kt = myList4.Contains("Kteam");
            if (kt)
                Console.WriteLine("\nCo ton tai han tu trong danh sach");
            else
                Console.WriteLine("\nKhong ton tai phan tu trong danh sach");

            //VD2:Hàm FindAll nhận thông số là 1 delegate, tương tự đối với các đối tượng trong lớp 
            List<int> myList5 = new List<int>() { 2, 4, 5, 6, 7, 8, 9, 19 };
            var q = myList5.FindAll(c =>
            {
                return c % 2 == 0;
            });
            foreach (var i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //VD Sử dụng lớp Product
            List<Product> sp = new List<Product>()
            {
                new Product()
                {
                    Name="Iphone", Price=1000, NoiSX="USA"
                },
                new Product()
                {
                    Name="Samsung", Price=800, NoiSX="Korea"
                },
                new Product()
                {
                    Name="Sony", Price=900, NoiSX="VN"
                },
            };
            var sp1 = sp.Find(c =>
            {
                return c.Name.StartsWith("S");
            });
            Console.WriteLine($"Name: {sp1.Name} | Price: {sp1.Price} | NoiSX: {sp1.NoiSX}");

            sp.Sort((p1, p2) =>
            {
                if (p1.Price > p2.Price)
                {
                    return 1;
                }
                else if (p1.Price < p2.Price)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            });
            foreach (var i in sp)
            {
                Console.WriteLine($"Name: {i.Name} | Price: {i.Price} | NoiSX: {i.NoiSX}");
            }
        }

        public class Product//Thuộc bài List
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string NoiSX { get; set; }

        }
        static void su_dung_Dictionary()
        {   //tạo 1 Dictionary rỗng có kiểu key là int và value là int
            Dictionary<int, int> myDictionary2 = new Dictionary<int, int>();

            Dictionary<string, int> myDictionary1 = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["tue"] = 2
            };
            //thêm cập nhật
            myDictionary1["threw"] = 3;
            myDictionary1.Add("four", 4);
            //xuất các phần tử ra màn hình
            var w = myDictionary1.Keys; //khai báo biến W giữ từ khóa của lớp Dictionary
            foreach (var k in w)
            {
                var value = myDictionary1[k]; //Lấy giá trị thông qua từ khóa rồi gán cho biến value
                Console.WriteLine($"{k} = {value}");
            }
            Console.WriteLine("\tcach 2");
            foreach (var item in myDictionary1)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            Console.WriteLine("Truy xuat cac phan tu thong qua Key: " + myDictionary1["four"]);
        }


        #region// SỬ DỤNG TUPLE
        static void su_dung_Tuple()
        {
            //cách 1: tạo thông qua phương thức Create
            var myTuple1 = Tuple.Create<int, string>(1, "How kteam");
            //cách 2: tạo thông qua toán tử new
            var myTuple2 = new Tuple<int, string, bool>(2, "Education", true);
            //Cho in ra màn hình
            Console.WriteLine($"ID: {myTuple1.Item1}, Name: {myTuple2.Item2}");
            //Hoặc
            Tuple<int> q = new Tuple<int>(1);
            Console.WriteLine("Su dung q: " + q.Item1);

            /*
             * Dùng var để C# tự nhận diện kiểu dữ liệu
             * Bạn có thể khai báo tường minh là Tuple<int, int>
             */
            Tuple<int, int, int> now = GetCurrentDayMontYear();
            Console.WriteLine($"Day: {now.Item1}, Mont: {now.Item2}, Year: {now.Item3}");
            Console.WriteLine("Cach 2: " + now.ToString());
        }
        static Tuple<int, int, int> GetCurrentDayMontYear()  //Thuộc bài Tuple
        {
            ///<sumary>
            /// Phương thức trả về 1 Tuple có 3 thuộc tính (cả 3 điều có kiểu dữ liệu là int)
            /// </sumary>
            /// <return></return>

            //Lấy ngày giờ hiện tại của hệ thống
            DateTime now = DateTime.Now;
            //Sử dụng contructor của Tuple<> để trả về hoặc có hể sử dụng phương thức Creatte đã trình bày ở trên
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
        #endregion

        #region//SỬ DỤNG DELEGATE
        class Su_Dung_Delegate
        {

            //tạo 1 biến delegate có kiểu int và tham số là string
            delegate int myDelegate1(string str1);
            public static void su_dung_Delegate()
            {
                Console.OutputEncoding = Encoding.Unicode;
                // Tạo một biến dùng để convertToInt 
                Console.WriteLine("Goi ham truc tiep: " + ConvertStringToInt("32"));
                myDelegate1 convertToInt = new myDelegate1(ConvertStringToInt);
                // Tạo một biến dùng để hiển thị chuỗi
                //Hàm ConvertStringToInt chỉ được gọi 1 lần rồi được trao qua biến convertToInt
                //sao này sử dụng thì chỉ cần lấy biến convertToInt ra sử dụng không cần gọi lại hàm
                string str = "35";
                int valueConverted = convertToInt(str);
                Console.WriteLine("Gia tri da Converted la: " + valueConverted);

                myDelegate1 showstring = new myDelegate1(ShowString);
                Console.Write("Thuc hien su dung bien showstring: ");
                showstring("Su dung bien showstring");

                // Tạo một biến dùng để thực hiện 2 hành động
                myDelegate1 muticast = convertToInt + showstring;
                Console.WriteLine("Ket qua khi goi muticast: ");
                muticast(str);

                muticast -= showstring;
                Console.WriteLine("Ket qua sau khi loai bo showstring: ");
                muticast(str);

                //Tạo một biến ShowString1 được xây dựng từ hàm ShowString
                myDelegate1 ShowString1 = new myDelegate1(ShowString);
                Nhapvashowten(ShowString1);// Truyền biến Delegate vào hàm Nhapvashowten như là thông số
            }
            //hàm chuyển 1 giá trị string thành int
            static int ConvertStringToInt(string stringvalue) //tương ứng với kiểu dữ liệu delegate
            {                                                 // có kiểu dữ liệu là int và tham số là string
                int valueInt = 0;
                Int32.TryParse(stringvalue, out valueInt);//chuyển đổi một chuỗi số thành một số nguyên
                Console.WriteLine("Da ep kieu thanh cong");
                return valueInt;
            }
            static int ShowString(string stringvalue)//Hàm xuất thông tin chuỗi ra màn hình
            {
                Console.WriteLine(stringvalue);
                return 0;
            }
            static void Nhapvashowten(myDelegate1 showten)//truyền Delegate như là 1 thông số
            {
                Console.WriteLine("Nhap ten cua ban: ");
                string ten = Console.ReadLine();
                showten(ten);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            //Console.WriteLine("****Su dung LinkedList");
            //su_dung_LinkedList();

            //Console.WriteLine("\n****Su dung Dictionnary\n");
            //su_dung_Dictionary();
            //Console.WriteLine("\n****Su dung HashSet");
            //Su_Dung_HashSet();

            //Console.WriteLine("****su dung Hashtable: ");
            //su_dung_Hashtable();
            //Console.WriteLine("****Su dung SortedList ");
            //su_dung_SortedList();
            Console.WriteLine("****su dung Stack ");
            su_dung_Stack();
            //May_tinh_casio();
            //Console.WriteLine("****su dung Queue ");
            //su_dung_Queue();
            //Console.WriteLine("****su dung BitArray");
            //su_dung_BitArray();
            //Console.WriteLine("****Su dung List");
            //su_dung_List();
            //Console.WriteLine("****Su dung Tuple");
            //su_dung_Tuple();

            //Console.WriteLine("Su dung Delegate");
            ////Su_Dung_Delegate myDelegate = new Su_Dung_Delegate();
            ////myDelegate.su_dung_Delegate();
            //Su_Dung_Delegate.su_dung_Delegate();

            Console.ReadKey();
        }
    }
}
