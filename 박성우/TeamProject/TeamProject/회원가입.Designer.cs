namespace TeamProject
{
    partial class NewInfo
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
            this.NewInfo_Lable_Id = new System.Windows.Forms.Label();
            this.NewInfo_Lable_Pw = new System.Windows.Forms.Label();
            this.NewInfo_Lable_PwCheck = new System.Windows.Forms.Label();
            this.NewInfo_Lable_Name = new System.Windows.Forms.Label();
            this.NewInfo_date = new System.Windows.Forms.DateTimePicker();
            this.NewInfo_Lable_Birthday = new System.Windows.Forms.Label();
            this.NewInfo_Text_Id = new System.Windows.Forms.TextBox();
            this.NewInfo_Text_Pw = new System.Windows.Forms.TextBox();
            this.NewInfo_Text_PwCheck = new System.Windows.Forms.TextBox();
            this.NewInfo_Text_Text_Name = new System.Windows.Forms.TextBox();
            this.NewInfo_Lable_Number = new System.Windows.Forms.Label();
            this.NewInfo_Textbox_Num1 = new System.Windows.Forms.TextBox();
            this.NewInfo_Textbox_Num2 = new System.Windows.Forms.TextBox();
            this.NewInfo_Textbox_Num3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewInfo_Input = new System.Windows.Forms.Button();
            this.NewInfo_Cancel = new System.Windows.Forms.Button();
            this.남자 = new System.Windows.Forms.CheckBox();
            this.여자 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.아이디중복체크 = new System.Windows.Forms.Label();
            this.비밀번호확인 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewInfo_Lable_Id
            // 
            this.NewInfo_Lable_Id.AutoSize = true;
            this.NewInfo_Lable_Id.Location = new System.Drawing.Point(84, 77);
            this.NewInfo_Lable_Id.Name = "NewInfo_Lable_Id";
            this.NewInfo_Lable_Id.Size = new System.Drawing.Size(75, 12);
            this.NewInfo_Lable_Id.TabIndex = 0;
            this.NewInfo_Lable_Id.Text = "아이디(10자)";
            // 
            // NewInfo_Lable_Pw
            // 
            this.NewInfo_Lable_Pw.AutoSize = true;
            this.NewInfo_Lable_Pw.Location = new System.Drawing.Point(78, 102);
            this.NewInfo_Lable_Pw.Name = "NewInfo_Lable_Pw";
            this.NewInfo_Lable_Pw.Size = new System.Drawing.Size(81, 12);
            this.NewInfo_Lable_Pw.TabIndex = 1;
            this.NewInfo_Lable_Pw.Text = "비밀번호(8자)";
            // 
            // NewInfo_Lable_PwCheck
            // 
            this.NewInfo_Lable_PwCheck.AutoSize = true;
            this.NewInfo_Lable_PwCheck.Location = new System.Drawing.Point(78, 126);
            this.NewInfo_Lable_PwCheck.Name = "NewInfo_Lable_PwCheck";
            this.NewInfo_Lable_PwCheck.Size = new System.Drawing.Size(81, 12);
            this.NewInfo_Lable_PwCheck.TabIndex = 2;
            this.NewInfo_Lable_PwCheck.Text = "비밀번호 확인";
            // 
            // NewInfo_Lable_Name
            // 
            this.NewInfo_Lable_Name.AutoSize = true;
            this.NewInfo_Lable_Name.Location = new System.Drawing.Point(130, 151);
            this.NewInfo_Lable_Name.Name = "NewInfo_Lable_Name";
            this.NewInfo_Lable_Name.Size = new System.Drawing.Size(29, 12);
            this.NewInfo_Lable_Name.TabIndex = 3;
            this.NewInfo_Lable_Name.Text = "이름";
            // 
            // NewInfo_date
            // 
            this.NewInfo_date.CustomFormat = "yyyy년MM월dd일";
            this.NewInfo_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NewInfo_date.Location = new System.Drawing.Point(192, 196);
            this.NewInfo_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_date.Name = "NewInfo_date";
            this.NewInfo_date.Size = new System.Drawing.Size(145, 21);
            this.NewInfo_date.TabIndex = 4;
            this.NewInfo_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NewInfo_Lable_Birthday
            // 
            this.NewInfo_Lable_Birthday.AutoSize = true;
            this.NewInfo_Lable_Birthday.Location = new System.Drawing.Point(106, 204);
            this.NewInfo_Lable_Birthday.Name = "NewInfo_Lable_Birthday";
            this.NewInfo_Lable_Birthday.Size = new System.Drawing.Size(53, 12);
            this.NewInfo_Lable_Birthday.TabIndex = 5;
            this.NewInfo_Lable_Birthday.Text = "생년월일";
            // 
            // NewInfo_Text_Id
            // 
            this.NewInfo_Text_Id.Location = new System.Drawing.Point(192, 69);
            this.NewInfo_Text_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Text_Id.MaxLength = 10;
            this.NewInfo_Text_Id.Name = "NewInfo_Text_Id";
            this.NewInfo_Text_Id.Size = new System.Drawing.Size(88, 21);
            this.NewInfo_Text_Id.TabIndex = 7;
            // 
            // NewInfo_Text_Pw
            // 
            this.NewInfo_Text_Pw.Location = new System.Drawing.Point(192, 94);
            this.NewInfo_Text_Pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Text_Pw.MaxLength = 8;
            this.NewInfo_Text_Pw.Name = "NewInfo_Text_Pw";
            this.NewInfo_Text_Pw.PasswordChar = '*';
            this.NewInfo_Text_Pw.Size = new System.Drawing.Size(88, 21);
            this.NewInfo_Text_Pw.TabIndex = 8;
            // 
            // NewInfo_Text_PwCheck
            // 
            this.NewInfo_Text_PwCheck.Location = new System.Drawing.Point(192, 118);
            this.NewInfo_Text_PwCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Text_PwCheck.MaxLength = 8;
            this.NewInfo_Text_PwCheck.Name = "NewInfo_Text_PwCheck";
            this.NewInfo_Text_PwCheck.PasswordChar = '*';
            this.NewInfo_Text_PwCheck.Size = new System.Drawing.Size(88, 21);
            this.NewInfo_Text_PwCheck.TabIndex = 9;
            // 
            // NewInfo_Text_Text_Name
            // 
            this.NewInfo_Text_Text_Name.Location = new System.Drawing.Point(192, 143);
            this.NewInfo_Text_Text_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Text_Text_Name.MaxLength = 10;
            this.NewInfo_Text_Text_Name.Name = "NewInfo_Text_Text_Name";
            this.NewInfo_Text_Text_Name.Size = new System.Drawing.Size(88, 21);
            this.NewInfo_Text_Text_Name.TabIndex = 10;
            // 
            // NewInfo_Lable_Number
            // 
            this.NewInfo_Lable_Number.AutoSize = true;
            this.NewInfo_Lable_Number.Location = new System.Drawing.Point(106, 177);
            this.NewInfo_Lable_Number.Name = "NewInfo_Lable_Number";
            this.NewInfo_Lable_Number.Size = new System.Drawing.Size(53, 12);
            this.NewInfo_Lable_Number.TabIndex = 11;
            this.NewInfo_Lable_Number.Text = "전화번호";
            // 
            // NewInfo_Textbox_Num1
            // 
            this.NewInfo_Textbox_Num1.Location = new System.Drawing.Point(192, 168);
            this.NewInfo_Textbox_Num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Textbox_Num1.MaxLength = 3;
            this.NewInfo_Textbox_Num1.Name = "NewInfo_Textbox_Num1";
            this.NewInfo_Textbox_Num1.Size = new System.Drawing.Size(42, 21);
            this.NewInfo_Textbox_Num1.TabIndex = 12;
            // 
            // NewInfo_Textbox_Num2
            // 
            this.NewInfo_Textbox_Num2.Location = new System.Drawing.Point(258, 168);
            this.NewInfo_Textbox_Num2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Textbox_Num2.MaxLength = 4;
            this.NewInfo_Textbox_Num2.Name = "NewInfo_Textbox_Num2";
            this.NewInfo_Textbox_Num2.Size = new System.Drawing.Size(42, 21);
            this.NewInfo_Textbox_Num2.TabIndex = 13;
            // 
            // NewInfo_Textbox_Num3
            // 
            this.NewInfo_Textbox_Num3.Location = new System.Drawing.Point(320, 168);
            this.NewInfo_Textbox_Num3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Textbox_Num3.MaxLength = 4;
            this.NewInfo_Textbox_Num3.Name = "NewInfo_Textbox_Num3";
            this.NewInfo_Textbox_Num3.Size = new System.Drawing.Size(42, 21);
            this.NewInfo_Textbox_Num3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // NewInfo_Input
            // 
            this.NewInfo_Input.Location = new System.Drawing.Point(132, 271);
            this.NewInfo_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Input.Name = "NewInfo_Input";
            this.NewInfo_Input.Size = new System.Drawing.Size(78, 22);
            this.NewInfo_Input.TabIndex = 17;
            this.NewInfo_Input.Text = "확인";
            this.NewInfo_Input.UseVisualStyleBackColor = true;
            this.NewInfo_Input.Click += new System.EventHandler(this.NewInfo_Input_Click);
            // 
            // NewInfo_Cancel
            // 
            this.NewInfo_Cancel.Location = new System.Drawing.Point(284, 271);
            this.NewInfo_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewInfo_Cancel.Name = "NewInfo_Cancel";
            this.NewInfo_Cancel.Size = new System.Drawing.Size(78, 22);
            this.NewInfo_Cancel.TabIndex = 18;
            this.NewInfo_Cancel.Text = "취소";
            this.NewInfo_Cancel.UseVisualStyleBackColor = true;
            this.NewInfo_Cancel.Click += new System.EventHandler(this.NewInfo_Cancel_Click);
            // 
            // 남자
            // 
            this.남자.AutoSize = true;
            this.남자.Location = new System.Drawing.Point(192, 223);
            this.남자.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.남자.Name = "남자";
            this.남자.Size = new System.Drawing.Size(48, 16);
            this.남자.TabIndex = 19;
            this.남자.Text = "남자";
            this.남자.UseVisualStyleBackColor = true;
            this.남자.CheckedChanged += new System.EventHandler(this.남자_CheckedChanged);
            // 
            // 여자
            // 
            this.여자.AutoSize = true;
            this.여자.Location = new System.Drawing.Point(263, 223);
            this.여자.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.여자.Name = "여자";
            this.여자.Size = new System.Drawing.Size(48, 16);
            this.여자.TabIndex = 20;
            this.여자.Text = "여자";
            this.여자.UseVisualStyleBackColor = true;
            this.여자.CheckedChanged += new System.EventHandler(this.여자_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "성별";
            // 
            // 아이디중복체크
            // 
            this.아이디중복체크.AutoSize = true;
            this.아이디중복체크.ForeColor = System.Drawing.Color.Red;
            this.아이디중복체크.Location = new System.Drawing.Point(286, 74);
            this.아이디중복체크.Name = "아이디중복체크";
            this.아이디중복체크.Size = new System.Drawing.Size(149, 12);
            this.아이디중복체크.TabIndex = 22;
            this.아이디중복체크.Text = "이미 등록된 아이디입니다.";
            this.아이디중복체크.Visible = false;
            // 
            // 비밀번호확인
            // 
            this.비밀번호확인.AutoSize = true;
            this.비밀번호확인.ForeColor = System.Drawing.Color.Red;
            this.비밀번호확인.Location = new System.Drawing.Point(286, 122);
            this.비밀번호확인.Name = "비밀번호확인";
            this.비밀번호확인.Size = new System.Drawing.Size(121, 12);
            this.비밀번호확인.TabIndex = 22;
            this.비밀번호확인.Text = "비밀번호가 다릅니다.";
            this.비밀번호확인.Visible = false;
            // 
            // NewInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 341);
            this.Controls.Add(this.비밀번호확인);
            this.Controls.Add(this.아이디중복체크);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.여자);
            this.Controls.Add(this.남자);
            this.Controls.Add(this.NewInfo_Cancel);
            this.Controls.Add(this.NewInfo_Input);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NewInfo_Textbox_Num3);
            this.Controls.Add(this.NewInfo_Textbox_Num2);
            this.Controls.Add(this.NewInfo_Textbox_Num1);
            this.Controls.Add(this.NewInfo_Lable_Number);
            this.Controls.Add(this.NewInfo_Text_Text_Name);
            this.Controls.Add(this.NewInfo_Text_PwCheck);
            this.Controls.Add(this.NewInfo_Text_Pw);
            this.Controls.Add(this.NewInfo_Text_Id);
            this.Controls.Add(this.NewInfo_Lable_Birthday);
            this.Controls.Add(this.NewInfo_date);
            this.Controls.Add(this.NewInfo_Lable_Name);
            this.Controls.Add(this.NewInfo_Lable_PwCheck);
            this.Controls.Add(this.NewInfo_Lable_Pw);
            this.Controls.Add(this.NewInfo_Lable_Id);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewInfo";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.NewInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewInfo_Lable_Id;
        private System.Windows.Forms.Label NewInfo_Lable_Pw;
        private System.Windows.Forms.Label NewInfo_Lable_PwCheck;
        private System.Windows.Forms.Label NewInfo_Lable_Name;
        private System.Windows.Forms.DateTimePicker NewInfo_date;
        private System.Windows.Forms.Label NewInfo_Lable_Birthday;
        private System.Windows.Forms.TextBox NewInfo_Text_Id;
        private System.Windows.Forms.TextBox NewInfo_Text_Pw;
        private System.Windows.Forms.TextBox NewInfo_Text_PwCheck;
        private System.Windows.Forms.TextBox NewInfo_Text_Text_Name;
        private System.Windows.Forms.Label NewInfo_Lable_Number;
        private System.Windows.Forms.TextBox NewInfo_Textbox_Num1;
        private System.Windows.Forms.TextBox NewInfo_Textbox_Num2;
        private System.Windows.Forms.TextBox NewInfo_Textbox_Num3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button NewInfo_Input;
        private System.Windows.Forms.Button NewInfo_Cancel;
        private System.Windows.Forms.CheckBox 남자;
        private System.Windows.Forms.CheckBox 여자;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 아이디중복체크;
        private System.Windows.Forms.Label 비밀번호확인;
    }
}