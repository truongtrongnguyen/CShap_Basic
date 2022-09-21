using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Hotels
    {
       public string Name { get; set; }
        public string HotelNo { get; set; }
        public string TypeHotels { get; set; }
        public string Address { get; set; }
        public List<Room> RoomList { get; set; }
        public Hotels()
        {
            RoomList = new List<Room>();
        }
        public void Input()
        {
            Console.Write("Nhap ten hotels: ");
            Name = Console.ReadLine();
            Console.Write("Nhap ma hotels: ");
            HotelNo = Console.ReadLine();
            Console.Write("Nhap loai hotels (VIP/BINH DAN): ");
            TypeHotels = Console.ReadLine();
            Console.Write("Nhap dia chi hotels: ");
            Address = Console.ReadLine();
            Console.Write("Nhap so phong can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Room room = new Room();
                room.Input();
                RoomList.Add(room);
            }

        }
        public void Display()
        {
            Console.WriteLine($"Ten Hotels: {Name} | Ma hotels: {HotelNo} | Loai: {TypeHotels} | Dia chi: {Address}");
            Console.WriteLine("Danh sach cac phong: ");
            foreach (var i in RoomList)
            {
                i.Display();
            }
        }
        public void ShowRoomAvailable(List<Book> books)
        {
            Console.WriteLine("Danh sach phong trong la: ");
            foreach(var i in RoomList)
            {
                if(!CheckAvailable(books, i))
                {
                    i.Display();
                }
            }
        }
        bool CheckAvailable(List<Book> books, Room room)
        {
            foreach(var book in books)
            {
                if(book.HotelsNo.Equals(HotelNo)&&book.RoomNo.Equals(room.RoomNo))
                {
                    return false;
                }
            }
            return true;
        }
      
    }
}
