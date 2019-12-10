namespace TeamProject
{
    partial class LogInForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInForm_Text_ID = new System.Windows.Forms.TextBox();
            this.LogInForm_Text_Pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginForm_Button_Account = new System.Windows.Forms.Button();
            this.LoginForm_Button_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInForm_Text_ID
            // 
            this.LogInForm_Text_ID.Location = new System.Drawing.Point(178, 118);
            this.LogInForm_Text_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInForm_Text_ID.Name = "LogInForm_Text_ID";
            this.LogInForm_Text_ID.Size = new System.Drawing.Size(156, 25);
            this.LogInForm_Text_ID.TabIndex = 0;
            // 
            // LogInForm_Text_Pw
            // 
            this.LogInForm_Text_Pw.Location = new System.Drawing.Point(178, 164);
            this.LogInForm_Text_Pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogInForm_Text_Pw.Name = "LogInForm_Text_Pw";
            this.LogInForm_Text_Pw.Size = new System.Drawing.Size(156, 25);
            this.LogInForm_Text_Pw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // LoginForm_Button_Account
            // 
            this.LoginForm_Button_Account.Location = new System.Drawing.Point(267, 231);
            this.LoginForm_Button_Account.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginForm_Button_Account.Name = "LoginForm_Button_Account";
            this.LoginForm_Button_Account.Size = new System.Drawing.Size(79, 36);
            this.LoginForm_Button_Account.TabIndex = 5;
            this.LoginForm_Button_Account.Text = "가입하기";
            this.LoginForm_Button_Account.UseVisualStyleBackColor = true;
            this.LoginForm_Button_Account.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // LoginForm_Button_Login
            // 
            this.LoginForm_Button_Login.Location = new System.Drawing.Point(170, 231);
            this.LoginForm_Button_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginForm_Button_Login.Name = "LoginForm_Button_Login";
            this.LoginForm_Button_Login.Size = new System.Drawing.Size(79, 36);
            this.LoginForm_Button_Login.TabIndex = 3;
            this.LoginForm_Button_Login.Text = "로그인";
            this.LoginForm_Button_Login.UseVisualStyleBackColor = true;
            this.LoginForm_Button_Login.Click += new System.EventHandler(this.LoginForm_Button_Login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "테스트용영화관리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "권소진폼으로";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 355);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginForm_Button_Login);
            this.Controls.Add(this.LoginForm_Button_Account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInForm_Text_Pw);
            this.Controls.Add(this.LogInForm_Text_ID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogInForm_Text_ID;
        private System.Windows.Forms.TextBox LogInForm_Text_Pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginForm_Button_Account;
        private System.Windows.Forms.Button LoginForm_Button_Login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

