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
        int i=0;
        string StrMsg;
        StrMsg = "";
        //**判斷第一題的答題情況
        if (radioButton1.Checked) 
            i += 1;
        else
            StrMsg += "第一題答錯！" + Environment.NewLine;

        //**判斷第二題的答題情況
        if (radioButton3.Checked)
            i += 1;
        else
            StrMsg += "第二題答錯！" + Environment.NewLine;

        if (i == 2)  StrMsg = "恭喜您全部答對！";
        MessageBox.Show(StrMsg, "測驗結果");
    }
  }
}
