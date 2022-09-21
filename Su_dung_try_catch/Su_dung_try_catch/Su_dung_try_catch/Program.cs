using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Data;

namespace Su_dung_try_catch
{
    using System;
    using System.IO;
    using System.Text;
    internal class Program
    {
        static void Register(string name, int age)
        {
            if(string.IsNullOrEmpty(name))//nếu tên là null hoặc rỗng thì tung ra 1 ngoại lệ
            {
                throw new NameEmptyException();
                //throw new NameNullException();    Nó chỉ tung ra một biệt lệ và những dòng ở sai nó không thực thi
            }
            
            if(age<18||age>100)
            {
                throw new AgeException(age);
            }
            Console.WriteLine("Xin chao {0},{1}", name, age);
        }
        static void Main(string[] args)
        {
           
            int a = 4;
            int b = 0;
            try
            {
                //VD1: Chia một số cho 0
                double q= a / b;
                Console.WriteLine(q);

                //VD2: Truy cập mảng không phù hợp
                //int[] d = { 2, 3 };
                //Console.WriteLine(d[8]);

                ////VD3: Truy cập đến 1 file
                //string file = @"C:\Users\DELL\Desktop\acb.txt";
                //string s = File.ReadAllText(file);
                //Console.WriteLine(s);

                ////VD4: Tự xây dựng Exception
                //Register("sdfsd", 260);

            }
            //VD4: Tự xây dựng Exception
            catch (NameEmptyException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NameNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }





            catch (FileNotFoundException q)//Bắt lỗi không tìm thấy file    
            {
                Console.WriteLine(q.Message);
                Console.WriteLine("File khong ton tai");
            }
            catch(ArgumentNullException e)//Lỗi đường dẫn file
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Duong dan file phai khac null");
            }
            catch (DivideByZeroException e)//Lỗi chia một số cho 0
            {
                Console.WriteLine("Ten loi: " + e.Message);
                Console.WriteLine("Loi chia cho 0");
            }
            //catch (ArithmeticException e)//Lỗi ép kiểu, hoạt động số học, ép kiểu hoặc chuyển đổi
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.StackTrace);
            //}
            catch (IndexOutOfRangeException e)//Lỗi truy cập vị trí không hợp lệ
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("chi so mang khong phu hop");
            }
            catch (Exception e)//Bắt tấc cả các lỗi
            {
                Console.WriteLine(e.Message);//Xuất ra tên lỗi Exception
                Console.WriteLine(e.StackTrace);//In ra địa chỉ dẫn đến lỗi
                Console.WriteLine(e.GetType().Name);//In ra lỗi thuôc lớp nào từ đó chỉ cần bắt lỗi ngay lớp đó
                Console.WriteLine("Loi");
            }
            finally
            {
                Console.WriteLine("Ket thuc chuong trinh");
            }
            Console.ReadKey();
        }
    }
}
