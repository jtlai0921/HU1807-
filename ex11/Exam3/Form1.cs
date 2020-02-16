using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3
{
  public partial class Form1 : Form
  {
    private int SizeX = 200;
    private int SizeY = 100;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int i;
        for (i = 1; i<=100; i++)
        {
            SizeX += 1;
            SizeY += 1;
            this.Size = new Size(SizeX, SizeY);
        }     
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int i;
        for (i = 1 ;i<=100;i++)
        {
            SizeX -= 1;
            SizeY -= 1;
            this.Size = new Size(SizeX, SizeY);
        }
    }
  }
}
