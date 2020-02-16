using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Month1;
            Month1 = int.Parse(textBox1.Text);
            switch (Month1)
            {
                case 1:
                case 2:
                case 3:
                    label2.Text = "現在是第一季";
                    break;
                case 4:
                case 5:
                case 6:
                    label2.Text = "現在是第二季";
                    break;
                case 7:
                case 8:
                case 9:
                    label2.Text = "現在是第三季";
                    break;
                case 10:
                case 11:
                case 12:
                    label2.Text = "現在是第四季";
                    break;
                default:
                    label2.Text = "一年只有12個月!!";
                    break;
            }
        }
    }
}
