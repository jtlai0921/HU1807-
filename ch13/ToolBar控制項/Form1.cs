using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBar控制項
{
  public partial class toolBar1 : Form
  {
    public toolBar1()
    {
      InitializeComponent();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      richTextBox1.Font = new Font("新細明體", 12, FontStyle.Bold);
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      richTextBox1.Font = new Font("新細明體", 12, FontStyle.Italic);
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      richTextBox1.Font = new Font("新細明體", 12, FontStyle.Underline);
    }
  
  }
}
