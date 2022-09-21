using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_co_ban
{
    internal class BT_FileText
    {
        //Link Youtobe: https://www.youtube.com/watch?v=VXkD3jifgKs

        private string _filename;
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }
        private FileStream fs;
        public FileStream FS
        {
            get { return fs; }
            set { fs = value; }
        }
        /// <summary>
        /// Yêu cầu người dùng nhập vào 10 dòng và ghi 10 dòng vào file text
        /// </summary>
        public void WriteData()
        {
            FS = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(FS);
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("moi ban nhap dong thu " + (i + 1));
                string str = Console.ReadLine();
                sw.Write(str);
            }
            sw.Flush();
            sw.Close();
            FS.Close();
        }
        public void ReadData()
        {
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(FS);
            string str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            
            //Lưu ý không sử dụng Flush được
            sr.Close();
            FS.Close();
        }
    }
}
