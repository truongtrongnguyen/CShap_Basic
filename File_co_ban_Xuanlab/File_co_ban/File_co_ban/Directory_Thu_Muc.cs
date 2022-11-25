using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_co_ban
{
    internal class Directory_Thu_Muc
    {
        public void LamViecVoiThuMuc()
        {
            string path = @"C:\Users\DELL\Desktop\C#";
            //Directory.CreateDirectory(path);
            //Directory.Delete(path);


            var file = Directory.GetFiles(path);    //Lấy các file trong đường dẫn
            var directory = Directory.GetDirectories(path);// Lấy các thư mục trong đường dẫn
            
            Console.WriteLine("Cac thu muc con trong thu muc C#");
            foreach(var i in directory)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Cac file trong thu muc C#");
            foreach(var i in file)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            //ListFileDirectory(path);

            //Kiểm tra xem thu mục path có tồn tại hay không
            if (Directory.Exists(path))
            {
                Console.WriteLine($"Thu muc {path} co ton tai");
            }
            else
            {
                Console.WriteLine($"Thu muc {path} khong ton tai");
            }

            Console.WriteLine();
        }
        static void ListFileDirectory(string path)//Hàm đệ quy lấy tấc cả các file con trong thư mục 
        {
            String[] directories =Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }
        public static void SeachFile_CanTim()
        {
            string path = @"D:\";
            DirectoryInfo mydata = new DirectoryInfo(path);
            FileInfo[] file = mydata.GetFiles("*.pdf", SearchOption.TopDirectoryOnly);
           
            Console.WriteLine("Tong so file la: {0} ",file.Length);
            Console.WriteLine("So file pdf tim thay la: ");
            foreach(var i in file)
            {
                Console.WriteLine(i.FullName);
            }
        }
    }
}
