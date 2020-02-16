using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton範例
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public int train, ticket;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
	            train = 1000;   //票價為1000
	        }
            textBox1.Text = "新台幣" + train * ticket + "元";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                train = 800;    //票價為800
            }
            textBox1.Text = "新台幣" + train * ticket + "元";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                ticket = 1;     //票數為一張
            }
            textBox1.Text = "新台幣" + train * ticket + "元";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                ticket = 2;     //票數為兩張
            }
            textBox1.Text = "新台幣" + train * ticket + "元";
        }
    }
}
