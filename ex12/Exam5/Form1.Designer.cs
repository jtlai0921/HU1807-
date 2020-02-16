namespace Exam5
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
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(45, 52);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(239, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "猜數字，數字不可重複，第一個數字不可為0";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(47, 100);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(85, 22);
      this.numericUpDown1.TabIndex = 1;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(138, 100);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(85, 22);
      this.numericUpDown2.TabIndex = 2;
      // 
      // numericUpDown3
      // 
      this.numericUpDown3.Location = new System.Drawing.Point(229, 100);
      this.numericUpDown3.Name = "numericUpDown3";
      this.numericUpDown3.Size = new System.Drawing.Size(85, 22);
      this.numericUpDown3.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(321, 144);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(69, 30);
      this.button1.TabIndex = 4;
      this.button1.Text = "猜猜看";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(321, 197);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(69, 30);
      this.button2.TabIndex = 5;
      this.button2.Text = "再來一盤";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(321, 252);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(69, 30);
      this.button3.TabIndex = 6;
      this.button3.Text = "偷看答案";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(48, 153);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(265, 128);
      this.textBox1.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(411, 322);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.numericUpDown3);
      this.Controls.Add(this.numericUpDown2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TextBox textBox1;
  }
}

