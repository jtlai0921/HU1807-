using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam9
{
  public partial class Form1 : Form
  {
    int I, Sum;
    double AVG;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        I = 1;
        Sum = 0;
        label2.Text = I.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Sum += int.Parse(textBox1.Text);
        I += 1;
        label2.Text = I.ToString();
        textBox1.Text = "";
        textBox1.Focus();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        AVG = Sum / (I - 1);
        label2.Text = "共有" + (I - 1) + "位同學，其總成績為：" + Sum + Environment.NewLine;
        label2.Text += "其平均成績為：" + AVG;
    }
  }
}
