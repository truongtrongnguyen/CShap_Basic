using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Uri_Dns_Ping
{
    internal class Su_dung_SendAsync
    {
        public async Task Demo()
        {
            var httpclient = new HttpClient();

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();

            httpRequestMessage.Method = HttpMethod.Get;

            httpRequestMessage.RequestUri = new Uri("https://www.google.com.vn");
            httpRequestMessage.Headers.Add("User-Age", "Mozilla/5.0");

            HttpResponseMessage httpResponseMessage = await httpclient.SendAsync(httpRequestMessage);

            var html = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(html);
        }
        public async Task Demo2()
        {
            HttpClient httpclient = new HttpClient();   //Khởi tạo httpclient

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();   //Thiết lập yêu cầu lên server

            httpRequestMessage.Method = HttpMethod.Post;    //Chọn phương thức yêu cầu Get, Post, Put...

            httpRequestMessage.RequestUri = new Uri("https://postman-echo.com/post");
            httpRequestMessage.Headers.Add("User-Age", "Mozilla/5.0");

            #region - UpLoad dữ liệu lên server Cách 1
            //httpMessageRequest.Content  => FormatException html, File,...
            //Post =>  FORM HTML
            /*
                key1=> value1                       tương tự [INPUT] trong html
                key2=> [value2-1, value2-2]                 [Multi Select] trong html
            */

            //var parameter = new List<KeyValuePair<string, string>>();
            //parameter.Add(new KeyValuePair<string, string>("key1", "value1"));
            //parameter.Add(new KeyValuePair<string, string>("key2", "value2-1"));
            //parameter.Add(new KeyValuePair<string, string>("key2", "value2-2"));
            //var content = new FormUrlEncodedContent(parameter);

            #endregion

            #region - Cách 2
            string data = @"{
            ""key1"":""value1"",
            ""key2"": ""value2-1""
            }";
            //            var content = new StringContent(data, Encoding.UTF8, "application/json");
            #endregion

            #region Cách 3
            var content = new MultipartFormDataContent();

            Stream filestream = File.OpenRead("D://temp/1.txt");   //Mở file để đọc
            StreamContent fileUpload = new StreamContent(filestream); //Tạo nội dung đính kèm vào httpRequest

            content.Add(fileUpload, "fileupload", "abcdef");

            //UPLOAD CHUỖI
            content.Add(new StringContent("value1"), "key1");

            content.Add(new StringContent(data, Encoding.UTF8, "application/json"));

            #endregion

            httpRequestMessage.Content = content;
            HttpResponseMessage httpResponseMessage = await httpclient.SendAsync(httpRequestMessage);
            var html = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(html);

        }
    }
}
