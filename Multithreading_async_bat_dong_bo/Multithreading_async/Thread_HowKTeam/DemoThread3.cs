using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_HowKTeam
{
    internal class DemoThread3
    {
        static int n = 1000;
        public void Demo()
        {
            Thread threada = new Thread(ThreadA);
            Thread threadb = new Thread(ThreadB);
            Thread threadc = new Thread(ThreadC);
            threada.Start();
            threadb.Start();
            threadb.Join();//-> Đợi thằng b chạy xong mới đến C

            threadc.Start();
        }
        public void ThreadA()
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("1 ");
            }    
        }
        public void ThreadB()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("2 ");
            }
        }
        public void ThreadC()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("3 ");
            }
        }
    }
}
