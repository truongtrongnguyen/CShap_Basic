using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace File_co_ban
{
    public class Product
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public void Save(Stream stream)//Ghi dữ liệu tại đây
        {

            
            byte[] byte_id = BitConverter.GetBytes(ID);//Chuyển từ kiểu int --> [] byte
            stream.Write(byte_id, 0, 4);//Do số nguyên chiêm 4 byte nên số lượng ghi là 4

            byte[] byte_price = BitConverter.GetBytes(Price);//Chuyển từ kiểu double --> [] byte
            stream.Write(byte_price, 0, 8);//Do kiểu dữ liệu double chiếm 8 byte nên số lượng ghi là 16

            byte[] byte_name = Encoding.UTF8.GetBytes(Name);//Chuyển chuỗi string --> [] byte
            byte[] byte_length = BitConverter.GetBytes(byte_name.Length);//Lưu chiều dài của mảng byte lại 
            stream.Write(byte_length, 0, 4);//Do chiều dài của mảng byte là số nguyên nên số lượng ghi là 4
            stream.Write(byte_name, 0, byte_name.Length);
        }
        public void Saves(FileStream fs)
        {
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(ID);
            bw.Write(Price);
            bw.Write(Name);
  
        }
        public void SaveWithBinary(Stream fs)
        {
            BinaryWriter br = new BinaryWriter(fs);
            br.Write(Name);
            br.Write(Price);
            br.Write(ID);
            br.Flush();
            br.Close();
        }
        public void ReadWithBinary(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);
            Name=br.ReadString();
            Price=br.ReadDouble();
            ID=br.ReadInt32();
        }

        public void Display(FileStream fs)
        {
            //while (true)
            {
                string s = " ";
                StreamReader sr = new StreamReader(fs);
                s=sr.ReadToEnd();
                string[] q = s.Split('\n');
                Regex re = new Regex(@"(?<id>^[\d]{3})(?<price>[\d]{8})(?<name>[a-z A-Z]+)");
                MatchCollection matches;
                foreach (var i in q)
                {
                    matches = re.Matches(i);
                    foreach (Match macth in matches)
                    {
                        Product p1 = new Product();
                        p1.Name = macth.Groups["name"].ToString();
                        p1.Price = Double.Parse(macth.Groups["price"].ToString());
                        p1.ID = int.Parse(macth.Groups["id"].ToString());


                        //string g = Convert.ToString(macth.Groups["Price"].ToString());
                        //string t = Convert.ToString(macth.Groups["id"].ToString());
                        Console.WriteLine($"Name: {macth.Groups["name"]} | ID: {macth.Groups["id"]} | Price: {macth.Groups["price"]}");
                        Console.WriteLine($"{p1.Name.GetType()} | {p1.ID.GetType()} | {p1.Price.GetType()}");

                    }
                }       
                sr.Close();
            }
        }
        public void Output()
        {
            Console.WriteLine($"Name: {Name} | ID: {ID} | Price: {Price}");

        }
        public void Restore(Stream stream)//Lấy giữ liệu
        {
            // chuyển [] byte --> int
            byte[] byte_id = new byte[4];//Khởi tạo mảng byte có 4 phần tử
            stream.Read(byte_id, 0, 4);
            ID = BitConverter.ToInt32(byte_id, 0);

            // chuyển [] byte --> int
            byte[] byte_price = new byte[8];
            stream.Read(byte_price, 0, 8);
            Price = BitConverter.ToDouble(byte_price, 0);

            //Lấy số lượng byte
            byte[] byte_lenght = new byte[4];
            stream.Read(byte_lenght, 0, 4);
            int length = BitConverter.ToInt32(byte_lenght, 0);

            //chuyển [] byte --> string
            byte[] byte_name = new byte[length];
            stream.Read(byte_name, 0, length);
            Name = Encoding.UTF8.GetString(byte_name, 0, length);
        }
    }

    internal class Class_Stream
    {
        public void LamViecVoiStream()
        {
            string path = @"C:\Users\DELL\Desktop\456.txt";

            //using (var stream = new FileStream(path: path, FileMode.Create));//sau khi sử dụng stream xong thì phải giải phóng nó bằng lệnh using
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);   //sử dụng FileStream thì cần truyền vào đường dẫn và lệnh mở file
            Product sp = new Product();
            //{
            //    ID = 224,
            //    Price = 12345678,
            //    Name = "San pham ihpone"
            //};
            //sp.Save(stream);
            //sp.Restore(stream);
            //sp.SaveWithBinary(stream);
            sp.ReadWithBinary(stream);
            Console.WriteLine($"Name: {sp.Name} | ID: {sp.ID} | Price: {sp.Price}");
            //sp.Display(stream);


            //sp.Restore(stream);

            //ListSP lsp = new ListSP();
            //lsp.Display(stream);
            //foreach (Product i in lsp.ds)
            //{
            //    i.Output();
            //    Console.WriteLine($"Name: {i.Name} | ID: {i.ID} | Price: {i.Price}");
            //}

            //Console.WriteLine($"Name: {sp.Name} | ID: {sp.ID} | Price: {sp.Price}");

            //stream.Flush();
            stream.Close();

            ////Lưu dữ liệu: 
            //byte[] buffer = { 1, 2, 3 };//Do làm việc với stream là chủ yếu thao tác với byte nhiều
            //int offset = 0; //Vị trí bắt đầu
            //int count = 3; // Số lượng byte 
            //stream.Write(buffer, offset, count);

            ////Đọc dữ liệu: 
            //int sobytedocduoc=stream.Read(buffer, offset, count);//kết quả nó sẽ lưu vào mảng byte buffer và nó trả về số byte đọc được

            //// chuyển int , double --> byte
            //int abc = 1;
            //var byte_abc = BitConverter.GetBytes(abc);//trả về 1 mảng các byte lưu vào byte_abc

            ////chuyển byte --> int, double, ...
            //BitConverter.ToInt32(byte_abc, 0);

            ////chuyển string --> byte
            //string s = "abc";
            //var byte_string = Encoding.UTF8.GetBytes(s);

            ////chuyển byte --> string
            //Encoding.UTF8.GetString(byte_string, 0, 10);

        }
        public void Test()
        {
            String path = @"C:\temp\MyTest.TXT";

            if (!File.Exists(path))
            {
                Console.WriteLine("File " + path + " does not exists!");

                // Đảm bảo rằng thư mục cha tồn tại.
                Directory.CreateDirectory(@"C:\temp");
            }

            // Tạo ra một FileStream để ghi dữ liệu.
            // (FileMode.Append: Mở file ra để ghi tiếp vào phía cuối của file,
            //  nếu file không tồn tại sẽ tạo mới). 
            using (FileStream writeFileStream = new FileStream(path, FileMode.Append))
            {
                string s = "\nHello every body!";

                // Chuyển một chuỗi thành mảng các byte theo mã hóa UTF8.
                byte[] bytes = Encoding.UTF8.GetBytes(s);

                // Ghi các byte xuống file.
                writeFileStream.Write(bytes, 0, bytes.Length);
            }


            string contents1 = File.ReadAllText(@"C:\temp\MyTest.TXT");//Đọc file
            Console.WriteLine(contents1);
            Console.WriteLine("Finish!");

        }
    }
}
