using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfThen
{
    public partial class ifThen : Form
    {
        public ifThen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox1.Text) > 10) )
                label2.Text = "您所輸入的值大於10";
            if ((int.Parse(textBox1.Text) <= 10))
                label2.Text = "您所輸入的值小於或等於10";
        }
    }
}
