namespace Prog_CSharp
{
    using System;
    using System.Text;
    using System.Collections;
    public class StringTester
    {
        public static string Ghepchuoi(string s1, string s2)
        {
            string s3 = s1 + s2;
            return s3;
        }
        public  bool Sosanh(string []s1, string []s2)
        {
            int n;
            if (s1.Length < s2.Length)
                n = s2.Length;
            else
                n = s1.Length;
            for(int i=0;i<n;i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }
        static void Main()
        { // thử tạo một vài chuỗi để mà_u8220 ?vọc” 
            StringTester test = new StringTester();
            float []mang1=new float[3];
            
            string[] chuoi2 = new string[] { "abc" };
            //Console.WriteLine($"So sanh chuoi xay dung ham: {test.Sosanh(chuoi1, chuoi2)}");
           
           
            string s3 = @"Samis, Inc.provides custom ,NET development,on-site Training and Consulting";
            int result; // để chứa kết quả so sánh 
                        // so sánh 2 chuỗi, case sensitive
                        // 
            
            
            string sa = "fd,fs, gd, as fdf";
            
            char[] ds = new char[] { 'd', 's','h','w'};
            char[] ds2 = new char[] { '+' };
           
            string s2 = "ABCD";
           
           
            StringBuilder chuoi3 = new StringBuilder();

           // Console.WriteLine($"Xin chao {2020,10}, nam sau la nam{2021}");//sao chữ xin chào thì nó sẽ dành ra 10 kí tự
            string s1 = "DUNG quay mat di";
            String[] cacchuoicon = s1.Split(' ');
            string[] chuoi1 = { "abc", "asda", "das", "qwe", "gewe", "kmk", "we" };
            s1 = String.Join(" ", chuoi1);  //Nối các chuỗi lại với nhau

            StringBuilder ssb = new StringBuilder();
            ssb.Append("Xin ");//Thêm một chuỗi
            ssb.Append("chao cac ban");
            ssb.Replace("Xin chao", "Chao mung");//Tìm kiếm và thay thế
            string kq = ssb.ToString();
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine(kq);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxx");

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("Ham tu xay dung");
            Console.WriteLine(Ghepchuoi(s1, s2));
            result = string.Compare(s1, s2);
            //Console.WriteLine("So sánh s1: {0}, s2: {1}, result:{ 2}\n", s1, s2, result); 
             // Compare overloaded, để ý đến trị bool “ignore case” 
            // (true = ignore case, không quan tâm chữ hoa chữ thường) 
            //result = string.Compare(s1, s2, true);
            //Console.WriteLine("So sánh insensitive\n");
            //Console.WriteLine("s1: {0}, s2: {1}, result: {2}\n", s1,
            //s2, result);
            //// dùng hàm Concat() để ghép chuỗi 
            //string s4 = string.Concat(s1, s2);
            //Console.WriteLine("s4 được ghép từ s1 và s2: {0}", s4);
            //// dùng tác tử + được nạp chồng để ghép hai chuỗi 
            //string s5 = s1 + s2;
            //Console.WriteLine("s5 được ghép từ s1 + s2: {0}", s5);
            //// dùng hàm sao Copy() 
            //result = string.Compare(s1, s2);
            //Console.WriteLine("so sanh co phan biet hoa thuong hay khong: {0}", result);
            //string s6 = string.Copy(s5);
            //Console.WriteLine("s6 được chép từ s5: {0}", s6);
            //// dùng tác tử gán để sao chép 
            //string s7 = s5;
            //Console.WriteLine("s7 = s5: {0}", s7);
            //// Có 3 cách để so sánh xem có bằng nhau hay không 
            //Console.WriteLine("\ns7.Equals(s6) bằng không ?: {0}",s7.Equals(s6));
            //Console.WriteLine("Equals(s7,s6) bằng không ?: {0}", string.Equals(s7, s6));
            //Console.WriteLine("s7==s6 bằng không ?: {0}", s7 == s6);
            //// Hai thuộc tính hữu ích: index và chiều dài 
            //Console.WriteLine("\nChuỗi s7 dài {0} ký tự.", s7.Length);
            //Console.WriteLine("Ký tự thứ 5 là {1}\n", s7.Length, s7[4]);
            //// Trắc nghiệm liệu xem một chuỗi kết thúc với một lô ký tự 
            //Console.WriteLine("s3:{0}\nKết thúc bởi Training?:{1}",s3, s3.EndsWith("Training")); 
            // Console.WriteLine("Kết thúc bởi Consulting?:{0}",s3.EndsWith("Consulting")); 
            //// Trả về chỉ mục của chuỗi con 
            // Console.WriteLine("\nXuất hiện đầu tiên của Training ");
            //Console.WriteLine("trên s3 là {0}\n",s3.IndexOf("Training"));
            //Console.WriteLine(s3.IndexOf("Tra"));
            //// Chèn từ “excellent” trước từ “Training” 
            //string s8 = s3.Insert(56, "excellent"); 
           
            //Console.WriteLine("s8: {0}\n", s8);
            //// Bạn có thể phối hợp lại hai hàm Insert 
            //// và IndexOf như sau:
            //string s9 = s3.Insert(s3.IndexOf("Training"),
            //"excellent ");
            //Console.WriteLine("s9: {0}\n", s9);
            Console.ReadLine();
            Console.ReadKey();
        } // end Main 
    } // end StringTester 
} // end Prog_CSharp