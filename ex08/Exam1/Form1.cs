using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int a1, a2;
        a1 =int.Parse(textBox1.Text);
        a2 = N_Sum(a1);
        label2.Text = "其結果為：" + a2.ToString();
    }

    private int N_Sum(int b1)
    {
      int I;
      int N1 = 1;
        for (I = 1 ;I<= b1; I++)
            N1 = N1 * I;
      return N1;
    }
  }
}
