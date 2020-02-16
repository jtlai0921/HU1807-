namespace Exam3
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "第一個數字：";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(54, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "第二個數字：";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(54, 110);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(77, 12);
      this.label3.TabIndex = 2;
      this.label3.Text = "第三個數字：";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(54, 141);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 12);
      this.label4.TabIndex = 3;
      this.label4.Text = "第四個數字：";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(151, 44);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(89, 22);
      this.textBox1.TabIndex = 4;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(151, 72);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(89, 22);
      this.textBox2.TabIndex = 5;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(151, 107);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(89, 22);
      this.textBox3.TabIndex = 6;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(151, 135);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(89, 22);
      this.textBox4.TabIndex = 7;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(77, 182);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(133, 28);
      this.button1.TabIndex = 8;
      this.button1.Text = "最大值為";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label5
      // 
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label5.Location = new System.Drawing.Point(54, 230);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(185, 37);
      this.label5.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(293, 309);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label5;
  }
}

