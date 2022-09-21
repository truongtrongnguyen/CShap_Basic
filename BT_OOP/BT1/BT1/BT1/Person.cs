
using System.Linq;
using System.Threading.Tasks;


namespace BT1
{
    using System;
    using System.Collections.Generic;
    using System.Timers;
    using System.Text;

    internal class Person
    {
        private string name;
        private Address address;
        private DateTime ngaysinh;
        private static int so_nguoi = 0;
        private string email;
        //Khi mà tạo một biến static thì không được đư nó vào hàm contructor
        public Person()
        {

        }

        public Person(string name, string ten_duong, string ten_quan, string ten_tp, DateTime ngaysinh)
        {
            this.Name = name;
            this.Address = new Address(ten_duong, ten_quan, ten_tp);
            so_nguoi++;
            this.ngaysinh = ngaysinh;
        }
        public string Name { get => name; set => name = value; }
        internal Address Address { get => address; set => address = value; }
        public static int So_nguoi { get => so_nguoi; set => so_nguoi = value; }
        public string tostring()
        {
            return $"NgayThangNam: {this.ngaysinh.Date.Day}/{this.ngaysinh.Date.Month}/{this.ngaysinh.Date.Year}\n"
                +$"Nguoi: {this.Name} + {this.Address.Tostring()}"
                +$"Emali: "+tenEmail();
        }
        public string tenEmail()
        {
            string ten = this.Name.Replace(" ","");
            return ten + "@gmail.com";
        }
    }
}
