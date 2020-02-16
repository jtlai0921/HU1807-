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
      //實作1
        int Yearpon;
        int Work_age;
        Work_age = int.Parse(textBox1.Text);
        switch (Work_age)
        {
          case 0://未滿一年
                Yearpon = 0;
                break;
          case 1: //滿1年未滿3年
          case 2:
                Yearpon = 1;
                break;
          case 3://滿3年未滿6年
          case 4:
          case 5:
                Yearpon = 3;
                break;
          default: //滿6年以上
                Yearpon = 5;
                break;
        }
        textBox2.Text = "此員工的年終獎金為：" + Yearpon + "個月";
    }
  }
}
