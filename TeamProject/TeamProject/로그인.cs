using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using Oracle.DataAccess.Client;

namespace TeamProject
{//testeteststststst
    public partial class LogInForm : Form
    {
        string checkPw;
        public LogInForm()
        {
            InitializeComponent();
            this.ActiveControl = LogInForm_Text_ID;
        }
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            NewInfo newInfo = new NewInfo();
            newInfo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            영화관리 파일 = new 영화관리();
            파일.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            예매하기 예매 = new 예매하기();
            예매.ShowDialog();
        }

        private void LoginForm_Button_Login_Click(object sender, EventArgs e)
        {
            //string commandstring = "select Id from 회원가입 where Id = Id";
            if (LogInForm_Text_ID.Text == "")
            {
                MessageBox.Show("아이디를 입력하십시오.");
            }
            else if (LogInForm_Text_Pw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하십시오.");
            }
            else
            {
                string ConStr = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                OracleConnection conn = new OracleConnection(ConStr);
                conn.Open();
                string strqry = "select pw from 회원 where id ='" + LogInForm_Text_ID.Text + "'";
                OracleCommand comm = new OracleCommand(strqry, conn);
                OracleDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    checkPw = dr["pw"].ToString();
                }
                if (checkPw == LogInForm_Text_Pw.Text)
                {
                    if (dr.ToString() == LogInForm_Text_ID.Text)
                        MessageBox.Show("로그인 성공!");

                    MessageBox.Show(LogInForm_Text_ID.Text + " 님 환영합니다.", "로그인 성공", MessageBoxButtons.OK);
                    LogInForm_Text_ID.Text = "";
                    LogInForm_Text_Pw.Text = "";

                    this.Visible = false;

                    예매하기 예매 = new 예매하기();
                    예매.ShowDialog();

                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("아이디나 비밀번호를 확인하십시오.");
                }
                conn.Close();
                
            }
        }
    }
}
