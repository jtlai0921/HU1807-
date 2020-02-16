using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num1, num2;
        num1 = int.Parse(textBox1.Text);
        num2 = int.Parse(textBox2.Text);
        test(ref num1, ref num2);
        label3.Text = "數字1加10=" + num1 + " 數字2+加10=" + num2;
    }

    void test(ref int a1, ref int a2)
    {
        a1 += 10;
        a2 += 10;
    }
  }
}
