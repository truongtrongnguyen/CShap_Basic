using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BT1
{
    internal class BT1
    {
        public BT1()
        {

        }
        public void BT()
        {
            Console.WriteLine("Chuong trinh ghi file trong C#");
            string content = " ";
            string path = @"C:\Users\DELL\Desktop/456.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Nhap chuoi can ghi vao file: ");
            content = Console.ReadLine();
            sw.WriteLine(content);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
