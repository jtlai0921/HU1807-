using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam4
{
  public partial class Form1 : Form
  {
    int a1;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      a1 = int.Parse(textBox1.Text);
      square();
    }
    void square()
    {
      label2.Text = "其結果為：" + a1 + "*" + a1 + "=" + a1 * a1;
    }       
  }
}
