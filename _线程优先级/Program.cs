using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _线程优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始执行：");
            SubThread subt = new SubThread();
            ThreadStart thrstart = new ThreadStart(subt.working);
            Thread wth1 = new Thread(thrstart);
            wth1.Name = "Subthr1";
            wth1.Priority = ThreadPriority.AboveNormal;
            Thread wth2 = new Thread(thrstart);
            wth2.Name = "Subthr2";
            wth2.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine("请等待3秒");
            wth1.Start();
            wth2.Start();
            Thread.Sleep(3000);
            subt.over = true;
           // Thread.Sleep(3000);
            wth1.Interrupt();
            wth2.Interrupt();
            wth1.Join();
            wth2.Join();
            Console.WriteLine("主线程结束");
            Console.Read();
        }
    }
}
