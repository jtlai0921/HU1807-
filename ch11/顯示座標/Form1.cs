using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 顯示座標
{
    public partial class 顯示座標 : Form
    {
        public 顯示座標()
        {
            InitializeComponent();
        }

        private void 顯示座標_Load(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void 顯示座標_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "X：" + e.X.ToString() + " Y:" + e.Y.ToString();
        }

        private void 顯示座標_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Text = "";
        switch (e.Button)
        {
            case MouseButtons.Left:
                label2.Text = "您所按下的按鍵是左鍵";
                break;
            case MouseButtons.Right:
                label2.Text = "您所按下的按鍵是右鍵";
                break;
            case MouseButtons.Middle:
                label2.Text = "您所按下的按鍵是中鍵";
                break;
        }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "X：" + e.X.ToString() + " Y:" + e.Y.ToString();
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Text = "";
        switch (e.Button)
        {
            case MouseButtons.Left:
                label2.Text = "您所按下的按鍵是左鍵";
                break;
            case MouseButtons.Right:
                label2.Text = "您所按下的按鍵是右鍵";
                break;
            case MouseButtons.Middle:
                label2.Text = "您所按下的按鍵是中鍵";
                break;
        }
        }

    }
}
