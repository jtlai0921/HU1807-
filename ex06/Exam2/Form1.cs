using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //列印9*9乘法表
        int I, J;
        for (I = 1;I<=9;I=I+3)
        {
          for (J = 1; J<= 10; J++)
          {
                if (J == 10)
                {
                    textBox1.Text += " ";
                    break;
                }
                textBox1.Text += I + " " + "x" + " " + J + "=" + I * J + "    " +
                                 (I + 1) + " " + "x" + " " + J + "=" + (I + 1) * J + "    " +
                                 (I + 2) + " " + "x" + " " + J + "=" + (I + 2) * J + "    " + Environment.NewLine;
          }
          textBox1.Text += Environment.NewLine;
        }
    }
  }
}
