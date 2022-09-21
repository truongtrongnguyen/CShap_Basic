using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QL_Khach_San.Models
{
    /// <summary>
    /// Class used for customers to book tickets remotely
    /// </summary>
    public class Booking
    {
        public string HotelNo { get; set; }
        public string RoomNo { get; set; }
        public string CMTND { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Booking()
        {
        }

        public void Input()//Nếu mà danh sách khách sạn trống thì không được đặt phòng
        {
            if (DataController.getInstance().HotelList.Count == 0)
            {
                return;
            }

            bool isFind = false;
            Console.WriteLine("Nhap ma khach san: ");
            Hotel currentHotel = null;
            while (true)
            {
                HotelNo = Console.ReadLine();
                isFind = false;
                foreach (Hotel hotel in DataController.getInstance().HotelList)
                {
                    if (hotel.HotelNo == HotelNo)//Nếu nhập mã khách sạn mà không tồn tại trong danh sách thì yêu cầu nhập lại
                    {
                        currentHotel = hotel;//Nếu tìm thấy mã khách sạn thì khởi tạo khách sạn đó 
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    Console.WriteLine("Ma khach san khong tim thay. Nhap lai: ");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Nhap ma phong: ");
            while (true)
            {
                RoomNo = Console.ReadLine();
                isFind = false;
                foreach (Room room in currentHotel.RoomList)//Tìm mã phòng nếu không thấy thì yêu cầu nhập lại
                {
                    if (room.RoomNo == RoomNo)
                    {
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    Console.WriteLine("Ma phong khong tim thay. Nhap lai: ");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Nhap CMTND: ");
            CMTND = Console.ReadLine();
            isFind = false;
            foreach (Customer customer in DataController.getInstance().CustomerList)//Tìm mã CMND 
            {
                if (customer.CMTND == CMTND)//Nếu tìm thấy thì không cần tạo mới khách hàng
                {
                    isFind = true;
                    break;
                }
            }
            if (!isFind)//Nếu không tìm thấy thì sẽ tạo một khách hàng mới
            {
                Customer customer = new Customer(CMTND);
                customer.InputWithoutCMTND();

                DataController.getInstance().CustomerList.Add(customer);
            }

            Console.WriteLine("Nhap ngay nhan (yyyy-MM-dd HH:mm:ss): ");
            CheckIn = Utils.Utility.ConvertStringToDateTime(Console.ReadLine());

            Console.WriteLine("Nhap ngay tra (yyyy-MM-dd HH:mm:ss): ");
            CheckOut = Utils.Utility.ConvertStringToDateTime(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Ma KS: {0}, ma phong: {1}, CMTND: {2}, " +
                "Ngay nhan: {3}, ngay tra: {4}", HotelNo, RoomNo, CMTND,
                Utils.Utility.ConvertDateTimeToString(CheckIn), Utils.Utility.ConvertDateTimeToString(CheckOut));
        }
    }
}
