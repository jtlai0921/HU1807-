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
        int a1, S2;
        a1 = int.Parse(textBox1.Text);
        S2 = Res_Sum(a1);
        label2.Text = "總購買金額為：" + S2.ToString() + "元";
    }

    private static int Res_Sum(int num)
    {
      int S1 = 0;
      if (num <=10)
        S1 = (int) ((560 * num) * 0.95);
      else if (num >=11 && num<=30)
        S1 = (int) ((560 * num) * 0.8);
      else if (num >=31 && num<=50)
        S1 = (int) ((560 * num) * 0.7);
      else
        S1 = (int) ((560 * num) * 0.5);
        return S1;
    }
  }
}
