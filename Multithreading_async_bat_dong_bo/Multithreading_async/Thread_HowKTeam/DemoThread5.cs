using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_HowKTeam
{
    internal class DemoThread5
    {
        static int n = 10;
        public void Demo()
        {
            ThreadPool.QueueUserWorkItem(ThreadA, "Lan 1");
            ThreadPool.QueueUserWorkItem(ThreadA, "Lan 2");
        }
        public void ThreadA(object a)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(a);
                Thread.Sleep(200);
            }
        }
        public void ThreadB(object a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                Thread.Sleep(200);
            }
        }
    }
}
