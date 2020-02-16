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

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
      int key1;
      key1 = (int) (e.KeyChar);
      if (key1 == 71)  //G
      {
          label1.BackColor = Color.Green;
          label2.BackColor = Color.White;
          label3.BackColor = Color.White;
      }
        
      if (key1 == 89)  //Y
      {
          label2.BackColor = Color.Yellow;
          label1.BackColor = Color.White;
          label3.BackColor = Color.White;
      }
        
      if (key1 == 82) 
      {
          label3.BackColor = Color.Red;
          label1.BackColor = Color.White;
          label2.BackColor = Color.White;
      }       
    }
  }
}
