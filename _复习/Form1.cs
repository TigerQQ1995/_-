using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listsongs = new List<string>();
        SoundPlayer sp;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"F:\迅雷下载\music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径
            string[] path=ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件名加载到listbox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                listsongs.Add(path[i]);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            sp.SoundLocation = listsongs[listBox1.SelectedIndex];
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listsongs[index];
            sp.Play();
        }
    }
}
