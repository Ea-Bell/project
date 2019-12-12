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


namespace WindowsFormsApp1
{
    public partial class 시간선택 : Form
    {
        string userid = ""; //로그인한 회원의 id 값을 저장 받음
        string times = ""; //해당 영화의 회차에 대한 값을 받음
        string seat = ""; // 현재 선택한 좌석의 값을 받음
        string connectionString = "User Id=LPK; Password=1234; Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.142.16)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";
                    
        private void 자리점멸()
        {
            Button [] btnArray;
            btnArray = new Button[] { 좌석1, 좌석2, 좌석3, 좌석6, 좌석5, 좌석4, 좌석7, 좌석8, 좌석9 }; 
            //버튼타입 배열로 좌석들을 배치
            for(int i = 0; i < btnArray.Length; i++)
            {
                if (btnArray[i].Name != seat)
                {// 선택한 좌석과 이름이 다르면 기본컨트롤색상으로 return
                   btnArray[i].BackColor = DefaultBackColor;
                   btnArray[i].ForeColor = DefaultForeColor;
                }
                else
                {// 선택한 좌석과 이름이 같은 좌석은 버튼배경이 보라색으로 변함
                    btnArray[i].ForeColor = Color.White;
                    btnArray[i].BackColor = Color.Purple;
                }
            }            
        }
        private void 좌석DB연동()
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select 좌석1,좌석2,좌석3,좌석4,좌석5,좌석6,좌석7,좌석8,좌석9,좌석10 from 예약내역;";
            OracleCommand comm = new OracleCommand(strqry, conn);
            OracleDataReader dr = comm.ExecuteReader();
            // 여기까지함 1211 20:34
        }
        public 시간선택(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }
        // ↑ 사용자 함수
        // ↓ 이벤트 처리기
        private void button1_Click(object sender, EventArgs e)
        {// 1회차 선택
            times = "1";
            
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;

            button2.BackColor = Control.DefaultBackColor;
            button2.ForeColor = Control.DefaultForeColor;
            button3.BackColor = Control.DefaultBackColor;
            button3.ForeColor = Control.DefaultForeColor;
        }
        private void button2_Click(object sender, EventArgs e)
        {// 2회차 선택
            times = "2";
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;

            button1.BackColor = Control.DefaultBackColor;
            button1.ForeColor = Control.DefaultForeColor;
            button3.BackColor = Control.DefaultBackColor;
            button3.ForeColor = Control.DefaultForeColor;
        }
        private void button3_Click(object sender, EventArgs e)
        {// 3회차 선택
            times = "3";
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.White;

            button2.BackColor = Control.DefaultBackColor;
            button2.ForeColor = Control.DefaultForeColor;
            button1.BackColor = Control.DefaultBackColor;
            button1.ForeColor = Control.DefaultForeColor;
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {//commit 버튼클릭
            if (seat == "")
            {
                MessageBox.Show("좌석을 선택해주세요");
            }else if(times == "")
            {
                MessageBox.Show("시간을 선택해주세요");
            }
            else
            {
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO 예약내역(예약내역, 회차번호, 상영관코드, 상영영화코드, 상영일, 회원번호, "+seat+") VALUES(seq_예약내역.nextval, '"+times+"', '미정', '미정', '"+userid+"','"+DateTime.Now.ToString("yyyyMMdd")+"' , 'O')";
                //seat 는 버튼을 누를 때, 버튼마다 주어진 문자열
                //cmd.CommandText = "INSERT INTO 예약내역(예약내역, 회차번호, 상영관코드, 상영영화코드, 상영일, 회원번호, 좌석1) VALUES(seq_예약내역.nextval, '"+times+"', '2', '3', '4', '5', '6')";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            MessageBox.Show("성공");
        }
        

        private void 좌석1_Click(object sender, EventArgs e)
        {// 좌석 A03
            seat = 좌석1.Name;            
            자리점멸();
        }

        private void 좌석2_Click(object sender, EventArgs e)
        {// 좌석 A04
            seat = 좌석2.Name;            
            자리점멸();
        }
        private void 좌석3_Click(object sender, EventArgs e)
        {// 좌석 A05
            seat = 좌석3.Name;
            자리점멸();
        }

        private void 좌석4_Click(object sender, EventArgs e)
        {// 좌석 A06
            seat = 좌석4.Name;
            자리점멸();
        }

        private void 좌석5_Click(object sender, EventArgs e)
        {
            seat = 좌석5.Name;
            자리점멸();
        }

        private void 좌석6_Click(object sender, EventArgs e)
        {
            seat = 좌석6.Name;
            자리점멸();
        }

        private void 좌석7_Click(object sender, EventArgs e)
        {
            seat = 좌석7.Name;
            자리점멸();
        }

        private void 좌석8_Click(object sender, EventArgs e)
        {
            seat = 좌석8.Name;
            자리점멸();
        }

        private void 좌석9_Click(object sender, EventArgs e)
        {
            seat = 좌석9.Name;
            자리점멸();
        }
    }
}
