using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _数据传递委托
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("启动主线程：");
            AddNum addnum = new AddNum(3, 5);
            ParameterizedThreadStart pthrstart = new ParameterizedThreadStart(ParameterThreadstartTest.Addresult);
            Thread mythr = new Thread(pthrstart);
            mythr.Name = "Subthr";
            mythr.Start(addnum);
            //mythr.Join();
            Console.WriteLine("主线程结束。");
            Console.Read();
        }
    }
}
