using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(this.Test);

             Thread th = new Thread(threadStart);
            // Thread th = new Thread(Test);
             th.IsBackground = true;
              th.Start();
                  
         // Test();

        }
        private void Test()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
