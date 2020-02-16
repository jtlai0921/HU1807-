using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

    
namespace FileDialog控制項
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        string filename;
        StreamReader fileread;
        StreamWriter filewriter;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\"; //設定預設目錄
            openFileDialog1.Filter = "純文字檔(*.txt)|*.txt|所有檔案(*.*)|*.*"; //預設開啟的檔案類型
            openFileDialog1.Title = "開啟舊檔"; //設定對話方塊的標題
            openFileDialog1.RestoreDirectory = true; //設定是否在關閉之前要還原至目前的目錄

            if (openFileDialog1.ShowDialog() == DialogResult.OK)  //假如按下開啟按鈕時
            {
                filename = openFileDialog1.FileName; //設定檔案名稱
                fileread = new StreamReader(filename); //讀取檔案
                textBox1.Text = fileread.ReadToEnd(); //自檔案目前位置讀至檔案尾端
                fileread.Close(); //將檔案關閉
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "D:\\"; //設定預設目錄
            saveFileDialog1.Filter = "純文字檔(*.txt)|*.txt"; //預設欲儲存的檔案類型
            saveFileDialog1.RestoreDirectory = true; //設定是否在關閉之前要還原至目前的目錄
            saveFileDialog1.Title = "存檔"; //設定對話方塊的標題
       
            if (saveFileDialog1.ShowDialog() == DialogResult.OK ) //假如按下儲存按鈕時
            {
                filename = saveFileDialog1.FileName; //設定檔案名稱
                filewriter = new StreamWriter(filename, false);
                filewriter.Write(textBox1.Text); //將資料流寫入指定的檔案中
                filewriter.Close(); //關閉檔案
            }
        }
    }
}
