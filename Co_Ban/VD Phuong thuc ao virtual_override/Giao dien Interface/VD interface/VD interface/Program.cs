using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_interface
{
    public interface IStorable   // khai báo một giao diện 
    {
        // không có access modifier, các thành viên là public, 
        // không có thiết đặt thi công 
        void Read();
        void Write(object o);
        int Status { get; set; } // thuộc tính Status cho biết trạng thái
       
    }
    public interface IOS
    {
       void Iphone();
       int IB(int a);
    }
    public interface Samsung: IOS
    {
        void samsung();
    }
    public class Apple:Samsung, IOS
    {
        private int a = 9;
        void Samsung.samsung()
        {
            Console.WriteLine("Xay dung ham giao dien Samsung");
        }
        void IOS.Iphone()
        {
            Console.WriteLine("Xay dung ham IOS");
        }
        public int IB(int a)
        {
            this.a = a;
            return a;
        }
    }
   public class TestAndroi : Samsung
    {
        private string s = "SAMSUNG";
        private int a = 1;
        public TestAndroi()
        { 
            Console.WriteLine("Day la ham Contructor cua TestAndroi: {0}",s);
        }
        public void Iphone()
        {
            Console.WriteLine("Gia Iphone");
        }
        void Samsung.samsung()
        {

            Console.WriteLine("Dien thoai {0}");
        }
        public int IB(int b)
        {
            this.a = b;
            return a;
        }
    }

    public class Document : IStorable, IOS, Samsung  // Tạo một lớp Document lo thiết đặt giao diện IStorable 
    {
        public Document(string s) // hàm constructor 
        {
            Console.WriteLine("Tao Document: {0}", s);
        } 
        public void samsung()
        {
            Console.WriteLine("Thiet lap ham samsung");
        }
        public void Read()  // thi công hàm hành sự Read()
        {
            Console.WriteLine("Thi cong Read() danh cho IStorable");
        }
        public void Write(object o)    // thi công hàm hành sự Write() 
        {
            Console.WriteLine("Thi cong Write() danh cho IStorable");
        } 
        public int Status   // thi công thuộc tính Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        private int status = 0;     // biến dành trữ trị thuộc tính status
        //  THI HÀNH interface thứ 2
        public void Iphone()
        {
            Console.WriteLine("Gia Iphone");
        }
        public int IB(int s)
        {
            this.s=s;
            return s;
        }
        private int s = 6;
    } // end Document
    internal class Program
    {
        static void Main(string[] args)
        {
            // truy xuất các hàm hành sự trên đối tượng Document 
            Document doc = new Document("Test Document");
            doc.Status = -1;
            doc.Read();
            //doc.Write();
            Console.WriteLine($"Document Status: {doc.Status}");
            // ép về kiểu giao diện và sử dụng giao diện 
            IStorable isDoc = (IStorable)doc; // ép thể hiện Document về
                                              // kiểu giao diện 
            isDoc.Status = 0;
            isDoc.Read();
            Console.WriteLine($"Document Status: {isDoc.Status}");

            TestAndroi ss = new TestAndroi();
            ss.Iphone();
            Console.WriteLine(ss.IB(3));

            Console.ReadKey();
        }
    }
}
