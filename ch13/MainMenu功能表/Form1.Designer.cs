namespace MainMenu功能表
{
  partial class MainMenu
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.文字SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.MenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
      this.字型大小TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字SToolStripMenuItem,
            this.字型大小TToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(284, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(13, 60);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(257, 188);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "";
      // 
      // 文字SToolStripMenuItem
      // 
      this.文字SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem2,
            this.MenuItem3,
            this.toolStripSeparator1,
            this.MenuItem4,
            this.MenuItem5,
            this.toolStripSeparator2,
            this.MenuItem6,
            this.MenuItem7,
            this.MenuItem8});
      this.文字SToolStripMenuItem.Name = "文字SToolStripMenuItem";
      this.文字SToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
      this.文字SToolStripMenuItem.Text = "文字(&S)";
      // 
      // MenuItem2
      // 
      this.MenuItem2.Name = "MenuItem2";
      this.MenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.MenuItem2.Size = new System.Drawing.Size(182, 22);
      this.MenuItem2.Text = "轉換大寫(&U)";
      this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
      // 
      // MenuItem3
      // 
      this.MenuItem3.Name = "MenuItem3";
      this.MenuItem3.Size = new System.Drawing.Size(182, 22);
      this.MenuItem3.Text = "轉換小寫(&L)";
      this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
      // 
      // MenuItem4
      // 
      this.MenuItem4.Name = "MenuItem4";
      this.MenuItem4.Size = new System.Drawing.Size(182, 22);
      this.MenuItem4.Text = "標楷體字型";
      this.MenuItem4.Click += new System.EventHandler(this.MenuItem4_Click);
      // 
      // MenuItem5
      // 
      this.MenuItem5.Checked = true;
      this.MenuItem5.CheckState = System.Windows.Forms.CheckState.Checked;
      this.MenuItem5.Name = "MenuItem5";
      this.MenuItem5.Size = new System.Drawing.Size(182, 22);
      this.MenuItem5.Text = "新細明體字型";
      this.MenuItem5.Click += new System.EventHandler(this.MenuItem5_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
      // 
      // MenuItem6
      // 
      this.MenuItem6.Name = "MenuItem6";
      this.MenuItem6.Size = new System.Drawing.Size(182, 22);
      this.MenuItem6.Text = "粗體字型";
      this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
      // 
      // MenuItem7
      // 
      this.MenuItem7.Name = "MenuItem7";
      this.MenuItem7.Size = new System.Drawing.Size(182, 22);
      this.MenuItem7.Text = "斜體字型";
      this.MenuItem7.Click += new System.EventHandler(this.MenuItem7_Click);
      // 
      // MenuItem8
      // 
      this.MenuItem8.Checked = true;
      this.MenuItem8.CheckState = System.Windows.Forms.CheckState.Checked;
      this.MenuItem8.Name = "MenuItem8";
      this.MenuItem8.Size = new System.Drawing.Size(182, 22);
      this.MenuItem8.Text = "標準體字型";
      this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click);
      // 
      // 字型大小TToolStripMenuItem
      // 
      this.字型大小TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem9,
            this.MenuItem10,
            this.MenuItem11,
            this.MenuItem12,
            this.MenuItem13});
      this.字型大小TToolStripMenuItem.Name = "字型大小TToolStripMenuItem";
      this.字型大小TToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
      this.字型大小TToolStripMenuItem.Text = "字型大小(&T)";
      // 
      // MenuItem9
      // 
      this.MenuItem9.Name = "MenuItem9";
      this.MenuItem9.Size = new System.Drawing.Size(152, 22);
      this.MenuItem9.Text = "8";
      this.MenuItem9.Click += new System.EventHandler(this.MenuItem9_Click);
      // 
      // MenuItem10
      // 
      this.MenuItem10.Name = "MenuItem10";
      this.MenuItem10.Size = new System.Drawing.Size(152, 22);
      this.MenuItem10.Text = "10";
      this.MenuItem10.Click += new System.EventHandler(this.MenuItem10_Click);
      // 
      // MenuItem11
      // 
      this.MenuItem11.Name = "MenuItem11";
      this.MenuItem11.Size = new System.Drawing.Size(152, 22);
      this.MenuItem11.Text = "12";
      this.MenuItem11.Click += new System.EventHandler(this.MenuItem11_Click);
      // 
      // MenuItem12
      // 
      this.MenuItem12.Name = "MenuItem12";
      this.MenuItem12.Size = new System.Drawing.Size(152, 22);
      this.MenuItem12.Text = "14";
      this.MenuItem12.Click += new System.EventHandler(this.MenuItem12_Click);
      // 
      // MenuItem13
      // 
      this.MenuItem13.Name = "MenuItem13";
      this.MenuItem13.Size = new System.Drawing.Size(152, 22);
      this.MenuItem13.Text = "16";
      this.MenuItem13.Click += new System.EventHandler(this.MenuItem13_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainMenu";
      this.Text = "功能表範例";
      this.Load += new System.EventHandler(this.MainMenu_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.ToolStripMenuItem 文字SToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MenuItem2;
    private System.Windows.Forms.ToolStripMenuItem MenuItem3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem MenuItem4;
    private System.Windows.Forms.ToolStripMenuItem MenuItem5;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem MenuItem6;
    private System.Windows.Forms.ToolStripMenuItem MenuItem7;
    private System.Windows.Forms.ToolStripMenuItem MenuItem8;
    private System.Windows.Forms.ToolStripMenuItem 字型大小TToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MenuItem9;
    private System.Windows.Forms.ToolStripMenuItem MenuItem10;
    private System.Windows.Forms.ToolStripMenuItem MenuItem11;
    private System.Windows.Forms.ToolStripMenuItem MenuItem12;
    private System.Windows.Forms.ToolStripMenuItem MenuItem13;
  }
}

