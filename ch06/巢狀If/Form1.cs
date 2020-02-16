using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 巢狀If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Month1;
            Month1 = int.Parse(textBox1.Text);
            if (Month1 >= 1 && Month1 <= 3) 
                label2.Text = "現在是第一季";
            else if (Month1 > 3 && Month1 <= 6)
                label2.Text = "現在是第二季";
            else if (Month1 > 6 && Month1 <= 9)
                label2.Text = "現在是第三季";
            else
                label2.Text = "現在是第四季";
        }
    }
}
