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
            Console.WriteLine("****\tNHAP THONG KHACH SAN\t***** ");
            Input_Edit();
            Console.Write("Nhap so phong can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Room room = new Room();
                room.Input();
                RoomList.Add(room);
            }
        }
        public void Input_Edit()
        {
            Console.Write("Nhap ten hotels: ");
            Name = Console.ReadLine();
            Console.Write("Nhap ma hotels: ");
            HotelNo = Console.ReadLine();
            Console.Write("Nhap loai hotels (VIP/BINH DAN): ");
            TypeHotels = Console.ReadLine();
            Console.Write("Nhap dia chi hotels: ");
            Address = Console.ReadLine();
        }
        public void Display()
        {
            
            Console.WriteLine($"\n\t**Ten Hotels: {Name} | Ma hotels: {HotelNo} | Loai: {TypeHotels} | Dia chi: {Address}**");
            if (RoomList.Count == 0)
            {
                Console.WriteLine("Chua co phong nao duoc them vao");
                return;
            }
                Console.WriteLine("Danh sach cac phong: ");
            foreach (var i in RoomList)
            {
                i.Display();
            }
        }
        public void ShowRoomAvailable()
        {
            //Console.WriteLine("Danh sach phong trong la: ");
            //foreach(var i in RoomList)
            //{
            //    if(!CheckAvailable(books, i))
            //    {
            //        i.Display();
            //    }
            //}
            foreach(var i in RoomList)
            {
                if (i.isRoomEmty.Equals("Trong"))
                {
                    i.Display();
                }
            }
        }
        
      
    }
}
