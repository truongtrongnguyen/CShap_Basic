using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD2_interface
{
    internal class Program
    {
        // Một giao diện 
        interface IStorable
        {
            void Read();
            void Write(object obj);
            int Status { get; set; }
        }
        // Lại thêm một giao diện mới 
        interface ICompressible
        {
            void Read();
            void Compress();
            void Decompress();
        }
        // Nới rộng giao diện
        interface ILoggedCompressible : ICompressible
        {
            void LogSavedBytes();
        }
        // Phối hợp các giao diện với nhau tạo thành một giao diện khác 
        interface IStorableCompressible : IStorable, ILoggedCompressible
        {
            void LogOriginalSize();
        }
        // Và đây thêm một giao diện khác lo mã hoá và giải mã 
        interface IEncryptable
        {
            void Encrypt(); // mã hóa dữ liệu 
            void Decrypt(); // giải mã dữ liệu 
        }
        interface IOS
        {
            void Iphone();
        }
        // Tạo lớp Document cho thiết đặt các giao diện 
        // IStorableCompressible và IEncryptable 
        public class Document : IStorableCompressible, IEncryptable
        {
            public Document(string s) // hàm constructor 
            {
                Console.WriteLine($"Tao document voi {s}");
            }
            // Thi công hàm hành sự Read() 
            public void Read()
            {
                Console.WriteLine("Thi công Read() dành cho IStorable");
            }
            void ICompressible.Read()
            {
                Console.WriteLine("Thi cong ham hanh su cua ICompressible.Read()");
            }
            // Thi công hàm hành sự Write() 
            public void Write(object o)
            {
                Console.WriteLine("Thi công Write() dành cho IStorable");
            }
            // Thi công thuộc tính Status 
            public int Status
            {
                    get { return status; }
                    set { status = value; }
            }

            // Thi công các hàm thuộc giao diện ICompressible 
            public void Compress()
            {
                Console.WriteLine("Thi công Compress");
            }
            public void Decompress()
            {
                Console.WriteLine("Thi công Decompress");
            }
            // Thi công hàm bổ sung của giao diện ILoggedCompressible
            public void LogSavedBytes()
            {
                Console.WriteLine("Thi công LogSavedBytes");
            }
            // Thi công hàm bổ sung của giao diện IStorableCompressible 
            public void LogOriginalSize()
            {
                Console.WriteLine("Thi công LogOriginalSize");
            }
            // Thi công các hàm của giao diện IEncryptable 
            public void Encrypt()
            {
                Console.WriteLine("Thi công Encrypt");
            }
            public void Decrypt()
            {
                Console.WriteLine("Thi công Decrypt");
            }
            // Biến trữ trị cho thuộc tính status của IStorable 
            private int status = 0;
        } // end Document
        static void Main(string[] args)
        {
            object o=3;
            // Tạo một đối tượng Document 
            Document doc = new Document("Test Document");
            

            // ép kiểu đối tượng Document qui chiếu về các giao diện khác nhau 
            //SỬ DỤNG TOÁN TỬ IS PHẢI XỬ LÍ CÁC BIỆT LỆ, CHỈ TRẢ VỀ TRUE HOẶC FALSE
            if(doc is IOS)
            {
                IStorable isDoc = doc as IStorable;
                isDoc.Read();
                isDoc.Write(o);
            }
            
            //if (isDoc != null)
            //{
                
            //}
            else
                Console.WriteLine("IStorable không được hỗ trợ");

            //SỬ DỤNG TOÁN TỬ AS NẾU KHÔNG ĐÚNG NÓ SẼ TRẢ CHO ĐỐI TƯỢNG VỀ NULL
            ICompressible icDoc = doc as ICompressible;
            if (icDoc != null)
            {
                icDoc.Compress();
                icDoc.Read();
            }
            else
                Console.WriteLine("ICompressible không được hỗ trợ");
            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if (ilcDoc != null)
            {
                ilcDoc.LogSavedBytes();
                ilcDoc.Compress();
                // ilcDoc.Read(); hàm này thuộc IStorable không dính dáng 
                // với giao diện ILoggedCompressible, nếu cho chạy sẽ sai 
            }
            else
                Console.WriteLine("ILoggedCompressible không được hỗ trợ");
            IStorableCompressible iscDoc = doc as IStorableCompressible;
            if (iscDoc != null)
            {
                iscDoc.LogOriginalSize(); // IStorableCompressible 
                iscDoc.LogSavedBytes(); // ILoggedCompressible 
                iscDoc.Compress(); // ICompressible 
                //iscDoc.ICompressible.Read(); // IStorable     //PHẢI ÉP KIỂU VỀ ICompressible MỚI SỬ DỤNG ĐƯỢC 
               // isDoc.Write(o);
            }
            else
                Console.WriteLine("IStorableCompressible không được hỗ trợ");
            IEncryptable ieDoc = doc as IEncryptable;
            if (ieDoc != null)
            {
                ieDoc.Encrypt();
            }
            else
                Console.WriteLine("IEncryptable không được hỗ trợ");
            Console.ReadKey();
        }
    }
}
