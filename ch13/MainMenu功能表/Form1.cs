using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu功能表
{
  public partial class MainMenu : Form
  {
    float StrFontSize; //表字串大小
    String StrFont; //表字串樣式
    FontStyle StrFontStyle; //表字串字型

    public MainMenu()
    {
      InitializeComponent();
    }

    private void MainMenu_Load(object sender, EventArgs e)
    {
      StrFont = "新細明體";  //預設將字型設定為新細明體
      StrFontSize = 8; //預設將字型大小設定為8
      StrFontStyle = FontStyle.Regular; //預設將字型樣式設定為標準體
      richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem2_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = richTextBox1.Text.ToUpper(); //將文字轉換為大寫字元
    }

    private void MenuItem3_Click(object sender, EventArgs e)
    {
      richTextBox1.Text = richTextBox1.Text.ToLower(); //將文字轉換為小寫字元
    }

    private void MenuItem4_Click(object sender, EventArgs e)
    {
      StrFont = "標楷體"; //將字型設定為標楷體
      MenuItem4.Checked = true; //設定標楷體為預設字體
      MenuItem5.Checked = false; //取消新細明體字型為預設字型
      richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem5_Click(object sender, EventArgs e)
    {
      StrFont = "新細明體"; //將字型設定為新細明體
      MenuItem4.Checked = false; //取消標楷體字型為預設字型
      MenuItem5.Checked = true; //設定新細明體為字型
      richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem9_Click(object sender, EventArgs e)
    {
      StrFontSize = 8; //將字型大小設定為8
        MenuItem9.Checked = true; //設定字型大小8為預設字型大小
        MenuItem10.Checked = false; //取消字型大小10為預設字型大小
        MenuItem11.Checked = false; //取消字型大小12為預設字型大小
        MenuItem12.Checked = false; //取消字型大小14為預設字型大小
        MenuItem13.Checked = false; //取消字型大小16為預設字型大小
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem10_Click(object sender, EventArgs e)
    {
      StrFontSize = 10; //將字型大小設定為10
        MenuItem10.Checked = true; //設定字型大小10為預設字型大小
        MenuItem9.Checked = false; //取消字型大小8為預設字型大小
        MenuItem11.Checked = false; //取消字型大小12為預設字型大小
        MenuItem12.Checked = false; //取消字型大小14為預設字型大小
        MenuItem13.Checked = false; //取消字型大小16為預設字型大小
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem11_Click(object sender, EventArgs e)
    {
      StrFontSize = 12; //將字型大小設定為12
        MenuItem11.Checked = true; //設定字型大小12為預設字型大小
        MenuItem9.Checked = false; //取消字型大小8為預設字型大小
        MenuItem10.Checked = false; //取消字型大小10為預設字型大小
        MenuItem12.Checked = false; //取消字型大小14為預設字型大小
        MenuItem13.Checked = false; //取消字型大小16為預設字型大小
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem12_Click(object sender, EventArgs e)
    {
      StrFontSize = 14; //將字型大小設定為14
        MenuItem12.Checked = true; //設定字型大小14為預設字型大小
        MenuItem9.Checked = false; //取消字型大小8為預設字型大小
        MenuItem10.Checked = false; //取消字型大小10為預設字型大小
        MenuItem11.Checked = false; //取消字型大小12為預設字型大小
        MenuItem13.Checked = false; //取消字型大小16為預設字型大小
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem13_Click(object sender, EventArgs e)
    {
      StrFontSize = 16; //將字型大小設定為16
        MenuItem13.Checked = true; //設定字型大小16為預設字型大小
        MenuItem9.Checked = false; //取消字型大小8為預設字型大小
        MenuItem10.Checked = false; //取消字型大小10為預設字型大小
        MenuItem11.Checked = false; //取消字型大小12為預設字型大小
        MenuItem12.Checked = false; //取消字型大小14為預設字型大小
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem6_Click(object sender, EventArgs e)
    {
      StrFontStyle = FontStyle.Bold; //設定預設字型樣式為粗體
        MenuItem6.Checked = true; //設定預設字型樣式為粗體
        MenuItem7.Checked = false; //取消斜體字型為預設字型
        MenuItem8.Checked = false; //取消標準體為預設字型
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem7_Click(object sender, EventArgs e)
    {
      StrFontStyle = FontStyle.Italic; //設定預設字型樣式為斜體
        MenuItem7.Checked = true; //設定預設字型樣式為斜體
        MenuItem6.Checked = false; //取消粗體字型為預設字型
        MenuItem8.Checked = false; //取消標準體為預設字型
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }

    private void MenuItem8_Click(object sender, EventArgs e)
    {
      StrFontStyle = FontStyle.Regular; //設定預設字型樣式為標準體
        MenuItem8.Checked = true; //設定預設字型樣式為標準體
        MenuItem6.Checked = false; //取消粗體字型為預設字型
        MenuItem7.Checked = false; //取消斜體字型為預設字型
        richTextBox1.Font = new Font(StrFont, StrFontSize, StrFontStyle); //更新textBox1控制項內的文字樣式
    }
  }
}
