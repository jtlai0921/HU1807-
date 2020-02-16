using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace continue指令
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0, sum=0;
            do
            {
                i = i + 1;
                if (i % 2 == 0)
                    continue;
                sum = sum + i;
            } while (i < 10);
            textBox1.Text = sum.ToString();
        }
    }
}
