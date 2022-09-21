using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

namespace Uri_Dns_Ping
{
    public class Uri_Dns
    {
        public void Demo1()
        {
            //Lấy ra các thông tin về Host, Scheme, Fragment, Query
            string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            var uri = new Uri(url);
            var uritype = typeof(Uri);
            uritype.GetProperties().ToList().ForEach(property =>
            {
                Console.WriteLine($"{property.Name,15} {property.GetValue(uri)}");
            });
            Console.WriteLine($"Segment: {string.Join(",", uri.Segments)}");
        }

        public void Demo2()
        {
            Console.WriteLine("Lay HostName cua may Local: ");
            var hostname = Dns.GetHostName();
            Console.WriteLine(hostname);
        }

        public void Demo3()
        {
            string url = "https://xuanthulab.net/";
            var uri = new Uri(url);
            var IPhostentry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine("Host cua duong link: " + IPhostentry.HostName);
            //Một tên miền có thể trỏ đến nhiều server
            IPhostentry.AddressList.ToList().ForEach(ip =>  //lấy ra các địa chỉ ip trỏ đến trang web đó
            {
                Console.WriteLine(ip);
            });
        }
        
        public void Demo_Ping()
        {
            // //Lớp Ping (System.Net.NetworkInformation.Ping), lớp này cho phép ứng dụng xác định một
            // // máy từ xa (như server, máy trong mạng ...) có phản hồi không.
            //using System.Net.NetworkInformation;

            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn"); //tham số của Send có thể là domain hoặc là ip: 216.24.57.253
            if (pingReply.Status==IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }
        }
    }
}
