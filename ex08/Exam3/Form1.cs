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
        int[] a1 =new int[4];
        a1[0] = int.Parse(textBox1.Text);
        a1[1] = int.Parse(textBox2.Text);
        a1[2] = int.Parse(textBox3.Text);
        a1[3] = int.Parse(textBox4.Text);
        Array.Sort(a1);
        label5.Text = "最大值為：" + a1[3].ToString();
    }
  }
}
