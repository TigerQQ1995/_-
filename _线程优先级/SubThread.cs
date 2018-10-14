using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _线程优先级
{
    class SubThread
    {
        public bool over = false;
        public void working()
        {
            long number = 0;
            Console.WriteLine("{0}子线程开始运行，", Thread.CurrentThread.Name);
            Console.WriteLine("优先级：{0}", Thread.CurrentThread.Priority);
            while (!over)
            {
                number++;
            }
            Console.WriteLine("{0}子线程，先累计到{1}", Thread.CurrentThread.Name, number);
            try
            {
                Thread.Sleep(Timeout.Infinite);
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine("{0}被中断，" + ex.Message, Thread.CurrentThread.Name);
            }
            Console.WriteLine("---子线程结束---", Thread.CurrentThread.Name);
        }
    }
}
