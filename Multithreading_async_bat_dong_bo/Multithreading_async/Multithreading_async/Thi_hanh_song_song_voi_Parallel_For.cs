using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Multithreading_async
{
    internal class Thi_hanh_song_song_voi_Parallel_For
    {
        public void Demo()
        {

            //ParallelFor();
            ParallelInvoke();
        }
        //In thông tin, Task ID và Thread ID đang chạy
        public void PinInfo(string info)
        {
            Console.WriteLine($"{info,10}  task:{Task.CurrentId,3}" + $"  thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        //Phương thức phù hợp với Action<int>, được làm tham số action của Parallel.For
        public async void RunTask(int i)
        {
            PinInfo($"Start {i,3} ");
            //Task.Delay(1000).Wait();
            await Task.Delay(1);
            PinInfo($"Finish {i,3}");
        }
        public async void RunTask1(string i)
        {
            PinInfo($"Start {i,3} ");
            //Task.Delay(1000).Wait();
            await Task.Delay(1);
            PinInfo($"Finish {i,3}");
        }

        public void ActionA()
        {
            PinInfo($"Finish {"ActionA",10}");
        }
        public void actionB()
        {
            PinInfo($"Finish {"ActionB",10}");
        }
        public void ParallelInvoke()
        {
            Action action=() =>
            {
                RunTask1("Action1");
            };

            Parallel.Invoke(action, ActionA, actionB);
        }

        public void ParallelFor()
        {
            string[] source = new string[] {"xuanthulab1","xuanthulab2","xuanthulab3",
                                    "xuanthulab4","xuanthulab5","xuanthulab6",
                                    "xuanthulab7","xuanthulab8","xuanthulab9"};
            ParallelLoopResult result1 = Parallel.ForEach(source, RunTask1);

            //Vòng lặp tạo ra chạy 20 lần RunTask
            ParallelLoopResult result = Parallel.For(1, 20, RunTask);
            Console.WriteLine($"All task start and finish: {result1.IsCompleted}");
        }
    }

}
