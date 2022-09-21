using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VD_ArrayList
{
    using System.Collections;
    internal class Program
    {
        // Xây dựng lại hàm ICompare để tiến hành so sánh và sắp xếp theo Ager
        // Sau khi xây dựng xong thì triệu gọi hàm Sort và truyền vào 1 đối
        // tượng là SortPerson để nó xắp xếp theo ta định nghĩa
        //  https://www.youtube.com/watch?v=fkqMno1hr_s&list=PL33lvabfss1y5jmklzilr2W2LZiltk6bU&index=2

        public class SortPerson:IComparer
        {
            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;
                if (p1 == null || p2 == null)
                    throw new InvalidOperationException();
                else
                {
                    if (p1.Ager > p2.Ager)
                        return 1;
                    else if (p1.Ager == p2.Ager)
                        return 0;
                    else
                        return -1;
                }
            }

        }
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(new Person("Nguyen Van A", 18));    //Do mình thêm vào một đối tượng nên là có thể
            arr.Add(new Person("Nguyen Van B", 25));    // thêm vào một class Person
            arr.Add(new Person("Nguyen Van C", 20));
            Console.WriteLine("Danh sach Person dau tien: ");
            foreach(var i in arr)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Sap xep Person phu dinh lai ICompare");
            arr.Sort(new SortPerson());
            foreach(var i in arr)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}




//public static void BT2_Stack()
//{
//    Stack stack = new Stack();
//    Queue queue = new Queue();

//    string s = "(((2+4*2)/2+5)*2)-((6/3+2)*2";
//    for (int i = 0; i < s.Length; i++)
//    {
//        //nếu là số thì cho thêm vào queue
//        if (s[i].Equals('1') || s[i].Equals('2') || s[i].Equals('3') || s[i].Equals('4') || s[i].Equals('5') || s[i].Equals('6')
//            || s[i].Equals('7') || s[i].Equals('8') || s[i].Equals('9') || s[i].Equals('0'))
//        {
//            queue.Enqueue(s[i]);
//        }
//        //nếu là dấu mở ngoặc thì thêm vào stack
//        if (s[i].Equals('('))
//        {
//            stack.Push(s[i]);
//        }
//        if (s[i].Equals(')'))//nếu gặp ( thì lấy các phần tử trong stack vào queue cho đến khi gặp kí tự ( thì dừng và xóa kí tự ( khỏi stack
//        {
//            int n = stack.Count;
//            bool kt = true;
//            for (int j = 0; j < n; j++)//cho vòng lặp ngoài để stack nó cập nhật dữ liệu khi nó chạy xong vòng lặp ở trong
//            {
//                foreach (var item in stack)
//                {
//                    if (item.Equals('('))//nếu gặp kí tự ( thì dừng và xóa kí tự đó khỏi stack
//                    {
//                        stack.Pop();
//                        kt = false;
//                        break;
//                    }
//                    else
//                    {
//                        queue.Enqueue(stack.Pop());
//                        break;
//                    }
//                }
//                if (kt == false)
//                {
//                    break;
//                }
//            }
//        }
//        //Nếu gặp kí tự toán tử
//        if (s[i].Equals('+') || s[i].Equals('-') || s[i].Equals('*') || s[i].Equals('/'))
//        {
//            if (stack.Count == 0)//Nếu stack đang rỗng thì thêm nó vào
//            {
//                stack.Push(s[i]);
//            }
//            else
//            {
//                //Nếu phần tử đầu satck không phải là toán tử thì thêm s[i] vào 
//                if (!stack.Peek().Equals('+') && !stack.Peek().Equals('-') && !stack.Peek().Equals('*') && !stack.Peek().Equals('/'))
//                {
//                    stack.Push(s[i]);
//                }
//                else
//                {
//                    //Kiểm tra độ ưu tiên nếu s[i] lớn hơn phần tử đầu stack
//                    if (s[i].Equals('*') || s[i].Equals('/') && stack.Peek().Equals('+') || stack.Peek().Equals('-'))
//                    {
//                        stack.Push(s[i]);
//                    }
//                    //Kiểm tra độ ưu tiên nếu s[i] >= phần tử đầu stack
//                    else if (stack.Peek().Equals('+') || stack.Peek().Equals('-') || stack.Peek().Equals('*') || stack.Peek().Equals('/'))
//                    {
//                        bool kt = true;
//                        for (int f = 0; f <= stack.Count; f++)//Cho vòng lặp duyệt để cập nhật dữ liệu
//                        {
//                            foreach (var item in stack)
//                            {
//                                //Nếu kí tự dầu stack là toán tử thì thêm nó vào queue đến khi stack rỗng hoặc các phần tử trong stack không phải là toán tử nữa thì dừng
//                                if (stack.Peek().Equals('+') || stack.Peek().Equals('-') || stack.Peek().Equals('*') || stack.Peek().Equals('/'))
//                                {
//                                    queue.Enqueue(stack.Pop());
//                                    //stack.Push(s[i]);
//                                    break;
//                                }

//                                if (!item.Equals('+') && !item.Equals('-') && !item.Equals('*') && !item.Equals('/') || stack == null)
//                                {
//                                    stack.Push(s[i]);
//                                    kt = false;
//                                    break;
//                                }
//                            }
//                            if (kt == false)
//                            {
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//    foreach (var item in stack)
//    {
//        queue.Enqueue(item);
//    }
//    double a1 = 0;
//    double a2 = 0;
//    double kq = 0;
//    Stack<double> stack_value = new Stack<double>();
//    foreach (var item in queue)
//    {
//        //Nếu phần tử đầu stack là số thì thêm vào queue
//        if (item.Equals('1') || item.Equals('2') || item.Equals('3') || item.Equals('4') || item.Equals('5')
//            || item.Equals('6') || item.Equals('7') || item.Equals('8') || item.Equals('9') || item.Equals('0'))
//        {

//            stack_value.Push(Convert.ToDouble(item.ToString()));

//        }
//        else if (item.Equals('+'))
//        {
//            a1 = stack_value.Pop();
//            a2 = stack_value.Pop();
//            kq = a2 + a1;
//            stack_value.Push(kq);
//        }
//        else if (item.Equals('-'))
//        {
//            a1 = stack_value.Pop();
//            a2 = stack_value.Pop();
//            kq = a2 - a1;
//            stack_value.Push(kq);
//        }
//        else if (item.Equals('*'))
//        {

//            a1 = stack_value.Pop();
//            a2 = stack_value.Pop();
//            kq = a2 * a1;
//            stack_value.Push(kq);
//        }
//        else if (item.Equals('/'))
//        {
//            a1 = stack_value.Pop();
//            a2 = stack_value.Pop();
//            kq = a2 / a1;
//            stack_value.Push(kq);
//        }
//    }
//    Console.WriteLine("Ket qua la: " + stack_value.Pop());
//}