using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _数据传递委托
{
    class ParameterThreadstartTest
    {
        public static void Addresult(object data)
        {
            if (data is AddNum)
            {
                Console.WriteLine("---启动{0}线程---", Thread.CurrentThread.Name);
                AddNum numbers = (AddNum)data;
                Console.WriteLine("{0}+{1}={2}", numbers.a, numbers.b, numbers.a + numbers.b);
                Console.WriteLine("---{0}线程结束---", Thread.CurrentThread.Name);
            }
        }
    }
}
