using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double S1, S2, M1, M2;
        int v1, v2, v3, v4, v5, v6;
        v1 = int.Parse(textBox1.Text);
        v2 = int.Parse(textBox2.Text);
        v3 = int.Parse(textBox3.Text);
        v4 = int.Parse(textBox4.Text);
        v5 = int.Parse(textBox5.Text);
        v6 = int.Parse(textBox6.Text);
        S1 = v1 + v2 + v3 + v4 + v5 + v6;
        S2 = Math.Pow(v1, 2) + Math.Pow(v1, 2) + Math.Pow(v1, 2) +
             Math.Pow(v1, 2) + Math.Pow(v1, 2) + Math.Pow(v1, 2);
        M1 = S1 / 6; //平均值
        textBox7.Text = M1.ToString();
        M2 = S2 / 6;
    }
  }
}
