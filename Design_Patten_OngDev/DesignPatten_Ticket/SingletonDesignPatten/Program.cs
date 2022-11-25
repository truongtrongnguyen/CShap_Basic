using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonDesignPatten
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Singleton được sử dụng khi chúng ta muốn có duy nhất một thực thể (instance) tồn tại trong ứng dụng.
            //Và nó cần được truy cập toàn cục (globally access), Bên cạnh đó nó có thể được khởi tạo chỉ khi cần (lazy initialization) 

            //Mẫu thiết kế Singleton đảm bảo rằng một lớp chỉ có một thể hiện (instance) duy nhất. Do thể hiện này có tiềm năng sử dụng
            //trong suốt chương trình, nên mẫu thiết kế Singleton cũng cung cấp một điểm truy cập toàn cục đến nó.

            var thread1 = new Thread(() => OngDevSingleton.GetInstance().SaysHi());
            var thread2 = new Thread(() => OngDevSingleton.GetInstance().SaysHi());
            thread1.Start();
            thread2.Start();

            Task t2 = new Task(() => OngDevSingleton.GetInstance().SaysHi());
            Task t3 = new Task(() => OngDevSingleton.GetInstance().SaysHi());
            t2.Start();
            t3.Start();
            t2.Wait();
            t3.Wait();

            Console.ReadKey();
        }
    }
}
