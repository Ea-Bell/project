namespace TeamProject
{
    partial class 홈페이지
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(홈페이지));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.뒤로가기 = new System.Windows.Forms.ToolStripButton();
            this.앞으로가기 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.브라우저주소링크 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(-16, -105);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(994, 665);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.뒤로가기,
            this.앞으로가기,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.브라우저주소링크});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 뒤로가기
            // 
            this.뒤로가기.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.뒤로가기.Image = ((System.Drawing.Image)(resources.GetObject("뒤로가기.Image")));
            this.뒤로가기.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.뒤로가기.Name = "뒤로가기";
            this.뒤로가기.Size = new System.Drawing.Size(24, 24);
            this.뒤로가기.Text = "뒤로가기";
            this.뒤로가기.Visible = false;
            this.뒤로가기.Click += new System.EventHandler(this.뒤로가기_Click);
            // 
            // 앞으로가기
            // 
            this.앞으로가기.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.앞으로가기.Image = ((System.Drawing.Image)(resources.GetObject("앞으로가기.Image")));
            this.앞으로가기.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.앞으로가기.Name = "앞으로가기";
            this.앞으로가기.Size = new System.Drawing.Size(24, 24);
            this.앞으로가기.Text = "앞으로가기";
            this.앞으로가기.Visible = false;
            this.앞으로가기.Click += new System.EventHandler(this.앞으로가기_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // 브라우저주소링크
            // 
            this.브라우저주소링크.Name = "브라우저주소링크";
            this.브라우저주소링크.Size = new System.Drawing.Size(500, 27);
            this.브라우저주소링크.KeyDown += new System.Windows.Forms.KeyEventHandler(this.브라우저주소링크_KeyDown);
            this.브라우저주소링크.Click += new System.EventHandler(this.브라우저주소링크_Click);
            // 
            // 홈페이지
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 423);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "홈페이지";
            this.Text = "홈페이지";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox 브라우저주소링크;
        private System.Windows.Forms.ToolStripButton 뒤로가기;
        private System.Windows.Forms.ToolStripButton 앞으로가기;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}