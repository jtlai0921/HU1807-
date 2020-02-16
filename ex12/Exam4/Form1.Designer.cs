namespace Exam4
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(59, 34);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(255, 93);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "第一題";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.radioButton3);
      this.groupBox2.Controls.Add(this.radioButton4);
      this.groupBox2.Location = new System.Drawing.Point(59, 160);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(255, 93);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "第二題";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(209, 12);
      this.label1.TabIndex = 0;
      this.label1.Text = "RadioButton可在眾多選項中選擇其一？";
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(18, 58);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(35, 16);
      this.radioButton1.TabIndex = 1;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "對";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(139, 58);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(35, 16);
      this.radioButton2.TabIndex = 2;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "錯";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(139, 53);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(35, 16);
      this.radioButton3.TabIndex = 4;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "錯";
      this.radioButton3.UseVisualStyleBackColor = true;
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(18, 53);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(35, 16);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "對";
      this.radioButton4.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(190, 12);
      this.label2.TabIndex = 5;
      this.label2.Text = "TextBox無法設定為多行文字方塊？";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(100, 266);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(132, 20);
      this.button1.TabIndex = 2;
      this.button1.Text = "確定送出";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(377, 311);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.Button button1;
  }
}

