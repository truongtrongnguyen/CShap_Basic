using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File_co_ban
{
    internal class DriveInfo_O_Dia//Lớp làm việc với ổ đĩa
    {
        public void LamViecVoiODia()
        {
            //var drives = DriveInfo.GetDrives();//Lấy ra tất cả ổ đĩa trong máy lưu vào một biến
             DriveInfo drive = new DriveInfo(@"C");//Truy cập thông qua tên bộ nhớ
            //foreach (var drive in drives)
            {
                Console.WriteLine("Drive: " + drive.Name);
                Console.WriteLine("Drive type: " + drive.DriveType);//Kiểu ổ đĩa
                Console.WriteLine("Lable Drive: " + drive.VolumeLabel);//Nhãn của ổ đĩa
                Console.WriteLine("Format Drive: " + drive.DriveFormat);//Định dạng ổ đĩa
                Console.WriteLine("size: " + drive.TotalSize);//Kích thước ổ đĩa
                Console.WriteLine("Free: " + drive.TotalFreeSpace);//Kích thước còn trống
                Console.WriteLine();
            }

        }

    }
}
