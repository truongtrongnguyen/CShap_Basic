using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_co_ban
{
    internal class Class_Path_Duong_Dan
    {
        public void LamViecVoiLopPath()
        {
            Console.WriteLine(Path.DirectorySeparatorChar);//in ra kí tự phân cách của đường dẫn thư mục '\'

            var path = Path.Combine("Dri1", "Dri2", "Remixd.txt");//Ghép các từ lại với nhau thành đường dẫn thư mục
            Console.WriteLine(path);

            path = Path.ChangeExtension(path, "pdf");//Đổi phần mở rộng của đường dẫn thư mục
            Console.WriteLine("Doi phan mo rong: " + path);

            Console.WriteLine("Lay duong dan file: " + Path.GetDirectoryName(path));//Lấy đường dẫn thư mục file

            Console.WriteLine("Lay phan mo rong: " + Path.GetExtension(path));//Lấy phần mở rộng

            Console.WriteLine("FullName: " + Path.GetFileName(path));//Lấy tên file

            Console.WriteLine("Lay duong dan hien tai: "+Path.GetFullPath(path));//Đường dẫn hiện tại của file code gép với chuỗi path

            //Lấy đường dẫn thư mục của các file mặc định trong máy tính
            string pa = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Console.WriteLine(pa);

        }
    }
}
