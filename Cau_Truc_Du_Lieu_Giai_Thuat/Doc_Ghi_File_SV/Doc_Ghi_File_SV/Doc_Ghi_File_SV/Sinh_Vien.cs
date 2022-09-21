using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Doc_Ghi_File_SV
{
    public class Sinh_Vien
    {
        public Sinh_Vien()
        { }
        public Sinh_Vien(string name, string id, string time, float diem)
        {
            this.Name = name;
            this.Id = id;
            this.Time = time;
            this.Diem = diem;
        }
        private string _name;
        private string _id;
        private string _time;
        private float _diem;

        public string Name { get => _name; set => _name = value; }
        public string Id { get => _id; set => _id = value; }
        public string Time { get => _time; set => _time = value; }
        public float Diem { get => _diem; set => _diem = value; }
        public void Input()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            Name = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            while(true)
            {
                Id = Console.ReadLine();
                if (CheckID(Id))
                {
                    break;
                }
                Console.Write("ID khong hop le vui long nhap lai: ");
            }
            Console.Write("Nhap ngay sinh: ");
            Time = Console.ReadLine();
            Console.Write("Nhap diem: ");
            Diem = float.Parse(Console.ReadLine());
        }
        private bool CheckID(string id)
        {
            string s = "N15DC";
            Regex e = new Regex(@"(?<ma>N15DC{1})(?<id>[A-Z0-9]+)");
            Match m = e.Match(id);
            if (s.Equals(m.Groups["ma"].ToString())&&id.Length==10)
            {
                return true;
            }
            return false;
        }
        public void Display()
        {
            Console.WriteLine($"Ho ten: {Name} | ID: {Id} | Ngay sinh: {Time} | Diem: {Diem}");
        }
    }
}
