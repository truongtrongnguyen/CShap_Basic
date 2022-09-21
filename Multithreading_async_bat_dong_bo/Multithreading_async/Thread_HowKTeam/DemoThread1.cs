using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_HowKTeam
{
    internal class DemoThread1
    {
        public static int n = 1000;
        public void Demo()
        {
            Thread thread = new Thread(MethodA);
            thread.Start();//hàm để gọi thread, phải là kiểu void và paramer nếu có phải là object

            Thread threadb = new Thread(MethodB);
            threadb.Start();
            Console.ReadLine();
        }
        public void MethodA()
        {
            for(int i=0;i<n;i++)
            {
                Console.Write("0");
            }    
        }
        public void MethodB()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("1");
            }
        }
    }
}
