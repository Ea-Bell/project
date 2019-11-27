using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TeamProject
{
    public partial class NewInfo : Form
    {
        bool ErrorCheck =false;
        OracleDataAdapter DBAdapter; 
        DataSet DS;
        OracleCommandBuilder myCommandBuilder; 
        DataTable MemberTable; 
        string Scheck;
        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                string commandString = "select * from 회원";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public NewInfo()
        {
            InitializeComponent();
            this.ActiveControl = NewInfo_Text_Id;
            DB_Open();
 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewInfo_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewInfo_Load(object sender, EventArgs e)
        {
            남자.Checked = true;
        }

        private void 남자_CheckedChanged(object sender, EventArgs e)
        {
            if (남자.Checked == true)
            {
                여자.Checked = false;
                Scheck = "남자";
                
            }             
        }
        private void 여자_CheckedChanged(object sender, EventArgs e)
        {
            if (여자.Checked == true)
            {
                남자.Checked = false;
                Scheck = "여자";
            }

        }


        private void NewInfo_Input_Click(object sender, EventArgs e)
        {
            bool check1 = true; // 회원가입 입력란에 입력이 되었는지  검사하는 변수
            아이디중복체크.Visible = false;
            비밀번호확인.Visible = false;
            ErrorCheck = true;
            if (NewInfo_Text_Id.Text == "")
            {
                MessageBox.Show("아이디를 입력하시오.");
                NewInfo_Text_Id.Focus();
                check1 = false;
            }
            else if (NewInfo_Text_Pw.Text == "")
            {
                MessageBox.Show("비밀번호를 입력하시오.");
                NewInfo_Text_Pw.Focus();
                check1 = false;
            }
            else if (NewInfo_Text_PwCheck.Text == "")
            {
                MessageBox.Show("비밀번호 확인을 입력하시오.");
                NewInfo_Text_Pw.Focus();
                check1 = false;
            }
            else if (NewInfo_Text_Text_Name.Text == "")
            {
                MessageBox.Show("이름을 입력하시오.");
                NewInfo_Text_Text_Name.Focus();
                check1 = false;
            }
            else if (NewInfo_Textbox_Num1.Text == "" || NewInfo_Textbox_Num2.Text == "" || NewInfo_Textbox_Num3.Text == "")
            {
                MessageBox.Show("전화번호를 입력하시오.");
                NewInfo_Textbox_Num1.Focus();
                if(NewInfo_Textbox_Num2.Text == "")
                {
                    NewInfo_Textbox_Num2.Focus();
                }
                if (NewInfo_Textbox_Num3.Text == "")
                {
                    NewInfo_Textbox_Num3.Focus();
                }

                check1 = false;
                
            }            
            if(NewInfo_Text_Pw.Text != NewInfo_Text_PwCheck.Text)
            {
                비밀번호확인.Visible = true;
                check1 = false;
            }

            if (check1 == true) {
                try
                {                    
                    // 중복 코드 삭제
                    DS.Clear();
                    DBAdapter.Fill(DS, "회원"); // 현재 phone 테이블 전체 내용 fill

                    MemberTable = DS.Tables["회원"]; // DS의 phone 테이블에 새로운 줄 추가
                    DataRow newRow = MemberTable.NewRow();

                    newRow["ID"] = NewInfo_Text_Id.Text;
                    newRow["PW"] = NewInfo_Text_Pw.Text;
                    newRow["NAME"] = NewInfo_Text_Text_Name.Text;
                    newRow["PHONE"] = NewInfo_Textbox_Num1.Text + "-" + NewInfo_Textbox_Num2.Text + "-" + NewInfo_Textbox_Num3.Text;
                    newRow["BIRTH"] = "970725";
                    newRow["SEX"] = Scheck;

                    MemberTable.Rows.Add(newRow);

                    DBAdapter.Update(DS, "회원");
                    DS.AcceptChanges();
                }
                catch (DataException DE)
                {
                    //MessageBox.Show(DE.Message);
                    ErrorCheck = false;
                    //MessageBox.Show("이미 등록된 아이디");
                    //아이디중복체크.Visible = true;
                }
                catch (Exception DE)
                {
                    //MessageBox.Show(DE.Message);
                    ErrorCheck = false;
                    //MessageBox.Show("이미 등록된 아이디");
                    아이디중복체크.Visible = true;
                }
                if (ErrorCheck == true)
                {
                    MessageBox.Show("회원가입이 완료되었습니다.");
                    Close();
                }
            }
        }
    }
}
