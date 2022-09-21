using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San.Models
{
    internal class User_Contronller1
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
                        InputHotel();
                        break;
                    case 2:
                        DisplayHotel();
                        break;
                    case 3:
                        InputBooking();
                        break;
                    case 4:
                        FindRoomAvailable();
                        break;
                    case 5:
                        CalculateProfit();
                        break;
                    case 6:
                        SearchCustomerByCMNTD();
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
        private static void FindRoomAvailable()//TÌm phòng trống
        {
            Console.WriteLine("Nhap ngay nhan (yyyy-MM-dd HH:mm:ss): ");
            DateTime checkIn = Utils.Utility.ConvertStringToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap ngay tra (yyyy-MM-dd HH:mm:ss): ");
            DateTime checkOut = Utils.  Utility.ConvertStringToDateTime(Console.ReadLine());

            //Book -> CheckIn (checkIn & checkOut) || CheckOut (checkIn & checkOut)
            List<Booking> bookList = new List<Booking>();//Tạo một danh sách khách hàng book
            foreach (Booking booking in DataController.getInstance().BookingList)
            {
                if (booking.CheckIn >= checkIn && booking.CheckIn <= checkOut)//Nếu mà booking.CheckIn da tồn tại thì nó đã có người đặt và thêm vào 
                {                                                               //danh sách để nữa sẽ loại ra những cái phòng mà khách đã đặt
                    bookList.Add(booking);
                }
                else if (booking.CheckOut >= checkIn && booking.CheckOut <= checkOut)
                {
                    bookList.Add(booking);
                }
            }

            //Hien thi danh sach phong con trong:
            foreach (Hotel hotel in DataController.getInstance().HotelList)
            {
                hotel.ShowRoomAvailable(bookList);
            }
        }

        private static void SearchCustomerByCMNTD()
        {
            Console.WriteLine("Nhap CMTND can tim: ");
            string cmntd = Console.ReadLine();

            List<Hotel> list = new List<Hotel>();//Tạo ra ds khách sạn mà khách hàng đó đã đến

            foreach (Booking booking in DataController.getInstance().BookingList)
            {
                if (booking.CMTND == cmntd)//Nếu mà mã CMND trong ds khách hàng booking trùng với mã cmnd cần tìm thì thêm cái hotel đó vào ds list
                {
                    Hotel hotel = DataController.getInstance().FindHotel(booking.HotelNo);//tiến hành tìm khách sạn và khởi tạo để thêm vào ds list
                    if (hotel != null && !list.Contains(hotel))
                    {
                        list.Add(hotel);
                    }
                }
            }

            Console.WriteLine("Danh sach KS ma KH toi: ");//Xuất ra ds mà khách hàng đó đã đến qua cmnd
            foreach (Hotel hotel in list)
            {
                hotel.Display();
            }
        }

        private static void CalculateProfit()
        {
            foreach (Hotel hotel in DataController.getInstance().HotelList)
            {
                int profit = hotel.CalculateProfit(DataController.getInstance().BookingList);
                Console.WriteLine("KS: {0}, ma ks: {1}, doanh thu: {2}", hotel.Name, hotel.HotelNo, profit);
            }
        }

        private static void InputBooking()
        {
            Console.WriteLine("Nhap thong tin dat phong: ");
            Booking booking = new Booking();
            booking.Input();

            DataController.getInstance().BookingList.Add(booking);
        }

        private static void DisplayHotel()
        {
            Console.WriteLine("Thong tin KS:");
            foreach (Hotel hotel in DataController.getInstance().HotelList)
            {
                hotel.Display();
            }
        }

        private static void InputHotel()
        {
            Console.WriteLine("Nhap so khach san can them: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Hotel hotel = new Hotel();
                hotel.Input();

                DataController.getInstance().HotelList.Add(hotel);
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Nhap thong tin khach san");
           /*
            * Nhập vào số khách sạn và thông tin khách sạn đó rồi đến nhập số phòng và thông tin phòng
            */
            Console.WriteLine("2. Hien thi thong tin KS");
            //Xuất ra tất cả các khách sạn và các phòng thuộc khách sạn đó
            Console.WriteLine("3. Dat phong");
            //Nhập thông tin đặt phòng nếu mã CMND chưa tồn tại trong danh sách khách hàng thì tiến hành thêm mới khách hàng, lưu ý là không thêm lại mã CMND sau khi nhập
            Console.WriteLine("4. Tim phong trong");
            Console.WriteLine("5. Thong ke doanh thu");
            //sử dụng mã khách sạn trong danh sách Book và tìm ra khách sạn mà khách hàng đã book và rồi từ đó tìm mã phòng và lấy ra đơn giá
            Console.WriteLine("6. Tim kiem KH");
            /*
             * Tìm khách hàng dựa trên mã CMND
             * Sau đó tạo ra một List<Hotels> mà khách hàng đã đến sử dụng hàm tìm Khách sạn và Xuất ra màn hình
             */
            Console.WriteLine("7. Thoat");
            Console.WriteLine("Chon: ");
        }
    }
}
