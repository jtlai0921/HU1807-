using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam6_1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //顯示三角型
        int I, J;
        for (I = 1 ;I<=5; I++) //第一層
        {
          for (J = 1; J <= I; J++) //第二層
            textBox1.Text += "*";
          textBox1.Text += Environment.NewLine;
        }    
    }
  }
}
