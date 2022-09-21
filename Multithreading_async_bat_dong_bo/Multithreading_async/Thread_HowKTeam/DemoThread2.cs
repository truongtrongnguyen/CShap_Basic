using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Thread_HowKTeam
{
    internal class DemoThread2
    {
        //hàm để gọi thread, phải là kiểu void và paramer nếu có phải là object
        public void Demo()
        {
            Thread thread = new Thread(Prints);
            

            int n = 5;
            string s = "Long dep trai";
            object obj = new Tuple<string, int>(s,n);
            thread.Start(obj);
        }
        public void Prints(object ob)//bắt buộc phải là kiểu object
        {
            Tuple<string, int> tuple = ob as Tuple<string, int>;

            string str = tuple.Item1;
            int n = tuple.Item2;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(str);
            }    
        }
    }
}
