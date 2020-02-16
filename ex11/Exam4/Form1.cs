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
    private int SizeX = 200;
    private int SizeY = 100;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_MouseDown(object sender, MouseEventArgs e)
    {
      int i;
        if (e.Button == MouseButtons.Left)
        {
          for (i = 1;i<=100;i++)
          {
            SizeX += 1;
            SizeY += 1;
            this.Size = new Size(SizeX, SizeY);
          }
                
        }
        else
        {
          for (i = 1;i<=100;i++)
          {
            SizeX -= 1;
            SizeY -= 1;
            this.Size = new Size(SizeX, SizeY);
          }           
        }
    }
  }
}
