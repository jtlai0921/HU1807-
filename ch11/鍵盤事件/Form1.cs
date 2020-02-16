using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鍵盤事件
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      label2.Text = "KeyDown";
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      label2.Text = "KeyPress";
    }

    private void Form1_KeyUp(object sender, KeyEventArgs e)
    {
      label2.Text = "KeyUp";
    }
  }
}
