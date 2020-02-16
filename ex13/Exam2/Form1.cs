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

    private void 綠色ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Green; //選擇「綠色」項目時將前景顏色變更為綠色
      richTextBox1.BackColor = Color.Yellow; //選擇「黃色」項目時將背景顏色變更為黃色
    }

    private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Black; //選擇「黑色」項目時將前景顏色變更為黑色
      richTextBox1.BackColor = Color.Red; //選擇「紅色」項目時將背景顏色變更為紅色
    }

    private void 黃色ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Yellow; //選擇「黃色」項目時將前景顏色變更為黃色
      richTextBox1.BackColor = Color.Blue; //選擇「藍色」項目時將背景顏色變更為藍色
    }

    private void 紅色ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      richTextBox1.ForeColor = Color.Red; //選擇「紅色」項目時將前景顏色變更為紅色
      richTextBox1.BackColor = Color.Green; //選擇「綠色」項目時將背景顏色變更為綠色
    }
  }
}
