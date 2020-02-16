using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, end1;
            int sum  = 0;
            end1 = int.Parse(textBox1.Text);
            for (i = 1 ;i<=end1;i++)
            {
                sum = sum + i;
            }
            label2.Text = sum.ToString();
        }
    }
}
