using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_co_ban
{
    internal class BT_Doc_Ghi
    {
        //Link Youtube: https://www.youtube.com/watch?v=JHkXvC-PwSo&list=PLPt6-BtUI22owYNbmZMv76VIfyqBDv0-D&index=72
        public void Doc_Ghi_File()
        {
            string path = @"C:\temp\MyTest.txt";

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                //Ghi file
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("123456");
                sw.Flush();
                sw.Close();
                //fs.Close();// Sử dụng using không cần lệnh đóng tệp
            }

            //Đọc file
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs);
                string s = sr.ReadToEnd();
                Console.WriteLine(s);
                sr.Close();
                //fs.Close();// Sử dụng using không cần lệnh đóng tệp
            }


            //Ghi binary
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(12334);
                bw.Flush();
                bw.Close();
               
            }

            //Đọc binary
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                var a = br.ReadInt32();
                Console.WriteLine(a);
                br.Close();
                //fs.Close();// Sử dụng using không cần lệnh đóng tệp
            }

        }
    }
}
