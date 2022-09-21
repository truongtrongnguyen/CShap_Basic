using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Book
    {
        public string CMND { get; set; }
        public string HotelsNo { get; set; }
        public string RoomNo { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public Book()
        { }
        public Book(string cmnd, string hotelsno, string roomno, DateTime checkin, DateTime checkout)
        {
            CMND = cmnd;
            HotelsNo = hotelsno;
            RoomNo = roomno;
            Check_In = checkin;
            Check_Out = checkout;
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
        public void Input()
        {
            if(DataController.getInstance().HotelList.Count==0)//Nếu khách sạn đang trống thì không được đặt phòng
            {
                return;
            }
            bool isFind = false;
            Hotels currenthotels = null;
            while(true)
            {
                Console.Write("Nhap ma hotels: ");
                HotelsNo = Console.ReadLine();
                if (Check(HotelsNo) !=null)
                {
                    currenthotels = Check(HotelsNo);
                    break;
                }
                else
                {
                    Console.WriteLine("Ma khach san khong tim thay vui long nhap lai");
                }
            }

            isFind = false;
            Console.Write("Nhap ma phong: ");
            while(true)
            {
                RoomNo = Console.ReadLine();
                foreach(var i in currenthotels.RoomList)
                {
                    if(RoomNo.Equals(i.RoomNo))
                    {
                        isFind = true;
                        break;
                    }
                }
                if(!isFind)
                {
                    Console.WriteLine("Ma phong khong tim thay vui long nhap lai");
                }
                else
                {
                    break;
                }
            }
            isFind = false;
            Console.Write("Nhap CMND: ");
            CMND = Console.ReadLine();
            foreach(var i in DataController.getInstance().BookingList)
            {
                if(CMND.Equals(i.CMND))
                {
                    isFind = false;
                }
            }
           if(!isFind)
            {
                Customer customer = new Customer(CMND);//Tạo một khách hàng mới với thông số là CMND
                customer.Input();
                DataController.getInstance().CustomerList.Add(customer);
            }
            Console.Write("Nhap ngay dat (yyyy/MM/dd): ");
            Check_In = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());
            Console.Write("Nhap tra (yyyy/MM/dd): ");
            Check_Out = DataController.getInstance().Convert_StringToDateTime(Console.ReadLine());

        }
      
        public void Display()
        {
            Console.WriteLine($"CMND: {CMND} | Ma hotels: {HotelsNo} | RoomNo: {RoomNo} | Ngay dat:{Check_In.Day}/{Check_In.Month}/{Check_In.Year} | Ngay tra: {Check_Out.Day}/{Check_Out.Month}/{Check_Out.Year}");
        }
    }
}
