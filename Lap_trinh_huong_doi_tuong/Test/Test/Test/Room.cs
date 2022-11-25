using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Test
{
    internal class Room
    {
        public string RoomName { get; set; }
        public string RoomNo { get; set; }
        public string So_Tang { get; set; }
        public int Price { get; set; }
        public string People { get; set; }
        public string isRoomEmty { get; set; }
        public Room()
        {

        }
        public Room(string roomname, string roomno, string so_tang, int price, string people)
        {
            RoomName = roomname;
            RoomNo = roomno;
            So_Tang = so_tang;
            Price = price;
            People = people;
        }
        public void Input()
        {
            Console.WriteLine("****\tNHAP THONG TIN CAC PHONG\t***** ");
            Edit_Room();
            isRoomEmty = "Trong";
        }
        public void Edit_Room()
        {
            Console.Write("Nhap ten phong: ");
            RoomName = Console.ReadLine();
            Console.Write("Nhap ma phong: ");
            RoomNo = Console.ReadLine();
            Console.Write("Nhap so tang: ");
            So_Tang = Console.ReadLine();
            Console.Write("Nhap gia phong: ");
            Price = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguoi: ");
            People = Console.ReadLine();
        }
        
        public void Input_Defalut()
        {
            //RoomName = default;
            //RoomNo = default;
            //So_Tang = default;
            //Price = default;
            //People = default;
            isRoomEmty = "Trong";

        }
        public void Display()
        {
            Console.WriteLine($"Ten phong: {RoomName} | Ma phong: {RoomNo} | So tang: {So_Tang} | Gia phong: {Price}/h | So nguoi: {People} | Tinh trang: {isRoomEmty}");
        }

    }
}
