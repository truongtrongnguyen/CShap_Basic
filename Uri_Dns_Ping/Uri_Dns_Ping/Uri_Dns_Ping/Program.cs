using System;
using System.IO;
using System.Threading.Tasks;
namespace Uri_Dns_Ping
{
    internal class Program
    {
        //System.Net
        //System.Net.Mail
        //System.Net.NetworkInformation
        //System.Net.Http
        static async Task Main(string[] args)
        {
            //Uri_Dns uri = new Uri_Dns();
            //uri.Demo3();
            //uri.Demo_Ping();

            Truy_van_GET_toi_HttpServer tr = new Truy_van_GET_toi_HttpServer();
            //string url = "https://www.google.com/search?q=xuanthulab";


            #region Sử dụng phương thức 1
            //string url = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
            //var html=await tr.DownLoadDataByte(url);
            //FileStream file = new FileStream("D://temp/tem.png", FileMode.Create, FileAccess.Write);
            //file.Write(html, 0, html.Length);
            #endregion


            #region - Sử dụng phương thức ReadAsByteArrayAsync
            //string url2 = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";

            ////var bytes = await tr.Downloadstream(url2);

            //string path = @"D:/temp/tem.png";

            //await tr.Downloadstream(url2, path);
            //Console.WriteLine("Hello World!");
            #endregion

            Su_dung_SendAsync se = new Su_dung_SendAsync();
            se.Demo2();

            Console.ReadLine();
        }


    }
}
