using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click滑鼠事件
{
    public partial class Click滑鼠事件 : Form
    {
        int i = 0;
        System.Drawing.Color[] color1 = new Color[5];

        public Click滑鼠事件()
        {
            InitializeComponent();
        }              
        private void label2_Click(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleCenter;
        label2.Text = i.ToString();
        i += 1;
        if (i > 4) 
            i = 0;
        }
        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = "";
            label2.BackColor = color1[i];

        }
        private void Click滑鼠事件_Load(object sender, EventArgs e)
        {
            color1[0] = Color.Brown;
            color1[1] = Color.Azure;
            color1[2] = Color.Chartreuse;
            color1[3] = Color.Cyan;
            color1[4] = Color.Gainsboro;
        }
    }
}
