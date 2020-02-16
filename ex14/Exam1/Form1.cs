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

        a1 = int.Parse(textBox1.Text);
        try
        {
            a2 = (int) (10 / a1);
            label2.Text = a2.ToString();
        }
        catch (DivideByZeroException)
        {
            label2.Text = "除數為0";
        }
    }
  }
}
