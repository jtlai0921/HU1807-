using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam6_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //繪製正三角型
        int I, J, K, N;
        N = 1;
        for (I = 16; I>=1 ; I--)  //第一層
        {
          for (J = 1; J<=I; J++) //第二層
                //控制星號列印的位置
                if (J == I)
                    for (K = 1; K<=N ;K++) //第三層
                        textBox1.Text += "*";
                else
                    textBox1.Text += "  "; //列印空白字元
            N += 2; //設定左右位置每次增加二個字元
            textBox1.Text += Environment.NewLine; //換行顯示
        }
    }
  }
}
