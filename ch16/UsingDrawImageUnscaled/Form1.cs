using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDrawImageUnscaled
{
    public partial class Form1 : Form
    {
        private Image im;
        private Graphics G;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            G = this.CreateGraphics();
            im = Image.FromFile("003.jpg");       
        }
        private void DrawGraphic()
        {
            G.DrawImageUnscaled(im, 20, 20);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraphic();
        }
    }
}
