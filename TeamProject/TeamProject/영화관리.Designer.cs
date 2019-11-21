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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.경로명.Location = new System.Drawing.Point(45, 397);
            this.경로명.Name = "경로명";
            this.경로명.Size = new System.Drawing.Size(52, 15);
            this.경로명.TabIndex = 2;
            this.경로명.Text = "경로명";
            // 
            // 저장
            // 
            this.저장.Location = new System.Drawing.Point(333, 320);
            this.저장.Name = "저장";
            this.저장.Size = new System.Drawing.Size(75, 23);
            this.저장.TabIndex = 3;
            this.저장.Text = "저장";
            this.저장.UseVisualStyleBackColor = true;
            this.저장.Click += new System.EventHandler(this.저장_Click);
            // 
            // 취소
            // 
            this.취소.Location = new System.Drawing.Point(422, 320);
            this.취소.Name = "취소";
            this.취소.Size = new System.Drawing.Size(75, 23);
            this.취소.TabIndex = 4;
            this.취소.Text = "취소";
            this.취소.UseVisualStyleBackColor = true;
            this.취소.Click += new System.EventHandler(this.취소_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(383, 263);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 25);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(383, 206);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 25);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(383, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 25);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 25);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "예고편URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "감독명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "영화명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "영화코드";
            // 
            // 영화관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}