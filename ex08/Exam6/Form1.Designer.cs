﻿namespace Exam6
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(83, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "請輸入數字1：";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(83, 12);
      this.label2.TabIndex = 1;
      this.label2.Text = "請輸入數字2：";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(111, 40);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(68, 22);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(111, 67);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(68, 22);
      this.textBox2.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(203, 67);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(62, 21);
      this.button1.TabIndex = 4;
      this.button1.Text = "結果";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label3
      // 
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label3.Location = new System.Drawing.Point(14, 112);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(251, 52);
      this.label3.TabIndex = 5;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(288, 204);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
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
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
  }
}

