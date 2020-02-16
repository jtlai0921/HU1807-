namespace 快顯功能表
{
  partial class ContextMenu
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
      this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3,
            this.MenuItem4});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(99, 92);
      // 
      // MenuItem1
      // 
      this.MenuItem1.Name = "MenuItem1";
      this.MenuItem1.Size = new System.Drawing.Size(152, 22);
      this.MenuItem1.Text = "綠色";
      this.MenuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
      // 
      // MenuItem2
      // 
      this.MenuItem2.Name = "MenuItem2";
      this.MenuItem2.Size = new System.Drawing.Size(152, 22);
      this.MenuItem2.Text = "黑色";
      this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
      // 
      // MenuItem3
      // 
      this.MenuItem3.Name = "MenuItem3";
      this.MenuItem3.Size = new System.Drawing.Size(152, 22);
      this.MenuItem3.Text = "黃色";
      this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
      // 
      // MenuItem4
      // 
      this.MenuItem4.Name = "MenuItem4";
      this.MenuItem4.Size = new System.Drawing.Size(152, 22);
      this.MenuItem4.Text = "紅色";
      this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
      this.richTextBox1.Location = new System.Drawing.Point(21, 68);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(244, 149);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      // 
      // ContextMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.richTextBox1);
      this.Name = "ContextMenu";
      this.Text = "快顯功能表範例";
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem MenuItem1;
    private System.Windows.Forms.ToolStripMenuItem MenuItem2;
    private System.Windows.Forms.ToolStripMenuItem MenuItem3;
    private System.Windows.Forms.ToolStripMenuItem MenuItem4;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

