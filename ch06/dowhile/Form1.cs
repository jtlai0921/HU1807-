using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int I, J, sum;
            I = int.Parse(textBox1.Text);
            J = 1;
            sum = 0;
            do
            {
                sum = sum + J;
                J = J + 1;
            } while (J <= I);
            label2.Text = sum.ToString();
        }
    }
}
