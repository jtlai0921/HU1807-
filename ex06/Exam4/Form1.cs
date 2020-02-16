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
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int Num1;
        string Str1;
        Num1 = int.Parse(textBox1.Text);
        Str1 = "";
        switch (Num1) 
        {
          case 1:
                Str1 = "壹";
                  break;
          case 2:
                Str1 = "貳";
                break;
            case 3:
                Str1 = "參";
                break;
            case 4:
                Str1 = "肆";
                break;
            case 5:
                Str1 = "伍";
                break;
            case 6:
                Str1 = "陸";
                break;
            case 7:
                Str1 = "柒";
                break;
            case 8:
                Str1 = "捌";
               break;
            case 9:
                Str1 = "玖";
                break;
            case 0:
                Str1 = "零";
                break;
        }
        label2.Text = Num1 + "相對應的國字為：" + Str1;
    }
  }
}
