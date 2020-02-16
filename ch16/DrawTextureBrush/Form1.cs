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

namespace DrawTextureBrush
{
    public partial class Form1 : Form
    {
        private Image im;
        private TextureBrush myBrush;
        private Graphics G;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            G = this.CreateGraphics();
            im = Image.FromFile("001.jpg");
            myBrush = new TextureBrush(im, WrapMode.TileFlipXY);
        }
        
        private void DrawGraphic()
        {
            G.FillRectangle(myBrush, 0, 0, this.Size.Width,this.Size.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraphic();
        }
    }
}
