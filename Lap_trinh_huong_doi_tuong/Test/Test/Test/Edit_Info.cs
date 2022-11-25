using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Edit_Info
    {
        public void Edit_General()
        {
            Console.Write("Nhap ma Hotels: ");
            string NoHotel = Console.ReadLine();
            foreach(var i in DataController.getInstance().HotelList)
            {
                if (NoHotel.Equals(i.HotelNo)){
                    i.Input();
                    return;
                }
            }
        }

        public void Edit_Hotels ()
        {
            Console.Write("Nhap ma Hotels: ");
            string NoHotel = Console.ReadLine();
            foreach (var i in DataController.getInstance().HotelList)
            {
                if (NoHotel.Equals(i.HotelNo))
                {
                    Console.WriteLine("\t CHINH SUA THONG TIN HOTELS");
                    i.Input_Edit();
                    return;
                }
            }
            Console.WriteLine("Ma Hotels khong tim thay, Vui long thu lai sau");
        }

        public void Edit_Room()
        {
            Console.Write("Nhap ma Hotels: ");
            string NoHotel = Console.ReadLine();
            foreach (var i in DataController.getInstance().HotelList)
            {
                if (NoHotel.Equals(i.HotelNo))
                {
                    Console.Write("Nhap ma Room: ");
                    string NoRoom = Console.ReadLine();
                    foreach (var j in i.RoomList)
                    {
                        if (NoRoom.Equals(j.RoomNo))
                        {
                            Console.WriteLine("\t CHINH SUA THONG TIN ROOM");
                            j.Edit_Room();
                            return;
                        }
                    }      
                }  
            }
            Console.WriteLine("Ma Room khong tim thay, Vui long thu lai sau");
        }

        public void Edit_Customer(bool isCheck)
        {
            DataController.getInstance().Check_Customer_Available();
            Console.Write("Nhap ma CMND hoac ho ten khach hang: ");
            string cmnd = Console.ReadLine();
            foreach (var i in DataController.getInstance().CustomerList)
            {
                if (cmnd.Equals(i.CMND)||cmnd.Equals(i.Name))
                {
                    if (isCheck)
                    {
                        Console.WriteLine("\t CHINH SUA THONG TIN CUSTOMER");
                        i.Input();
                        return;
                    }
                    else
                    {
                        i.Display();
                        return;
                    }
                }
            }
            Console.WriteLine("Ma Customer khong tim thay, Vui long thu lai sau");
        }

        public void Edit_Book()
        {
            Console.Write("Nhap ma Book: ");
            string NoBook = Console.ReadLine();
            foreach (var i in DataController.getInstance().BookingList)
            {
                if (NoBook.Equals(i.NoBook))
                {
                   foreach(var j in DataController.getInstance().HotelList)
                    {
                        if (j.HotelNo.Equals(i.HotelsNo))
                        {

                            foreach(var x in j.RoomList)
                            {
                                if (x.RoomNo.Equals(i.RoomNo))
                                {
                                    x.Input_Defalut();
                                    Console.WriteLine("\t CHINH SUA THONG TIN BOOK");
                                    i.Input_Edit();
                                    return;
                                }
                            }
                            //Console.WriteLine("\t CHINH SUA THONG TIN CUSTOMER");
                            //i.Input_Edit2(j);
                            //return;
                        }
                    }
                    
                }
            }
            Console.WriteLine("Ma Book khong tim thay, Vui long thu lai sau");
        }
    }
}
