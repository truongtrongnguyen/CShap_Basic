using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace QL_Sinh_Vien_Doc_Ghi_File
{
    [Serializable]//Giao thức chuyển đổi dùng để lưu file
    public class Class_Controller
    {
        public List<ClassRoom> ClassroomList;
        public Class_Controller()
        {
            ClassroomList = new List<ClassRoom>();
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Doc du  lieu tu file Data.json ra Object");
            Console.WriteLine("2. Hien thi thong tin lop hoc");
            Console.WriteLine("3. Luu du lieu vao cac file .txt");
            Console.WriteLine("4. Them lop hoc");
            Console.WriteLine("5. Doc du lieu");
        }
        public void Giaodien()
        {
            while (true)
            {
                int Option;
                do
                {
                    ShowMenu();
                    Console.Write("Nhap lua chon cua ban: ");
                    Option = int.Parse(Console.ReadLine());
                    switch (Option)
                    {
                        case 1:
                            {
                                ClassroomList = ImportJSON();
                                break;
                            }
                        case 2:
                            {
                                // ClassroomList=ImportJSON();
                                Display(ClassroomList);
                                break;
                            }
                        case 3:
                            {
                                SaveFiles(ClassroomList);
                                break;
                            }
                        case 4:
                            {
                                Themlophoc();
                                //Environment.Exit(0);
                                break;
                            }
                        case 5:
                            {
                                Chinhsuathongtin(ClassroomList);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Lua chon khong hop le");
                                break;
                            }
                    }
                } while (Option != 6);
            }
        }
        public List<ClassRoom> ImportJSON()
        {
            //B1. Doc noi dung data.json
            var content = System.IO.File.ReadAllText(@"D:\Code_C#\Code_C-\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\Data.json");
            //Console.WriteLine(content);
            //B2. Convert JSON thanh Array Class Object trong C#
            List<ClassRoom> classRooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClassRoom>>(content);
            Console.WriteLine("Read information for File ISON successfull");
            Console.WriteLine("So luong lop hoc: "+classRooms.Count);

            return classRooms;
        }

        public void Display(List<ClassRoom> ClassroomList)
        {
            foreach (ClassRoom classroom in ClassroomList)
            {
                classroom.Display();
            }
        }
        public void Chinhsuathongtin(List<ClassRoom> ClassroomList)
        {
            Console.Write("Nhap ten lop: ");
            string nameclass = Console.ReadLine();
            var lopcantim = (from lop in ClassroomList
                             where lop.Name == nameclass
                             select (lop.StudentList));

            lopcantim.ToList().ForEach(x =>
            {
                foreach (var i in x)
                {
                    i.Display();
                }
            });

            if (lopcantim != null)
            {

                Console.Write("Nhap ten sinh vien: ");
                string namesv = Console.ReadLine();
                lopcantim.ToList().ForEach(x =>
                {
                    foreach (var i in x)
                    {
                        if (namesv.Equals(i.Fullname))
                        {
                            Console.WriteLine("Nhap thong tin moi cua sinh vien: ");
                            i.Input();
                            
                        }
                    }
                });
            }
        }
        static void SaveFiles(List<ClassRoom> classroomlist)    //
        {
            for(int i=0;i<classroomlist.Count;i++)
            {
                using (Stream stream = File.Open($@"D:\Code_C#\Code_C-\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\{classroomlist[i].Name}.txt", FileMode.Create))
                {
                    var binaryFomatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFomatter.Serialize(stream, classroomlist[i]);
                }
            }
        }
        public void Themlophoc()
        {
            ClassRoom classroom = new ClassRoom();
            classroom.Input();
            ClassroomList.Add(classroom);

            //var jons=Newtonsoft.Json.JsonConvert.SerializeObject(classroom);
            var jons = Newtonsoft.Json.JsonConvert.SerializeObject(ClassroomList);
            FileStream file = new FileStream(@"D:\Code_C#\Code_C-\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\Data.json", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            
            sw.WriteLine(jons);
            sw.Flush();
            sw.Close();
        }

        public List<ClassRoom> ReadFile()//CHƯA HOÀN THÀNH
        {
            //read file => object
             using (FileStream stream = File.Open(@"D:\Code_C#\Code_C-\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\Data.json", FileMode.Open))
             {
                //var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //return (List<ClassRoom>)binaryFormatter.Deserialize(stream);

                StreamReader sr = new StreamReader(stream);
                string json = sr.ReadToEnd();
                List<ClassRoom> items = JsonConvert.DeserializeObject < List < ClassRoom>>(json);
                ClassroomList = items;
                return items;
            }
        }
        public List<ClassRoom> ReadFromBinaryFile()//CHƯA HOÀN THÀNH
        {
            using (Stream stream = File.Open(@"D:\Code_C#\Code_C-\File_co_ban_Xuanlab\File_co_ban\QL_Sinh_Vien_Doc_Ghi_File\Data.json", FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (List<ClassRoom>)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
