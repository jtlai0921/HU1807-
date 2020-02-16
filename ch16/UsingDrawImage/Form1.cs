using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UsingDrawImage
{
    public partial class Form1 : Form
    {
        private Image im;
        private TextureBrush myBrush;
        private Rectangle sR, dR;
        private Graphics G;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            G = this.CreateGraphics();
            im = Image.FromFile("002.jpg");
            sR = new Rectangle(400, 80, 400, 400);
            dR = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
        }
        
        private void DrawGraphic()
        {
            G.DrawImage(im, dR, sR, GraphicsUnit.Pixel);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraphic();
        }
    }
}
