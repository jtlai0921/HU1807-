using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int result;
        int length, width;
        length = int.Parse(textBox1.Text);
        width = int.Parse(textBox2.Text);
        result = Area(length, width);
        label3.Text = "長方形面積= " + result;
    }

    int Area(int intL, int intW )
    {
        return intL * intW;
    } 
  }
}
