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
        public void Display()
        {
            Console.WriteLine($"Ten phong: {RoomName} | Ma phong: {RoomNo} | So tang: {So_Tang} | Gia phong: {Price} | So nguoi: {People}");
        }

    }
}
