using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _多线程2
{
    class SubThread
    {
        int number;
        public Thread workthrd;
        public SubThread(string name)
        {
            number = 0;
            ThreadStart threadStart = new ThreadStart(this.Working);
            workthrd = new Thread(threadStart);
            workthrd.Name = name;
            workthrd.Start();
        }
        public void Working()
        {
            Console.WriteLine("---{0}子线程开始执行---", workthrd.Name);
            while (number <= 10)
            {
                Thread.Sleep(300);
                Console.WriteLine("{0}子线程，先累计到{1}", workthrd.Name, number);
                number++;

            }
            Console.WriteLine("---{0}子线程结束---", workthrd.Name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始执行：");
            SubThread subt1 = new SubThread("subt1");
            SubThread subt2 = new SubThread("subt2");
            SubThread subt3 = new SubThread("subt3");
            subt1.workthrd.Join();     //杀死主进程
            subt2.workthrd.Join();
            subt3.workthrd.Join();
            Console.WriteLine("主线程结束。");
            Console.Read();
        }
    }
}
