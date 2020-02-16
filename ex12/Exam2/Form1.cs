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
        double c1, Tem1;
        c1 = double.Parse(textBox1.Text);
        Tem1 = (9 * c1) / 5.0 + 32;
        label2.Text = "華氏溫度為：" + Tem1.ToString();
    }
  }
}
