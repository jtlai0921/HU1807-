namespace Exam2
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
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.綠色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.黃色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.紅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.綠色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.黃色ToolStripMenuItem,
            this.紅色ToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
      // 
      // 綠色ToolStripMenuItem
      // 
      this.綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
      this.綠色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.綠色ToolStripMenuItem.Text = "綠色";
      this.綠色ToolStripMenuItem.Click += new System.EventHandler(this.綠色ToolStripMenuItem_Click);
      // 
      // 黑色ToolStripMenuItem
      // 
      this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
      this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.黑色ToolStripMenuItem.Text = "黑色";
      this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
      // 
      // 黃色ToolStripMenuItem
      // 
      this.黃色ToolStripMenuItem.Name = "黃色ToolStripMenuItem";
      this.黃色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.黃色ToolStripMenuItem.Text = "黃色";
      this.黃色ToolStripMenuItem.Click += new System.EventHandler(this.黃色ToolStripMenuItem_Click);
      // 
      // 紅色ToolStripMenuItem
      // 
      this.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
      this.紅色ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.紅色ToolStripMenuItem.Text = "紅色";
      this.紅色ToolStripMenuItem.Click += new System.EventHandler(this.紅色ToolStripMenuItem_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
      this.richTextBox1.Location = new System.Drawing.Point(20, 87);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(252, 142);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.richTextBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 綠色ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 黃色ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 紅色ToolStripMenuItem;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

