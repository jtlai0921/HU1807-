using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 快顯功能表
{
  public partial class ContextMenu : Form
  {
    public ContextMenu()
    {
      InitializeComponent();
    }

    private void MenuItem1_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Green; //選擇「綠色」項目時將前景顏色變更為綠色
    }

    private void MenuItem2_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Black; //選擇「黑色」項目時將前景顏色變更為黑色
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Yellow; //選擇「黃色」項目時將前景顏色變更為黃色
    }

    private void MenuItem4_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Red; //選擇「紅色」項目時將前景顏色變更為紅色
    }
  }
}
