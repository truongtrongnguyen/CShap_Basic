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
                Console.Clear();
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
                        Display_Books();
                        break;
                    case 4:
                        InputBooking();
                        break;
                    case 5:
                        Dislay_Info_Customer();
                        break;
                    case 6:
                        Edit_General();
                        break;
                    case 7:
                        FindCustomer();
                        break;
                    default:
                        Console.WriteLine("Nhap sai!!!");
                        break;
                }
                Console.ReadKey();
            } while (choose != 7);
        }
        public void SeachWithCMND()
        {
            Console.Write("Nhap ma CMND can tim: ");
            string CMND = Console.ReadLine();
            List<Hotels> hotelslist = new List<Hotels>();
            foreach (Book book in DataController.getInstance().BookingList)
            {
                if (CMND.Equals(book.CMND))
                {
                    Hotels h = DataController.getInstance().FindHotels(book.HotelsNo);
                    if (h != null && !hotelslist.Contains(h))
                    {
                        hotelslist.Add(h);
                    }
                }
            }
            Console.WriteLine("Danh sach Hotels ma khach hang da den");
            foreach (Hotels i in hotelslist)
            {
                i.Display();
            }
        }

        public void FindCustomer()
        {
            DataController.getInstance().Edit_info.Edit_Customer(false);
        }

        public void Edit_General()
        {
            Console.Write("Nhap thong tin can chinh sua (Room, Hotels, Book, Customer): ");
            string temp = Console.ReadLine();
            if (temp.Equals("Room"))
            {
                DataController.getInstance().Edit_info.Edit_Room();
            }
            else if (temp.Equals("Hotels"))
            {
                DataController.getInstance().Edit_info.Edit_Hotels();
            }
            else if (temp.Equals("Book"))
            {
                DataController.getInstance().Edit_info.Edit_Book();
            }
            else if (temp.Equals("Customer"))
            {
                DataController.getInstance().Edit_info.Edit_Customer(true);
            }
        }

        public void Dislay_Info_Customer()
        {
            if (!DataController.getInstance().Check_Customer_Available())
            {
                return;
            }
            foreach (var i in DataController.getInstance().CustomerList)
            {
                i.Display();
            }
        }

        public void FindRoomAvailable() // Tim phong trong
        {
            //Console.Write("Nhap ngay dat (yyyy/MM/dd): ");
            //DateTime Check_In = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());
            //Console.Write("Nhap tra (yyyy/MM/dd): ");
            //DateTime Check_Out = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());

            //List<Book> books = new List<Book>();//Tạo một danh sách các phòng trống
            //foreach(var i in DataController.getInstance().BookingList)
            //{
            //    if(i.Check_In>=Check_In&&i.Check_In<=Check_Out)
            //    {
            //        books.Add(i);
            //    }
            //    else if(i.Check_Out>=Check_In&&i.Check_Out<=Check_Out)
            //    {
            //        books.Add(i);
            //    }
            //}
            ////Xuất danh sách các phòng trống
            //foreach(Hotels hotel in DataController.getInstance().HotelList)
            //{
            //    hotel.ShowRoomAvailable(books);
            //}

            Console.WriteLine("Danh sach cac phong trong: ");
            foreach (var i in DataController.getInstance().HotelList)
            {
                i.ShowRoomAvailable();
            }
        }
        public void InputBooking()
        {
            if (!DataController.getInstance().Check_Hotels_Available())
            {
                return;
            }
            Display_Hotels();
            Console.WriteLine("Nhap thong tin dat phong");

            Book book = new Book();
            book.Input();
            DataController.getInstance().BookingList.Add(book);
            Customer temp = book.CustomerBook;
            temp.ListCustomerBook.Add(book);
        }

        public void Display_Books()
        {
            if (!DataController.getInstance().Check_Book_Available())
            {
                return;
            }
            foreach (var i in DataController.getInstance().BookingList)
            {
                i.Display();
            }
        }

        public void Display_Hotels()
        {
            if (!DataController.getInstance().Check_Hotels_Available())
            {
                return;
            }
            foreach (var i in DataController.instance.HotelList)
            {
                i.Display();
            }

        }

        public void Input_Hotles()
        {
            Console.WriteLine("Nhap so Hotels can them: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
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
            Console.WriteLine("3. Hien thi thong tin Book");
            Console.WriteLine("4. Tim phong trong va dat phong");
            Console.WriteLine("5. Hien thi thong tin khach hang");
            Console.WriteLine("6. Chinh sua thong tin");
            Console.WriteLine("7. Tim kiem KH");
            Console.WriteLine("8. Thoat");
            Console.WriteLine("Chon: ");

        }
    }
}
