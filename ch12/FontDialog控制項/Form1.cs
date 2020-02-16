using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialog控制項
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fontDialog1.ShowDialog(); //開啟字型對話方塊
            textBox1.Font = fontDialog1.Font; //以在字型對話方塊內所指定的字型來指定給textBox1
            textBox1.ForeColor = fontDialog1.Color; //以在字型對話方塊內所指定的顏色來指定給textBox1
        }
    }
}
