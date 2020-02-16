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

namespace UsingDrawString
{
    public partial class Form1 : Form
    {
        private Image im;
        private HatchBrush myBrush;
        private Font myFont;
        private Graphics G;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            G=this.CreateGraphics();
        }
        private void DrawGraphic()
        {
            myBrush=new HatchBrush(HatchStyle.DashedDownwardDiagonal,Color.Black,Color.Red);
            myFont=new Font("標楷體",25,FontStyle.Bold);
            G.DrawString("Visual Studio",myFont,myBrush,new PointF(20,10));
            myBrush=new HatchBrush(HatchStyle.DarkUpwardDiagonal,Color.Black,Color.Blue);
            myFont=new Font("標楷體",15,FontStyle.Strikeout);
            G.DrawString("Visual Studio 2013",myFont,myBrush,new PointF(10,60));
            myBrush=new HatchBrush(HatchStyle.DashedDownwardDiagonal,Color.Black,Color.Green);
            myFont=new Font("標楷體",20,FontStyle.Underline);
            G.DrawString(".NET Framework",myFont,myBrush,new PointF(30,100));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraphic();
        }
    }
}
