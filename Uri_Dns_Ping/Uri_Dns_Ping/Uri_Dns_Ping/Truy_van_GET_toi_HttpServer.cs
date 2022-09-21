using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
namespace Uri_Dns_Ping
{
    public class Truy_van_GET_toi_HttpServer
    {
        public async Task<string> GetWebContent(string url)
        {
            using HttpClient httpclient = new HttpClient(); //Khởi tại httpclient

            try
            {
                //Thiết lập Headers gửi đi cho Server
                httpclient.DefaultRequestHeaders.Add("User-Age", "Mozilla/5.0");    
                    
                HttpResponseMessage httpRequestMessage = await httpclient.GetAsync(url);     //B2: Thực hiện truy vấn với GetAsync

                ShowHeaders(httpRequestMessage.Headers);
                Console.WriteLine();

                string html = await httpRequestMessage.Content.ReadAsStringAsync(); //B3: Đọc nội dung truy vấn
                return html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Loi";
            }
        }

        public async Task<byte[]> DownLoadDataByte(string url)
        {
            try
            {
                HttpClient httpclient = new HttpClient();

                HttpResponseMessage httpResponseMessage = await httpclient.GetAsync(url);

                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                return bytes;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task Downloadstream(string url, string filename)
        {
            HttpClient httpclient = new HttpClient(); //B1: Khởi tạo HttpCLient
            try
            {
                var htttpReponseMessage = await httpclient.GetAsync(url);    //B2: Thực hiện truy vấn

                using var stream = await htttpReponseMessage.Content.ReadAsStreamAsync();    //B3: Đọc nội dung truy vấn

                using var streamfile = File.OpenWrite(filename);//tạo một file khác để tiếp tục đọc nếu đọc chưa thành công

                int SIZEBUFFER = 500;//tạo ra bộ đệm có kích thước là 500byte
                var bytes = new byte[SIZEBUFFER];//Tạo ra một vùng đệm

                bool endread = false;
                do
                {
                    int numByte = await stream.ReadAsync(bytes, 0, SIZEBUFFER);   // phương thức ReadAsync trả về kiểu int 
                    //nếu nó trả về 0 byte tức là nó đang ở cuối stream, là đọc thành công, ngược lại thì ta phải tạo một file khác để đọc từ file 
                    // đang đọc hiện tại qua file đó
                    if (numByte == 0)
                    {
                        endread = true;
                    }
                    else
                    {
                        await streamfile.WriteAsync(bytes, 0, numByte);
                    }

                } while (!endread);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ShowHeaders(HttpResponseHeaders headers)
        {
            Console.WriteLine("CAC HEADERS: ");
            foreach(var header in headers)
            {
                Console.WriteLine($"{header.Key} : {header.Value}");
            }
        }
    }
}
