namespace Timer控制項
{
  partial class Form1
  {
    /// <summary>
    /// 設計工具所需的變數。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清除任何使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 設計工具產生的程式碼

    /// <summary>
    /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
    /// 修改這個方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "經過時間";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(116, 56);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(99, 22);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(26, 121);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(58, 24);
      this.button1.TabIndex = 2;
      this.button1.Text = "開始";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(116, 122);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(67, 22);
      this.button2.TabIndex = 3;
      this.button2.Text = "停止";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(203, 121);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(69, 23);
      this.button3.TabIndex = 4;
      this.button3.Text = "清除";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(31, 168);
      this.trackBar1.Maximum = 60;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(240, 45);
      this.trackBar1.TabIndex = 5;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 223);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Timer控制項範例";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Timer timer1;
  }
}

