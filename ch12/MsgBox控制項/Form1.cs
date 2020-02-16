using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgBox控制項
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
       int MsgResult;
        MsgResult = (int) MessageBox.Show("您是否常使用.net 系列語言呢?", "詢問",
        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        if ((int) DialogResult.Yes == MsgResult) //按下「是」按鈕
          textBox1.Text = "感謝您的愛用";
        else if ((int) DialogResult.No == MsgResult)  //按下「否」按鈕
            textBox1.Text = "多使用會發現它的好處唷";
        else if ((int) DialogResult.Cancel == MsgResult)  //按下「取消」按鈕
            textBox1.Text = "您按了取消鍵";
    }
  }
}
