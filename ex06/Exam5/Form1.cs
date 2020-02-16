using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int Res1, Dis1, Tax, Res2;
        float TaxRate;
        //Res1 : 表綜所稅淨額  Taxrate：表稅率  Dis1：表累進差額  Tax：表稅金  Res2:表應繳稅金

        Res1 = int.Parse(textBox1.Text);       
                        
        if (Res1<=370000) {
            TaxRate = (float) 0.06;
            Dis1 = 0;
        } else if (Res1>=370001 && Res1<=990000) {
            TaxRate = (float) 0.13;
            Dis1 = 25900;
        } else if (Res1>=990001 && Res1<=1980000) {
            TaxRate = (float) 0.21;
            Dis1 = 105100;
        } else if (Res1>=1980001 && Res1<=3720000) {
            TaxRate = (float) 0.3;
            Dis1 = 283300;
        } else {
            TaxRate = (float) 0.4;
            Dis1 = 655300;
        }

        Tax = (int) (Res1*TaxRate);  //所得稅
        Res2 = Tax - Dis1; //稅金-累進差額
        textBox2.Text = "您今年的綜所稅淨額為：" + Res1 + "元" + Environment.NewLine;
        textBox2.Text += "稅率為：" + float.Parse(TaxRate.ToString()) + Environment.NewLine;
        textBox2.Text += "稅金為：" + Tax + "元" + Environment.NewLine;
        textBox2.Text += "累進差額為：" + Dis1 + "元" + Environment.NewLine;
        textBox2.Text += "您今年應繳金額為：" + Res2 + "元" + Environment.NewLine;
    }
  }
}
