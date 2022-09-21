using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QL_Sinh_Vien_Doc_Ghi_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<ClassRoom> classRooms = new List<ClassRoom>();
            //int choose;

            //do
            //{
            //    ShowMenu();
            //    choose = int.Parse(Console.ReadLine());

            //    switch (choose)
            //    {
            //        case 1:
            //            classRooms = ImportJSON();
            //            break;
            //        case 2:
            //            Display(classRooms);
            //            break;
            //        case 3:
            //            SaveFiles(classRooms);
            //            break;
            //        case 4:
            //            Console.WriteLine("Thoat chuong trinh");
            //            break;
            //        default:
            //            Console.WriteLine("Nhap sai!!!");
            //            break;
            //    }
            //} while (choose != 4);


            Class_Controller e = new Class_Controller();
            e.Giaodien();
            Console.ReadKey();
        }
        static void SaveFiles(List<ClassRoom> classRooms)
        {
            foreach (ClassRoom classroom in classRooms)
            {
                //luu tung object classroom vao file Name.obj
                using (Stream stream = File.Open(@"D:\Code C#\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\" +"abc.obj", FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, classroom);
                }
            }
            //read file => object
            /**using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }*/
        }

        static List<ClassRoom> ImportJSON()
        {
            //B1. Doc noi dung data.json
            var content = System.IO.File.ReadAllText(@"D:\Code C#\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\Data.json");
            Console.WriteLine(content);
            //B2. Convert JSON thanh Array Class Object trong C#
            List<ClassRoom> classRooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClassRoom>>(content);

            Console.WriteLine("Length: " + classRooms.Count);

            Display(classRooms);

            return classRooms;
        }

        static void Display(List<ClassRoom> classRooms)
        {
            foreach (ClassRoom classroom in classRooms)
            {
                classroom.Display();
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap du lieu tu file data.json");
            Console.WriteLine("2. Hien thi thong tin lop hoc");
            Console.WriteLine("3. Luu");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Choose: ");
        }
    }
}
