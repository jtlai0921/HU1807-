namespace 顯示座標
{
    partial class 顯示座標
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(66, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "您可以隨意按下滑鼠按鍵，會在下方標籤中顯示座標及按鍵";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(64, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 67);
            this.label2.TabIndex = 1;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // 顯示座標
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 289);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "顯示座標";
            this.Text = "MouseUp及MouseDown事件範例";
            this.Load += new System.EventHandler(this.顯示座標_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.顯示座標_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.顯示座標_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

