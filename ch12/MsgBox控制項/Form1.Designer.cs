﻿namespace MsgBox控制項
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(42, 41);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(205, 22);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(68, 106);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(149, 28);
      this.button1.TabIndex = 1;
      this.button1.Text = "問個小問題";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 177);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "MsgBox控制項範例";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
  }
}

