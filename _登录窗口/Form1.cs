using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _登录窗口
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Equals("钱勇") && this.textBox2.Text.Equals("123"))
            {
                MessageBox.Show("登陆成功！");
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
