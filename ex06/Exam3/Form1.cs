using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int N1, Sum, J;
      Sum = 1;
      N1 = int.Parse(textBox1.Text); //取得階層數
      for (J = 1; J <= N1; J++)
        Sum = Sum * J;
      label2.Text = N1 + "階層的結果為：" + Sum.ToString();
    }
  }
}
