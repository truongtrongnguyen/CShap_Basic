using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Khach_San.Models
{
    internal class DataController
    {
        public List<Customer> CustomerList { get; set; }
        public List<Hotel> HotelList { get; set; }
        public List<Booking> BookingList { get; set; }

        public static DataController instance = null;//Tạo một đối tượng thuộc class DataController

        private DataController()
        {
            CustomerList = new List<Customer>();
            HotelList = new List<Hotel>();
            BookingList = new List<Booking>();
        }

        public static DataController getInstance()
        {
            if (instance == null)
            {
                instance = new DataController();
            }
            return instance;
        }

        public Hotel FindHotel(string hotelNo)
        {
            foreach (Hotel hotel in HotelList)
            {
                if (hotel.HotelNo == hotelNo)
                {
                    return hotel;
                }
            }
            return null;
        }
    }
}
