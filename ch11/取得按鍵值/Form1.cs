using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 取得按鍵值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Left:
                    label2.Text = "←";
                    break;
                case Keys.Right:
                    label2.Text = "→";
                    break;
                case Keys.Up:
                    label2.Text = "↑";
                    break;
                case Keys.Down:
                    label2.Text = "↓";
                    break;
                case Keys.ControlKey:
                    label2.Text = "Control鍵";
                    break;
                case Keys.Tab:
                    label2.Text = "Tab鍵";
                    break;
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    label2.Text = "數字鍵";
                    break;
                case Keys.CapsLock:
                    label2.Text = "Caps Lock鍵";
                    break;
                case Keys.ShiftKey:
                    label2.Text = "Shift鍵";
                    break;
                case Keys.F1:
                case Keys.F2:
                case Keys.F3:
                case Keys.F4:
                case Keys.F5:
                case Keys.F6:
                case Keys.F7:
                case Keys.F8:
                case Keys.F9:
                case Keys.F10:
                case Keys.F11:
                case Keys.F12:
                    label2.Text = "F1~F12鍵";
                    break;
                case Keys.A:
                case Keys.B:
                case Keys.C:
                case Keys.D:
                case Keys.E:
                case Keys.F:
                case Keys.G:
                case Keys.H:
                case Keys.I:
                case Keys.J:
                case Keys.K:
                case Keys.L:
                case Keys.M:
                case Keys.N:
                case Keys.O:
                case Keys.P:
                case Keys.Q:
                case Keys.R:
                case Keys.S:
                case Keys.T:
                case Keys.U:
                case Keys.V:
                case Keys.W:
                case Keys.X:
                case Keys.Y:
                case Keys.Z:
                    label2.Text = "A~Z鍵";
                    break;
                case Keys.Enter:
                    label2.Text = "Enter鍵";
                    break;
                case Keys.NumLock:
                    label2.Text = "Num Lock鍵";
                    break;
                case Keys.Escape:
                    label2.Text = "Escape鍵";
                    break;
                case Keys.PageDown:
                    label2.Text = "PageDown鍵";
                    break;
                case Keys.PageUp:
                    label2.Text = "PageUp鍵";
                    break;
            }
        }    
    }
}
