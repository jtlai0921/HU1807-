using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer控制項
{
  public partial class Form1 : Form
  {
    int min = 0;
    int sec=0;
    int a = 0;
    int b = 0;

    public Form1()
    {
      InitializeComponent();
    }
    
    private void timer1_Tick(object sender, EventArgs e)
    {
      timer1.Interval = 10;
        b += 1;
        if (b == 10)
        {
            b = 0;
            a += 1;  
            if (a == 10) 
            {
                a = 0;
                sec += 1;
                trackBar1.Value += 1;
            
                if (trackBar1.Value == 60) 
                {
                  trackBar1.Value = 0;
                    if (sec == 60) {
                      sec = 0;
                        min += 1;
                    }
                }
            } 
        }
        textBox1.Text = min + "分" + sec + "秒" + a + b;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      timer1.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      timer1.Enabled = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      min = 0;
      sec = 0;
      a = 0;
      b = 0;
      trackBar1.Value = 0;
	    textBox1.Text = min + "分" + sec + "秒" + a + b;
    }
  }
}
