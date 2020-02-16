using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox控制項
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }
        int Sum1;
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = Sum1.ToString(); //顯示總金額
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Sum1 = Sum1 + 10; //點選綠茶時，將Sum1變數10
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Sum1 = Sum1 + 10; //點選紅茶時，將Sum1變數10
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Sum1 = Sum1 + 20; //點選檸檬紅茶時，將Sum1變數20
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Sum1 = Sum1 + 25; //點選奶茶時，將Sum1變數25
        }
    }
}
