using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Ivory;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.DarkOliveGreen;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Left = label1.Left + e.X - (label1.Width / 2);
            label1.Top = label1.Top + e.Y - (label1.Top / 2);
        }
    }
}
