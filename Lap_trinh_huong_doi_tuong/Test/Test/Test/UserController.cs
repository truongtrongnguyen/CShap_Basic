using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class UserController
    {
        public void Giao_dien()
        {
            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Input_Hotles();
                        break;
                    case 2:
                        Display_Hotels();
                        break;
                    case 3:
                        InputBooking();
                        break;
                    case 4:
                        FindRoomAvailable();
                        break;
                    case 5:
                        SeachWithCMND();
                        break;
                    case 6:

                        break;
                    case 7:
                        Console.WriteLine("Thoat!!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!!!");
                        break;
                }
            } while (choose != 7);
        }
        public void SeachWithCMND()
        {
            Console.Write("Nhap ma CMND can tim: ");
            string CMND = Console.ReadLine();
            List<Hotels> hotelslist = new List<Hotels>();
            foreach(Book book in DataController.getInstance().BookingList)
            {
                if(CMND.Equals(book.CMND))
                {
                    Hotels h = DataController.getInstance().FindHotels(book.HotelsNo);
                    if (h != null && !hotelslist.Contains(h))
                    {
                        hotelslist.Add(h);
                    }
                }
            }
            Console.WriteLine("Danh sach Hotels ma khach hang do da den");
            foreach(Hotels i in hotelslist)
            {
                i.Display();
            }
        }
        public void FindRoomAvailable()
        {
            Console.Write("Nhap ngay dat (yyyy/MM/dd): ");
            DateTime Check_In = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());
            Console.Write("Nhap tra (yyyy/MM/dd): ");
            DateTime Check_Out = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());

            List<Book> books = new List<Book>();//Tạo một danh sách các phòng trống
            foreach(var i in DataController.getInstance().BookingList)
            {
                if(i.Check_In>=Check_In&&i.Check_In<=Check_Out)
                {
                    books.Add(i);
                }
                else if(i.Check_Out>=Check_In&&i.Check_Out<=Check_Out)
                {
                    books.Add(i);
                }
            }
            //Xuất danh sách các phòng trống
            foreach(Hotels hotel in DataController.getInstance().HotelList)
            {
                hotel.ShowRoomAvailable(books);
            }
        }
        public void InputBooking()
        {
            Console.WriteLine("Nhap thong tin dat phong");
            Book book = new Book();
            book.Input();
            DataController.getInstance().BookingList.Add(book);
        }

        public void Display_Hotels()
        {
            foreach(var i in DataController.instance.HotelList)
            {
                i.Display();
            }
        }

        public void Input_Hotles()
        {
            Console.WriteLine("Nhap so Hotels can them: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Hotels hotels = new Hotels();
                hotels.Input();
                DataController.getInstance().HotelList.Add(hotels);
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap thong tin khach san");
            Console.WriteLine("2. Hien thi thong tin KS");
            Console.WriteLine("3. Dat phong");
            Console.WriteLine("4. Tim phong trong");
            Console.WriteLine("5. Thong ke doanh thu");
            Console.WriteLine("6. Tim kiem KH");
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Chon: ");
        }
    }
}
