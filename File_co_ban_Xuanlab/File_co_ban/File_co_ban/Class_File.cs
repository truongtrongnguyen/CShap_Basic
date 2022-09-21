using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_co_ban
{
    internal class Class_File
    {
        public void LamViecVoiFile()
        {
            string path = @"C:\Users\DELL\Desktop\123.txt";
            string contents = "Xin chao cac ban";
            File.WriteAllText(path, contents);//Ghi đè file
            DirectoryInfo f1 = new DirectoryInfo(path);
            Console.WriteLine(f1.Extension);
            //File.AppendAllText(path, contents);//Ghi thêm vào file

            string contents1 = File.ReadAllText(@"C:\Users\DELL\Desktop\456.txt");//Đọc file
            Console.WriteLine(contents1);

            //File.Move(path, @"C:\Users\DELL\Desktop\123.txt");//Đổi tên file
           // File.Copy(path, @"C:\Users\DELL\Desktop\456.txt");
        }
    }
}
