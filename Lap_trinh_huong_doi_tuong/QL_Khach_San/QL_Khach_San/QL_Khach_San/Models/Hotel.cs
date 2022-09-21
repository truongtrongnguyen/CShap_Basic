using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San.Models
{
    internal class Hotel
    {
        public string HotelNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<Room> RoomList { get; set; }

        public Hotel()
        {
            RoomList = new List<Room>();
        }

        public void Input()
        {
            Console.WriteLine("Nhap ma khach san: ");
            HotelNo = Console.ReadLine();

            Console.WriteLine("Nhap ten khach san: ");
            Name = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();

            Console.WriteLine("Nhap loai: ");
            Type = Console.ReadLine();

            Console.WriteLine("Nhap so phong: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Room room = new Room();
                room.Input();

                RoomList.Add(room);
            }
        }

        public void DisplayAll()
        {
            Console.WriteLine("Ten KS: {0}, ma ks: {1}, dia chi: {2}, loai: {3}",
                Name, HotelNo, Address, Type);
            Console.WriteLine("Danh sach phong: ");
            foreach (Room room in RoomList)
            {
                room.Display();
            }
        }

        public void Display()
        {
            Console.WriteLine("Ten KS: {0}, ma ks: {1}, dia chi: {2}, loai: {3}",
                Name, HotelNo, Address, Type);
        }

        Room findRoom(string roomNo)
        {
            foreach (Room room in RoomList)
            {
                if (room.RoomNo == roomNo)
                {
                    return room;
                }
            }
            return null;
        }

        public int CalculateProfit(List<Booking> bookings)
        {
            int profit = 0;
            foreach (Booking booking in bookings)//Tìm các khách hàng đã Booking trong danh sách
            {
                if (booking.HotelNo == HotelNo)//Nếu tùm thấy tức là có khách hàng đã Booking
                {
                    Room room = findRoom(booking.RoomNo);//Sau đó đến tìm phòng khách hàng ở để lấy giá phòng
                    if (room != null)
                    {
                        profit += room.Price;
                    }
                }
            }
            return profit;
        }

        public void ShowRoomAvailable(List<Booking> bookings)
        {
            Display();
            Console.WriteLine("Danh sach phong trong: ");
            foreach (Room room in RoomList)//Tìm phòng trống trong danh sách phòng
            {
                if (CheckAvailable(bookings, room))//Xuất những phòng mà khách hàng chưa booking
                {
                    room.Display();
                }
            }
        }

        bool CheckAvailable(List<Booking> bookings, Room room)
        {
            foreach (Booking booking in bookings)//Loại ra những phòng trong danh sách bookings truyền vào mà khách hàng đã booking
            {
                if (booking.HotelNo == HotelNo && booking.RoomNo == room.RoomNo)//Nếu mã hotels và mã phòng trong bookings truyền vào mà khớp là có người đã đặt phòng
                {
                    return false;
                }
            }
            return true;
        }
    }
}
