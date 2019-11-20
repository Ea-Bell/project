namespace TeamProject
{
    partial class 영화관리
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
            this.영화포스터 = new System.Windows.Forms.PictureBox();
            this.그림찾기btn = new System.Windows.Forms.Button();
            this.경로명 = new System.Windows.Forms.Label();
            this.저장 = new System.Windows.Forms.Button();
            this.취소 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.영화포스터)).BeginInit();
            this.SuspendLayout();
            // 
            // 영화포스터
            // 
            this.영화포스터.Location = new System.Drawing.Point(72, 59);
            this.영화포스터.Name = "영화포스터";
            this.영화포스터.Size = new System.Drawing.Size(214, 221);
            this.영화포스터.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.영화포스터.TabIndex = 0;
            this.영화포스터.TabStop = false;
            // 
            // 그림찾기btn
            // 
            this.그림찾기btn.Location = new System.Drawing.Point(133, 320);
            this.그림찾기btn.Name = "그림찾기btn";
            this.그림찾기btn.Size = new System.Drawing.Size(75, 23);
            this.그림찾기btn.TabIndex = 1;
            this.그림찾기btn.Text = "그림찾기";
            this.그림찾기btn.UseVisualStyleBackColor = true;
            this.그림찾기btn.Click += new System.EventHandler(this.그림찾기btn_Click);
            // 
            // 경로명
            // 
            this.경로명.AutoSize = true;
            this.경로명.Location = new System.Drawing.Point(216, 373);
            this.경로명.Name = "경로명";
            this.경로명.Size = new System.Drawing.Size(52, 15);
            this.경로명.TabIndex = 2;
            this.경로명.Text = "경로명";
            // 
            // 저장
            // 
            this.저장.Location = new System.Drawing.Point(472, 387);
            this.저장.Name = "저장";
            this.저장.Size = new System.Drawing.Size(75, 23);
            this.저장.TabIndex = 3;
            this.저장.Text = "저장";
            this.저장.UseVisualStyleBackColor = true;
            this.저장.Click += new System.EventHandler(this.저장_Click);
            // 
            // 취소
            // 
            this.취소.Location = new System.Drawing.Point(554, 386);
            this.취소.Name = "취소";
            this.취소.Size = new System.Drawing.Size(75, 23);
            this.취소.TabIndex = 4;
            this.취소.Text = "취소";
            this.취소.UseVisualStyleBackColor = true;
            this.취소.Click += new System.EventHandler(this.취소_Click);
            // 
            // 영화관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.취소);
            this.Controls.Add(this.저장);
            this.Controls.Add(this.경로명);
            this.Controls.Add(this.그림찾기btn);
            this.Controls.Add(this.영화포스터);
            this.Name = "영화관리";
            this.Text = "영화관리";
            ((System.ComponentModel.ISupportInitialize)(this.영화포스터)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox 영화포스터;
        private System.Windows.Forms.Button 그림찾기btn;
        private System.Windows.Forms.Label 경로명;
        private System.Windows.Forms.Button 저장;
        private System.Windows.Forms.Button 취소;
    }
}