using System;
using StackADT.Queue;
namespace StackADT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ADT: abstract data type
            TestQueue();
            Console.ReadKey();
        }
        public static void TestQueue()
        {
            CircularArrayBaseQueue<int> d = new CircularArrayBaseQueue<int>(10);
            for(int i=0;i<10;i++)
            {
                d.enqueue(i);
            }
            Console.WriteLine(d.ToString());
            Console.WriteLine("Phan tu dau tien: "+d.peek());
            Console.WriteLine("Kich thuoc: " + d.size());
            for (int i = 0; i < 5; i++)
            {
                d.dequeue();
            }
            Console.WriteLine("Kich thuoc: " + d.size());
            Console.WriteLine(d.ToString());
            for (int i = 2; i < 4; i++)
            {
                d.enqueue(i);
            }
            Console.WriteLine("Kich thuoc: " + d.size());
            Console.WriteLine(d.ToString());
            for (int i = 1; i <3; i++)
            {
                d.enqueue(i);
            }
            Console.WriteLine("Kich thuoc: " + d.size());
            Console.WriteLine(d.ToString());
        }
        public void Test()
        {
            DoublyLinkedList<string> d = new DefaultDoublyLinkedList<string>();
            d.add("ahihi");
            d.add("hello");
            d.add("work");
            Console.WriteLine(d.ToString());
            d.addFirt("addFirst");
            d.addLast("addLast");
            Console.WriteLine(d.peekLast());
            Console.WriteLine(d.ToString());
            Console.WriteLine("Chua dung: " + d.contain("ahihi"));
            Console.WriteLine("Vi tri: " + d.indexOf("ahihi"));
            Console.WriteLine("Remove: " + d.remove("ahihi"));
            Console.WriteLine("Vi tri dau: " + d.Size());
            
            Console.WriteLine("Sau khi xoa: " + d.ToString());
            Console.ReadKey();
        }
        public static void TestStackADT()
        {
            DefaultStackLinkedList<int> arr = new DefaultStackLinkedList<int>(10);
            for(int i=0;i<14;i++)
            {
                arr.Push(i);
            }
            Console.WriteLine(arr.ToString());
            Console.WriteLine("Xoa phan tu cuoi: " + arr.Pop());
            Console.WriteLine("Lay phan tu cuoi: " + arr.Top());
           
            Console.WriteLine("Them phan tu: ");
            arr.Push(69);
            arr.Clear();
            Console.WriteLine(arr.ToString());
            Console.WriteLine("So phan tu trong arr: " + arr.Size());
            //Console.WriteLine(arr.Top());

        }
        public static void test_DynamicArray()
        {
            //Khi mà capacity không đủ khoảng trống thì nó sẽ đi tìm vị trí khác trên bộ nhớ để đáp ứng nhu cầu lưu trữ đó
            DynamicArray<int> arr = new DynamicArray<int>(20);

            for (int i = 0; i < 12; i++)
            {
                arr.add(i);
            }
            Console.WriteLine(arr.ToString());
            arr.add(344);
            arr.remove(344);
            Console.WriteLine(arr.contain(34));
            arr.clear();
            Console.WriteLine(arr.ToString());
            Console.WriteLine("So phan tu tring arr: " + arr.size());
            Console.WriteLine(arr.get(9));
            Console.ReadKey();
        }
    }
}
