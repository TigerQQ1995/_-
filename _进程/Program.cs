using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _进程
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Process[] pros=Process.GetProcesses();
               foreach (var item in pros)
               {
                   Console.WriteLine(item);
               }
               Process.Start("calc");
               */
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\ZMH\Desktop\窗口程序.docx");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();

            Console.ReadKey();
        }
    }
}
