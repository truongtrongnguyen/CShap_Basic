using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class DataController
    {
        public List<Customer> CustomerList { get; set; }
        public List<Hotels> HotelList { get; set; }
        public Edit_Info Edit_info { get; set; }
        public List<Book> BookingList { get; set; }
        public static DataController instance=null;
        private DataController()
        {
            CustomerList = new List<Customer>();
            HotelList = new List<Hotels>();
            BookingList = new List<Book>();
            Edit_info = new Edit_Info();
        }
        public static DataController getInstance()//Tạo một đối tượng thuộc lớp DataController
        {
            if (instance == null)
            {
                instance = new DataController();
            }
            return instance;
        }
        public DateTime Convert_StringToDateTime(string date)
        {
            DateTime outputDateTimeValue;
            DateTime.TryParseExact(date, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out outputDateTimeValue);
            return outputDateTimeValue;
        }
        public Hotels FindHotels(string hotlesNo)
        {
            foreach (Hotels h in HotelList)
            {
                if (hotlesNo.Equals(h.HotelNo))
                {
                    return h;
                }
            }
            return null;
        }

        public bool Check_Hotels_Available()
        {
            if (HotelList.Count == 0)
            {
                Console.WriteLine("Chua co Hotel nao duoc them vao");
                return false;
            }
            return true;
        }
        public bool Check_Book_Available()
        {
            if (BookingList.Count == 0)
            {
                Console.WriteLine("Chua co khach hang nao dat phong");
                return false;
            }
            return true;
        }
        public bool Check_Customer_Available()
        {
            if (CustomerList.Count == 0)
            {
                Console.WriteLine("Chua co khach hang nao trong danh sach");
                return false;
            }
            return true;
        }

    }
}
