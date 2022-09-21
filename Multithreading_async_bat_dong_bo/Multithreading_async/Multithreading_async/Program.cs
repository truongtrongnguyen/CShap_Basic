using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace Multithreading_async
{
    using System.IO;
    internal class Program
    {
        static async Task Abc()
        {
            //Task task = new Task(() =>
            //{

            //});
            //task.Start();
            //await task; 
            //hoặc
            //await File.WriteAllLinesAsync("WriteLines.txt", "ssds");
        }
        static async Task Main(string[] args) //Biến hàm Main thành phương thức bất đồng bộ, sử dụng async bắt buộc phải có await
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Bất đồng bộ asynchronous - dotnet cho phép ta tạo ra nhiều tác vụ có thể chạy song song với nhau,chạy đồng thời với nhau
            // và có thể chạy trên nhiều luồng khác nhau

            #region Sử dụng lớp Task không có kiểu trả về

            //Task T2 = Task2();
            //Task T3 = Task3();

            ////T2.Start();//Khởi chạy tác vụ
            ////T3.Start(); //T2 chạy trên 1 Thread riêng và T3 cũng chay trên một Thread riêng
            //DoSomeThing(6, "eds", ConsoleColor.Red);  //Và dòng này cũng chạy trên một Thread riêng
            ////T2.Wait();//đảm bảo T2 phải hoàn thành xong mới thực hiện tác vụ khác
            ////T3.Wait();
            ////Task.WaitAll(T2, T3);
            //await T2;
            //await T3;

            #endregion

            #region Tác vụ khi hoàn thành có giá trị trả về 
            ////Task<T>
            //Task t4 = Task4();
            ////Task T5 = Task5();


            ////await T5;

            //var task = GetWeb(@"https://xuanthulab.net/lap-trinh-bat-dong-bo-asynchronou-c-c-sharp-voi-bat-dong-bo-theo-mo-hinh-tac-vu.html");
            //await t4;
            //var conten=await task;
            //Console.WriteLine(conten);
            #endregion

            Thi_hanh_song_song_voi_Parallel_For th = new Thi_hanh_song_song_voi_Parallel_For();
            th.Demo();

            Console.WriteLine("HelloWork");
            Console.ReadKey();
        }
        static async Task<string> GetWeb(string url)    //Phương thức tải một trang web 
        {
            HttpClient httpClient = new HttpClient();
            Console.WriteLine("Bat dau tai");
            HttpResponseMessage kq=await httpClient.GetAsync(url);//GetAsync là một phương thức bất đồng bộ để tải nội dung của trang web
            Console.WriteLine("Bat dau doc noi dung");
            string content=await kq.Content.ReadAsStringAsync();
            Console.WriteLine("Hoan thanh");
            return content;
        }


        static async Task<string> Task5()   //Tác vụ khi hoàn thành có giá trị trả về và có tham số
        {
            //Task<string> T5 = new Task<string>(Func<object, string>, object);
            Task<string> T5 = new Task<string>((object ob) =>
            {
                string t = (string)ob;
                DoSomeThing(3, t, ConsoleColor.DarkCyan);
                return "Return from " + t;
            }, "T5");
            T5.Start();
            var kq = await T5;
            Console.WriteLine("T5 da hoan thanh");
            Console.WriteLine(kq);
            return kq;
        }


        public static async Task<string> Task4()    //Tác vụ khi hoàn thành có giá trị trả về không có tham số
        {
            //Task<string> T4 = new Task<string>(Func<string>);
            Task<string> T4 = new Task<string>(() =>
            {
                DoSomeThing(5, "T4", ConsoleColor.DarkGreen);
                return "Return from T4";
            });
            T4.Start();
            var kq = await T4;//kết thúc đông thời trả về một chuỗi
            Console.WriteLine("T4 da hoan thanh");
            Console.WriteLine(kq);
            return kq;
        }


        static async Task Task2()//thêm từ khóa async
        {
            //Task t2 = new Task(() => { }); //delegate không tham số
            Task T2 = new Task(() =>
            {
                DoSomeThing(3, "T2", ConsoleColor.Green);
            });
            T2.Start();
            await T2;//await đảm bảo t2 hoàn thành những tác vụ trên mới thực thi những dòng lệnh bên dưới và nó sẽ không khóa đi cái T2 chính của hàm và không cần lệnh return
            Console.WriteLine("T2 da hoan thanh");
        }


        static async Task Task3()//tác vụ không có kiểu trả về và có nhận tham số
        {
            //Task t3 = new Task(Action<Object>, Object);  //Tham số Object1 tương đương là một biểu thức lambda, Object tương đương là tham số cho biểu thức lambda của Object1 
            Task T3 = new Task((object ob) =>
            {
                string tentacvu = (string)ob;   //chuỗi T3 được truyền vào ob là kiểu object và convert để truyền vào hàm
                DoSomeThing(8, tentacvu, ConsoleColor.Blue);
            }, "T3");
            T3.Start();
            await T3;
            Console.WriteLine("T3 da hoan thanh");
        }


        static void DoSomeThing(int seconds, string mgf, ConsoleColor color)
        {

            //string s = "";
            //lock(s)//tiến hành khóa biến s lại, chỉ được sử dụng trong scope
            //{
            //    // ra khỏi scope thì các đối tượng khác mới có thể được sử dụng biến s
            //}

            lock(Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mgf,10}...start");
                Console.ResetColor();
            }      
            for(int i=0;i< seconds; i++)
            {
               lock(Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{mgf,10} {i,5}");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                }
            }
            lock(Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mgf,10}...End");
                Console.ResetColor();
            }
        }
    }
}
