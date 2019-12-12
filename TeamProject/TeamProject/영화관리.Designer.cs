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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(영화관리));
            this.영화포스터 = new System.Windows.Forms.PictureBox();
            this.그림찾기btn = new System.Windows.Forms.Button();
            this.경로명 = new System.Windows.Forms.Label();
            this.저장 = new System.Windows.Forms.Button();
            this.취소 = new System.Windows.Forms.Button();
            this.예고편urlTxt = new System.Windows.Forms.TextBox();
            this.감독명txt = new System.Windows.Forms.TextBox();
            this.영화명txt = new System.Windows.Forms.TextBox();
            this.영화코드txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.테스트용_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.상영영화관리 = new System.Windows.Forms.Button();
            this.수정하기 = new System.Windows.Forms.Button();
            this.삭제하기 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.영화포스터)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 영화포스터
            // 
            this.영화포스터.Location = new System.Drawing.Point(63, 47);
            this.영화포스터.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.영화포스터.Name = "영화포스터";
            this.영화포스터.Size = new System.Drawing.Size(187, 177);
            this.영화포스터.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.영화포스터.TabIndex = 0;
            this.영화포스터.TabStop = false;
            // 
            // 그림찾기btn
            // 
            this.그림찾기btn.Location = new System.Drawing.Point(116, 256);
            this.그림찾기btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.그림찾기btn.Name = "그림찾기btn";
            this.그림찾기btn.Size = new System.Drawing.Size(66, 18);
            this.그림찾기btn.TabIndex = 1;
            this.그림찾기btn.Text = "그림찾기";
            this.그림찾기btn.UseVisualStyleBackColor = true;
            this.그림찾기btn.Click += new System.EventHandler(this.그림찾기btn_Click);
            // 
            // 경로명
            // 
            this.경로명.AutoSize = true;
            this.경로명.Location = new System.Drawing.Point(316, 26);
            this.경로명.Name = "경로명";
            this.경로명.Size = new System.Drawing.Size(41, 12);
            this.경로명.TabIndex = 2;
            this.경로명.Text = "경로명";
            // 
            // 저장
            // 
            this.저장.Location = new System.Drawing.Point(270, 255);
            this.저장.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.저장.Name = "저장";
            this.저장.Size = new System.Drawing.Size(66, 18);
            this.저장.TabIndex = 3;
            this.저장.Text = "저장";
            this.저장.UseVisualStyleBackColor = true;
            this.저장.Click += new System.EventHandler(this.저장_Click);
            // 
            // 취소
            // 
            this.취소.Location = new System.Drawing.Point(340, 255);
            this.취소.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.취소.Name = "취소";
            this.취소.Size = new System.Drawing.Size(66, 18);
            this.취소.TabIndex = 4;
            this.취소.Text = "취소";
            this.취소.UseVisualStyleBackColor = true;
            this.취소.Click += new System.EventHandler(this.취소_Click);
            // 
            // 예고편urlTxt
            // 
            this.예고편urlTxt.Location = new System.Drawing.Point(335, 210);
            this.예고편urlTxt.Name = "예고편urlTxt";
            this.예고편urlTxt.Size = new System.Drawing.Size(162, 21);
            this.예고편urlTxt.TabIndex = 22;
            // 
            // 감독명txt
            // 
            this.감독명txt.Location = new System.Drawing.Point(335, 165);
            this.감독명txt.Name = "감독명txt";
            this.감독명txt.Size = new System.Drawing.Size(162, 21);
            this.감독명txt.TabIndex = 21;
            // 
            // 영화명txt
            // 
            this.영화명txt.Location = new System.Drawing.Point(335, 114);
            this.영화명txt.Name = "영화명txt";
            this.영화명txt.Size = new System.Drawing.Size(162, 21);
            this.영화명txt.TabIndex = 20;
            // 
            // 영화코드txt
            // 
            this.영화코드txt.Location = new System.Drawing.Point(335, 62);
            this.영화코드txt.Name = "영화코드txt";
            this.영화코드txt.Size = new System.Drawing.Size(162, 21);
            this.영화코드txt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "예고편URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "감독명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "영화명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "영화코드";
            // 
            // 테스트용_Label
            // 
            this.테스트용_Label.AutoSize = true;
            this.테스트용_Label.Location = new System.Drawing.Point(10, 460);
            this.테스트용_Label.Name = "테스트용_Label";
            this.테스트용_Label.Size = new System.Drawing.Size(88, 12);
            this.테스트용_Label.TabIndex = 23;
            this.테스트용_Label.Text = "테스트용 Label";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 316);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(440, 120);
            this.dataGridView1.TabIndex = 24;
            // 
            // 상영영화관리
            // 
            this.상영영화관리.Location = new System.Drawing.Point(150, 293);
            this.상영영화관리.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.상영영화관리.Name = "상영영화관리";
            this.상영영화관리.Size = new System.Drawing.Size(101, 18);
            this.상영영화관리.TabIndex = 25;
            this.상영영화관리.Text = "상영영화관리";
            this.상영영화관리.UseVisualStyleBackColor = true;
            this.상영영화관리.Click += new System.EventHandler(this.상영영화관리_Click);
            // 
            // 수정하기
            // 
            this.수정하기.Location = new System.Drawing.Point(411, 256);
            this.수정하기.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.수정하기.Name = "수정하기";
            this.수정하기.Size = new System.Drawing.Size(66, 18);
            this.수정하기.TabIndex = 26;
            this.수정하기.Text = "수정하기";
            this.수정하기.UseVisualStyleBackColor = true;
            // 
            // 삭제하기
            // 
            this.삭제하기.Location = new System.Drawing.Point(482, 256);
            this.삭제하기.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.삭제하기.Name = "삭제하기";
            this.삭제하기.Size = new System.Drawing.Size(66, 18);
            this.삭제하기.TabIndex = 27;
            this.삭제하기.Text = "삭제하기";
            this.삭제하기.UseVisualStyleBackColor = true;
            // 
            // 영화관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(595, 479);
            this.Controls.Add(this.삭제하기);
            this.Controls.Add(this.수정하기);
            this.Controls.Add(this.상영영화관리);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.테스트용_Label);
            this.Controls.Add(this.예고편urlTxt);
            this.Controls.Add(this.감독명txt);
            this.Controls.Add(this.영화명txt);
            this.Controls.Add(this.영화코드txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.취소);
            this.Controls.Add(this.저장);
            this.Controls.Add(this.경로명);
            this.Controls.Add(this.그림찾기btn);
            this.Controls.Add(this.영화포스터);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "영화관리";
            this.Text = "영화관리";
            ((System.ComponentModel.ISupportInitialize)(this.영화포스터)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox 영화포스터;
        private System.Windows.Forms.Button 그림찾기btn;
        private System.Windows.Forms.Label 경로명;
        private System.Windows.Forms.Button 저장;
        private System.Windows.Forms.Button 취소;
        private System.Windows.Forms.TextBox 예고편urlTxt;
        private System.Windows.Forms.TextBox 감독명txt;
        private System.Windows.Forms.TextBox 영화명txt;
        private System.Windows.Forms.TextBox 영화코드txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 테스트용_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 상영영화관리;
        private System.Windows.Forms.Button 수정하기;
        private System.Windows.Forms.Button 삭제하기;
    }
}