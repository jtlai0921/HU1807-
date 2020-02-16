namespace Exam9
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(125, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "輸入各位同學的成績：";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(150, 55);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(85, 22);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(255, 53);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(57, 24);
      this.button1.TabIndex = 2;
      this.button1.Text = "下一位";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(61, 90);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(209, 31);
      this.button2.TabIndex = 3;
      this.button2.Text = "求成績";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label2
      // 
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.Location = new System.Drawing.Point(23, 145);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(288, 63);
      this.label2.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(348, 261);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label2;
  }
}

