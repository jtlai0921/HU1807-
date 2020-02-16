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
    
    private int[] Ans=new int[3] {0,0,0};

    public Form1()
    {
      InitializeComponent();
      
    }

    private void Form1_Load(object sender, EventArgs e)
    {   
      GetAns();
    }
    
    private void GetAns()
    {
        Random Rnd =new Random();
        int i;

        //**第一個數字需介於0到9之間
        Ans[0] = Rnd.Next(1, 10);
        for (i = 1;i<=2;i++)
            Ans[i] = Rnd.Next(0, 10);
        
        //**檢查三個數值是否有重複的情況，若有則重新取亂數值
        while (Ans[0] == Ans[1])
            Ans[1] = Rnd.Next(0, 10);

        while ((Ans[0] == Ans[2]) || (Ans[1] == Ans[2])) 
            Ans[2] = Rnd.Next(0, 10);
    }

    private void button1_Click(object sender, EventArgs e)
    {
         int[] MyAns=new int[3];
         int i, j, ACount=0, Bcount=0;
         string TmpAns;
        MyAns[0] = (int) numericUpDown1.Value;
        MyAns[1] = (int) numericUpDown2.Value;
        MyAns[2] = (int) numericUpDown3.Value;
        TmpAns = (MyAns[0].ToString() + MyAns[1].ToString() + MyAns[2].ToString());

        //檢查使用者的猜測情況
        for (i = 0;i<=2;i++)
        {
          for (j = 0;j<=2;j++)
            {
              //如果數字與位置都相同，則為A，並跳出第二層迴圈
                if ((MyAns[i] == Ans[j]) && (i == j) )
                {
                  ACount += 1;
                    break;
                    //如果數字相同但位置不同，則為B，並跳出第二層迴圈
                 }
                    
                else if (MyAns[i] == Ans[j]) 
                {
                  Bcount += 1;
                    break;
                }
            }
        }
            
              textBox1.Text += TmpAns + " → " + ACount + "A, " 
                               + Bcount + " B" + Environment.NewLine;

        //**判斷是否完全猜中
        if (ACount == 3) 
        {
          button1.Enabled = false;
            MessageBox.Show("恭喜您猜中了！", "過關");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      GetAns();
        button1.Enabled = true;
        textBox1.Text = "";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      MessageBox.Show(Ans[0].ToString() + Ans[1].ToString()
                 + Ans[2].ToString(), "哦哦！您偷看答案！");
    }
  }
}
