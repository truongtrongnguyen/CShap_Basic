using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_HowKTeam
{
    internal class DemoThread4
    {
        static int n = 1000;
        public void Demo()
        {
            //Forceground -> chương trình kết thúc phải đợi cho thread chạy xong mới dừng
            //Background -> Chương trình kết thúc thì Thread cũng bị hủy luôn
            //2 thằng này có độ ưu tiên ngang nhau trừ khi bạn set lại
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("1");
                }
            });
            thread.IsBackground = true;//mặc định nó sẽ là ForceGround nên ta cần set lại
            thread.Start();
        }
    }
}
