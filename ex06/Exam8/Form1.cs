using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam8
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int I, N, Sum, Sum1;
        Sum = 0;
        Sum1 = 0;
        N = int.Parse(textBox1.Text);
        //求總和
        for (I = 1;I<=N;I++)
            Sum = Sum + I;
        //求偶數和
        I = 0;
        do
        {
          Sum1 = Sum1 + I;
            I += 2;
        } while (I<=N);
        label2.Text = "總和為：" + Sum + Environment.NewLine;
        label2.Text += "偶數和為：" + Sum1;
    }
  }
}
