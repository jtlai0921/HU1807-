using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPress事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ch1;
            ch1 = (int)(e.KeyChar);
            if (ch1 < 65 || ch1 > 90) //判斷是否輸入字元為A~Z
            {
                MessageBox.Show("必須要輸入A~Z");
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int  ch1;
            ch1 = (int)(e.KeyChar);
        if ( ch1 < 48 || ch1 > 57 )  //判斷是否輸入字元為0~9
            {
                MessageBox.Show("必須要輸入0~9");
                e.Handled = true;
            }         
        }
    }
}
