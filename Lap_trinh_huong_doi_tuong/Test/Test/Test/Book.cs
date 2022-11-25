using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Book
    {
        public string NoBook { get; set; }
        public string CMND { get; set; }
        public string HotelsNo { get; set; }
        public string RoomNo { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public string currentBook { get; set; }
        public Customer CustomerBook { get; set; }
        public Book()
        { }
        public Book(string cmnd, string hotelsno, string roomno, DateTime checkin, DateTime checkout, string noBook)
        {
            CMND = cmnd;
            HotelsNo = hotelsno;
            RoomNo = roomno;
            Check_In = checkin;
            Check_Out = checkout;
            NoBook = noBook;
        }
        public Hotels Check(string hotelsno)
        {
            foreach (var i in DataController.getInstance().HotelList)
            {
                if (hotelsno.Equals(i.HotelNo))
                {
                    return i;
                }
            }
            return null;
        }

        public int So_Ngay()
        {
            // Tháng có 31 ngày: 1, 3, 5, 7, 8, 10, 12
            // Tháng có 30 ngày: 4, 6, 9, 11
            // Tháng 2 có 28 ngày - không nhuận
            // Tháng 2 có 29 ngày - nhuận
          //  int sumDay = 0;
          //  int Day_CheckIn = 0;
          //  int Day_CheckOut = 0;
          //  if(Check_Out.Day>=Check_In.Day&& Check_Out.Month == Check_In.Month)
          //  {
          //      sumDay = Check_Out.Day - Check_In.Day;
          //  }

          //  // Thang co 31 ngay
          //  if (Check_In.Month == 1 || Check_In.Month == 3 || Check_In.Month == 5 || Check_In.Month == 7 ||
          //      Check_In.Month == 8 || Check_In.Month == 10 || Check_In.Month == 12)
          //  {
          //       Day_CheckIn = 31 - Check_In.Month;
          //  }
          //  // Thang co 30 ngay
          //  if(Check_In.Month == 4 || Check_In.Month == 6 || Check_In.Month == 9 || Check_In.Month == 11)
          //  {
          //      Day_CheckIn = 30 - Check_In.Month;
          //  }

          //  if (Check_Out.Month == 1 || Check_Out.Month == 3 || Check_Out.Month == 5 || Check_Out.Month == 7 ||
          //Check_Out.Month == 8 || Check_Out.Month == 10 || Check_Out.Month == 12)
          //  {
          //      Day_CheckOut = Check_Out.Month;
          //  }
            TimeSpan time = Check_Out - Check_In;
            int value= time.Days;
            return value;
        }

        public void Input()
        {
            if (DataController.getInstance().HotelList.Count == 0)//Nếu khách sạn đang trống thì không được đặt phòng
            {
                Console.WriteLine("Chua co Hotel nao duoc them vao");
                return;
            }
            Console.Write("Nhap ma Book: ");
            NoBook = Console.ReadLine();

            bool isFind = false;
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            foreach (var i in DataController.getInstance().CustomerList)
            {
                if (CMND.Equals(i.CMND))
                {
                    CustomerBook = i;
                    isFind = true;
                }
            }
            if (!isFind)
            {
                Console.WriteLine("Thong tin khach hang chua ton tai! Vui long tao moi khach hang...");
                Customer customer = new Customer(CMND);//Tạo một khách hàng mới với thông số là CMND
                customer.Input();
                CustomerBook = customer;
                DataController.getInstance().CustomerList.Add(customer);
            }

            Input_Edit();
        }

        public void Input_Edit()
        {
            //Console.Write("Nhap CMND: ");
            //CMND = Console.ReadLine();
            bool isFind = false;
            Hotels currenthotels = null;
            while (true)
            {
                Console.Write("Nhap ma hotels: ");
                HotelsNo = Console.ReadLine();
                if (Check(HotelsNo) != null)
                {
                    currenthotels = Check(HotelsNo);
                    break;
                }
                else
                {
                    Console.WriteLine("Ma khach san khong tim thay vui long nhap lai");
                }
            }
            // Khi nào nhập đúng khách sạn ở trên thì mới đến nhập mã phòng
            isFind = false;
            Console.Write("Nhap ma phong: ");
            while (true)
            {
                RoomNo = Console.ReadLine();
                foreach (var i in currenthotels.RoomList)
                {
                    if (RoomNo.Equals(i.RoomNo) && i.isRoomEmty.Equals("Trong"))
                    {
                        currentBook = i.isRoomEmty = "Da dat";    // Cập nhật phòng đã có người đặt
                        isFind = true;
                        break;
                    }
                }
                if (!isFind)
                {
                    Console.WriteLine("Ma phong khong tim thay hoac da co nguoi Book, Vui long nhap lai");
                }
                else if (isFind)
                {
                    break;
                }
            }
            Console.Write("Nhap ngay dat (yyyy/MM/dd): ");
            Check_In = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());
            Console.Write("Nhap tra (yyyy/MM/dd): ");
            Check_Out = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());
        }


        public void Display()
        {
            Console.WriteLine($"Ma Book: {NoBook} | CMND: {CMND} | Ma hotels: {HotelsNo} | RoomNo: {RoomNo} | " +
                $"Ngay dat:{Check_In.Day}/{Check_In.Month}/{Check_In.Year} | " +
                $"Ngay tra: {Check_Out.Day}/{Check_Out.Month}/{Check_Out.Year} | " +
                $"Tinh trang Book: {currentBook} | Tong Ngay: {So_Ngay()}");
            Console.WriteLine(GetRelativeTime(Check_In, Check_Out));
        }




        public string GetRelativeTime(DateTime CheckIn, DateTime CheckOut)
        {
            TimeSpan difference = CheckOut - CheckIn.ToUniversalTime();
            TimeSpan positive = TimeSpan.FromSeconds((int)Math.Abs(difference.TotalSeconds));
            Console.WriteLine("Tong thoi gian la: " + positive);

            if (positive.TotalSeconds == 0)
                return "Ngay bây giờ";

            string relativeTime = GetOffset(positive);
            string suffix = GetSuffix(difference);

            return string.Format("{0} {1}", suffix, relativeTime);
        }
        private string GetOffset(TimeSpan positive)
        {
            if (positive.Days >= 365)
                return GetOffsetWords(positive.Days / 365, "năm");
            else if (positive.Days >= 7)
                return GetOffsetWords(positive.Days / 7, "tuần");
            else if (positive.Days >= 1)
                return GetOffsetWords(positive.Days, "ngày");
            else if (positive.Hours >= 1)
                return GetOffsetWords(positive.Hours, "giờ");
            else if (positive.Minutes >= 1)
                return GetOffsetWords(positive.Minutes, "phút");
            else
                return GetOffsetWords(positive.Seconds, "giây");
        }

        private string GetOffsetWords(int offset, string unit)
        {
            return string.Format("{0} {1}", offset, unit);
        }

        private string GetSuffix(TimeSpan difference)
        {
            return difference.TotalSeconds > 0 ? "cách đây" : "tương lai";
        }
    }
}
